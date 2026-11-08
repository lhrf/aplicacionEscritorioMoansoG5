using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmConsultarReportes : Form
    {
        private readonly ReporteNegocio negocio = new();

        public FrmConsultarReportes()
        {
            InitializeComponent();
            txtDni.MaxLength = 8;
            cboEstado.Items.Clear();
            cboEstado.Items.Add("(Todos)");
            foreach (var estado in EstadoReporte.Todos) cboEstado.Items.Add(estado);
            cboEstado.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpFechaFin.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnReimprimir.Click += BtnReimprimir_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            if (!Validacion.Vacio(txtDni.Text) && !Validacion.EsDni(txtDni.Text))
            {
                Ui.Aviso("El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            Ui.Intentar(() =>
            {
                var lista = negocio.Consultar(txtDni.Text, dtpFechaInicio.Value, dtpFechaFin.Value, cboEstado.Text);
                Ui.Llenar(dgvReportes, lista, r => new object?[]
                {
                    r.NumeroAtencion, r.NombrePaciente, r.Examenes, r.Estado, Ui.FechaHora(r.FechaAutorizacion)
                });
            });
        }

        private void BtnReimprimir_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            if (r == null) { Ui.Aviso("Seleccione un reporte."); return; }
            Ui.Imprimir("Reporte clínico " + r.NumeroAtencion, ReporteNegocio.TextoImpresion(r));
        }
    }
}
