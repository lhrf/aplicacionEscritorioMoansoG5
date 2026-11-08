namespace CEIBIO.Entidades
{
    public class AtencionExamen
    {
        public int IdAtencion { get; set; }
        public int IdExamen { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string NombreExamen { get; set; } = string.Empty;
        public string TipoMuestra { get; set; } = string.Empty;
        public string Procedimiento { get; set; } = string.Empty;
        public decimal Tarifa { get; set; }
        public string? ObservacionesMicroscopicas { get; set; }

        public override string ToString() => NombreExamen;
    }
}
