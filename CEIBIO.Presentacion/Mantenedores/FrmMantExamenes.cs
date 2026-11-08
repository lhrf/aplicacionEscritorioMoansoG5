using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantExamenes : Form
    {
        private readonly ExamenNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantExamenes()
        {
            InitializeComponent();
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Minimum = 0;
            nudTarifa.Maximum = 9999;
            txtCodigo.MaxLength = 10;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar);
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); txtCodigo.Focus(); };
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.Codigo, x.Nombre, x.TipoMuestra, x.Procedimiento, x.Tarifa.ToString("0.00"), x.EstadoTexto
            }));
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Examen>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdExamen);
            txtCodigo.Text = x.Codigo;
            txtNombre.Text = x.Nombre;
            cboTipoMuestra.SelectedItem = x.TipoMuestra;
            cboProcedimiento.SelectedItem = x.Procedimiento;
            nudTarifa.Value = Math.Min(nudTarifa.Maximum, x.Tarifa);
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Examen
            {
                IdExamen = m.Id,
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                TipoMuestra = cboTipoMuestra.Text,
                Procedimiento = cboProcedimiento.Text,
                Tarifa = nudTarifa.Value
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Examen>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar el examen " + x.Nombre + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdExamen))) Buscar();
        }
    }
}
