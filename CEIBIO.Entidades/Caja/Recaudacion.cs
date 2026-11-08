namespace CEIBIO.Entidades
{
    public class Recaudacion
    {
        public int IdRecaudacion { get; set; }
        public int IdComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }   // negativo cuando es una anulación
        public int IdMedioPago { get; set; }
        public string Tipo { get; set; } = string.Empty;   // Ingreso, Anulación

        // Datos para mostrar
        public string NumeroComprobante { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string MedioPago { get; set; } = string.Empty;
        public string NombreCajero { get; set; } = string.Empty;
    }
}
