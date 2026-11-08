namespace CEIBIO.Entidades
{
    public class IntervaloReferencia
    {
        public int IdIntervalo { get; set; }
        public int IdParametro { get; set; }
        public string NombreParametro { get; set; } = string.Empty;
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; } = string.Empty;
        public decimal? ValorMinimo { get; set; }
        public decimal? ValorMaximo { get; set; }
        public string Sexo { get; set; } = "Ambos";
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; } = 120;
        public string? ReferenciaTexto { get; set; }
        public bool Habilitado { get; set; } = true;

        public string EdadTexto => EdadMinima + " a " + EdadMaxima + " años";
        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";

        public string Texto
        {
            get
            {
                if (ValorMinimo.HasValue && ValorMaximo.HasValue) return ValorMinimo.Value.ToString("0.###") + " - " + ValorMaximo.Value.ToString("0.###");
                if (ValorMaximo.HasValue) return "≤ " + ValorMaximo.Value.ToString("0.###");
                if (ValorMinimo.HasValue) return "≥ " + ValorMinimo.Value.ToString("0.###");
                return ReferenciaTexto ?? string.Empty;
            }
        }
    }
}
