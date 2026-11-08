using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantCondiciones : Form
    {
        private readonly CondicionNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantCondiciones()
        {
            InitializeComponent();
            cboExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            nudHorasAyuno.Minimum = 0;
            nudHorasAyuno.Maximum = 24;
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
                x.NombreExamen, x.HorasAyuno, x.RestriccionMedicamentos, x.MuestraQueDebeTraer, x.EstadoTexto
            }));
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<CondicionPreanalitica>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdCondicion);
            cboExamen.SelectedValue = x.IdExamen;
            nudHorasAyuno.Value = Math.Min(nudHorasAyuno.Maximum, x.HorasAyuno);
            txtMedicamentos.Text = x.RestriccionMedicamentos ?? "";
            txtMuestra.Text = x.MuestraQueDebeTraer ?? "";
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new CondicionPreanalitica
            {
                IdCondicion = m.Id,
                IdExamen = Ui.ItemCombo<Examen>(cboExamen)?.IdExamen ?? 0,
                HorasAyuno = (int)nudHorasAyuno.Value,
                RestriccionMedicamentos = txtMedicamentos.Text,
                MuestraQueDebeTraer = txtMuestra.Text
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<CondicionPreanalitica>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar las condiciones de " + x.NombreExamen + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdCondicion))) Buscar();
        }
    }
}
