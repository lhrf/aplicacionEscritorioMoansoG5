using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Seguridad
{
    public partial class FrmCambiarClave : Form
    {
        private readonly UsuarioNegocio negocio = new();

        public FrmCambiarClave()
        {
            InitializeComponent();
            txtClaveActual.UseSystemPasswordChar = true;
            txtClaveNueva.UseSystemPasswordChar = true;
            txtClaveConfirmacion.UseSystemPasswordChar = true;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => Close();
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var r = negocio.CambiarClave(txtClaveActual.Text, txtClaveNueva.Text, txtClaveConfirmacion.Text);
            if (Ui.Mostrar(r)) Close();
        }
    }
}
