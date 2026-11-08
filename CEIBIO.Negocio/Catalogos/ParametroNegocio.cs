using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-44 Mantenedor de parámetros de examen.</summary>
    public class ParametroNegocio
    {
        private readonly ParametroDatos datos = new();

        public List<Parametro> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        /// <summary>Parámetros habilitados de un examen (combo de CU-54).</summary>
        public List<Parametro> ListarPorExamen(int idExamen) => datos.ListarPorExamen(idExamen, true);

        public Parametro? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Parametro p) => Respuesta.Intentar(() =>
        {
            p.Nombre = (p.Nombre ?? "").Trim();
            p.Unidad = Validacion.TextoONulo(p.Unidad);
            if (p.IdExamen <= 0 || Validacion.Vacio(p.Nombre)) return Respuesta.Error("Seleccione el examen e ingrese el nombre del parámetro.");
            if (datos.ExisteNombre(p.IdExamen, p.Nombre, p.IdParametro)) return Respuesta.Error("El examen ya tiene un parámetro con ese nombre.");

            if (p.IdParametro == 0)
                return Respuesta.Ok("Parámetro registrado.", datos.Insertar(p, Sesion.IdUsuario));
            datos.Actualizar(p, Sesion.IdUsuario);
            return Respuesta.Ok("Parámetro actualizado.", p.IdParametro);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Parámetro inhabilitado.");
        });
    }
}
