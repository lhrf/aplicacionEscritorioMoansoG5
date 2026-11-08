using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmRegistrarPago : Form
    {
        private readonly PagoNegocio negocio = new();

        public FrmRegistrarPago()
        {
            InitializeComponent();
            nudMontoRecibido.DecimalPlaces = 2;
            nudMontoRecibido.Minimum = 0;
            nudMontoRecibido.Maximum = 99999;
            dgvPendientes.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            cboMedioPago.SelectedIndexChanged += (s, e) => ActualizarMedio();
            nudMontoRecibido.ValueChanged += (s, e) => CalcularVuelto();
            btnRegistrar.Click += BtnRegistrar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                Ui.Combo(cboMedioPago, new MedioPagoNegocio().ListarHabilitados(), "Descripcion", "IdMedioPago");
                Cargar();
            });
        }

        private void Cargar()
        {
            Ui.Llenar(dgvPendientes, negocio.ListarPendientes(), a => new object?[]
            {
                a.NumeroAtencion, a.NombrePaciente, a.Modalidad, a.CostoTotal.ToString("0.00")
            });
            MostrarSeleccion();
        }

        private Atencion? Actual => Ui.Seleccionado<Atencion>(dgvPendientes);

        private void MostrarSeleccion()
        {
            var a = Actual;
            var detalle = a == null ? new List<AtencionExamen>() : negocio.ListarDetalle(a.IdAtencion);
            Ui.Llenar(dgvDetalle, detalle, d => new object?[] { d.NombreExamen, d.Tarifa.ToString("0.00") });
            lblDescuento.Text = "Descuento: " + Ui.Soles(a?.Descuento ?? 0);
            lblTotal.Text = "Total a pagar: " + Ui.Soles(a?.CostoTotal ?? 0);

            var enCurso = a == null ? null : negocio.ObtenerPagoEnCurso(a.IdAtencion);
            if (enCurso != null)
            {
                cboMedioPago.SelectedValue = enCurso.IdMedioPago;
                if (enCurso.Estado == EstadoPago.PendienteAutorizacion)
                    Ui.Info("El pago por " + enCurso.MedioPago.ToLower() + " de esta atención está pendiente de autorización del Supervisor de Turno.");
                else if (enCurso.Estado == EstadoPago.Autorizado)
                    Ui.Info("La transferencia fue autorizada. Pulse «Registrar conformidad» para completar el pago.");
            }
            nudMontoRecibido.Value = 0;
            ActualizarMedio();
        }

        private void ActualizarMedio()
        {
            var medio = Ui.ItemCombo<MedioPago>(cboMedioPago);
            bool requiere = medio?.RequiereAutorizacion ?? false;
            nudMontoRecibido.Enabled = !requiere;
            if (requiere) nudMontoRecibido.Value = 0;
            CalcularVuelto();
        }

        private void CalcularVuelto()
        {
            decimal total = Actual?.CostoTotal ?? 0;
            lblVuelto.Text = "Vuelto: " + Ui.Soles(PagoNegocio.CalcularVuelto(total, nudMontoRecibido.Value));
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            var a = Actual;
            var medio = Ui.ItemCombo<MedioPago>(cboMedioPago);
            if (a == null) { Ui.Aviso("Seleccione una atención pendiente de pago."); return; }
            if (medio == null) { Ui.Aviso("Seleccione el medio de pago."); return; }
            if (Ui.Mostrar(negocio.RegistrarPago(a.IdAtencion, medio.IdMedioPago, nudMontoRecibido.Value))) Ui.Intentar(Cargar);
        }
    }
}
