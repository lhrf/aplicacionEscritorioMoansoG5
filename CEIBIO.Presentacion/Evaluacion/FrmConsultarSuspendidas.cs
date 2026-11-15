using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Evaluacion
{
    public partial class FrmConsultarSuspendidas : Form
    {
        private readonly EvaluacionNegocio negocio = new();

        public FrmConsultarSuspendidas()
        {
            InitializeComponent();
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpFechaFin.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnReactivar.Click += BtnReactivar_Click;
            btnCerrar.Click += (s, e) => Close();
            Ui.AlSeleccionar(dgvSuspendidas, () => btnReactivar.Enabled = dgvSuspendidas.CurrentRow != null);
            Ui.AlDobleClic(dgvSuspendidas, () => BtnReactivar_Click(btnReactivar, EventArgs.Empty));
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            if (!Ui.RangoValido(dtpFechaInicio, dtpFechaFin)) return;
            Ui.Intentar(() =>
            {
                var lista = negocio.ConsultarSuspendidas(dtpFechaInicio.Value, dtpFechaFin.Value);
                Ui.Llenar(dgvSuspendidas, lista, x => new object?[]
                {
                    x.NumeroAtencion, x.NombrePaciente, x.Motivo, Ui.Fecha(x.NuevaFecha), x.NombreEnfermera
                });
                btnReactivar.Enabled = dgvSuspendidas.CurrentRow != null;
            });
        }

        private void BtnReactivar_Click(object? sender, EventArgs e)
        {
            var s = Ui.Seleccionado<Suspension>(dgvSuspendidas);
            if (s == null) { Ui.Aviso("Seleccione una atención suspendida."); return; }
            if (!Ui.Confirmar("¿Desea reactivar la atención " + s.NumeroAtencion + " de " + s.NombrePaciente + "?")) return;
            if (Ui.Mostrar(negocio.Reactivar(s.IdSuspension))) Buscar();
        }
    }
}
