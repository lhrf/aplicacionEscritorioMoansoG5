using CEIBIO.Entidades;
using CEIBIO.Negocio;
using CEIBIO.Presentacion.Formalizacion;

namespace CEIBIO.Presentacion.Analisis
{
    public partial class FrmPendientesValidacion : Form
    {
        private readonly ResultadoNegocio negocio = new();

        public FrmPendientesValidacion()
        {
            InitializeComponent();
            btnValidar.Click += BtnValidar_Click;
            Ui.AlDobleClic(dgvPendientes, () => BtnValidar_Click(btnValidar, EventArgs.Empty));
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Ui.Intentar(Cargar);
        }

        private void Cargar()
        {
            Ui.Llenar(dgvPendientes, negocio.ListarPendientesValidacion(), r => new object?[]
            {
                r.NumeroAtencion, r.NombrePaciente, r.NombreExamen, r.NombreTecnico, Ui.FechaHora(r.FechaEnvio)
            });
            btnValidar.Enabled = dgvPendientes.Rows.Count > 0;
        }

        private void BtnValidar_Click(object? sender, EventArgs e)
        {
            var r = Ui.Seleccionado<ResultadoAnalitico>(dgvPendientes);
            if (r == null) { Ui.Aviso("Seleccione una atención."); return; }
            using var f = new FrmValidarResultados(r.IdAtencion);
            f.ShowDialog(this);
            Ui.Intentar(Cargar);
        }
    }
}
