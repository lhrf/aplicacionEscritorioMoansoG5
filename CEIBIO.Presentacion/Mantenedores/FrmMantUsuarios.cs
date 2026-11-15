using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantUsuarios : Form
    {
        private readonly UsuarioNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantUsuarios()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
            Ui.SoloDigitos(txtDni, 8);
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar, dgvRegistros);
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); txtClave.Enabled = true; txtNombre.Focus(); };
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            btnCerrar.Click += (s, e) => Close();
            Ui.AlPresionarEnter(txtBuscar, Buscar);
            Ui.AlDobleClic(dgvRegistros, () => BtnEditar_Click(null, EventArgs.Empty));
            Ui.AlSeleccionar(dgvRegistros, MostrarEstado);
            Load += (s, e) => Ui.Intentar(() =>
            {
                Ui.Combo(cboRol, negocio.ListarRoles(), "Nombre", "IdRol");
                Buscar();
            });
        }

        private void MostrarEstado() => m.Estado(Ui.Seleccionado<Usuario>(dgvRegistros)?.Habilitado);

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.NombreCompleto, x.Dni, x.NombreUsuario, x.NombreRol, x.EstadoTexto
            }));
            MostrarEstado();
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Usuario>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdUsuario);
            txtNombre.Text = x.NombreCompleto;
            txtDni.Text = x.Dni;
            txtUsuario.Text = x.NombreUsuario;
            txtClave.Clear();
            txtClave.Enabled = false;
            cboRol.SelectedValue = x.IdRol;
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Usuario
            {
                IdUsuario = m.Id,
                NombreCompleto = txtNombre.Text,
                Dni = txtDni.Text,
                NombreUsuario = txtUsuario.Text,
                IdRol = Ui.ItemCombo<Rol>(cboRol)?.IdRol ?? 0
            };
            if (!Ui.Mostrar(negocio.Guardar(x, m.Id == 0 ? txtClave.Text : null))) return;
            m.Cancelar();
            txtClave.Enabled = true;
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Usuario>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (x.Habilitado)
            {
                if (x.IdUsuario == Sesion.IdUsuario) { Ui.Aviso("No puede inhabilitar su propio usuario."); return; }
                if (!Ui.Confirmar("¿Desea inhabilitar al usuario " + x.NombreUsuario + "?")) return;
                if (Ui.Mostrar(negocio.Inhabilitar(x.IdUsuario))) Buscar();
            }
            else
            {
                if (!Ui.Confirmar("¿Desea habilitar al usuario " + x.NombreUsuario + "?")) return;
                if (Ui.Mostrar(negocio.Habilitar(x.IdUsuario))) Buscar();
            }
        }
    }
}
