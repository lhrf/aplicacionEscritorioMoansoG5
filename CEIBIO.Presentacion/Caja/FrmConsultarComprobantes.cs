using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmConsultarComprobantes : Form
    {
        private readonly ComprobanteNegocio negocio = new();

        public FrmConsultarComprobantes()
        {
            InitializeComponent();
            txtDni.MaxLength = 8;
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            if (!Validacion.Vacio(txtDni.Text) && !Validacion.EsDni(txtDni.Text))
            {
                Ui.Aviso("El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            Ui.Intentar(() =>
            {
                var lista = negocio.Consultar(dtpFechaInicio.Value, dtpFechaFin.Value, txtDni.Text);
                Ui.Llenar(dgvComprobantes, lista, c => new object?[]
                {
                    c.NumeroComprobante, Ui.FechaHora(c.FechaEmision), c.NombrePaciente, c.Total.ToString("0.00"), c.Estado
                });
            });
        }
    }
}
