namespace CEIBIO.Entidades
{
    public class Box
    {
        public int IdBox { get; set; }
        public string Numero { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; } = true;

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => "Box " + Numero + (string.IsNullOrWhiteSpace(Descripcion) ? "" : " - " + Descripcion);
    }
}
