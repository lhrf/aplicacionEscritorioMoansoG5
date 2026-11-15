using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Evaluacion
{
    public partial class FrmSuspenderAtencion : Form
    {
        private readonly EvaluacionNegocio negocio = new();
        private Atencion? atencion;

        public FrmSuspenderAtencion()
        {
            InitializeComponent();
            Configurar();
        }

        public FrmSuspenderAtencion(Atencion atencion) : this()
        {
            Mostrar(atencion);
        }

        private void Mostrar(Atencion? a)
        {
            atencion = a;
            txtNumeroAtencion.Text = a?.NumeroAtencion ?? "";
            txtPaciente.Text = a?.NombrePaciente ?? "";
            btnSuspender.Enabled = a != null;
        }

        private void ElegirAtencion()
        {
            if (atencion != null) return;
            var pendientes = negocio.ListarPendientes();
            if (pendientes.Count == 0)
            {
                Ui.Aviso("No hay atenciones pendientes de evaluación.");
                Mostrar(null);
                return;
            }
            Mostrar(Ui.Elegir("Seleccionar atención", pendientes, a => a.NumeroAtencion + " - " + a.NombrePaciente));
        }

        private void Configurar()
        {
            txtMotivo.ReadOnly = false;
            Ui.SoloLectura(txtNumeroAtencion, txtPaciente);
            CancelButton = btnCancelar;
            Load += (s, e) => Ui.Intentar(ElegirAtencion);
            dtpNuevaFecha.MinDate = DateTime.Today.AddDays(1);
            dtpNuevaFecha.Value = DateTime.Today.AddDays(1);
            btnSuspender.Click += BtnSuspender_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnSuspender_Click(object? sender, EventArgs e)
        {
            if (atencion == null) { Ui.Aviso("Seleccione la atención que desea suspender."); return; }
            var s = new Suspension { IdAtencion = atencion.IdAtencion, Motivo = txtMotivo.Text, NuevaFecha = dtpNuevaFecha.Value.Date };
            if (!Ui.Mostrar(negocio.Suspender(s))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
