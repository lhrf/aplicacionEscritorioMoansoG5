using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Seguridad
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioNegocio negocio = new();

        public FrmLogin()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
            AcceptButton = btnIngresar;
            btnIngresar.Click += BtnIngresar_Click;
            btnSalir.Click += (s, e) => Close();
        }

        private void BtnIngresar_Click(object? sender, EventArgs e)
        {
            var r = negocio.IniciarSesion(txtUsuario.Text, txtClave.Text);
            if (!r.Exito)
            {
                Ui.Mostrar(r);
                txtClave.Clear();
                txtClave.Focus();
                return;
            }

            var menu = new FrmMenuPrincipal();
            menu.FormClosed += (s, a) =>
            {
                if (menu.CerroSesion)
                {
                    txtClave.Clear();
                    Show();
                    txtUsuario.Focus();
                }
                else
                {
                    Close();
                }
            };
            Hide();
            menu.Show();
        }
    }
}
