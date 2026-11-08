namespace CEIBIO.Entidades
{
    public class RetencionEntrega
    {
        public int IdRetencion { get; set; }
        public int IdReporte { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public DateTime FechaRetencion { get; set; }
        public bool Levantada { get; set; }
        public DateTime? FechaLevantamiento { get; set; }
    }
}
