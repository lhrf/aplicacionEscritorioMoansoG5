using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class ExamenDatos
    {
        private static Examen Mapear(SqlDataReader r) => new Examen
        {
            IdExamen = Leer.Entero(r, "IdExamen"),
            Codigo = Leer.Texto(r, "Codigo"),
            Nombre = Leer.Texto(r, "Nombre"),
            TipoMuestra = Leer.Texto(r, "TipoMuestra"),
            Procedimiento = Leer.Texto(r, "Procedimiento"),
            Tarifa = Leer.Decimal(r, "Tarifa"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<Examen> Listar(string filtro, bool soloHabilitados) =>
            Db.Listar("usp_Examen_Listar", Mapear, P("@Filtro", filtro), P("@SoloHabilitados", soloHabilitados));

        public Examen? ObtenerPorId(int id) => Db.Obtener("usp_Examen_ObtenerPorId", Mapear, P("@IdExamen", id));

        public bool ExisteCodigo(string codigo, int idExcluir) =>
            Db.Entero("usp_Examen_ExisteCodigo", P("@Codigo", codigo), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(Examen e, int idUsuario) =>
            Db.Entero("usp_Examen_Insertar",
                P("@Codigo", e.Codigo), P("@Nombre", e.Nombre), P("@TipoMuestra", e.TipoMuestra),
                P("@Procedimiento", e.Procedimiento), P("@Tarifa", e.Tarifa), P("@IdUsuario", idUsuario));

        public void Actualizar(Examen e, int idUsuario) =>
            Db.Ejecutar("usp_Examen_Actualizar",
                P("@IdExamen", e.IdExamen), P("@Codigo", e.Codigo), P("@Nombre", e.Nombre), P("@TipoMuestra", e.TipoMuestra),
                P("@Procedimiento", e.Procedimiento), P("@Tarifa", e.Tarifa), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Examen_CambiarEstado", P("@IdExamen", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
