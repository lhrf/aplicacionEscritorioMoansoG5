namespace CEIBIO.Entidades
{
    /// <summary>Resultado de CU-02 Calcular costo de la atención.</summary>
    public class CostoAtencion
    {
        public decimal Subtotal { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
    }
}
