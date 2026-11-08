namespace CEIBIO.Entidades
{
    public class Plantilla
    {
        public int IdPlantilla { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Formato { get; set; } = string.Empty;   // ruta del archivo de la plantilla
        public bool Habilitado { get; set; } = true;

        public List<int> IdExamenes { get; set; } = new();
        /// <summary>Nombres de los exámenes asociados, separados por coma (para la grilla).</summary>
        public string Examenes { get; set; } = string.Empty;

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Nombre;
    }
}
