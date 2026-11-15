using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantEquipos : Form
    {
        private readonly EquipoNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantEquipos()
        {
            InitializeComponent();
            cboTipo.Items.Clear();
            cboTipo.Items.AddRange(EquipoNegocio.Tipos);
            Ui.Lista(cboTipo);
            txtCodigo.MaxLength = 10;
            Ui.Mayusculas(txtCodigo);
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar, dgvRegistros);
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); txtCodigo.Focus(); };
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            btnCerrar.Click += (s, e) => Close();
            Ui.AlPresionarEnter(txtBuscar, Buscar);
            Ui.AlDobleClic(dgvRegistros, () => BtnEditar_Click(null, EventArgs.Empty));
            Ui.AlSeleccionar(dgvRegistros, MostrarEstado);
            Load += (s, e) => Buscar();
        }

        private void MostrarEstado() => m.Estado(Ui.Seleccionado<Equipo>(dgvRegistros)?.Habilitado);

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.Codigo, x.Nombre, x.Marca, x.Modelo, x.Tipo, x.EstadoTexto
            }));
            MostrarEstado();
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Equipo>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdEquipo);
            txtCodigo.Text = x.Codigo;
            txtNombre.Text = x.Nombre;
            txtMarca.Text = x.Marca ?? "";
            txtModelo.Text = x.Modelo ?? "";
            cboTipo.SelectedItem = x.Tipo;
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Equipo
            {
                IdEquipo = m.Id,
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Tipo = cboTipo.Text
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Equipo>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (x.Habilitado)
            {
                if (!Ui.Confirmar("¿Desea inhabilitar " + "el equipo " + x.Nombre + "?")) return;
                if (Ui.Mostrar(negocio.Inhabilitar(x.IdEquipo))) Buscar();
            }
            else
            {
                if (!Ui.Confirmar("¿Desea habilitar nuevamente " + "el equipo " + x.Nombre + "?")) return;
                if (Ui.Mostrar(negocio.Habilitar(x.IdEquipo))) Buscar();
            }
        }
    }
}
