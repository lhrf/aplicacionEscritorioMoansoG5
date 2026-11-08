namespace CEIBIO.Entidades
{
    /// <summary>Datos del comprobante y del Reporte clínico que se comparan antes de entregar (CU-58).</summary>
    public class DatosEntrega
    {
        // Comprobante de pago
        public int IdComprobante { get; set; }
        public string NumeroComprobante { get; set; } = string.Empty;
        public string EstadoComprobante { get; set; } = string.Empty;
        public string PacienteComprobante { get; set; } = string.Empty;
        public string ExamenesComprobante { get; set; } = string.Empty;

        // Reporte clínico
        public int IdReporte { get; set; }
        public int IdAtencion { get; set; }
        public string NumeroAtencion { get; set; } = string.Empty;
        public string PacienteReporte { get; set; } = string.Empty;
        public string EstadoReporte { get; set; } = string.Empty;

        public string DniPaciente { get; set; } = string.Empty;

        /// <summary>True si el comprobante está emitido y corresponde al mismo paciente del reporte.</summary>
        public bool Coinciden => EstadoComprobante == "Emitido" && PacienteComprobante == PacienteReporte;
    }
}
