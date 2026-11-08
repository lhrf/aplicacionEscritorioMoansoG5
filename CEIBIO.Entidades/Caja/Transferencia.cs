namespace CEIBIO.Entidades
{
    public class Transferencia
    {
        public int IdTransferencia { get; set; }
        public int IdPago { get; set; }
        public string? NumeroOperacion { get; set; }
        public decimal? Importe { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public string Estado { get; set; } = string.Empty;   // Autorizada, Rechazada
        public string? Observacion { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Datos para mostrar
        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string NombreSupervisor { get; set; } = string.Empty;
    }
}
