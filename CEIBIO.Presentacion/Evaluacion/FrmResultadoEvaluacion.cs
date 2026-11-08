using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Evaluacion
{
    public partial class FrmResultadoEvaluacion : Form
    {
        private readonly EvaluacionNegocio negocio = new();
        private Atencion? atencion;

        public FrmResultadoEvaluacion()
        {
            InitializeComponent();
            Configurar();
            Load += (s, e) => Ui.Intentar(ElegirAtencion);
        }

        public FrmResultadoEvaluacion(Atencion atencion)
        {
            InitializeComponent();
            Configurar();
            Load += (s, e) => Ui.Intentar(() => Mostrar(atencion));
        }

        private void Configurar()
        {
            txtHorasAyuno.ReadOnly = true;
            txtMedicamentos.ReadOnly = true;
            txtEstadoMuestra.ReadOnly = true;
            btnApto.Click += BtnApto_Click;
            btnSuspender.Click += BtnSuspender_Click;
            btnCerrar.Click += (s, e) => Close();
        }

        private void ElegirAtencion()
        {
            var pendientes = negocio.ListarPendientes().Where(a => negocio.ObtenerPorAtencion(a.IdAtencion)?.Resultado == null
                                                                && negocio.ObtenerPorAtencion(a.IdAtencion) != null).ToList();
            if (pendientes.Count == 0)
            {
                Ui.Aviso("No hay atenciones con observaciones registradas pendientes de resultado.");
                return;
            }
            var elegida = Ui.Elegir("Seleccionar atención", pendientes, a => a.NumeroAtencion + " - " + a.NombrePaciente);
            if (elegida != null) Mostrar(elegida);
        }

        private void Mostrar(Atencion a)
        {
            atencion = a;
            txtNumeroAtencion.Text = a.NumeroAtencion;
            txtPaciente.Text = a.NombrePaciente;
            var ev = negocio.ObtenerPorAtencion(a.IdAtencion);
            txtHorasAyuno.Text = ev?.HorasAyuno.ToString() ?? "";
            txtMedicamentos.Text = ev?.Medicamentos ?? "";
            txtEstadoMuestra.Text = ev?.EstadoMuestraTexto ?? "";
            txtObservaciones.Text = ev?.Observaciones ?? "";
            btnApto.Enabled = ev != null;
            btnSuspender.Enabled = ev != null;
        }

        private void BtnApto_Click(object? sender, EventArgs e)
        {
            if (atencion == null) return;
            if (Ui.Mostrar(negocio.RegistrarApto(atencion.IdAtencion))) Close();
        }

        private void BtnSuspender_Click(object? sender, EventArgs e)
        {
            if (atencion == null) return;
            using var f = new FrmSuspenderAtencion(atencion);
            if (f.ShowDialog(this) == DialogResult.OK) Close();
        }
    }
}
