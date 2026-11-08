namespace CEIBIO.Entidades
{
    /// <summary>Registro de la Bitácora de Uso del Equipo.</summary>
    public class UsoEquipo
    {
        public int IdUso { get; set; }
        public int IdEquipo { get; set; }
        public int IdMuestra { get; set; }
        public DateTime HoraInicio { get; set; }
        public bool RequiereNuevaCorrida { get; set; }

        // Datos para mostrar
        public string NombreEquipo { get; set; } = string.Empty;
        public string CodigoMuestra { get; set; } = string.Empty;
        public string NombreTecnico { get; set; } = string.Empty;
        public string FallaAnalitica { get; set; } = string.Empty;
    }
}
