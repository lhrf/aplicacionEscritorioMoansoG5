namespace CEIBIO.Entidades
{
    public class Examen
    {
        public int IdExamen { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string TipoMuestra { get; set; } = string.Empty;
        public string Procedimiento { get; set; } = string.Empty;
        public decimal Tarifa { get; set; }
        public bool Habilitado { get; set; } = true;

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Codigo + " - " + Nombre;
    }
}
