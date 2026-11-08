namespace CEIBIO.Entidades
{
    public class Comprobante
    {
        public int IdComprobante { get; set; }
        public string NumeroComprobante { get; set; } = string.Empty;
        public int IdAtencion { get; set; }
        public int IdPago { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string? MotivoAnulacion { get; set; }

        public string NumeroAtencion { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string MedioPago { get; set; } = string.Empty;
        public string NombreCajero { get; set; } = string.Empty;
        public List<AtencionExamen> Detalle { get; set; } = new();
    }
}
