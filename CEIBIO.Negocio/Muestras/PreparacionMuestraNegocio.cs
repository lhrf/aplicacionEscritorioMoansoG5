using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class PreparacionMuestraNegocio
    {
        private readonly MuestraDatos datos = new();
        private readonly TuboDatos tuboDatos = new();

        public static readonly string[] EstadosConservacion = { "Adecuado", "Observado" };

        public Muestra? BuscarPorCodigo(string codigo) =>
            Validacion.Vacio(codigo) ? null : datos.ObtenerPorCodigo(codigo.Trim().ToUpperInvariant());

        public int MinutosRequeridos(int idAtencion)
        {
            var tubos = tuboDatos.ListarRequeridosPorAtencion(idAtencion);
            return tubos.Count == 0 ? 0 : tubos.Max(t => t.MinutosCentrifugacion);
        }

        public Respuesta RegistrarIngreso(string codigo) => Respuesta.Intentar(() =>
        {
            var muestra = BuscarPorCodigo(codigo);
            if (muestra == null) return Respuesta.Error("El código de muestra no existe. Ingréselo nuevamente.");
            if (muestra.Estado != EstadoMuestra.Recolectada)
                return Respuesta.Error("La muestra no está pendiente de ingreso (estado actual: " + muestra.Estado + ").");
            datos.RegistrarIngreso(muestra.IdMuestra, Sesion.IdUsuario);
            return Respuesta.Ok("Ingreso registrado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ".", muestra.IdMuestra, muestra.Codigo);
        });

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

        public List<Muestra> ListarAcondicionadas() => datos.ListarPorEstado(EstadoMuestra.Acondicionada);

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

        public Respuesta Devolver(int idMuestra, string diferencia) => Respuesta.Intentar(() =>
        {
            var muestra = datos.ObtenerPorId(idMuestra);
            if (muestra == null || muestra.Estado != EstadoMuestra.Acondicionada) return Respuesta.Error("Seleccione una muestra acondicionada.");
            if (Validacion.Vacio(diferencia)) return Respuesta.Error("Describa la diferencia encontrada.");
            datos.Devolver(idMuestra, diferencia.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Muestra devuelta al Auxiliar de Laboratorio para su corrección.", idMuestra);
        });

        public List<Muestra> ListarDevueltas() => datos.ListarPorEstado(EstadoMuestra.Devuelta);

        public List<Muestra> ConsultarTransito(DateTime desde, DateTime hasta, string? estado)
        {
            if (estado == "(Todos)") estado = null;
            return datos.ConsultarTransito(desde, hasta, estado);
        }

        public List<MovimientoMuestra> ListarMovimientos(int idMuestra) => datos.ListarMovimientos(idMuestra);

        public List<MovimientoMuestra> ConsultarMovimientos(DateTime desde, DateTime hasta, string? tipoMovimiento)
        {
            if (tipoMovimiento == "(Todos)") tipoMovimiento = null;
            return datos.ConsultarMovimientos(desde, hasta, tipoMovimiento);
        }

        public List<Muestra> ListarPendientesAcondicionar() => datos.ListarPorEstado(EstadoMuestra.Ingresada);
    }
}
