namespace CEIBIO.Entidades
{
    /// <summary>Sección de un examen dentro de una versión del Reporte clínico, con la plantilla usada (CU-49).</summary>
    public class ReporteSeccion
    {
        public int IdSeccion { get; set; }
        public int IdReporte { get; set; }
        public int Version { get; set; }
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; } = string.Empty;
        public int IdPlantilla { get; set; }
        public string NombrePlantilla { get; set; } = string.Empty;
        public string Contenido { get; set; } = string.Empty;
    }
}
