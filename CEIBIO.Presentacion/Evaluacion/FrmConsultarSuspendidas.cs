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
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                var lista = negocio.ConsultarSuspendidas(dtpFechaInicio.Value, dtpFechaFin.Value);
                Ui.Llenar(dgvSuspendidas, lista, x => new object?[]
                {
                    x.NumeroAtencion, x.NombrePaciente, x.Motivo, Ui.Fecha(x.NuevaFecha), x.NombreEnfermera
                });
            });
        }

        private void BtnReactivar_Click(object? sender, EventArgs e)
        {
            var s = Ui.Seleccionado<Suspension>(dgvSuspendidas);
            if (s == null) { Ui.Aviso("Seleccione una atención suspendida."); return; }
            if (Ui.Mostrar(negocio.Reactivar(s.IdSuspension))) Buscar();
        }
    }
}
