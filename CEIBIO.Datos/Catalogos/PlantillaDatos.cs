using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class PlantillaDatos
    {
        private static Plantilla Mapear(SqlDataReader r) => new Plantilla
        {
            IdPlantilla = Leer.Entero(r, "IdPlantilla"),
            Nombre = Leer.Texto(r, "Nombre"),
            Formato = Leer.Texto(r, "Formato"),
            Habilitado = Leer.Booleano(r, "Habilitado"),
            Examenes = Leer.Texto(r, "Examenes")
        };

        public List<Plantilla> Listar(string filtro) => Db.Listar("usp_Plantilla_Listar", Mapear, P("@Filtro", filtro));

        public Plantilla? ObtenerPorId(int id)
        {
            var plantilla = Db.Obtener("usp_Plantilla_ObtenerPorId", Mapear, P("@IdPlantilla", id));
            if (plantilla != null)
                plantilla.IdExamenes = Db.Listar("usp_Plantilla_ListarExamenes", r => Leer.Entero(r, "IdExamen"), P("@IdPlantilla", id));
            return plantilla;
        }

        public Plantilla? ObtenerPorExamen(int idExamen) => Db.Obtener("usp_Plantilla_ObtenerPorExamen", Mapear, P("@IdExamen", idExamen));

        public bool ExisteNombre(string nombre, int idExcluir) =>
            Db.Entero("usp_Plantilla_ExisteNombre", P("@Nombre", nombre), P("@IdExcluir", idExcluir)) > 0;

        public string ExamenesEnOtraPlantilla(IEnumerable<int> idExamenes, int idExcluir) =>
            Db.Texto("usp_Plantilla_ExamenesEnOtraPlantilla", P("@IdExamenes", Lista(idExamenes)), P("@IdExcluir", idExcluir));

        public int Insertar(Plantilla p, int idUsuario) =>
            Db.Entero("usp_Plantilla_Insertar", P("@Nombre", p.Nombre), P("@Formato", p.Formato), P("@IdExamenes", Lista(p.IdExamenes)), P("@IdUsuario", idUsuario));

        public void Actualizar(Plantilla p, int idUsuario) =>
            Db.Ejecutar("usp_Plantilla_Actualizar", P("@IdPlantilla", p.IdPlantilla), P("@Nombre", p.Nombre), P("@Formato", p.Formato),
                P("@IdExamenes", Lista(p.IdExamenes)), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Plantilla_CambiarEstado", P("@IdPlantilla", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
