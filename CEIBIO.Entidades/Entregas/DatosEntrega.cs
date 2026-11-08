namespace CEIBIO.Entidades
{
    public class DatosEntrega
    {
        public int IdComprobante { get; set; }
        public string NumeroComprobante { get; set; } = string.Empty;
        public string EstadoComprobante { get; set; } = string.Empty;
        public string PacienteComprobante { get; set; } = string.Empty;
        public string ExamenesComprobante { get; set; } = string.Empty;

        public int IdReporte { get; set; }
        public int IdAtencion { get; set; }
        public string NumeroAtencion { get; set; } = string.Empty;
        public string PacienteReporte { get; set; } = string.Empty;
        public string EstadoReporte { get; set; } = string.Empty;

        public string DniPaciente { get; set; } = string.Empty;

        public bool Coinciden => EstadoComprobante == "Emitido" && PacienteComprobante == PacienteReporte;
    }
}
