namespace CEIBIO.Entidades
{
    public class Etiqueta
    {
        public string NombrePaciente { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string NombreExamen { get; set; } = string.Empty;
        public string Tubo { get; set; } = string.Empty;

        public string Texto => NombrePaciente + Environment.NewLine + Fecha.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine +
                               Codigo + Environment.NewLine + NombreExamen + " - " + Tubo;
    }
}
