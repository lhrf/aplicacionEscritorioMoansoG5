namespace CEIBIO.Entidades
{
    public class UsoEquipo
    {
        public int IdUso { get; set; }
        public int IdEquipo { get; set; }
        public int IdMuestra { get; set; }
        public DateTime HoraInicio { get; set; }
        public bool RequiereNuevaCorrida { get; set; }

        public string NombreEquipo { get; set; } = string.Empty;
        public string CodigoMuestra { get; set; } = string.Empty;
        public string NombreTecnico { get; set; } = string.Empty;
        public string FallaAnalitica { get; set; } = string.Empty;
    }
}
