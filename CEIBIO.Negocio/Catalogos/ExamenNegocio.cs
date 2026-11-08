using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-06 Mantenedor de exámenes.</summary>
    public class ExamenNegocio
    {
        private readonly ExamenDatos datos = new();

        public static readonly string[] TiposMuestra = { "Sangre", "Orina", "Heces" };
        public static readonly string[] Procedimientos = { "Automatizado", "Microscópico" };

        /// <summary>Todos los exámenes (para la grilla del mantenedor).</summary>
        public List<Examen> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim(), false);

        /// <summary>Exámenes habilitados (buscador de CU-01, combos y listas de otros mantenedores).</summary>
        public List<Examen> ListarHabilitados(string filtro = "") => datos.Listar((filtro ?? "").Trim(), true);

        public Examen? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Examen e) => Respuesta.Intentar(() =>
        {
            e.Codigo = (e.Codigo ?? "").Trim().ToUpperInvariant();
            e.Nombre = (e.Nombre ?? "").Trim();

            if (Validacion.Vacio(e.Codigo) || Validacion.Vacio(e.Nombre) || Validacion.Vacio(e.TipoMuestra) || Validacion.Vacio(e.Procedimiento))
                return Respuesta.Error("Complete el código, el nombre, el tipo de muestra y el procedimiento.");
            if (e.Tarifa <= 0) return Respuesta.Error("La tarifa debe ser mayor que cero.");
            if (datos.ExisteCodigo(e.Codigo, e.IdExamen)) return Respuesta.Error("El código " + e.Codigo + " ya está registrado.");

            if (e.IdExamen == 0)
                return Respuesta.Ok("Examen registrado.", datos.Insertar(e, Sesion.IdUsuario));
            datos.Actualizar(e, Sesion.IdUsuario);
            return Respuesta.Ok("Examen actualizado.", e.IdExamen);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Examen inhabilitado. Las atenciones que ya lo usan no se modifican.");
        });
    }
}
