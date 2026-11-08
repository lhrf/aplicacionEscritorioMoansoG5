using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Preparacion
{
    public partial class FrmDevolverMuestra : Form
    {
        private readonly PreparacionMuestraNegocio negocio = new();
        private readonly Muestra? muestra;

        public FrmDevolverMuestra()
        {
            InitializeComponent();
            btnDevolver.Click += BtnDevolver_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmDevolverMuestra(Muestra muestra) : this()
        {
            this.muestra = muestra;
            txtCodigo.Text = muestra.Codigo;
            txtPaciente.Text = muestra.NombrePaciente;
        }

        private void BtnDevolver_Click(object? sender, EventArgs e)
        {
            if (muestra == null) { Ui.Aviso("Abra este formulario desde la recepción de muestras."); return; }
            if (!Ui.Mostrar(negocio.Devolver(muestra.IdMuestra, txtDiferencia.Text))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
