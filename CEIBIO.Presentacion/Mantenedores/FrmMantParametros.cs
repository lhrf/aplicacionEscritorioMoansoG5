using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantParametros : Form
    {
        private readonly ParametroNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantParametros()
        {
            InitializeComponent();
            cboExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar);
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => m.Nuevo();
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                Ui.Combo(cboExamen, new ExamenNegocio().ListarHabilitados(), "Nombre", "IdExamen");
                Buscar();
            });
        }

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.NombreExamen, x.Nombre, x.Unidad, x.EstadoTexto
            }));
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Parametro>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdParametro);
            cboExamen.SelectedValue = x.IdExamen;
            txtNombre.Text = x.Nombre;
            txtUnidad.Text = x.Unidad ?? "";
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Parametro
            {
                IdParametro = m.Id,
                IdExamen = Ui.ItemCombo<Examen>(cboExamen)?.IdExamen ?? 0,
                Nombre = txtNombre.Text,
                Unidad = txtUnidad.Text
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Parametro>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar el parámetro " + x.Nombre + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdParametro))) Buscar();
        }
    }
}
