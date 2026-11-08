using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Analisis
{
    public partial class FrmConsultarBitacora : Form
    {
        private readonly UsoEquipoNegocio negocio = new();

        public FrmConsultarBitacora()
        {
            InitializeComponent();
            cboEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(() =>
            {
                var equipos = new List<Equipo> { new Equipo { IdEquipo = 0, Nombre = "(Todos)" } };
                equipos.AddRange(negocio.ListarEquipos());
                Ui.Combo(cboEquipo, equipos, "Nombre", "IdEquipo");
                cboEquipo.SelectedIndex = 0;
                Buscar();
            });
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                int idEquipo = Ui.ItemCombo<Equipo>(cboEquipo)?.IdEquipo ?? 0;
                Ui.Llenar(dgvBitacora, negocio.ConsultarBitacora(idEquipo, dtpFechaInicio.Value, dtpFechaFin.Value), u => new object?[]
                {
                    Ui.FechaHora(u.HoraInicio), u.CodigoMuestra + " (" + u.NombreEquipo + ")", u.NombreTecnico, u.FallaAnalitica
                });
            });
        }
    }
}
