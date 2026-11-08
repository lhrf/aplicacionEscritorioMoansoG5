using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class EntregaNegocio
    {
        private readonly EntregaDatos datos = new();
        private readonly ReporteDatos reporteDatos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly ComprobanteDatos comprobanteDatos = new();

        public static readonly string[] Relaciones = { "Paciente", "Representante", "Familiar" };

        public List<ReporteClinico> ListarPendientesEntrega() => reporteDatos.ListarPorEstado(EstadoReporte.DisponibleEntrega);

        public DatosEntrega? VerificarComprobante(string numeroComprobanteODni) =>
            Validacion.Vacio(numeroComprobanteODni) ? null : datos.BuscarParaEntrega(numeroComprobanteODni);

        public Respuesta RegistrarEntrega(Entrega e) => Respuesta.Intentar(() =>
        {
            var reporte = reporteDatos.ObtenerPorId(e.IdReporte);
            if (reporte == null) return Respuesta.Error("Primero busque el comprobante o el DNI.");
            if (reporte.Estado == EstadoReporte.EntregaRetenida) return Respuesta.Error("La entrega está retenida. Levante la retención antes de entregar.");
            if (reporte.Estado != EstadoReporte.DisponibleEntrega) return Respuesta.Error("El reporte no está disponible para entrega.");

            if (comprobanteDatos.ObtenerEmitidoPorAtencion(reporte.IdAtencion) == null)
                return Respuesta.Error("La atención no tiene un Comprobante de pago vigente. Retenga la entrega.");

            e.NombreRecibe = (e.NombreRecibe ?? "").Trim();
            e.DniRecibe = (e.DniRecibe ?? "").Trim();
            if (Validacion.Vacio(e.NombreRecibe)) return Respuesta.Error("Ingrese el nombre de quien recibe.");
            if (!Validacion.EsDni(e.DniRecibe)) return Respuesta.Error("El DNI de quien recibe debe tener 8 dígitos.");
            if (!Relaciones.Contains(e.Relacion)) return Respuesta.Error("Seleccione la relación con el paciente.");
            if (e.Relacion == "Paciente" && e.DniRecibe != reporte.Dni)
                return Respuesta.Error("Si recibe el paciente, el DNI debe ser el del paciente (" + reporte.Dni + ").");

            int id = datos.Registrar(e, Sesion.IdUsuario);
            return Respuesta.Ok("Entrega registrada. Ya puede cerrar la atención " + reporte.NumeroAtencion + ".", id);
        });

        public Respuesta Retener(int idReporte, string motivo) => Respuesta.Intentar(() =>
        {
            var reporte = reporteDatos.ObtenerPorId(idReporte);
            if (reporte == null || reporte.Estado != EstadoReporte.DisponibleEntrega) return Respuesta.Error("El reporte no está disponible para entrega.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la retención.");
            datos.Retener(idReporte, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Entrega retenida.", idReporte);
        });

        public Respuesta LevantarRetencion(int idReporte) => Respuesta.Intentar(() =>
        {
            var reporte = reporteDatos.ObtenerPorId(idReporte);
            if (reporte == null || reporte.Estado != EstadoReporte.EntregaRetenida) return Respuesta.Error("La entrega no está retenida.");
            datos.LevantarRetencion(idReporte, Sesion.IdUsuario);
            return Respuesta.Ok("Retención levantada. El reporte está disponible para entrega.", idReporte);
        });

        public List<Entrega> ListarEntregadas() => datos.ListarEntregadasSinCerrar();

        public Respuesta CerrarAtencion(int idAtencion) => Respuesta.Intentar(() =>
        {
            var reporte = reporteDatos.ObtenerPorAtencion(idAtencion);
            if (reporte == null) return Respuesta.Error("La atención no tiene Reporte clínico.");
            if (reporte.Estado == EstadoReporte.EntregaRetenida) return Respuesta.Error("La entrega está retenida; no se puede cerrar la atención.");
            if (reporte.Estado != EstadoReporte.Entregado || datos.ObtenerPorAtencion(idAtencion) == null)
                return Respuesta.Error("Primero registre la entrega de resultados.");
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado == EstadoAtencion.Culminada) return Respuesta.Error("La atención ya está culminada.");

            atencionDatos.CambiarEstado(idAtencion, EstadoAtencion.Culminada, Sesion.IdUsuario);
            return Respuesta.Ok("Atención " + atencion.NumeroAtencion + " culminada.", idAtencion);
        });

        public List<Entrega> ConsultarEntregas(DateTime desde, DateTime hasta) => datos.Consultar(desde, hasta);
    }
}
