namespace CEIBIO.Entidades
{
    /// <summary>Registro de la tabla Auditoria (RNF-20): quién hizo qué cambio, sobre qué registro y cuándo.</summary>
    public class Auditoria
    {
        public int IdAuditoria { get; set; }
        public string Tabla { get; set; } = string.Empty;
        public int IdRegistro { get; set; }
        public string Accion { get; set; } = string.Empty;
        public string? Detalle { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
    }
}
