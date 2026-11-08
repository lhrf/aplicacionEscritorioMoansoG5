namespace CEIBIO.Entidades
{
    public class MedioPago
    {
        public int IdMedioPago { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool RequiereAutorizacion { get; set; }
        public bool Habilitado { get; set; } = true;

        public string RequiereAutorizacionTexto => RequiereAutorizacion ? "Sí" : "No";
        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => Descripcion;
    }
}
