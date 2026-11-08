using System.Text;
using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmConsultarRecaudacion : Form
    {
        private readonly ComprobanteNegocio negocio = new();
        private List<Recaudacion> movimientos = new();

        public FrmConsultarRecaudacion()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnImprimir.Click += BtnImprimir_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                movimientos = negocio.ConsultarRecaudacion(dtpFecha.Value);
                Ui.Llenar(dgvRecaudacion, movimientos, m => new object?[]
                {
                    m.NumeroComprobante, m.NombrePaciente, m.MedioPago, m.NombreCajero, m.Importe.ToString("0.00")
                });
                var porMedio = ComprobanteNegocio.TotalesPorMedio(movimientos);
                lblTotalEfectivo.Text = "Efectivo: " + Ui.Soles(porMedio.GetValueOrDefault("Efectivo"));
                lblTotalTransferencia.Text = "Transferencia: " + Ui.Soles(porMedio.GetValueOrDefault("Transferencia"));
                lblTotalDia.Text = "Total del día: " + Ui.Soles(ComprobanteNegocio.TotalDia(movimientos));
            });
        }

        private void BtnImprimir_Click(object? sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("LABORATORIO CLÍNICO CEIBIO S.A.C.");
            sb.AppendLine("RECAUDACIÓN DEL DÍA " + dtpFecha.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine(new string('-', 70));
            foreach (var m in movimientos)
                sb.AppendLine(m.NumeroComprobante.PadRight(14) + m.NombrePaciente.PadRight(30) + m.MedioPago.PadRight(14) + m.Importe.ToString("0.00").PadLeft(10));
            sb.AppendLine(new string('-', 70));
            foreach (var t in ComprobanteNegocio.TotalesPorMedio(movimientos))
                sb.AppendLine(t.Key.PadRight(58) + t.Value.ToString("0.00").PadLeft(10));
            foreach (var t in ComprobanteNegocio.TotalesPorCajero(movimientos))
                sb.AppendLine(("Cajero: " + t.Key).PadRight(58) + t.Value.ToString("0.00").PadLeft(10));
            sb.AppendLine("TOTAL DEL DÍA".PadRight(58) + ComprobanteNegocio.TotalDia(movimientos).ToString("0.00").PadLeft(10));
            Ui.Imprimir("Recaudación del día", sb.ToString());
        }
    }
}
