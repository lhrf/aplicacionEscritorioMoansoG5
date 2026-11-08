using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Evaluacion
{
    public partial class FrmSuspenderAtencion : Form
    {
        private readonly EvaluacionNegocio negocio = new();
        private readonly Atencion? atencion;

        public FrmSuspenderAtencion()
        {
            InitializeComponent();
            Configurar();
        }

        public FrmSuspenderAtencion(Atencion atencion) : this()
        {
            this.atencion = atencion;
            txtNumeroAtencion.Text = atencion.NumeroAtencion;
            txtPaciente.Text = atencion.NombrePaciente;
        }

        private void Configurar()
        {
            txtMotivo.ReadOnly = false;
            dtpNuevaFecha.MinDate = DateTime.Today.AddDays(1);
            dtpNuevaFecha.Value = DateTime.Today.AddDays(1);
            btnSuspender.Click += BtnSuspender_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnSuspender_Click(object? sender, EventArgs e)
        {
            if (atencion == null) { Ui.Aviso("Abra este formulario desde el resultado de la evaluación."); return; }
            var s = new Suspension { IdAtencion = atencion.IdAtencion, Motivo = txtMotivo.Text, NuevaFecha = dtpNuevaFecha.Value.Date };
            if (!Ui.Mostrar(negocio.Suspender(s))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
