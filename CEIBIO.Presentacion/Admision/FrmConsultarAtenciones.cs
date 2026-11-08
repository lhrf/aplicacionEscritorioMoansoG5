using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmConsultarAtenciones : Form
    {
        private readonly AtencionNegocio negocio = new();

        public FrmConsultarAtenciones()
        {
            InitializeComponent();
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            if (dtpFechaFin.Value.Date < dtpFechaInicio.Value.Date)
            {
                Ui.Aviso("La fecha final no puede ser anterior a la inicial.");
                return;
            }
            Ui.Intentar(() =>
            {
                var lista = negocio.Consultar(dtpFechaInicio.Value, dtpFechaFin.Value, cboEstado.Text);
                Ui.Llenar(dgvAtenciones, lista, a => new object?[]
                {
                    a.NumeroAtencion, Ui.FechaHora(a.FechaRegistro), a.NombrePaciente, a.Examenes, a.Modalidad, a.CostoTotal.ToString("0.00"), a.Estado
                });
                if (lista.Count == 0) Ui.Info("No hay atenciones para los filtros indicados.");
            });
        }
    }
}
