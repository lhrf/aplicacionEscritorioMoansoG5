using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.TomaMuestras
{
    public partial class FrmConsultarRechazadas : Form
    {
        private readonly TomaMuestraNegocio negocio = new();

        public FrmConsultarRechazadas()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today.AddDays(-7);
            dateTimePicker2.Value = DateTime.Today;
            button2.Click += (s, e) => Buscar();
            button1.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                var lista = negocio.ConsultarRechazadas(dateTimePicker1.Value, dateTimePicker2.Value);
                Ui.Llenar(dataGridView1, lista, r => new object?[]
                {
                    Ui.FechaHora(r.Fecha), r.NombrePaciente, r.NombreExamen, r.Motivo, r.NombreTecnico
                });
            });
        }
    }
}
