using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class ParametroDatos
    {
        private static Parametro Mapear(SqlDataReader r) => new Parametro
        {
            IdParametro = Leer.Entero(r, "IdParametro"),
            IdExamen = Leer.Entero(r, "IdExamen"),
            NombreExamen = Leer.Texto(r, "NombreExamen"),
            Nombre = Leer.Texto(r, "Nombre"),
            Unidad = Leer.TextoNulo(r, "Unidad"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<Parametro> Listar(string filtro) => Db.Listar("usp_Parametro_Listar", Mapear, P("@Filtro", filtro));

        public List<Parametro> ListarPorExamen(int idExamen, bool soloHabilitados) =>
            Db.Listar("usp_Parametro_ListarPorExamen", Mapear, P("@IdExamen", idExamen), P("@SoloHabilitados", soloHabilitados));

        public Parametro? ObtenerPorId(int id) => Db.Obtener("usp_Parametro_ObtenerPorId", Mapear, P("@IdParametro", id));

        public bool ExisteNombre(int idExamen, string nombre, int idExcluir) =>
            Db.Entero("usp_Parametro_ExisteNombre", P("@IdExamen", idExamen), P("@Nombre", nombre), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(Parametro p, int idUsuario) =>
            Db.Entero("usp_Parametro_Insertar", P("@IdExamen", p.IdExamen), P("@Nombre", p.Nombre), P("@Unidad", p.Unidad), P("@IdUsuario", idUsuario));

        public void Actualizar(Parametro p, int idUsuario) =>
            Db.Ejecutar("usp_Parametro_Actualizar", P("@IdParametro", p.IdParametro), P("@IdExamen", p.IdExamen), P("@Nombre", p.Nombre), P("@Unidad", p.Unidad), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Parametro_CambiarEstado", P("@IdParametro", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
