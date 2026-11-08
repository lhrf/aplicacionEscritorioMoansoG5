using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.TomaMuestras
{
    public partial class FrmTomaMuestraSede : Form
    {
        private readonly TomaMuestraNegocio negocio = new();
        private Atencion? atencion;
        private Muestra? muestra;

        public FrmTomaMuestraSede()
        {
            InitializeComponent();
            btnIniciar.Click += BtnIniciar_Click;
            btnImprimirEtiquetas.Click += (s, e) => ImprimirEtiquetas();
            btnRechazo.Click += BtnRechazo_Click;
            btnValidar.Click += BtnValidar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(ElegirAtencion);
        }

        private void ElegirAtencion()
        {
            var lista = negocio.ListarEnToma();
            if (lista.Count == 0)
            {
                Ui.Aviso("No hay pacientes asignados a un box para la toma de muestra.");
                Mostrar(null);
                return;
            }
            Mostrar(Ui.Elegir("Seleccionar paciente", lista, a => "Box " + a.NumeroBox + " - " + a.NumeroAtencion + " - " + a.NombrePaciente));
        }

        private void Mostrar(Atencion? a)
        {
            atencion = a;
            txtNumeroAtencion.Text = a?.NumeroAtencion ?? "";
            txtPaciente.Text = a?.NombrePaciente ?? "";
            txtBox.Text = a?.NumeroBox ?? "";
            muestra = a == null ? null : negocio.ObtenerMuestra(a.IdAtencion);
            textBox1.Text = muestra?.Codigo ?? "";
            var tubos = a == null ? new List<TuboRequerido>() : negocio.ListarTubosRequeridos(a.IdAtencion);
            Ui.Llenar(dataGridView1, tubos, t => new object?[] { t.NombreExamen, t.Tipo, t.ColorTapa, t.Estado });
            dateTimePicker1.Value = DateTime.Now;
            btnIniciar.Enabled = a != null && muestra == null;
            btnImprimirEtiquetas.Enabled = muestra != null;
            btnRechazo.Enabled = muestra != null;
            btnValidar.Enabled = muestra != null;
        }

        private void BtnIniciar_Click(object? sender, EventArgs e)
        {
            if (atencion == null) return;
            var r = negocio.IniciarToma(atencion.IdAtencion);
            if (!Ui.Mostrar(r)) return;
            Mostrar(atencion);
            ImprimirEtiquetas();
        }

        private void ImprimirEtiquetas()
        {
            if (atencion == null) return;
            var etiquetas = negocio.ListarEtiquetas(atencion.IdAtencion);
            if (etiquetas.Count == 0) return;
            Ui.Imprimir("Etiquetas " + etiquetas[0].Codigo,
                string.Join(Environment.NewLine + new string('-', 40) + Environment.NewLine, etiquetas.Select(x => x.Texto)));
        }

        private void BtnRechazo_Click(object? sender, EventArgs e)
        {
            if (atencion == null || muestra == null) return;
            var tubo = Ui.Seleccionado<TuboRequerido>(dataGridView1);
            using var f = new FrmRechazoMuestra(muestra, tubo);
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                    if (fila.Tag == tubo) fila.Cells[3].Value = "Rechazado - repetir";
                ImprimirEtiquetas();
            }
        }

        private void BtnValidar_Click(object? sender, EventArgs e)
        {
            if (atencion == null) return;
            if (Ui.Mostrar(negocio.ValidarRecoleccion(atencion.IdAtencion, dateTimePicker1.Value))) Ui.Intentar(ElegirAtencion);
        }
    }
}
