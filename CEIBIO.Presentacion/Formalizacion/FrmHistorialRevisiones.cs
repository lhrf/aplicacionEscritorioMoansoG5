using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmHistorialRevisiones : Form
    {
        private readonly ReporteNegocio negocio = new();

        public FrmHistorialRevisiones()
        {
            InitializeComponent();
            AcceptButton = btnBuscar;
            btnBuscar.Click += BtnBuscar_Click;
            btnCerrar.Click += (s, e) => Close();
        }

        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            if (Validacion.Vacio(txtNumeroAtencion.Text)) { Ui.Aviso("Ingrese el número de atención."); return; }
            Ui.Intentar(() =>
            {
                var lista = negocio.ListarHistorial(txtNumeroAtencion.Text);
                Ui.Llenar(dgvHistorial, lista, h => new object?[]
                {
                    h.Version, h.Accion, h.Observacion, h.NombreResponsable, Ui.FechaHora(h.Fecha)
                });
                if (lista.Count == 0) Ui.Info("No se encontró historial para esa atención.");
            });
        }
    }
}
