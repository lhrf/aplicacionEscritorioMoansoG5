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
            Ui.SoloDigitos(txtDniRecibe, 8);
            Ui.SoloLectura(txtComprobante, txtPacienteComprobante, txtExamenesComprobante, txtAtencion, txtPacienteReporte, txtEstadoReporte);
            Ui.AlPresionarEnter(txtBusqueda, () => BtnBuscar_Click(btnBuscar, EventArgs.Empty));
            btnBuscar.Click += BtnBuscar_Click;
            cboRelacion.SelectedIndexChanged += CboRelacion_SelectedIndexChanged;
            btnRegistrar.Click += BtnRegistrar_Click;
            btnRetener.Click += BtnRetener_Click;
            btnLevantar.Click += BtnLevantar_Click;
            btnCerrar.Click += (s, e) => Close();
            Mostrar(null);
        }

        public FrmRegistrarEntrega(string busqueda) : this()
        {
            txtBusqueda.Text = busqueda;
            Load += (s, e) => BtnBuscar_Click(btnBuscar, EventArgs.Empty);
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            if (Validacion.Vacio(txtBusqueda.Text)) { Ui.Aviso("Ingrese el número de comprobante o el DNI del paciente."); txtBusqueda.Focus(); return; }
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
            if (datos == null) return;
            if (cboRelacion.Text == "Paciente")
            {
                txtNombreRecibe.Text = datos.PacienteReporte;
                txtDniRecibe.Text = datos.DniPaciente;
            }
            else if (txtDniRecibe.Text == datos.DniPaciente)
            {
                txtNombreRecibe.Clear();
                txtDniRecibe.Clear();
                txtNombreRecibe.Focus();
            }
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            if (datos == null) return;
            if (cboRelacion.SelectedIndex < 0) { Ui.Aviso("Seleccione la relación de quien recibe con el paciente."); return; }
            var entrega = new Entrega
            {
                IdReporte = datos.IdReporte,
                NombreRecibe = txtNombreRecibe.Text,
                DniRecibe = txtDniRecibe.Text,
                Relacion = cboRelacion.Text
            };
            if (!Ui.Mostrar(negocio.RegistrarEntrega(entrega))) return;
            if (Ui.Confirmar("¿Desea imprimir el Reporte clínico entregado?"))
            {
                int idReporte = datos.IdReporte;
                Ui.Intentar(() =>
                {
                    var reporte = new ReporteNegocio().ObtenerPorId(idReporte);
                    if (reporte != null) Ui.Imprimir("Reporte clínico " + reporte.NumeroAtencion, ReporteNegocio.TextoImpresion(reporte));
                });
            }
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
            if (!Ui.Confirmar("¿Desea levantar la retención de la entrega?")) return;
            if (Ui.Mostrar(negocio.LevantarRetencion(datos.IdReporte))) BtnBuscar_Click(sender, e);
        }
    }
}
