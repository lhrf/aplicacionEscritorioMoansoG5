using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.TomaMuestras
{
    public partial class FrmRechazoMuestra : Form
    {
        private readonly TomaMuestraNegocio negocio = new();
        private readonly Muestra? muestra;
        private readonly TuboRequerido? tubo;

        public FrmRechazoMuestra()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            button2.Click += BtnRegistrar_Click;
            button1.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public FrmRechazoMuestra(Muestra muestra, TuboRequerido? tubo) : this()
        {
            this.muestra = muestra;
            this.tubo = tubo;
            textBox1.Text = tubo?.NombreExamen ?? "";
            textBox2.Text = tubo == null ? "" : tubo.Tipo + " (" + tubo.ColorTapa + ")";
        }

        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            if (muestra == null) { Ui.Aviso("Abra este formulario desde la toma de muestra."); return; }
            var r = new RechazoMuestra
            {
                IdMuestra = muestra.IdMuestra,
                IdExamen = tubo?.IdExamen,
                IdTubo = tubo?.IdTubo,
                Motivo = comboBox1.Text,
                Observacion = textBox3.Text
            };
            if (!Ui.Mostrar(negocio.RegistrarRechazo(r))) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
