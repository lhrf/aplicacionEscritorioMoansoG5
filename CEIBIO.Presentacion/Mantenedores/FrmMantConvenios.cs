using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantConvenios : Form
    {
        private readonly ConvenioNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantConvenios()
        {
            InitializeComponent();
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Minimum = 0;
            nudDescuento.Maximum = 100;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar);
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); dtpFin.Value = DateTime.Today.AddYears(1); txtInstitucion.Focus(); };
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
                x.Institucion, x.PorcentajeDescuento.ToString("0.##"), Ui.Fecha(x.FechaInicio), Ui.Fecha(x.FechaFin), x.EstadoTexto
            }));
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Convenio>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdConvenio);
            txtInstitucion.Text = x.Institucion;
            nudDescuento.Value = x.PorcentajeDescuento;
            dtpInicio.Value = x.FechaInicio;
            dtpFin.Value = x.FechaFin;
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Convenio
            {
                IdConvenio = m.Id,
                Institucion = txtInstitucion.Text,
                PorcentajeDescuento = nudDescuento.Value,
                FechaInicio = dtpInicio.Value.Date,
                FechaFin = dtpFin.Value.Date
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Convenio>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar el convenio con " + x.Institucion + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdConvenio))) Buscar();
        }
    }
}
