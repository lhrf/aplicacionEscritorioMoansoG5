using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.TomaMuestras
{
    public partial class FrmTomaMuestraDomicilio : Form
    {
        private readonly TomaMuestraNegocio negocio = new();

        public FrmTomaMuestraDomicilio()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            dataGridView1.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            button6.Click += BtnPreparar_Click;
            button5.Click += (s, e) => ImprimirEtiquetas();
            btnRegistrarRetorno.Click += BtnRegistrarRetorno_Click;
            button3.Click += BtnNoRealizada_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private VisitaDomiciliaria? Actual => Ui.Seleccionado<VisitaDomiciliaria>(dataGridView1);

        private void Cargar()
        {
            var lista = negocio.ListarVisitasDelDia();
            Ui.Llenar(dataGridView1, lista, v => new object?[] { v.NumeroAtencion, v.NombrePaciente, v.Direccion, v.Examenes });
            MostrarSeleccion();
            if (lista.Count == 0) Ui.Info("No tiene visitas domiciliarias programadas para hoy.");
        }

        private void MostrarSeleccion()
        {
            var v = Actual;
            var tubos = v == null ? new List<TuboRequerido>() : negocio.ListarTubosALlevar(v.IdAtencion);
            Ui.Llenar(dataGridView2, tubos, t => new object?[] { t.NombreExamen, t.Tipo + " (" + t.ColorTapa + ")", t.Cantidad });
            var muestra = v == null ? null : negocio.ObtenerMuestra(v.IdAtencion);
            textBox1.Text = muestra?.Codigo ?? "";
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            button6.Enabled = v != null && muestra == null;
            button5.Enabled = muestra != null;
            btnRegistrarRetorno.Enabled = muestra != null;
            button3.Enabled = v != null;
        }

        private void BtnPreparar_Click(object? sender, EventArgs e)
        {
            var v = Actual;
            if (v == null) return;
            if (!Ui.Mostrar(negocio.PrepararVisita(v.IdAtencion))) return;
            MostrarSeleccion();
            ImprimirEtiquetas();
        }

        private void ImprimirEtiquetas()
        {
            var v = Actual;
            if (v == null) return;
            var etiquetas = negocio.ListarEtiquetas(v.IdAtencion);
            if (etiquetas.Count == 0) return;
            Ui.Imprimir("Etiquetas " + etiquetas[0].Codigo,
                string.Join(Environment.NewLine + new string('-', 40) + Environment.NewLine, etiquetas.Select(x => x.Texto)));
        }

        private void BtnRegistrarRetorno_Click(object? sender, EventArgs e)
        {
            var v = Actual;
            if (v == null) return;
            if (Ui.Mostrar(negocio.RegistrarRetorno(v.IdAtencion, dateTimePicker1.Value, textBox2.Text, textBox3.Text))) Ui.Intentar(Cargar);
        }

        private void BtnNoRealizada_Click(object? sender, EventArgs e)
        {
            var v = Actual;
            if (v == null) return;
            var motivo = Ui.Pedir("Visita no realizada", "Motivo por el que no se realizó la visita:");
            if (motivo == null) return;
            if (Ui.Mostrar(negocio.RegistrarVisitaNoRealizada(v.IdAtencion, motivo))) Ui.Intentar(Cargar);
        }
    }
}
