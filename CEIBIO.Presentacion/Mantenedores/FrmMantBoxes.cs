using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantBoxes : Form
    {
        private readonly BoxNegocio negocio = new();
        private readonly Mantenedor m;

        public FrmMantBoxes()
        {
            InitializeComponent();
            textBox1.MaxLength = 10;
            m = new Mantenedor(grpDatos, btnNuevo, btnEditar, guardar, cancelar, btnInhabilitar);
            button3.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => { m.Nuevo(); textBox1.Focus(); };
            btnEditar.Click += BtnEditar_Click;
            guardar.Click += BtnGuardar_Click;
            cancelar.Click += (s, e) => m.Cancelar();
            btnInhabilitar.Click += BtnInhabilitar_Click;
            button1.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() => Ui.Llenar(dataGridView1, negocio.Listar(txtBuscar.Text), x => new object?[]
            {
                x.Numero, x.Descripcion, x.EstadoTexto
            }));
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Box>(dataGridView1);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            m.Editar(x.IdBox);
            textBox1.Text = x.Numero;
            textBox2.Text = x.Descripcion ?? "";
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            var x = new Box { IdBox = m.Id, Numero = textBox1.Text, Descripcion = textBox2.Text };
            if (!Ui.Mostrar(negocio.Guardar(x))) return;
            m.Cancelar();
            Buscar();
        }

        private void BtnInhabilitar_Click(object? sender, EventArgs e)
        {
            var x = Ui.Seleccionado<Box>(dataGridView1);
            if (x == null) { Ui.Aviso("Seleccione un registro."); return; }
            if (!Ui.Confirmar("¿Desea inhabilitar el box " + x.Numero + "?")) return;
            if (Ui.Mostrar(negocio.Inhabilitar(x.IdBox))) Buscar();
        }
    }
}
