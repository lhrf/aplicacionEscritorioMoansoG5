namespace CEIBIO.Entidades
{
    /// <summary>Resultado de un parámetro de un examen de la atención.</summary>
    public class ResultadoAnalitico
    {
        public int IdResultado { get; set; }
        public int IdAtencion { get; set; }
        public int IdParametro { get; set; }
        public string? Valor { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string? ObservacionMedico { get; set; }
        public DateTime? FechaValidacion { get; set; }

        // Datos para mostrar
        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; } = string.Empty;
        public string NombreParametro { get; set; } = string.Empty;
        public string? Unidad { get; set; }
        public string NombreTecnico { get; set; } = string.Empty;
        public string NombreMedico { get; set; } = string.Empty;
        public string? ValorAnterior { get; set; }

        // Se calculan en la capa de negocio al validar (CU-46)
        public string IntervaloReferencia { get; set; } = string.Empty;
        public bool FueraDeRango { get; set; }

        public bool EsCuantitativo => !string.IsNullOrWhiteSpace(Unidad);
        public string FueraDeRangoTexto => FueraDeRango ? "Sí" : "No";
        public string ValidadoTexto => Estado == EstadoResultado.Validado ? "Sí" : "No";
    }
}
