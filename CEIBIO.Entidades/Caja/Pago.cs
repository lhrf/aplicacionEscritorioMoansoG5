namespace CEIBIO.Entidades
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdAtencion { get; set; }
        public int IdMedioPago { get; set; }
        public decimal Importe { get; set; }
        public decimal? MontoRecibido { get; set; }
        public decimal? Vuelto { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaConformidad { get; set; }

        // Datos para mostrar
        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string MedioPago { get; set; } = string.Empty;
        public bool RequiereAutorizacion { get; set; }
        public string NombreCajero { get; set; } = string.Empty;
    }
}
