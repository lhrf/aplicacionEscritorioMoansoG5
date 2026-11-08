using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-53 Mantenedor de plantillas de Reporte clínico.</summary>
    public class PlantillaNegocio
    {
        private readonly PlantillaDatos datos = new();

        public List<Plantilla> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        /// <summary>Devuelve la plantilla con la lista IdExamenes para marcar el CheckedListBox.</summary>
        public Plantilla? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Plantilla p) => Respuesta.Intentar(() =>
        {
            p.Nombre = (p.Nombre ?? "").Trim();
            p.Formato = (p.Formato ?? "").Trim();
            if (Validacion.Vacio(p.Nombre) || Validacion.Vacio(p.Formato)) return Respuesta.Error("Complete el nombre y el formato de la plantilla.");
            if (p.IdExamenes.Count == 0) return Respuesta.Error("Marque al menos un examen asociado.");
            if (datos.ExisteNombre(p.Nombre, p.IdPlantilla)) return Respuesta.Error("Ya existe una plantilla con ese nombre.");
            string enOtra = datos.ExamenesEnOtraPlantilla(p.IdExamenes, p.IdPlantilla);
            if (enOtra.Length > 0)
                return Respuesta.Error("Estos exámenes ya están asociados a otra plantilla habilitada: " + enOtra + ".");

            if (p.IdPlantilla == 0)
                return Respuesta.Ok("Plantilla registrada.", datos.Insertar(p, Sesion.IdUsuario));
            datos.Actualizar(p, Sesion.IdUsuario);
            return Respuesta.Ok("Plantilla actualizada.", p.IdPlantilla);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Plantilla inhabilitada.");
        });
    }
}
