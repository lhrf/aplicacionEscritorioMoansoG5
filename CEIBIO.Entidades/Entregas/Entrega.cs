namespace CEIBIO.Entidades
{
    public class Entrega
    {
        public int IdEntrega { get; set; }
        public int IdReporte { get; set; }
        public string NombreRecibe { get; set; } = string.Empty;
        public string DniRecibe { get; set; } = string.Empty;
        public string Relacion { get; set; } = string.Empty;
        public DateTime FechaEntrega { get; set; }

        public int IdAtencion { get; set; }
        public string NumeroAtencion { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
    }
}
