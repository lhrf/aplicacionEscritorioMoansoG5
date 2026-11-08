using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmAutorizarTransferencia : Form
    {
        private readonly TransferenciaNegocio negocio = new();

        public FrmAutorizarTransferencia()
        {
            InitializeComponent();
            nudImporte.DecimalPlaces = 2;
            nudImporte.Minimum = 0;
            nudImporte.Maximum = 99999;
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Value = DateTime.Today;
            dgvTransferencias.SelectionChanged += (s, e) => MostrarSeleccion();
            btnAutorizar.Click += BtnAutorizar_Click;
            btnRechazar.Click += BtnRechazar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvTransferencias, negocio.ListarPendientes(), p => new object?[]
            {
                p.NumeroAtencion, p.NombrePaciente, p.Importe.ToString("0.00"), p.NombreCajero, Ui.FechaHora(p.FechaRegistro)
            });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var p = Ui.Seleccionado<Pago>(dgvTransferencias);
            txtNumeroOperacion.Clear();
            nudImporte.Value = p?.Importe ?? 0;
            dtpFecha.Value = DateTime.Today;
        }

        private void BtnAutorizar_Click(object? sender, EventArgs e)
        {
            var p = Ui.Seleccionado<Pago>(dgvTransferencias);
            if (p == null) { Ui.Aviso("Seleccione una transferencia pendiente."); return; }
            if (Ui.Mostrar(negocio.Autorizar(p.IdPago, txtNumeroOperacion.Text, nudImporte.Value, dtpFecha.Value))) Ui.Intentar(Cargar);
        }

        private void BtnRechazar_Click(object? sender, EventArgs e)
        {
            var p = Ui.Seleccionado<Pago>(dgvTransferencias);
            if (p == null) { Ui.Aviso("Seleccione una transferencia pendiente."); return; }
            using var f = new FrmRechazarTransferencia(p);
            if (f.ShowDialog(this) == DialogResult.OK) Ui.Intentar(Cargar);
        }
    }
}
