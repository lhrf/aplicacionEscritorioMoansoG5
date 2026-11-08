using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class CondicionDatos
    {
        private static CondicionPreanalitica Mapear(SqlDataReader r) => new CondicionPreanalitica
        {
            IdCondicion = Leer.Entero(r, "IdCondicion"),
            IdExamen = Leer.Entero(r, "IdExamen"),
            NombreExamen = Leer.Texto(r, "NombreExamen"),
            HorasAyuno = Leer.Entero(r, "HorasAyuno"),
            RestriccionMedicamentos = Leer.TextoNulo(r, "RestriccionMedicamentos"),
            MuestraQueDebeTraer = Leer.TextoNulo(r, "MuestraQueDebeTraer"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<CondicionPreanalitica> Listar(string filtro) => Db.Listar("usp_Condicion_Listar", Mapear, P("@Filtro", filtro));

        /// <summary>Condiciones habilitadas de los exámenes de una atención (CU-10).</summary>
        public List<CondicionPreanalitica> ListarPorAtencion(int idAtencion) =>
            Db.Listar("usp_Condicion_ListarPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        public CondicionPreanalitica? ObtenerPorId(int id) => Db.Obtener("usp_Condicion_ObtenerPorId", Mapear, P("@IdCondicion", id));

        public bool ExisteParaExamen(int idExamen, int idExcluir) =>
            Db.Entero("usp_Condicion_ExisteParaExamen", P("@IdExamen", idExamen), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(CondicionPreanalitica c, int idUsuario) =>
            Db.Entero("usp_Condicion_Insertar",
                P("@IdExamen", c.IdExamen), P("@HorasAyuno", c.HorasAyuno), P("@RestriccionMedicamentos", c.RestriccionMedicamentos),
                P("@MuestraQueDebeTraer", c.MuestraQueDebeTraer), P("@IdUsuario", idUsuario));

        public void Actualizar(CondicionPreanalitica c, int idUsuario) =>
            Db.Ejecutar("usp_Condicion_Actualizar",
                P("@IdCondicion", c.IdCondicion), P("@IdExamen", c.IdExamen), P("@HorasAyuno", c.HorasAyuno),
                P("@RestriccionMedicamentos", c.RestriccionMedicamentos), P("@MuestraQueDebeTraer", c.MuestraQueDebeTraer), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Condicion_CambiarEstado", P("@IdCondicion", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
