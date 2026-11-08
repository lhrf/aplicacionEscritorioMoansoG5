namespace CEIBIO.Entidades
{
    public class Plantilla
    {
        public int IdPlantilla { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Formato { get; set; } = string.Empty;
        public bool Habilitado { get; set; } = true;

        public List<int> IdExamenes { get; set; } = new();
        public string Examenes { get; set; } = string.Empty;

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Nombre;
    }
}
