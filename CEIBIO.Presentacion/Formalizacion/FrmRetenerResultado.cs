using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmRetenerResultado : Form
    {
        private readonly ResultadoNegocio negocio = new();
        private readonly ResultadoAnalitico? resultado;

        public FrmRetenerResultado()
        {
            InitializeComponent();
            btnRetener.Click += BtnRetener_Click;
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmRetenerResultado(ResultadoAnalitico resultado) : this()
        {
            this.resultado = resultado;
            txtParametro.Text = resultado.NombreParametro;
            txtValor.Text = resultado.Valor + (Validacion.Vacio(resultado.Unidad) ? "" : " " + resultado.Unidad);
        }

        private void BtnRetener_Click(object? sender, EventArgs e)
        {
            if (resultado == null) { Ui.Aviso("Abra este formulario desde la validación de resultados."); return; }
            if (!Ui.Mostrar(negocio.Retener(resultado.IdResultado, txtObservacion.Text))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
