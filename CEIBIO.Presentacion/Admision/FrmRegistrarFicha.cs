using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmRegistrarFicha : Form
    {
        private readonly PacienteNegocio negocio = new();

        public Paciente? Registrado { get; private set; }

        public FrmRegistrarFicha() : this("")
        {
        }

        public FrmRegistrarFicha(string dni)
        {
            InitializeComponent();
            txtDni.Text = dni;
            Ui.SoloDigitos(txtDni, 8);
            Ui.SoloDigitos(txtTelefono, 9);
            Ui.Lista(cboSexo);
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var p = new Paciente
            {
                Dni = txtDni.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Sexo = cboSexo.Text,
                FechaNacimiento = dtpFechaNacimiento.Value.Date,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };
            var r = negocio.Registrar(p);
            if (!Ui.Mostrar(r)) return;
            Ui.Intentar(() => Registrado = negocio.ObtenerPorId(r.Id));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
