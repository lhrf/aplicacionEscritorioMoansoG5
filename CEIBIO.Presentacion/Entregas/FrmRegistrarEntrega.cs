using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Entregas
{
    public partial class FrmRegistrarEntrega : Form
    {
        private readonly EntregaNegocio negocio = new();
        private DatosEntrega? datos;

        public FrmRegistrarEntrega()
        {
            InitializeComponent();
            cboRelacion.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDniRecibe.MaxLength = 8;
            AcceptButton = btnBuscar;
            btnBuscar.Click += BtnBuscar_Click;
            cboRelacion.SelectedIndexChanged += CboRelacion_SelectedIndexChanged;
            btnRegistrar.Click += BtnRegistrar_Click;
            btnRetener.Click += BtnRetener_Click;
            btnLevantar.Click += BtnLevantar_Click;
            btnCerrar.Click += (s, e) => Close();
            Mostrar(null);
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            Ui.Intentar(() =>
            {
                var d = negocio.VerificarComprobante(txtBusqueda.Text);
                if (d == null) Ui.Aviso("No hay un Reporte clínico disponible para entrega con ese número de comprobante o DNI.");
                else if (!d.Coinciden) Ui.Aviso("El Comprobante de pago no corresponde o no está vigente. Retenga la entrega.");
                Mostrar(d);
            });
        }

        private void Mostrar(DatosEntrega? d)
        {
            datos = d;
            txtComprobante.Text = d?.NumeroComprobante ?? "";
            txtPacienteComprobante.Text = d?.PacienteComprobante ?? "";
            txtExamenesComprobante.Text = d?.ExamenesComprobante ?? "";
            txtAtencion.Text = d?.NumeroAtencion ?? "";
            txtPacienteReporte.Text = d?.PacienteReporte ?? "";
            txtEstadoReporte.Text = d?.EstadoReporte ?? "";
            txtNombreRecibe.Clear();
            txtDniRecibe.Clear();
            cboRelacion.SelectedIndex = -1;
            bool retenida = d?.EstadoReporte == EstadoReporte.EntregaRetenida;
            btnRegistrar.Enabled = d != null && d.Coinciden && !retenida;
            btnRetener.Enabled = d != null && !retenida;
            btnLevantar.Enabled = retenida;
        }

        private void CboRelacion_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (datos == null || cboRelacion.Text != "Paciente") return;
            txtNombreRecibe.Text = datos.PacienteReporte;
            txtDniRecibe.Text = datos.DniPaciente;
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            if (datos == null) return;
            var entrega = new Entrega
            {
                IdReporte = datos.IdReporte,
                NombreRecibe = txtNombreRecibe.Text,
                DniRecibe = txtDniRecibe.Text,
                Relacion = cboRelacion.Text
            };
            if (!Ui.Mostrar(negocio.RegistrarEntrega(entrega))) return;
            if (Ui.Confirmar("¿Desea cerrar ahora la atención " + datos.NumeroAtencion + "?"))
                Ui.Mostrar(negocio.CerrarAtencion(datos.IdAtencion));
            txtBusqueda.Clear();
            Mostrar(null);
        }

        private void BtnRetener_Click(object? sender, EventArgs e)
        {
            if (datos == null) return;
            using var f = new FrmRetenerEntrega(datos);
            if (f.ShowDialog(this) == DialogResult.OK) BtnBuscar_Click(sender, e);
        }

        private void BtnLevantar_Click(object? sender, EventArgs e)
        {
            if (datos == null) return;
            if (Ui.Mostrar(negocio.LevantarRetencion(datos.IdReporte))) BtnBuscar_Click(sender, e);
        }
    }
}
