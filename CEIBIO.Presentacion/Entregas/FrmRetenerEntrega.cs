using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Entregas
{
    public partial class FrmRetenerEntrega : Form
    {
        private readonly EntregaNegocio negocio = new();
        private readonly DatosEntrega? datos;

        public FrmRetenerEntrega()
        {
            InitializeComponent();
            btnRetener.Click += BtnRetener_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmRetenerEntrega(DatosEntrega datos) : this()
        {
            this.datos = datos;
            txtNumeroAtencion.Text = datos.NumeroAtencion;
            txtPaciente.Text = datos.PacienteReporte;
        }

        private void BtnRetener_Click(object? sender, EventArgs e)
        {
            if (datos == null) { Ui.Aviso("Abra este formulario desde el registro de entrega."); return; }
            if (!Ui.Mostrar(negocio.Retener(datos.IdReporte, txtMotivo.Text))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
