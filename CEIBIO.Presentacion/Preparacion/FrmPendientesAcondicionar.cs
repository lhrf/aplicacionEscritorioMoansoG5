using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Preparacion
{
    public partial class FrmPendientesAcondicionar : Form
    {
        private readonly PreparacionMuestraNegocio negocio = new();

        public FrmPendientesAcondicionar()
        {
            InitializeComponent();
            button2.Click += (s, e) => Cargar();
            button1.Click += (s, e) => Close();
            Load += (s, e) => Cargar();
        }

        private void Cargar()
        {
            Ui.Intentar(() =>
            {
                Ui.Llenar(dgvPendientes, negocio.ListarPendientesAcondicionar(), m => new object?[]
                {
                    m.Codigo, m.NombrePaciente, Ui.FechaHora(m.FechaIngreso), m.TiempoTranscurrido
                });
            });
        }
    }
}
