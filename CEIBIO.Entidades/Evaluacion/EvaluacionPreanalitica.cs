namespace CEIBIO.Entidades
{
    public class EvaluacionPreanalitica
    {
        public int IdEvaluacion { get; set; }
        public int IdAtencion { get; set; }
        public int HorasAyuno { get; set; }
        public string? Medicamentos { get; set; }

        public bool? RotuladoCorrecto { get; set; }
        public bool? RecipienteHermetico { get; set; }
        public bool? VolumenSuficiente { get; set; }
        public bool? ConservacionAdecuada { get; set; }

        public string? Observaciones { get; set; }
        public DateTime FechaObservacion { get; set; }
        public string? Resultado { get; set; }
        public DateTime? FechaResultado { get; set; }

        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string NombreEnfermera { get; set; } = string.Empty;

        public string EstadoMuestraTexto
        {
            get
            {
                if (RotuladoCorrecto == null && RecipienteHermetico == null && VolumenSuficiente == null && ConservacionAdecuada == null)
                    return "No requiere muestra entregada";
                var fallas = new List<string>();
                if (RotuladoCorrecto == false) fallas.Add("rotulado incorrecto");
                if (RecipienteHermetico == false) fallas.Add("recipiente no hermético");
                if (VolumenSuficiente == false) fallas.Add("volumen insuficiente");
                if (ConservacionAdecuada == false) fallas.Add("conservación inadecuada");
                return fallas.Count == 0 ? "Conforme" : "Observada: " + string.Join(", ", fallas);
            }
        }
    }
}
