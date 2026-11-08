namespace CEIBIO.Entidades
{
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
