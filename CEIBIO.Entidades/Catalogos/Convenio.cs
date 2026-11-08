namespace CEIBIO.Entidades
{
    public class Convenio
    {
        public int IdConvenio { get; set; }
        public string Institucion { get; set; } = string.Empty;
        public decimal PorcentajeDescuento { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Today;
        public DateTime FechaFin { get; set; } = DateTime.Today;
        public bool Habilitado { get; set; } = true;

        public bool Vigente => Habilitado && DateTime.Today >= FechaInicio.Date && DateTime.Today <= FechaFin.Date;
        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Institucion + " (" + PorcentajeDescuento.ToString("0.##") + " %)";
    }
}
