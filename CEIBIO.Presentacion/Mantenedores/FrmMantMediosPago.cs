using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantMediosPago : Form
    {
        private readonly MedioPagoNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantMediosPago()
        {
            InitializeComponent();
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

        private void MostrarEstado() => m.Estado(Ui.Seleccionado<MedioPago>(dgvRegistros)?.Habilitado);

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.Codigo, x.Descripcion, x.RequiereAutorizacionTexto, x.EstadoTexto
            }));
            MostrarEstado();
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<MedioPago>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdMedioPago);
            txtCodigo.Text = x.Codigo;
            txtDescripcion.Text = x.Descripcion;
            chkRequiereAutorizacion.Checked = x.RequiereAutorizacion;
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new MedioPago
            {
                IdMedioPago = m.Id,
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text,
                RequiereAutorizacion = chkRequiereAutorizacion.Checked
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<MedioPago>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (x.Habilitado)
            {
                if (!Ui.Confirmar("¿Desea inhabilitar " + "el medio de pago " + x.Descripcion + "?")) return;
                if (Ui.Mostrar(negocio.Inhabilitar(x.IdMedioPago))) Buscar();
            }
            else
            {
                if (!Ui.Confirmar("¿Desea habilitar nuevamente " + "el medio de pago " + x.Descripcion + "?")) return;
                if (Ui.Mostrar(negocio.Habilitar(x.IdMedioPago))) Buscar();
            }
        }
    }
}
