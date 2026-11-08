namespace CEIBIO.Entidades
{
    public class RechazoMuestra
    {
        public int IdRechazo { get; set; }
        public int IdMuestra { get; set; }
        public int? IdExamen { get; set; }
        public int? IdTubo { get; set; }
        public string Motivo { get; set; } = string.Empty;   // Hemólisis, Volumen insuficiente, Coagulada, Otro
        public string? Observacion { get; set; }
        public DateTime Fecha { get; set; }

        // Datos para mostrar
        public string CodigoMuestra { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string NombreExamen { get; set; } = string.Empty;
        public string NombreTecnico { get; set; } = string.Empty;
    }
}
