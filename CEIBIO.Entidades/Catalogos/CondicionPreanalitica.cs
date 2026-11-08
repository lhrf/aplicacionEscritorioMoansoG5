namespace CEIBIO.Entidades
{
    public class CondicionPreanalitica
    {
        public int IdCondicion { get; set; }
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; } = string.Empty;
        public int HorasAyuno { get; set; }
        public string? RestriccionMedicamentos { get; set; }
        public string? MuestraQueDebeTraer { get; set; }
        public bool Habilitado { get; set; } = true;

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
    }
}
