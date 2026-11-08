using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class TuboDatos
    {
        private static Tubo Mapear(SqlDataReader r) => new Tubo
        {
            IdTubo = Leer.Entero(r, "IdTubo"),
            Tipo = Leer.Texto(r, "Tipo"),
            ColorTapa = Leer.Texto(r, "ColorTapa"),
            Aditivo = Leer.TextoNulo(r, "Aditivo"),
            MinutosCentrifugacion = Leer.Entero(r, "MinutosCentrifugacion"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<Tubo> Listar(string filtro) => Db.Listar("usp_Tubo_Listar", Mapear, P("@Filtro", filtro));

        public Tubo? ObtenerPorId(int id)
        {
            var tubo = Db.Obtener("usp_Tubo_ObtenerPorId", Mapear, P("@IdTubo", id));
            if (tubo != null)
                tubo.IdExamenes = Db.Listar("usp_Tubo_ListarExamenes", r => Leer.Entero(r, "IdExamen"), P("@IdTubo", id));
            return tubo;
        }

        public bool ExisteTipo(string tipo, string colorTapa, string? aditivo, int idExcluir) =>
            Db.Entero("usp_Tubo_ExisteTipo", P("@Tipo", tipo), P("@IdExcluir", idExcluir), P("@ColorTapa", colorTapa), P("@Aditivo", aditivo)) > 0;

        public int Insertar(Tubo t, int idUsuario) =>
            Db.Entero("usp_Tubo_Insertar",
                P("@Tipo", t.Tipo), P("@ColorTapa", t.ColorTapa), P("@Aditivo", t.Aditivo), P("@MinutosCentrifugacion", t.MinutosCentrifugacion),
                P("@IdExamenes", Lista(t.IdExamenes)), P("@IdUsuario", idUsuario));

        public void Actualizar(Tubo t, int idUsuario) =>
            Db.Ejecutar("usp_Tubo_Actualizar",
                P("@IdTubo", t.IdTubo), P("@Tipo", t.Tipo), P("@ColorTapa", t.ColorTapa), P("@Aditivo", t.Aditivo),
                P("@MinutosCentrifugacion", t.MinutosCentrifugacion), P("@IdExamenes", Lista(t.IdExamenes)), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Tubo_CambiarEstado", P("@IdTubo", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));

        public List<TuboRequerido> ListarRequeridosPorAtencion(int idAtencion) =>
            Db.Listar("usp_Tubo_ListarRequeridosPorAtencion",
                r => new TuboRequerido
                {
                    IdExamen = Leer.Entero(r, "IdExamen"),
                    NombreExamen = Leer.Texto(r, "NombreExamen"),
                    IdTubo = Leer.Entero(r, "IdTubo"),
                    Tipo = Leer.Texto(r, "Tipo"),
                    ColorTapa = Leer.Texto(r, "ColorTapa"),
                    MinutosCentrifugacion = Leer.Entero(r, "MinutosCentrifugacion")
                }, P("@IdAtencion", idAtencion));
    }
}
