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
                x.Codigo, x.Descripcion, x.RequiereAutorizacionTexto, x.EstadoTexto
            }));
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
            if (!Ui.Confirmar("¿Desea inhabilitar el medio de pago " + x.Descripcion + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdMedioPago))) Buscar();
        }
    }
}
