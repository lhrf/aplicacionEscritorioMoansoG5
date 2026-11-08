namespace CEIBIO.Entidades
{
    /// <summary>Muestra biológica de una atención, identificada por su código correlativo.</summary>
    public class Muestra
    {
        public int IdMuestra { get; set; }
        public int IdAtencion { get; set; }
        public string Codigo { get; set; } = string.Empty;   // M-000001
        public DateTime FechaGeneracion { get; set; }
        public DateTime? HoraExtraccion { get; set; }
        public DateTime? FechaValidacion { get; set; }
        public string? CondicionesDeclaradas { get; set; }
        public string? RechazosOcurridos { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? EstadoConservacion { get; set; }   // Adecuado, Observado
        public int? MinutosCentrifugacion { get; set; }
        public DateTime? FechaAcondicionamiento { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string Estado { get; set; } = string.Empty;

        // Datos para mostrar
        public string NumeroAtencion { get; set; } = string.Empty;
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; } = string.Empty;
        public string Modalidad { get; set; } = string.Empty;
        public string Examenes { get; set; } = string.Empty;
        public string TubosEsperados { get; set; } = string.Empty;
        public string NombreResponsable { get; set; } = string.Empty;
        public string NombreAcondiciona { get; set; } = string.Empty;

        /// <summary>Minutos desde el ingreso (consulta de pendientes de acondicionar).</summary>
        public int MinutosDesdeIngreso => FechaIngreso.HasValue ? (int)(DateTime.Now - FechaIngreso.Value).TotalMinutes : 0;
        public string TiempoTranscurrido => (MinutosDesdeIngreso / 60) + " h " + (MinutosDesdeIngreso % 60) + " min";
    }
}
