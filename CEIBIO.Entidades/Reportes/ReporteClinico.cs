namespace CEIBIO.Entidades
{
    public class ReporteClinico
    {
        public int IdReporte { get; set; }
        public int IdAtencion { get; set; }
        public int Version { get; set; } = 1;
        public string Contenido { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public bool Definitivo { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime? FechaAutorizacion { get; set; }

        public string NumeroAtencion { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string Examenes { get; set; } = string.Empty;
        public string NombreDigitador { get; set; } = string.Empty;
        public string NombreDirector { get; set; } = string.Empty;

        public string EstadoVersion => Estado + " - versión " + Version + (Definitivo ? " (definitivo)" : "");
        public int DiasSinRecoger => FechaAutorizacion.HasValue ? (DateTime.Today - FechaAutorizacion.Value.Date).Days : 0;
    }
}
