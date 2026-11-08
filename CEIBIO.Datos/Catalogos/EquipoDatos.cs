using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class EquipoDatos
    {
        private static Equipo Mapear(SqlDataReader r) => new Equipo
        {
            IdEquipo = Leer.Entero(r, "IdEquipo"),
            Codigo = Leer.Texto(r, "Codigo"),
            Nombre = Leer.Texto(r, "Nombre"),
            Marca = Leer.TextoNulo(r, "Marca"),
            Modelo = Leer.TextoNulo(r, "Modelo"),
            Tipo = Leer.Texto(r, "Tipo"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<Equipo> Listar(string filtro, bool soloHabilitados) =>
            Db.Listar("usp_Equipo_Listar", Mapear, P("@Filtro", filtro), P("@SoloHabilitados", soloHabilitados));

        public Equipo? ObtenerPorId(int id) => Db.Obtener("usp_Equipo_ObtenerPorId", Mapear, P("@IdEquipo", id));

        public bool ExisteCodigo(string codigo, int idExcluir) =>
            Db.Entero("usp_Equipo_ExisteCodigo", P("@Codigo", codigo), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(Equipo e, int idUsuario) =>
            Db.Entero("usp_Equipo_Insertar",
                P("@Codigo", e.Codigo), P("@Nombre", e.Nombre), P("@Marca", e.Marca), P("@Modelo", e.Modelo), P("@Tipo", e.Tipo), P("@IdUsuario", idUsuario));

        public void Actualizar(Equipo e, int idUsuario) =>
            Db.Ejecutar("usp_Equipo_Actualizar",
                P("@IdEquipo", e.IdEquipo), P("@Codigo", e.Codigo), P("@Nombre", e.Nombre), P("@Marca", e.Marca), P("@Modelo", e.Modelo), P("@Tipo", e.Tipo), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Equipo_CambiarEstado", P("@IdEquipo", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
