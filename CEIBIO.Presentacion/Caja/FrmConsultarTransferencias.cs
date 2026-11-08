using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmConsultarTransferencias : Form
    {
        private readonly TransferenciaNegocio negocio = new();

        public FrmConsultarTransferencias()
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
                var lista = negocio.ConsultarAutorizadas(dtpFechaInicio.Value, dtpFechaFin.Value);
                Ui.Llenar(dgvTransferencias, lista, t => new object?[]
                {
                    t.NumeroOperacion, t.NombrePaciente, t.Importe?.ToString("0.00"), t.NombreSupervisor, Ui.FechaHora(t.FechaRegistro)
                });
            });
        }
    }
}
