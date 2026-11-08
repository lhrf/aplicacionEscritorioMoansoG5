using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmRevisarReporte : Form
    {
        private readonly ReporteNegocio negocio = new();

        public FrmRevisarReporte()
        {
            InitializeComponent();
            rtbReporte.ReadOnly = true;
            rtbReporte.Font = new Font("Consolas", 10F);
            dgvReportes.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            btnConformidad.Click += BtnConformidad_Click;
            btnObservar.Click += BtnObservar_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvReportes, negocio.ListarEnRevision(), r => new object?[]
            {
                r.NumeroAtencion, r.NombrePaciente, r.Version, r.NombreDigitador
            });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            rtbReporte.Text = r?.Contenido ?? "";
            var validados = r == null ? new List<ResultadoAnalitico>() : negocio.ListarResultadosValidados(r.IdAtencion);
            Ui.Llenar(dgvValidados, validados, x => new object?[] { x.NombreParametro, x.Valor, x.Unidad });
            txtObservaciones.Clear();
            btnConformidad.Enabled = r != null;
            btnObservar.Enabled = r != null;
        }

        private void BtnConformidad_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            if (r == null) return;
            if (Ui.Mostrar(negocio.DarConformidad(r.IdReporte))) Ui.Intentar(Cargar);
        }

        private void BtnObservar_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            if (r == null) return;
            if (Ui.Mostrar(negocio.Observar(r.IdReporte, txtObservaciones.Text))) Ui.Intentar(Cargar);
        }
    }
}
