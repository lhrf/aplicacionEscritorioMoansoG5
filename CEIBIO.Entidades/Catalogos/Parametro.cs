namespace CEIBIO.Entidades
{
    public class Parametro
    {
        public int IdParametro { get; set; }
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Unidad { get; set; }
        public bool Habilitado { get; set; } = true;

        public bool EsCuantitativo => !string.IsNullOrWhiteSpace(Unidad);
        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Nombre;
    }
}
