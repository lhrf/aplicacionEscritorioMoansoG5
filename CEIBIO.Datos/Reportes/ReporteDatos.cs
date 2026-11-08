using System.Text.Json;
using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class ReporteDatos
    {
        private static ReporteClinico Mapear(SqlDataReader r) => new ReporteClinico
        {
            IdReporte = Leer.Entero(r, "IdReporte"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            Version = Leer.Entero(r, "Version"),
            Contenido = Leer.Texto(r, "Contenido"),
            Estado = Leer.Texto(r, "Estado"),
            Definitivo = Leer.Booleano(r, "Definitivo"),
            FechaGeneracion = Leer.Fecha(r, "FechaGeneracion"),
            FechaAutorizacion = Leer.FechaNula(r, "FechaAutorizacion"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            Dni = Leer.Texto(r, "Dni"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            Examenes = Leer.Texto(r, "Examenes"),
            NombreDigitador = Leer.Texto(r, "NombreDigitador"),
            NombreDirector = Leer.Texto(r, "NombreDirector")
        };

        public ReporteClinico? ObtenerPorId(int idReporte) => Db.Obtener("usp_Reporte_ObtenerPorId", Mapear, P("@IdReporte", idReporte));

        public ReporteClinico? ObtenerPorAtencion(int idAtencion) => Db.Obtener("usp_Reporte_ObtenerPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        public List<ReporteClinico> ListarPorEstado(string estado) => Db.Listar("usp_Reporte_ListarPorEstado", Mapear, P("@Estado", estado));

        public List<ReporteClinico> Consultar(string? dni, DateTime desde, DateTime hasta, string? estado) =>
            Db.Listar("usp_Reporte_Consultar", Mapear,
                P("@Dni", string.IsNullOrWhiteSpace(dni) ? null : dni.Trim()), P("@Desde", desde.Date), P("@Hasta", hasta.Date),
                P("@Estado", string.IsNullOrWhiteSpace(estado) ? null : estado));

        public int Insertar(int idAtencion, string contenido, List<ReporteSeccion> secciones, int idDigitador) =>
            Db.Entero("usp_Reporte_Insertar", P("@IdAtencion", idAtencion), P("@Contenido", contenido), P("@IdDigitador", idDigitador),
                P("@Secciones", SeccionesJson(secciones)));

        public void Regenerar(int idReporte, string contenido, List<ReporteSeccion> secciones, bool nuevaVersion, int idDigitador) =>
            Db.Ejecutar("usp_Reporte_Regenerar",
                P("@IdReporte", idReporte), P("@Contenido", contenido), P("@NuevaVersion", nuevaVersion), P("@IdDigitador", idDigitador),
                P("@Secciones", SeccionesJson(secciones)));

        public List<ReporteSeccion> ListarSecciones(int idReporte, int? version) =>
            Db.Listar("usp_ReporteSeccion_Listar",
                r => new ReporteSeccion
                {
                    IdSeccion = Leer.Entero(r, "IdSeccion"),
                    IdReporte = Leer.Entero(r, "IdReporte"),
                    Version = Leer.Entero(r, "Version"),
                    IdExamen = Leer.Entero(r, "IdExamen"),
                    NombreExamen = Leer.Texto(r, "NombreExamen"),
                    IdPlantilla = Leer.Entero(r, "IdPlantilla"),
                    NombrePlantilla = Leer.Texto(r, "NombrePlantilla"),
                    Contenido = Leer.Texto(r, "Contenido")
                }, P("@IdReporte", idReporte), P("@Version", version));

        private static string SeccionesJson(List<ReporteSeccion> secciones) =>
            JsonSerializer.Serialize(secciones.Select(s => new { s.IdExamen, s.IdPlantilla, s.Contenido }));

        public void CambiarEstado(int idReporte, string estado, string accion, string? observacion, int idUsuario) =>
            Db.Ejecutar("usp_Reporte_CambiarEstado",
                P("@IdReporte", idReporte), P("@Estado", estado), P("@Accion", accion), P("@Observacion", observacion), P("@IdUsuario", idUsuario));

        public void MarcarDefinitivo(int idReporte, int idUsuario) =>
            Db.Ejecutar("usp_Reporte_MarcarDefinitivo", P("@IdReporte", idReporte), P("@IdUsuario", idUsuario));

        public void Autorizar(int idReporte, int idDirector) =>
            Db.Ejecutar("usp_Reporte_Autorizar", P("@IdReporte", idReporte), P("@IdDirector", idDirector));

        public void AnularAutorizacion(int idReporte, string motivo, int idDirector) =>
            Db.Ejecutar("usp_Reporte_AnularAutorizacion", P("@IdReporte", idReporte), P("@Motivo", motivo), P("@IdDirector", idDirector));

        public void DevolverAlMedico(int idReporte, string observacion, int idDirector) =>
            Db.Ejecutar("usp_Reporte_DevolverAlMedico", P("@IdReporte", idReporte), P("@Observacion", observacion), P("@IdDirector", idDirector));

        public List<ReporteHistorial> ListarHistorial(int idReporte) =>
            Db.Listar("usp_Reporte_ListarHistorial",
                r => new ReporteHistorial
                {
                    IdHistorial = Leer.Entero(r, "IdHistorial"),
                    IdReporte = Leer.Entero(r, "IdReporte"),
                    Version = Leer.Entero(r, "Version"),
                    Accion = Leer.Texto(r, "Accion"),
                    Observacion = Leer.TextoNulo(r, "Observacion"),
                    Fecha = Leer.Fecha(r, "Fecha"),
                    NombreResponsable = Leer.Texto(r, "NombreResponsable")
                }, P("@IdReporte", idReporte));
    }
}
