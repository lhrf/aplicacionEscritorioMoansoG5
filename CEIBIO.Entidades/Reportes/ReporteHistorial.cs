namespace CEIBIO.Entidades
{
    public class ReporteHistorial
    {
        public int IdHistorial { get; set; }
        public int IdReporte { get; set; }
        public int Version { get; set; }
        public string Accion { get; set; } = string.Empty;
        public string? Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreResponsable { get; set; } = string.Empty;
    }
}
