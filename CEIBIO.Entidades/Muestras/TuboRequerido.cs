namespace CEIBIO.Entidades
{
    /// <summary>Tubo o recipiente que requiere un examen de la atención.</summary>
    public class TuboRequerido
    {
        public int IdExamen { get; set; }
        public string NombreExamen { get; set; } = string.Empty;
        public int IdTubo { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string ColorTapa { get; set; } = string.Empty;
        public int MinutosCentrifugacion { get; set; }
        public int Cantidad { get; set; } = 1;
        public string Estado { get; set; } = "Pendiente";
    }
}
