namespace CEIBIO.Entidades
{
    public class Suspension
    {
        public int IdSuspension { get; set; }
        public int IdAtencion { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public DateTime NuevaFecha { get; set; } = DateTime.Today.AddDays(1);
        public DateTime FechaRegistro { get; set; }
        public bool Reactivada { get; set; }
        public DateTime? FechaReactivacion { get; set; }

        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string NombreEnfermera { get; set; } = string.Empty;
    }
}
