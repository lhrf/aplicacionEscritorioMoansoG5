using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmDevolverReporte : Form
    {
        private readonly ReporteNegocio negocio = new();
        private readonly ReporteClinico? reporte;

        public FrmDevolverReporte()
        {
            InitializeComponent();
            btnDevolver.Click += BtnDevolver_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmDevolverReporte(ReporteClinico reporte) : this()
        {
            this.reporte = reporte;
            txtNumeroAtencion.Text = reporte.NumeroAtencion;
            txtPaciente.Text = reporte.NombrePaciente;
        }

        private void BtnDevolver_Click(object? sender, EventArgs e)
        {
            if (reporte == null) { Ui.Aviso("Abra este formulario desde la autorización de reportes."); return; }
            if (!Ui.Mostrar(negocio.DevolverAlMedico(reporte.IdReporte, txtObservacion.Text))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
