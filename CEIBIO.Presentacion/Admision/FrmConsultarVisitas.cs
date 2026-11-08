using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmConsultarVisitas : Form
    {
        private readonly VisitaNegocio negocio = new();

        public FrmConsultarVisitas()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                var lista = negocio.ConsultarPorFecha(dtpFecha.Value);
                Ui.Llenar(dgvVisitas, lista, v => new object?[]
                {
                    v.NombrePaciente, v.Direccion, v.Telefono, v.Examenes, v.NombreTecnico, v.Estado
                });
            });
        }
    }
}
