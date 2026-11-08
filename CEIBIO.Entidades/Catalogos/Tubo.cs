namespace CEIBIO.Entidades
{
    public class Tubo
    {
        public int IdTubo { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string ColorTapa { get; set; } = string.Empty;
        public string? Aditivo { get; set; }
        public int MinutosCentrifugacion { get; set; }
        public bool Habilitado { get; set; } = true;

        public List<int> IdExamenes { get; set; } = new();

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Tipo + " (" + ColorTapa + ")";
    }
}
