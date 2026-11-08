namespace CEIBIO.Entidades
{
    public class Atencion
    {
        public int IdAtencion { get; set; }
        public string NumeroAtencion { get; set; } = string.Empty;
        public int IdPaciente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Modalidad { get; set; } = "En sede";
        public int? IdConvenio { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal CostoTotal { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string? MotivoAnulacion { get; set; }
        public int? NumeroTurno { get; set; }
        public DateTime? FechaDerivacion { get; set; }
        public int? IdBox { get; set; }
        public int IdUsuarioRegistro { get; set; }

        public string Dni { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string Examenes { get; set; } = string.Empty;
        public string NombreConvenio { get; set; } = string.Empty;
        public string NumeroBox { get; set; } = string.Empty;
        public string NombreUsuarioRegistro { get; set; } = string.Empty;
        public string NumeroComprobante { get; set; } = string.Empty;
        public string MedioPago { get; set; } = string.Empty;
        public string EstadoReporte { get; set; } = string.Empty;

        public List<AtencionExamen> Detalle { get; set; } = new();
    }
}
