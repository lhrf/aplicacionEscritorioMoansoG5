using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Caja
{
    public partial class FrmConsultarComprobantes : Form
    {
        private readonly ComprobanteNegocio negocio = new();

        public FrmConsultarComprobantes()
        {
            InitializeComponent();
            Ui.SoloDigitos(txtDni, 8);
            Ui.AlPresionarEnter(txtDni, Buscar);
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;
            btnBuscar.Click += (s, e) => Buscar();
            btnCerrar.Click += (s, e) => Close();
            Ui.AlDobleClic(dgvComprobantes, Reimprimir);
            Load += (s, e) => Buscar();
        }

        private void Buscar()
        {
            if (!Ui.RangoValido(dtpFechaInicio, dtpFechaFin)) return;
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

        private void Reimprimir()
        {
            var c = Ui.Seleccionado<Comprobante>(dgvComprobantes);
            if (c == null) return;
            var completo = negocio.ObtenerPorId(c.IdComprobante) ?? c;
            Ui.Imprimir("Comprobante " + completo.NumeroComprobante, ComprobanteNegocio.TextoImpresion(completo));
        }
    }
}
