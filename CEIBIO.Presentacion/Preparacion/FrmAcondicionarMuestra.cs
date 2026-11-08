using CEIBIO.Entidades;
using CEIBIO.Negocio;

namespace CEIBIO.Presentacion.Preparacion
{
    public partial class FrmAcondicionarMuestra : Form
    {
        private readonly PreparacionMuestraNegocio negocio = new();
        private Muestra? muestra;

        public FrmAcondicionarMuestra()
        {
            InitializeComponent();
            cboConservacion.DropDownStyle = ComboBoxStyle.DropDownList;
            nudMinutos.Minimum = 0;
            nudMinutos.Maximum = 60;
            AcceptButton = button5;
            button5.Click += (s, e) => Buscar();
            button4.Click += BtnIngreso_Click;
            button2.Click += BtnAcondicionar_Click;
            button3.Click += BtnCorregir_Click;
            button1.Click += (s, e) => Close();
            Mostrar(null);
        }

        private void Buscar()
        {
            Ui.Intentar(() =>
            {
                var m = negocio.BuscarPorCodigo(textBox1.Text);
                if (m == null) Ui.Aviso("El código de muestra no existe. Ingréselo nuevamente.");
                Mostrar(m);
            });
        }

        private void Mostrar(Muestra? m)
        {
            muestra = m;
            textBox2.Text = Ui.FechaHora(m?.FechaIngreso);
            textBox3.Text = m?.NombrePaciente ?? "";
            txtExamenes.Text = m?.Examenes ?? "";
            textBox4.Text = m?.Modalidad ?? "";
            txtTubos.Text = m?.TubosEsperados ?? "";
            txtMotivoCorreccion.Clear();
            cboConservacion.SelectedItem = m?.EstadoConservacion;
            if (m?.EstadoConservacion == null) cboConservacion.SelectedIndex = -1;
            int requeridos = m == null ? 0 : negocio.MinutosRequeridos(m.IdAtencion);
            nudMinutos.Value = Math.Min(nudMinutos.Maximum, m?.MinutosCentrifugacion ?? requeridos);

            button4.Enabled = m?.Estado == EstadoMuestra.Recolectada;
            button2.Enabled = m?.Estado == EstadoMuestra.Ingresada;
            button3.Enabled = m?.Estado == EstadoMuestra.Devuelta;
            txtMotivoCorreccion.Enabled = m?.Estado == EstadoMuestra.Devuelta;
            if (m != null && m.Estado != EstadoMuestra.Recolectada && m.Estado != EstadoMuestra.Ingresada && m.Estado != EstadoMuestra.Devuelta)
                Ui.Info("Estado actual de la muestra: " + m.Estado + ".");
        }

        private void Recargar()
        {
            if (muestra != null) Ui.Intentar(() => Mostrar(negocio.BuscarPorCodigo(muestra.Codigo)));
        }

        private void BtnIngreso_Click(object? sender, EventArgs e)
        {
            if (muestra == null) return;
            if (Ui.Mostrar(negocio.RegistrarIngreso(muestra.Codigo))) Recargar();
        }

        private void BtnAcondicionar_Click(object? sender, EventArgs e)
        {
            if (muestra == null) return;
            if (Ui.Mostrar(negocio.RegistrarAcondicionamiento(muestra.IdMuestra, cboConservacion.Text, (int)nudMinutos.Value))) Recargar();
        }

        private void BtnCorregir_Click(object? sender, EventArgs e)
        {
            if (muestra == null) return;
            if (Ui.Mostrar(negocio.CorregirRegistro(muestra.IdMuestra, cboConservacion.Text, (int)nudMinutos.Value, txtMotivoCorreccion.Text))) Recargar();
        }
    }
}
