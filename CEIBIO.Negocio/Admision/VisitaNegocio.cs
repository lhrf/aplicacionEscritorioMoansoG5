using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class VisitaNegocio
    {
        private readonly VisitaDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();

        public VisitaDomiciliaria? ObtenerPorAtencion(int idAtencion) => datos.ObtenerPorAtencion(idAtencion);

        public Respuesta Programar(VisitaDomiciliaria v) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(v.IdAtencion);
            if (atencion == null) return Respuesta.Error("La atención no existe.");
            if (atencion.Modalidad != Modalidad.ADomicilio) return Respuesta.Error("La atención no es de modalidad a domicilio.");
            if (atencion.Estado == EstadoAtencion.Anulada) return Respuesta.Error("La atención está anulada.");
            if (datos.ObtenerPorAtencion(v.IdAtencion) != null) return Respuesta.Error("La atención ya tiene una visita. Use Reprogramar.");

            var error = Validar(v);
            if (error != null) return Respuesta.Error(error);

            v.Estado = EstadoVisita.Programada;
            int id = datos.Insertar(v, Sesion.IdUsuario);
            return Respuesta.Ok("Visita programada para el " + v.FechaProgramada.ToString("dd/MM/yyyy") + ".", id);
        });

        public Respuesta Reprogramar(VisitaDomiciliaria v) => Respuesta.Intentar(() =>
        {
            var actual = datos.ObtenerPorAtencion(v.IdAtencion);
            if (actual == null) return Respuesta.Error("La atención no tiene una visita programada.");
            if (actual.Estado == EstadoVisita.Cancelada || actual.Estado == EstadoVisita.Realizada)
                return Respuesta.Error("La visita está " + actual.Estado.ToLower() + "; no se puede reprogramar.");

            var error = Validar(v);
            if (error != null) return Respuesta.Error(error);
            if (Validacion.Vacio(v.Motivo)) return Respuesta.Error("Ingrese el motivo de la reprogramación.");

            v.IdVisita = actual.IdVisita;
            v.Estado = EstadoVisita.Reprogramada;
            datos.Actualizar(v, Sesion.IdUsuario);
            return Respuesta.Ok("Visita reprogramada para el " + v.FechaProgramada.ToString("dd/MM/yyyy") + ".", actual.IdVisita);
        });

        public Respuesta Cancelar(int idAtencion, string motivo) => Respuesta.Intentar(() =>
        {
            var actual = datos.ObtenerPorAtencion(idAtencion);
            if (actual == null) return Respuesta.Error("La atención no tiene una visita programada.");
            if (actual.Estado == EstadoVisita.Realizada) return Respuesta.Error("La visita ya se realizó.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la cancelación.");
            datos.CambiarEstado(actual.IdVisita, EstadoVisita.Cancelada, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Visita cancelada.", actual.IdVisita);
        });

        public List<VisitaDomiciliaria> ConsultarPorFecha(DateTime fecha) => datos.ListarPorFecha(fecha);

        public List<VisitaDomiciliaria> ListarMisVisitas() => datos.ListarAsignadas(Sesion.IdUsuario);

        private static string? Validar(VisitaDomiciliaria v)
        {
            v.Direccion = (v.Direccion ?? "").Trim();
            v.Referencia = Validacion.TextoONulo(v.Referencia);
            v.Telefono = (v.Telefono ?? "").Trim();
            v.Motivo = Validacion.TextoONulo(v.Motivo);
            if (Validacion.Vacio(v.Direccion)) return "Ingrese la dirección.";
            if (!Validacion.EsTelefono(v.Telefono)) return "El teléfono debe tener de 7 a 9 dígitos.";
            if (v.FechaProgramada.Date < DateTime.Today) return "La fecha programada no puede ser anterior a hoy.";
            return null;
        }
    }
}
