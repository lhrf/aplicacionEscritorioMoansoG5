using System.Text;
using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Preparacion
{
    public partial class FrmConsultarTransito : Form
    {
        private readonly PreparacionMuestraNegocio negocio = new();

        public FrmConsultarTransito()
        {
            InitializeComponent();
            cboEstado.Items.Clear();
            cboEstado.Items.Add("(Todos)");
            foreach (var estado in EstadoMuestra.Todos) cboEstado.Items.Add(estado);
            cboEstado.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dateTimePicker1.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            dgvTransito.CellDoubleClick += (s, e) => MostrarMovimientos();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                var lista = negocio.ConsultarTransito(dtpFechaInicio.Value, dateTimePicker1.Value, cboEstado.Text);
                Ui.Llenar(dgvTransito, lista, m => new object?[]
                {
                    m.Codigo, m.NombrePaciente, Ui.FechaHora(m.FechaIngreso), m.MinutosCentrifugacion?.ToString() ?? "", m.NombreResponsable, m.Estado
                });
            });
        }

        private void MostrarMovimientos()
        {
            var m = Ui.Seleccionado<Muestra>(dgvTransito);
            if (m == null) return;
            Ui.Intentar(() =>
            {
                var movimientos = negocio.ListarMovimientos(m.IdMuestra);
                var sb = new StringBuilder();
                foreach (var x in movimientos)
                    sb.AppendLine(Ui.FechaHora(x.FechaHora) + "  " + x.TipoMovimiento + " - " + x.NombreUsuario + (Validacion.Vacio(x.Detalle) ? "" : ": " + x.Detalle));
                Ui.Info(movimientos.Count == 0 ? "La muestra aún no tiene movimientos." : "Movimientos de la muestra " + m.Codigo + ":\n\n" + sb);
            });
        }
    }
}
