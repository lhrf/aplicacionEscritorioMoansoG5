using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Analisis
{
    public partial class FrmFallaAnalitica : Form
    {
        private readonly UsoEquipoNegocio negocio = new();
        private readonly UsoEquipo? uso;

        public FrmFallaAnalitica()
        {
            InitializeComponent();
            btnRegistrar.Click += BtnRegistrar_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmFallaAnalitica(UsoEquipo uso) : this()
        {
            this.uso = uso;
            txtEquipo.Text = uso.NombreEquipo;
            txtMuestra.Text = uso.CodigoMuestra;
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            if (uso == null) { Ui.Aviso("Abra este formulario desde el registro de uso del equipo."); return; }
            if (!Ui.Mostrar(negocio.RegistrarFalla(uso.IdUso, txtDescripcion.Text))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
