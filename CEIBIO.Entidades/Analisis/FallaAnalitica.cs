namespace CEIBIO.Entidades
{
    public class FallaAnalitica
    {
        public int IdFalla { get; set; }
        public int IdUso { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
    }
}
