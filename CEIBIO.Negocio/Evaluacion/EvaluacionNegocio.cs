using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>
    /// CU-10 Registrar observaciones preanalíticas, CU-11 Registrar resultado de la evaluación pre-analítica,
    /// CU-12 Suspender atención y CU-14 Consultar atenciones suspendidas.
    /// </summary>
    public class EvaluacionNegocio
    {
        private readonly EvaluacionDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly CondicionDatos condicionDatos = new();

        /// <summary>CU-10 paso 2.</summary>
        public List<Atencion> ListarPendientes() => atencionDatos.ListarPorEstado(EstadoAtencion.PendienteEvaluacion);

        /// <summary>CU-10 paso 4: condiciones que exige cada examen de la atención.</summary>
        public List<CondicionPreanalitica> ListarCondiciones(int idAtencion) => condicionDatos.ListarPorAtencion(idAtencion);

        /// <summary>CU-10 A2: true si algún examen es de orina o heces (se pide el estado de la muestra entregada).</summary>
        public bool RequiereMuestraEntregada(int idAtencion) =>
            atencionDatos.ListarDetalle(idAtencion).Any(d => d.TipoMuestra == "Orina" || d.TipoMuestra == "Heces");

        public EvaluacionPreanalitica? ObtenerPorAtencion(int idAtencion) => datos.ObtenerPorAtencion(idAtencion);

        /// <summary>CU-10 paso 6. Si los exámenes no requieren muestra entregada, se ignoran los datos de la muestra.</summary>
        public Respuesta GuardarObservaciones(EvaluacionPreanalitica e) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(e.IdAtencion);
            if (atencion == null) return Respuesta.Error("Seleccione una atención.");
            if (atencion.Estado != EstadoAtencion.PendienteEvaluacion)
                return Respuesta.Error("La atención no está pendiente de evaluación (estado actual: " + atencion.Estado + ").");
            if (e.HorasAyuno < 0 || e.HorasAyuno > 72) return Respuesta.Error("Revise las horas de ayuno.");

            e.Medicamentos = Validacion.TextoONulo(e.Medicamentos);
            e.Observaciones = Validacion.TextoONulo(e.Observaciones);
            if (!RequiereMuestraEntregada(e.IdAtencion))
            {
                e.RotuladoCorrecto = null;
                e.RecipienteHermetico = null;
                e.VolumenSuficiente = null;
                e.ConservacionAdecuada = null;
            }
            else
            {
                e.RotuladoCorrecto ??= false;
                e.RecipienteHermetico ??= false;
                e.VolumenSuficiente ??= false;
                e.ConservacionAdecuada ??= false;
            }

            datos.GuardarObservaciones(e, Sesion.IdUsuario);
            return Respuesta.Ok("Observaciones preanalíticas registradas para la atención " + atencion.NumeroAtencion + ".", e.IdAtencion);
        });

        /// <summary>CU-11: registra al paciente como apto y deriva la atención a Caja.</summary>
        public Respuesta RegistrarApto(int idAtencion) => Respuesta.Intentar(() =>
        {
            var error = ValidarEvaluable(idAtencion);
            if (error != null) return Respuesta.Error(error);
            datos.RegistrarApto(idAtencion, Sesion.IdUsuario);
            return Respuesta.Ok("Paciente apto. La atención pasó a Caja (pendiente de pago).", idAtencion);
        });

        /// <summary>CU-12: paciente no apto. Registra el motivo y la nueva fecha, y suspende la atención.</summary>
        public Respuesta Suspender(Suspension s) => Respuesta.Intentar(() =>
        {
            var error = ValidarEvaluable(s.IdAtencion);
            if (error != null) return Respuesta.Error(error);
            s.Motivo = (s.Motivo ?? "").Trim();
            if (Validacion.Vacio(s.Motivo)) return Respuesta.Error("Ingrese el motivo de la suspensión.");
            if (s.NuevaFecha.Date <= DateTime.Today) return Respuesta.Error("La nueva fecha debe ser posterior a hoy.");

            datos.Suspender(s, Sesion.IdUsuario);
            return Respuesta.Ok("Atención suspendida hasta el " + s.NuevaFecha.ToString("dd/MM/yyyy") + ".", s.IdAtencion);
        });

        /// <summary>CU-14.</summary>
        public List<Suspension> ConsultarSuspendidas(DateTime desde, DateTime hasta) => datos.ConsultarSuspendidas(desde, hasta);

        /// <summary>CU-12: reactiva la atención en la nueva fecha (o después); vuelve a "Pendiente de evaluación".</summary>
        public Respuesta Reactivar(int idSuspension) => Respuesta.Intentar(() =>
        {
            var s = datos.ObtenerSuspension(idSuspension);
            if (s == null) return Respuesta.Error("Seleccione una atención suspendida.");
            if (s.Reactivada) return Respuesta.Error("La atención ya fue reactivada.");
            if (DateTime.Today < s.NuevaFecha.Date)
                return Respuesta.Error("La atención se puede reactivar desde el " + s.NuevaFecha.ToString("dd/MM/yyyy") + ".");

            datos.Reactivar(idSuspension, Sesion.IdUsuario);
            return Respuesta.Ok("Atención " + s.NumeroAtencion + " reactivada. Está otra vez pendiente de evaluación.", s.IdAtencion);
        });

        private string? ValidarEvaluable(int idAtencion)
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null) return "Seleccione una atención.";
            if (atencion.Estado != EstadoAtencion.PendienteEvaluacion) return "La atención no está pendiente de evaluación.";
            var evaluacion = datos.ObtenerPorAtencion(idAtencion);
            if (evaluacion == null) return "Primero registre las observaciones preanalíticas (CU-10).";
            if (evaluacion.Resultado != null) return "La atención fue reactivada: registre nuevamente las observaciones preanalíticas.";
            return null;
        }
    }
}
