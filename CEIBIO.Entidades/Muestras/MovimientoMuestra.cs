namespace CEIBIO.Entidades
{
    /// <summary>Movimiento del Libro de Tránsito de Muestras: ingreso, acondicionamiento, recepción, devolución o corrección.</summary>
    public class MovimientoMuestra
    {
        public int IdMovimiento { get; set; }
        public int IdMuestra { get; set; }
        public string TipoMovimiento { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public int IdUsuario { get; set; }
        public string? Detalle { get; set; }

        // Datos para mostrar
        public string CodigoMuestra { get; set; } = string.Empty;
        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
    }
}
