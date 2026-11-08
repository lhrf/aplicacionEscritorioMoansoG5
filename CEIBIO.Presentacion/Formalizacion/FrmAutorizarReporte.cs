using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmAutorizarReporte : Form
    {
        private readonly ReporteNegocio negocio = new();

        public FrmAutorizarReporte()
        {
            InitializeComponent();
            dgvReportes.SelectionChanged += (s, e) => Ui.Intentar(MostrarSeleccion);
            btnAutorizar.Click += BtnAutorizar_Click;
            btnDevolver.Click += BtnDevolver_Click;
            btnAnular.Click += BtnAnular_Click;
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            var lista = negocio.ListarPendientesAutorizacion().Concat(negocio.ListarAutorizados()).ToList();
            Ui.Llenar(dgvReportes, lista, r => new object?[]
            {
                r.NumeroAtencion, r.NombrePaciente, r.Version + " - " + r.Estado, Ui.FechaHora(r.FechaAutorizacion ?? r.FechaGeneracion)
            });
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            var validaciones = r == null ? new List<ResultadoAnalitico>() : negocio.ListarValidaciones(r.IdAtencion);
            Ui.Llenar(dgvValidaciones, validaciones, x => new object?[]
            {
                x.NombreParametro, x.ValidadoTexto, x.NombreMedico, Ui.FechaHora(x.FechaValidacion)
            });
            bool pendiente = r?.Estado == EstadoReporte.PendienteAutorizacion;
            bool autorizado = r?.Estado == EstadoReporte.Autorizado || r?.Estado == EstadoReporte.DisponibleEntrega;
            btnAutorizar.Enabled = pendiente;
            btnDevolver.Enabled = pendiente;
            btnAnular.Enabled = autorizado;
            txtMotivo.Enabled = autorizado;
            txtMotivo.Clear();
        }

        private void BtnAutorizar_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            if (r == null) return;
            if (Ui.Mostrar(negocio.Autorizar(r.IdReporte))) Ui.Intentar(Cargar);
        }

        private void BtnDevolver_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            if (r == null) return;
            using var f = new FrmDevolverReporte(r);
            if (f.ShowDialog(this) == DialogResult.OK) Ui.Intentar(Cargar);
        }

        private void BtnAnular_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvReportes);
            if (r == null) return;
            if (!Ui.Confirmar("¿Desea anular la autorización del reporte de la atención " + r.NumeroAtencion + "?")) return;
            if (Ui.Mostrar(negocio.AnularAutorizacion(r.IdReporte, txtMotivo.Text))) Ui.Intentar(Cargar);
        }
    }
}
