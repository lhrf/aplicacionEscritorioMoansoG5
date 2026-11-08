using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantTubos : Form
    {
        private readonly TuboNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantTubos()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 60;
            clbExamenes.CheckOnClick = true;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, button4, button2, btnInhabilitar);
            button3.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); textBox1.Focus(); };
            btnEditar.Click += BtnEditar_Click;
            button4.Click += BtnGuardar_Click;
            button2.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            button1.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                clbExamenes.Items.Clear();
                foreach (var ex in new ExamenNegocio().ListarHabilitados()) clbExamenes.Items.Add(ex);
                Buscar();
            });
        }

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dataGridView1, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.Tipo, x.ColorTapa, x.Aditivo, x.MinutosCentrifugacion, x.EstadoTexto
            }));
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var sel = Ui.Seleccionado<Tubo>(dataGridView1);
            if (sel == null) { Ui.Aviso("Seleccione un registro."); return; }
            Ui.Intentar(() =>
            {
                var x = negocio.ObtenerPorId(sel.IdTubo);
                if (x == null) return;
                m.Editar(x.IdTubo);
                textBox1.Text = x.Tipo;
                textBox2.Text = x.ColorTapa;
                textBox3.Text = x.Aditivo ?? "";
                numericUpDown1.Value = Math.Min(numericUpDown1.Maximum, x.MinutosCentrifugacion);
                for (int i = 0; i < clbExamenes.Items.Count; i++)
                    clbExamenes.SetItemChecked(i, clbExamenes.Items[i] is Examen ex && x.IdExamenes.Contains(ex.IdExamen));
            });
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Tubo
            {
                IdTubo = m.Id,
                Tipo = textBox1.Text,
                ColorTapa = textBox2.Text,
                Aditivo = textBox3.Text,
                MinutosCentrifugacion = (int)numericUpDown1.Value,
                IdExamenes = clbExamenes.CheckedItems.OfType<Examen>().Select(ex => ex.IdExamen).ToList()
            };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Tubo>(dataGridView1);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar " + x.Tipo + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdTubo))) Buscar();
        }
    }
}
