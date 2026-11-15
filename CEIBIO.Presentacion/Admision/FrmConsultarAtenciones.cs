using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Admision
{
    public partial class FrmConsultarAtenciones : Form
    {
        private readonly AtencionNegocio negocio = new();

        public FrmConsultarAtenciones()
        {
            InitializeComponent();
            Ui.Lista(cboEstado);
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Ui.AlDobleClic(dgvAtenciones, VerDetalle);
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            if (!Ui.RangoValido(dtpFechaInicio, dtpFechaFin)) return;
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

        private void VerDetalle()
        {
            var a = Ui.Seleccionado<Atencion>(dgvAtenciones);
            if (a == null) return;
            var detalle = new PagoNegocio().ListarDetalle(a.IdAtencion);
            var texto = "Atención: " + a.NumeroAtencion + Environment.NewLine +
                        "Paciente: " + a.NombrePaciente + Environment.NewLine +
                        "Fecha: " + Ui.FechaHora(a.FechaRegistro) + Environment.NewLine +
                        "Modalidad: " + a.Modalidad + Environment.NewLine +
                        "Estado: " + a.Estado + Environment.NewLine + Environment.NewLine +
                        string.Join(Environment.NewLine, detalle.Select(d => d.NombreExamen + "  " + Ui.Soles(d.Tarifa))) + Environment.NewLine + Environment.NewLine +
                        "Costo total: " + Ui.Soles(a.CostoTotal);
            Ui.Info(texto);
        }
    }
}
