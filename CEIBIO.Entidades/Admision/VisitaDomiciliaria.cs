namespace CEIBIO.Entidades
{
    public class VisitaDomiciliaria
    {
        public int IdVisita { get; set; }
        public int IdAtencion { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string? Referencia { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public DateTime FechaProgramada { get; set; } = DateTime.Today;
        public string Estado { get; set; } = string.Empty;
        public string? Motivo { get; set; }
        public int? IdTecnico { get; set; }

        // Datos para mostrar
        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string Examenes { get; set; } = string.Empty;
        public string NombreTecnico { get; set; } = string.Empty;
        public string NumeroComprobante { get; set; } = string.Empty;
        public string EstadoAtencion { get; set; } = string.Empty;
    }
}
