using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmBuscarFicha : Form
    {
        private readonly PacienteNegocio negocio = new();
        private Paciente? paciente;

        public FrmBuscarFicha()
        {
            InitializeComponent();
            Ui.SoloDigitos(txtDni, 8);
            Ui.SoloDigitos(txtTelefono, 9);
            Ui.Lista(cboSexo);
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            Ui.AlPresionarEnter(txtDni, () => BtnBuscar_Click(btnBuscar, EventArgs.Empty));
            txtDni.TextChanged += (s, e) => { if (paciente != null && txtDni.Text.Trim() != paciente.Dni) Mostrar(null); };
            Ui.Columnas(dgvAtenciones, "N.° atención", "Fecha", "Exámenes", "Estado");
            btnBuscar.Click += BtnBuscar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnRegistrarFicha.Click += BtnRegistrarFicha_Click;
            btnCerrar.Click += (s, e) => Close();
            Ui.Intentar(() => Mostrar(null));
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            if (!Validacion.EsDni(txtDni.Text))
            {
                Ui.Aviso("El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            Ui.Intentar(() =>
            {
                var encontrado = negocio.BuscarPorDni(txtDni.Text);
                if (encontrado == null)
                {
                    Mostrar(null);
                    if (Ui.Confirmar("No existe una Ficha clínica histórica con ese DNI. ¿Desea registrarla?"))
                        BtnRegistrarFicha_Click(sender, e);
                    return;
                }
                Mostrar(encontrado);
            });
        }

        private void Mostrar(Paciente? p)
        {
            paciente = p;
            txtNombres.Text = p?.Nombres ?? "";
            txtApellidos.Text = p?.Apellidos ?? "";
            cboSexo.SelectedItem = p?.Sexo;
            if (p == null) cboSexo.SelectedIndex = -1;
            dtpFechaNacimiento.Value = p?.FechaNacimiento ?? DateTime.Today;
            txtTelefono.Text = p?.Telefono ?? "";
            txtDireccion.Text = p?.Direccion ?? "";
            btnActualizar.Enabled = p != null;
            var atenciones = p == null ? new List<Atencion>() : negocio.ListarAtenciones(p.IdPaciente);
            Ui.Llenar(dgvAtenciones, atenciones, a => new object?[] { a.NumeroAtencion, Ui.Fecha(a.FechaRegistro), a.Examenes, a.Estado });
        }

        private void BtnActualizar_Click(object? sender, EventArgs e)
        {
            if (paciente == null) return;
            var p = new Paciente
            {
                IdPaciente = paciente.IdPaciente,
                Dni = paciente.Dni,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Sexo = cboSexo.Text,
                FechaNacimiento = dtpFechaNacimiento.Value.Date,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };
            if (Ui.Mostrar(negocio.Actualizar(p))) Ui.Intentar(() => Mostrar(negocio.ObtenerPorId(p.IdPaciente)));
        }

        private void BtnRegistrarFicha_Click(object? sender, EventArgs e)
        {
            using var f = new FrmRegistrarFicha(txtDni.Text.Trim());
            if (f.ShowDialog(this) == DialogResult.OK && f.Registrado != null)
            {
                var registrado = f.Registrado;
                txtDni.Text = registrado.Dni;
                Ui.Intentar(() => Mostrar(registrado));
            }
        }
    }
}
