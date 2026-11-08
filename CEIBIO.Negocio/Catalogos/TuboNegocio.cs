using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class TuboNegocio
    {
        private readonly TuboDatos datos = new();

        public List<Tubo> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        public Tubo? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Tubo t) => Respuesta.Intentar(() =>
        {
            t.Tipo = (t.Tipo ?? "").Trim();
            t.ColorTapa = (t.ColorTapa ?? "").Trim();
            t.Aditivo = Validacion.TextoONulo(t.Aditivo);
            if (Validacion.Vacio(t.Tipo) || Validacion.Vacio(t.ColorTapa)) return Respuesta.Error("Complete el tipo y el color de tapa.");
            if (t.MinutosCentrifugacion < 0 || t.MinutosCentrifugacion > 60) return Respuesta.Error("El tiempo de centrifugación debe estar entre 0 y 60 minutos.");
            if (t.IdExamenes.Count == 0) return Respuesta.Error("Marque al menos un examen asociado.");
            if (datos.ExisteTipo(t.Tipo, t.ColorTapa, t.Aditivo, t.IdTubo))
                return Respuesta.Error("Ya existe un tubo o recipiente con el mismo tipo, color de tapa y aditivo.");

            if (t.IdTubo == 0)
                return Respuesta.Ok("Tubo registrado.", datos.Insertar(t, Sesion.IdUsuario));
            datos.Actualizar(t, Sesion.IdUsuario);
            return Respuesta.Ok("Tubo actualizado.", t.IdTubo);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Tubo inhabilitado.");
        });
    }
}
