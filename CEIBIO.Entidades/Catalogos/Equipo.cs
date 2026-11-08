namespace CEIBIO.Entidades
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public bool Habilitado { get; set; } = true;

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Codigo + " - " + Nombre;
    }
}
