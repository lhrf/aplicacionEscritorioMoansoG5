using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class MedioPagoDatos
    {
        private static MedioPago Mapear(SqlDataReader r) => new MedioPago
        {
            IdMedioPago = Leer.Entero(r, "IdMedioPago"),
            Codigo = Leer.Texto(r, "Codigo"),
            Descripcion = Leer.Texto(r, "Descripcion"),
            RequiereAutorizacion = Leer.Booleano(r, "RequiereAutorizacion"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<MedioPago> Listar(string filtro, bool soloHabilitados) =>
            Db.Listar("usp_MedioPago_Listar", Mapear, P("@Filtro", filtro), P("@SoloHabilitados", soloHabilitados));

        public MedioPago? ObtenerPorId(int id) => Db.Obtener("usp_MedioPago_ObtenerPorId", Mapear, P("@IdMedioPago", id));

        public bool ExisteCodigo(string codigo, int idExcluir) =>
            Db.Entero("usp_MedioPago_ExisteCodigo", P("@Codigo", codigo), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(MedioPago m, int idUsuario) =>
            Db.Entero("usp_MedioPago_Insertar",
                P("@Codigo", m.Codigo), P("@Descripcion", m.Descripcion), P("@RequiereAutorizacion", m.RequiereAutorizacion), P("@IdUsuario", idUsuario));

        public void Actualizar(MedioPago m, int idUsuario) =>
            Db.Ejecutar("usp_MedioPago_Actualizar",
                P("@IdMedioPago", m.IdMedioPago), P("@Codigo", m.Codigo), P("@Descripcion", m.Descripcion),
                P("@RequiereAutorizacion", m.RequiereAutorizacion), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_MedioPago_CambiarEstado", P("@IdMedioPago", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
