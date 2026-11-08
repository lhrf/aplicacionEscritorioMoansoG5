using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class TomaMuestraNegocio
    {
        private readonly AtencionDatos atencionDatos = new();
        private readonly BoxDatos boxDatos = new();
        private readonly TuboDatos tuboDatos = new();
        private readonly MuestraDatos muestraDatos = new();
        private readonly VisitaDatos visitaDatos = new();

        public static readonly string[] MotivosRechazo = { "Hemólisis", "Volumen insuficiente", "Coagulada", "Otro" };

        public List<Atencion> ListarEnEspera() => atencionDatos.ListarEnEsperaPorTurno();

        public List<Box> ListarBoxesLibres() => boxDatos.ListarLibres();

        public Respuesta AsignarBox(int idAtencion, int idBox) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.EnEsperaToma) return Respuesta.Error("Seleccione un paciente en espera.");
            var libres = boxDatos.ListarLibres();
            if (libres.Count == 0) return Respuesta.Error("No hay boxes libres. La atención permanece en espera.");
            if (!libres.Any(b => b.IdBox == idBox)) return Respuesta.Error("El box seleccionado no está libre.");

            atencionDatos.AsignarBox(idAtencion, idBox, Sesion.IdUsuario);
            return Respuesta.Ok("Turno " + atencion.NumeroTurno + " derivado al box seleccionado.", idAtencion);
        });

        public List<Atencion> ListarEnToma() => atencionDatos.ListarPorEstado(EstadoAtencion.EnTomaMuestra);

        public List<TuboRequerido> ListarTubosRequeridos(int idAtencion) => tuboDatos.ListarRequeridosPorAtencion(idAtencion);

        public List<TuboRequerido> ListarTubosALlevar(int idAtencion) =>
            ListarTubosRequeridos(idAtencion)
                .GroupBy(t => t.IdTubo)
                .Select(g => new TuboRequerido
                {
                    IdTubo = g.Key,
                    Tipo = g.First().Tipo,
                    ColorTapa = g.First().ColorTapa,
                    MinutosCentrifugacion = g.First().MinutosCentrifugacion,
                    NombreExamen = string.Join(", ", g.Select(x => x.NombreExamen)),
                    Cantidad = g.Count()
                }).ToList();

        public Muestra? ObtenerMuestra(int idAtencion) => muestraDatos.ObtenerPorAtencion(idAtencion);

        public Respuesta IniciarToma(int idAtencion) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.EnTomaMuestra || atencion.IdBox == null)
                return Respuesta.Error("La atención no está en toma de muestra con box asignado.");
            return GenerarCodigo(idAtencion);
        });

        public List<Etiqueta> ListarEtiquetas(int idAtencion)
        {
            var muestra = muestraDatos.ObtenerPorAtencion(idAtencion);
            if (muestra == null) return new List<Etiqueta>();
            return ListarTubosRequeridos(idAtencion).Select(t => new Etiqueta
            {
                NombrePaciente = muestra.NombrePaciente,
                Fecha = muestra.FechaGeneracion,
                Codigo = muestra.Codigo,
                NombreExamen = t.NombreExamen,
                Tubo = t.Tipo + " (" + t.ColorTapa + ")"
            }).ToList();
        }

        public Respuesta ValidarRecoleccion(int idAtencion, DateTime horaExtraccion) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.EnTomaMuestra) return Respuesta.Error("La atención no está en toma de muestra.");
            var muestra = muestraDatos.ObtenerPorAtencion(idAtencion);
            if (muestra == null) return Respuesta.Error("Primero inicie la toma de muestra para generar el código.");
            var error = ValidarHora(horaExtraccion);
            if (error != null) return Respuesta.Error(error);

            muestraDatos.RegistrarRecoleccion(muestra.IdMuestra, horaExtraccion, Sesion.IdUsuario);
            return Respuesta.Ok("Recolección validada. Muestra " + muestra.Codigo + " recolectada.", muestra.IdMuestra, muestra.Codigo);
        });

        public Respuesta RegistrarRechazo(RechazoMuestra r) => Respuesta.Intentar(() =>
        {
            var muestra = muestraDatos.ObtenerPorId(r.IdMuestra);
            if (muestra == null) return Respuesta.Error("Primero inicie la toma de muestra.");
            if (muestra.Estado != EstadoMuestra.Generada) return Respuesta.Error("La recolección ya fue validada; no se puede registrar el rechazo.");
            if (!MotivosRechazo.Contains(r.Motivo)) return Respuesta.Error("Seleccione el motivo del rechazo.");
            r.Observacion = Validacion.TextoONulo(r.Observacion);
            if (r.Motivo == "Otro" && r.Observacion == null) return Respuesta.Error("Describa el motivo en la observación.");

            muestraDatos.RegistrarRechazo(r, Sesion.IdUsuario);
            return Respuesta.Ok("Rechazo registrado. Reimprima la etiqueta y repita la recolección.", r.IdMuestra);
        });

        public List<RechazoMuestra> ConsultarRechazadas(DateTime desde, DateTime hasta) => muestraDatos.ConsultarRechazadas(desde, hasta);

        public List<VisitaDomiciliaria> ListarVisitasDelDia() => visitaDatos.ListarDelDia(Sesion.IdUsuario, DateTime.Today);

        public Respuesta PrepararVisita(int idAtencion) => Respuesta.Intentar(() =>
        {
            var error = ValidarVisitaDelTecnico(idAtencion);
            if (error != null) return Respuesta.Error(error);
            return GenerarCodigo(idAtencion);
        });

        public Respuesta RegistrarRetorno(int idAtencion, DateTime horaExtraccion, string? condicionesDeclaradas, string? rechazosOcurridos) => Respuesta.Intentar(() =>
        {
            var error = ValidarVisitaDelTecnico(idAtencion) ?? ValidarHora(horaExtraccion);
            if (error != null) return Respuesta.Error(error);
            var muestra = muestraDatos.ObtenerPorAtencion(idAtencion);
            if (muestra == null) return Respuesta.Error("Primero prepare la visita para generar el código de la muestra.");

            muestraDatos.RegistrarRetorno(muestra.IdMuestra, horaExtraccion,
                Validacion.TextoONulo(condicionesDeclaradas), Validacion.TextoONulo(rechazosOcurridos), Sesion.IdUsuario);
            return Respuesta.Ok("Retorno registrado. Muestra " + muestra.Codigo + " recolectada.", muestra.IdMuestra, muestra.Codigo);
        });

        public Respuesta RegistrarVisitaNoRealizada(int idAtencion, string motivo) => Respuesta.Intentar(() =>
        {
            var error = ValidarVisitaDelTecnico(idAtencion);
            if (error != null) return Respuesta.Error(error);
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo por el que no se realizó la visita.");
            var visita = visitaDatos.ObtenerPorAtencion(idAtencion)!;
            visitaDatos.CambiarEstado(visita.IdVisita, EstadoVisita.NoRealizada, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Visita registrada como no realizada. El Asesor de Admisión deberá reprogramarla.", visita.IdVisita);
        });

        private Respuesta GenerarCodigo(int idAtencion)
        {
            int idMuestra = muestraDatos.Generar(idAtencion, Sesion.IdUsuario);
            var muestra = muestraDatos.ObtenerPorId(idMuestra);
            string codigo = muestra?.Codigo ?? "";
            return Respuesta.Ok("Código de muestra " + codigo + " generado. Imprima las etiquetas.", idMuestra, codigo);
        }

        private string? ValidarVisitaDelTecnico(int idAtencion)
        {
            var visita = visitaDatos.ObtenerPorAtencion(idAtencion);
            if (visita == null) return "La atención no tiene visita domiciliaria.";
            if (visita.IdTecnico != Sesion.IdUsuario) return "La visita no está asignada a usted.";
            if (visita.EstadoAtencion != EstadoAtencion.VisitaAsignada) return "La atención no está en estado «Visita asignada».";
            if (visita.Estado != EstadoVisita.Programada && visita.Estado != EstadoVisita.Reprogramada)
                return "La visita está " + visita.Estado.ToLower() + ".";
            return null;
        }

        private static string? ValidarHora(DateTime horaExtraccion)
        {
            if (horaExtraccion > DateTime.Now.AddMinutes(5)) return "La hora de extracción no puede ser posterior a la hora actual.";
            if (horaExtraccion.Date < DateTime.Today.AddDays(-1)) return "Revise la fecha y hora de extracción.";
            return null;
        }
    }
}
