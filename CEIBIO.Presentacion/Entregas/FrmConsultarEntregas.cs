using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Entregas
{
    public partial class FrmConsultarEntregas : Form
    {
        private readonly EntregaNegocio negocio = new();

        public FrmConsultarEntregas()
        {
            InitializeComponent();
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                Ui.Llenar(dgvEntregas, negocio.ConsultarEntregas(dtpFechaInicio.Value, dtpFechaFin.Value), x => new object?[]
                {
                    x.NombrePaciente, x.NombreRecibe, x.DniRecibe, x.Relacion, Ui.FechaHora(x.FechaEntrega)
                });
            });
        }
    }
}
