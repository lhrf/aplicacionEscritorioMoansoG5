using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Entregas
{
    public partial class FrmPendientesEntrega : Form
    {
        private readonly EntregaNegocio negocio = new();

        public FrmPendientesEntrega()
        {
            InitializeComponent();
            btnActualizar.Click += (s, e) => Cargar();
            btnCerrar.Click += (s, e) => Close();
            Ui.AlDobleClic(dgvPendientes, Entregar);
            Load += (s, e) => Cargar();
        }

        private void Cargar()
        {
            Ui.Intentar(() =>
            {
                Ui.Llenar(dgvPendientes, negocio.ListarPendientesEntrega(), r => new object?[]
                {
                    r.NumeroAtencion, r.NombrePaciente, Ui.FechaHora(r.FechaAutorizacion), r.DiasSinRecoger
                });
            });
        }

        private void Entregar()
        {
            var r = Ui.Seleccionado<ReporteClinico>(dgvPendientes);
            if (r == null || !Permisos.PuedeAbrir("FrmRegistrarEntrega")) return;
            using var f = new FrmRegistrarEntrega(r.Dni);
            f.ShowDialog(this);
            Cargar();
        }
    }
}
