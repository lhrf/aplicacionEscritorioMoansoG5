using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmRechazarTransferencia : Form
    {
        private readonly TransferenciaNegocio negocio = new();
        private readonly Pago? pago;

        public FrmRechazarTransferencia()
        {
            InitializeComponent();
            btnRechazar.Click += BtnRechazar_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmRechazarTransferencia(Pago pago) : this()
        {
            this.pago = pago;
            txtNumeroAtencion.Text = pago.NumeroAtencion;
            txtImporte.Text = pago.Importe.ToString("0.00");
        }

        private void BtnRechazar_Click(object? sender, EventArgs e)
        {
            if (pago == null) { Ui.Aviso("Abra este formulario desde la autorización de transferencias."); return; }
            if (!Ui.Mostrar(negocio.Rechazar(pago.IdPago, txtObservacion.Text))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
