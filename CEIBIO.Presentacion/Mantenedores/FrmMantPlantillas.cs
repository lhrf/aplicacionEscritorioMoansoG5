using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantPlantillas : Form
    {
        private readonly PlantillaNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantPlantillas()
        {
            InitializeComponent();
            clbExamenes.CheckOnClick = true;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, btnGuardar, btnCancelar, btnInhabilitar);
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); txtNombre.Focus(); };
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            btnExaminar.Click += BtnExaminar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                clbExamenes.Items.Clear();
                foreach (var ex in new ExamenNegocio().ListarHabilitados()) clbExamenes.Items.Add(ex);
                Buscar();
            });
        }

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dgvRegistros, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.Nombre, x.Formato, x.Examenes, x.EstadoTexto
            }));
        }

        private void BtnExaminar_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Seleccionar formato de plantilla",
                Filter = "Documentos (*.docx;*.doc;*.pdf;*.rtf;*.txt)|*.docx;*.doc;*.pdf;*.rtf;*.txt|Todos los archivos (*.*)|*.*"
            };
            if (dlg.ShowDialog(this) == DialogResult.OK) txtFormato.Text = Path.GetFileName(dlg.FileName);
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var sel = Ui.Seleccionado<Plantilla>(dgvRegistros);
            if (sel == null) { Ui.Aviso("Seleccione un registro."); return; }
            Ui.Intentar(() =>
            {
                var x = negocio.ObtenerPorId(sel.IdPlantilla);
                if (x == null) return;
                m.Editar(x.IdPlantilla);
                txtNombre.Text = x.Nombre;
                txtFormato.Text = x.Formato;
                for (int i = 0; i < clbExamenes.Items.Count; i++)
                    clbExamenes.SetItemChecked(i, clbExamenes.Items[i] is Examen ex && x.IdExamenes.Contains(ex.IdExamen));
            });
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Plantilla
            {
                IdPlantilla = m.Id,
                Nombre = txtNombre.Text,
                Formato = txtFormato.Text,
                IdExamenes = clbExamenes.CheckedItems.OfType<Examen>().Select(ex => ex.IdExamen).ToList()
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Plantilla>(dgvRegistros);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar la plantilla " + x.Nombre + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdPlantilla))) Buscar();
        }
    }
}
