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

        /// <summary>Un parámetro con unidad de medida es cuantitativo: su valor debe ser numérico.</summary>
        public bool EsCuantitativo => !string.IsNullOrWhiteSpace(Unidad);
        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Nombre;
    }
}
