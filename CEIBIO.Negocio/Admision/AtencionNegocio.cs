using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-01 Registrar atención del paciente, CU-02 Calcular costo de la atención y CU-08 Consultar atenciones.</summary>
    public class AtencionNegocio
    {
        private readonly AtencionDatos datos = new();
        private readonly PacienteDatos pacienteDatos = new();
        private readonly ConvenioDatos convenioDatos = new();
        private readonly ExamenDatos examenDatos = new();
        private readonly PagoDatos pagoDatos = new();

        /// <summary>
        /// CU-02: suma las tarifas de los exámenes y aplica el descuento del convenio (null = sin convenio).
        /// Se puede llamar cada vez que se agrega o quita un examen para refrescar las etiquetas.
        /// </summary>
        public CostoAtencion CalcularCosto(IEnumerable<Examen> examenes, Convenio? convenio)
        {
            decimal subtotal = examenes.Sum(e => e.Tarifa);
            decimal porcentaje = convenio != null && convenio.Vigente ? convenio.PorcentajeDescuento : 0m;
            decimal descuento = Math.Round(subtotal * porcentaje / 100m, 2, MidpointRounding.AwayFromZero);
            return new CostoAtencion
            {
                Subtotal = subtotal,
                PorcentajeDescuento = porcentaje,
                Descuento = descuento,
                Total = subtotal - descuento
            };
        }

        /// <summary>
        /// CU-01: registra la atención. En sede queda "Pendiente de evaluación"; a domicilio queda "Pendiente de pago"
        /// y luego se debe programar la visita (CU-05). Respuesta.Dato = número de atención.
        /// </summary>
        public Respuesta Registrar(int idPaciente, string modalidad, List<int> idExamenes, int? idConvenio) => Respuesta.Intentar(() =>
        {
            var paciente = pacienteDatos.ObtenerPorId(idPaciente);
            if (paciente == null) return Respuesta.Error("El paciente no está registrado. Debe registrarse en Archivo (Ficha clínica histórica).");
            if (modalidad != Modalidad.EnSede && modalidad != Modalidad.ADomicilio) return Respuesta.Error("Seleccione la modalidad de atención.");
            if (idExamenes == null || idExamenes.Count == 0) return Respuesta.Error("Seleccione al menos un examen.");

            // Se vuelven a leer las tarifas y el convenio desde la base de datos (no se confía en los valores del formulario).
            var examenes = new List<Examen>();
            foreach (int idExamen in idExamenes.Distinct())
            {
                var examen = examenDatos.ObtenerPorId(idExamen);
                if (examen == null || !examen.Habilitado) return Respuesta.Error("Uno de los exámenes seleccionados no existe o está inhabilitado.");
                examenes.Add(examen);
            }

            Convenio? convenio = null;
            if (idConvenio.HasValue && idConvenio.Value > 0)
            {
                convenio = convenioDatos.ObtenerPorId(idConvenio.Value);
                if (convenio == null || !convenio.Vigente) return Respuesta.Error("El convenio seleccionado no está vigente.");
            }

            var costo = CalcularCosto(examenes, convenio);
            var atencion = new Atencion
            {
                IdPaciente = idPaciente,
                Modalidad = modalidad,
                IdConvenio = convenio?.IdConvenio,
                Subtotal = costo.Subtotal,
                Descuento = costo.Descuento,
                CostoTotal = costo.Total,
                Estado = modalidad == Modalidad.ADomicilio ? EstadoAtencion.PendientePago : EstadoAtencion.PendienteEvaluacion,
                IdUsuarioRegistro = Sesion.IdUsuario,
                Detalle = examenes.Select(e => new AtencionExamen { IdExamen = e.IdExamen, Tarifa = e.Tarifa }).ToList()
            };

            int id = datos.Insertar(atencion);
            var guardada = datos.ObtenerPorId(id);
            string numero = guardada?.NumeroAtencion ?? id.ToString();
            string mensaje = "Atención registrada con el número " + numero + ".";
            if (modalidad == Modalidad.ADomicilio) mensaje += " Programe ahora la visita domiciliaria.";
            return Respuesta.Ok(mensaje, id, numero);
        });

        /// <summary>CU-01 A4: anula una atención que aún no fue pagada.</summary>
        public Respuesta Anular(int idAtencion, string motivo) => Respuesta.Intentar(() =>
        {
            var atencion = datos.ObtenerPorId(idAtencion);
            if (atencion == null) return Respuesta.Error("La atención no existe.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la anulación.");

            bool estadoPermitido = atencion.Estado == EstadoAtencion.PendienteEvaluacion || atencion.Estado == EstadoAtencion.Suspendida
                                   || atencion.Estado == EstadoAtencion.PendientePago;
            if (!estadoPermitido) return Respuesta.Error("Solo se puede anular una atención que aún no fue pagada.");
            if (pagoDatos.ObtenerVigente(idAtencion) != null)
                return Respuesta.Error("La atención tiene un pago registrado o pendiente de autorización; no se puede anular.");

            datos.Anular(idAtencion, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Atención " + atencion.NumeroAtencion + " anulada.", idAtencion);
        });

        public Atencion? ObtenerPorId(int idAtencion) => datos.ObtenerPorId(idAtencion);

        /// <summary>Busca por número: acepta "AT-000012" o "12".</summary>
        public Atencion? ObtenerPorNumero(string numeroAtencion) => datos.ObtenerPorNumero(Validacion.NumeroAtencion(numeroAtencion));

        /// <summary>Exámenes de la atención con su tarifa.</summary>
        public List<AtencionExamen> ListarDetalle(int idAtencion) => datos.ListarDetalle(idAtencion);

        public List<Atencion> ListarPorEstado(string estado) => datos.ListarPorEstado(estado);

        /// <summary>CU-08: estado null, vacío o "(Todos)" = todos los estados.</summary>
        public List<Atencion> Consultar(DateTime desde, DateTime hasta, string? estado)
        {
            if (estado == "(Todos)") estado = null;
            return datos.Consultar(desde, hasta, estado);
        }
    }
}
