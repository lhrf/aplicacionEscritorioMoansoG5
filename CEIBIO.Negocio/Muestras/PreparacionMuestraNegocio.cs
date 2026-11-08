using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>
    /// CU-34 Registrar acondicionamiento de la muestra, CU-35 Registrar recepción formal, CU-36 Devolver muestra con diferencias,
    /// CU-37 Consultar tránsito de muestras y CU-38 Consultar muestras pendientes de acondicionar.
    /// </summary>
    public class PreparacionMuestraNegocio
    {
        private readonly MuestraDatos datos = new();
        private readonly TuboDatos tuboDatos = new();

        public static readonly string[] EstadosConservacion = { "Adecuado", "Observado" };

        /// <summary>Busca por código correlativo (acepta minúsculas). Null si no existe (CU-34 A1).</summary>
        public Muestra? BuscarPorCodigo(string codigo) =>
            Validacion.Vacio(codigo) ? null : datos.ObtenerPorCodigo(codigo.Trim().ToUpperInvariant());

        /// <summary>Minutos de centrifugación reglamentarios (el mayor de los tubos de la atención; 0 = no requiere).</summary>
        public int MinutosRequeridos(int idAtencion)
        {
            var tubos = tuboDatos.ListarRequeridosPorAtencion(idAtencion);
            return tubos.Count == 0 ? 0 : tubos.Max(t => t.MinutosCentrifugacion);
        }

        /// <summary>CU-34 pasos 2-3: registra el ingreso de la muestra con la fecha y hora.</summary>
        public Respuesta RegistrarIngreso(string codigo) => Respuesta.Intentar(() =>
        {
            var muestra = BuscarPorCodigo(codigo);
            if (muestra == null) return Respuesta.Error("El código de muestra no existe. Ingréselo nuevamente.");
            if (muestra.Estado != EstadoMuestra.Recolectada)
                return Respuesta.Error("La muestra no está pendiente de ingreso (estado actual: " + muestra.Estado + ").");
            datos.RegistrarIngreso(muestra.IdMuestra, Sesion.IdUsuario);
            return Respuesta.Ok("Ingreso registrado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ".", muestra.IdMuestra, muestra.Codigo);
        });

        /// <summary>
        /// CU-34 pasos 4-7: marca la muestra como acondicionada. Si la centrifugación es menor a la reglamentaria,
        /// se guarda igual pero el mensaje incluye la advertencia (A2).
        /// </summary>
        public Respuesta RegistrarAcondicionamiento(int idMuestra, string estadoConservacion, int minutosCentrifugacion) => Respuesta.Intentar(() =>
        {
            var muestra = datos.ObtenerPorId(idMuestra);
            if (muestra == null) return Respuesta.Error("Busque la muestra por su código.");
            if (muestra.Estado != EstadoMuestra.Ingresada) return Respuesta.Error("Primero registre el ingreso de la muestra.");
            if (!EstadosConservacion.Contains(estadoConservacion)) return Respuesta.Error("Seleccione el estado de conservación.");

            int requeridos = MinutosRequeridos(muestra.IdAtencion);
            int? minutos = requeridos > 0 || minutosCentrifugacion > 0 ? minutosCentrifugacion : null;
            datos.RegistrarAcondicionamiento(idMuestra, estadoConservacion, minutos, Sesion.IdUsuario);

            string mensaje = "Muestra " + muestra.Codigo + " acondicionada y enviada al área de procesamiento.";
            if (requeridos > 0 && minutosCentrifugacion < requeridos)
                mensaje += " ADVERTENCIA: la centrifugación (" + minutosCentrifugacion + " min) es menor a la reglamentaria (" + requeridos + " min).";
            return Respuesta.Ok(mensaje, idMuestra, muestra.Codigo);
        });

        /// <summary>CU-34 A3: corrige el registro de una muestra devuelta con diferencias.</summary>
        public Respuesta CorregirRegistro(int idMuestra, string estadoConservacion, int minutosCentrifugacion, string motivo) => Respuesta.Intentar(() =>
        {
            var muestra = datos.ObtenerPorId(idMuestra);
            if (muestra == null) return Respuesta.Error("Busque la muestra por su código.");
            if (muestra.Estado != EstadoMuestra.Devuelta) return Respuesta.Error("Solo se corrigen muestras devueltas con diferencias.");
            if (!EstadosConservacion.Contains(estadoConservacion)) return Respuesta.Error("Seleccione el estado de conservación.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la corrección.");

            string anterior = "Conservación: " + (muestra.EstadoConservacion ?? "-") + "; centrifugación: " + (muestra.MinutosCentrifugacion?.ToString() ?? "-") + " min";
            datos.Corregir(idMuestra, estadoConservacion, minutosCentrifugacion, anterior, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Registro corregido. La muestra vuelve a la lista del área de procesamiento.", idMuestra, muestra.Codigo);
        });

        // ---------------- CU-35 / CU-36 ----------------
        public List<Muestra> ListarAcondicionadas() => datos.ListarPorEstado(EstadoMuestra.Acondicionada);

        /// <summary>CU-35: el código cotejado debe coincidir con el de la muestra seleccionada.</summary>
        public Respuesta ConfirmarRecepcion(int idMuestra, string codigoCotejado) => Respuesta.Intentar(() =>
        {
            var muestra = datos.ObtenerPorId(idMuestra);
            if (muestra == null || muestra.Estado != EstadoMuestra.Acondicionada) return Respuesta.Error("Seleccione una muestra acondicionada.");
            if (Validacion.Vacio(codigoCotejado)) return Respuesta.Error("Ingrese el código de la muestra física.");
            if (!string.Equals(codigoCotejado.Trim(), muestra.Codigo, StringComparison.OrdinalIgnoreCase))
                return Respuesta.Error("El código no coincide con la muestra seleccionada. Si hay diferencias, use «Devolver con diferencias».");

            datos.RegistrarRecepcion(idMuestra, Sesion.IdUsuario);
            return Respuesta.Ok("Muestra " + muestra.Codigo + " recibida para análisis.", idMuestra, muestra.Codigo);
        });

        /// <summary>CU-36.</summary>
        public Respuesta Devolver(int idMuestra, string diferencia) => Respuesta.Intentar(() =>
        {
            var muestra = datos.ObtenerPorId(idMuestra);
            if (muestra == null || muestra.Estado != EstadoMuestra.Acondicionada) return Respuesta.Error("Seleccione una muestra acondicionada.");
            if (Validacion.Vacio(diferencia)) return Respuesta.Error("Describa la diferencia encontrada.");
            datos.Devolver(idMuestra, diferencia.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Muestra devuelta al Auxiliar de Laboratorio para su corrección.", idMuestra);
        });

        public List<Muestra> ListarDevueltas() => datos.ListarPorEstado(EstadoMuestra.Devuelta);

        // ---------------- CU-37 / CU-38 ----------------
        /// <summary>CU-37: estado null, vacío o "(Todos)" = todos.</summary>
        public List<Muestra> ConsultarTransito(DateTime desde, DateTime hasta, string? estado)
        {
            if (estado == "(Todos)") estado = null;
            return datos.ConsultarTransito(desde, hasta, estado);
        }

        /// <summary>Libro de Tránsito: movimientos de una muestra (ingreso, acondicionamiento, recepción, devoluciones y correcciones).</summary>
        public List<MovimientoMuestra> ListarMovimientos(int idMuestra) => datos.ListarMovimientos(idMuestra);

        /// <summary>CU-37: movimientos entre dos fechas; tipo null, vacío o "(Todos)" = todos (ver TipoMovimientoMuestra).</summary>
        public List<MovimientoMuestra> ConsultarMovimientos(DateTime desde, DateTime hasta, string? tipoMovimiento)
        {
            if (tipoMovimiento == "(Todos)") tipoMovimiento = null;
            return datos.ConsultarMovimientos(desde, hasta, tipoMovimiento);
        }

        /// <summary>CU-38: muestras ingresadas que aún no se acondicionan (ver Muestra.TiempoTranscurrido).</summary>
        public List<Muestra> ListarPendientesAcondicionar() => datos.ListarPorEstado(EstadoMuestra.Ingresada);
    }
}
