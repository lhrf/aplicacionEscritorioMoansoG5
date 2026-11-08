using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmEmitirComprobante : Form
    {
        private readonly ComprobanteNegocio negocio = new();
        private Comprobante? comprobante;

        public FrmEmitirComprobante()
        {
            InitializeComponent();
            txtPaciente.ReadOnly = true;
            dgvPagadas.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            btnEmitir.Click += BtnEmitir_Click;
            btnReimprimir.Click += BtnReimprimir_Click;
            btnAnular.Click += BtnAnular_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvPagadas, negocio.ListarAtencionesPagadas(), a => new object?[]
            {
                a.NumeroAtencion, a.NombrePaciente, a.MedioPago, a.CostoTotal.ToString("0.00")
            });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var a = Ui.Seleccionado<Atencion>(dgvPagadas);
            comprobante = null;
            if (a != null)
                comprobante = Validacion.Vacio(a.NumeroComprobante) ? negocio.VistaPrevia(a.IdAtencion) : negocio.ObtenerPorAtencion(a.IdAtencion);

            txtNumeroComprobante.Text = comprobante?.NumeroComprobante ?? "";
            txtFecha.Text = comprobante == null ? "" : Ui.FechaHora(comprobante.FechaEmision);
            txtDni.Text = comprobante?.Dni ?? "";
            txtPaciente.Text = comprobante?.NombrePaciente ?? "";
            Ui.Llenar(dgvDetalle, comprobante?.Detalle ?? new List<AtencionExamen>(), d => new object?[] { d.NombreExamen, d.Tarifa.ToString("0.00") });
            lblDescuento.Text = "Descuento: " + Ui.Soles(comprobante?.Descuento ?? 0);
            lblTotal.Text = "Total: " + Ui.Soles(comprobante?.Total ?? 0);

            bool emitido = comprobante != null && comprobante.IdComprobante > 0;
            btnEmitir.Enabled = comprobante != null && !emitido;
            btnReimprimir.Enabled = emitido;
            btnAnular.Enabled = emitido;
        }

        private void BtnEmitir_Click(object? sender, EventArgs e)
        {
            var a = Ui.Seleccionado<Atencion>(dgvPagadas);
            if (a == null) return;
            var r = negocio.Emitir(a.IdAtencion);
            if (!Ui.Mostrar(r)) return;
            var emitido = negocio.ObtenerPorId(r.Id);
            if (emitido != null) Ui.Imprimir("Comprobante " + emitido.NumeroComprobante, ComprobanteNegocio.TextoImpresion(emitido));
            Ui.Intentar(Cargar);
        }

        private void BtnReimprimir_Click(object? sender, EventArgs e)
        {
            if (comprobante == null || comprobante.IdComprobante == 0) return;
            Ui.Imprimir("Comprobante " + comprobante.NumeroComprobante, ComprobanteNegocio.TextoImpresion(comprobante));
        }

        private void BtnAnular_Click(object? sender, EventArgs e)
        {
            if (comprobante == null || comprobante.IdComprobante == 0) return;
            var motivo = Ui.Pedir("Anular comprobante", "Motivo de la anulación:");
            if (motivo == null) return;
            if (Ui.Mostrar(negocio.Anular(comprobante.IdComprobante, motivo))) Ui.Intentar(Cargar);
        }
    }
}
