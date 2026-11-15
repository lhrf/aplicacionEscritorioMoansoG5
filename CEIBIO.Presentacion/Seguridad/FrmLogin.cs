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
            Shown += (s, e) => txtUsuario.Focus();
            btnSalir.Click += (s, e) => Close();
        }

        private void BtnIngresar_Click(object? sender, EventArgs e)
        {
            if (Validacion.Vacio(txtUsuario.Text)) { Ui.Aviso("Ingrese su usuario."); txtUsuario.Focus(); return; }
            if (Validacion.Vacio(txtClave.Text)) { Ui.Aviso("Ingrese su clave."); txtClave.Focus(); return; }
            Respuesta r;
            try
            {
                Cursor = Cursors.WaitCursor;
                r = negocio.IniciarSesion(txtUsuario.Text, txtClave.Text);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
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
