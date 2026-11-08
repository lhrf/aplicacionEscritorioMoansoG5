
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    // CU-47: Retener y repetir resultado
    public partial class FrmRetenerResultado : Form
    {

        private readonly Color azul =
            Color.FromArgb(11, 61, 110);

        private readonly Color rojo =
            Color.FromArgb(180, 35, 24);

        public FrmRetenerResultado()
        {
            InitializeComponent();
            this.btnCancelar.Click += this.BtnCancelar_Click;
            this.btnRetener.Click += this.BtnRetener_Click;

        }



        // CREAR ETIQUETAS
        private void CrearEtiqueta(
            Control padre,
            string nombre,
            string texto,
            int x,
            int y)
        {
            Label etiqueta = new Label
            {
                Name = nombre,
                Text = texto,
                Location = new Point(x, y),
                AutoSize = true,
                ForeColor = Color.FromArgb(31, 35, 40),
                Font = new Font("Segoe UI", 10)
            };

            padre.Controls.Add(etiqueta);
        }

        // CREAR CUADROS DE TEXTO
        private TextBox CrearTexto(
            Control padre,
            string nombre,
            int x,
            int y,
            int ancho,
            int alto,
            bool soloLectura)
        {
            TextBox caja = new TextBox
            {
                Name = nombre,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                ReadOnly = soloLectura,
                BackColor = soloLectura
                    ? Color.FromArgb(233, 238, 243)
                    : Color.White,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10)
            };

            padre.Controls.Add(caja);
            return caja;
        }

        // CREAR BOTONES
        private Button CrearBoton(
            string nombre,
            string texto,
            int x,
            int y,
            int ancho,
            Color fondo,
            Color letra)
        {
            Button boton = new Button
            {
                Name = nombre,
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, 36),
                BackColor = fondo,
                ForeColor = letra,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            boton.FlatAppearance.BorderSize = 0;

            return boton;
        }

        // RECIBIR DATOS DEL RESULTADO
        public void CargarResultado(
            string parametro,
            string valor)
        {
            txtParametro.Text = parametro;
            txtValor.Text = valor;
        }

        // OBTENER OBSERVACIÓN
        public string Observacion
        {
            get { return txtObservacion.Text.Trim(); }
        }

        // BOTÓN RETENER
        private void BtnRetener_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtObservacion.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una observación " +
                    "para el Técnico Analista.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtObservacion.Focus();
                return;
            }

            // La operación real de retención debe
            // implementarse en la capa de negocio.
            // Aquí únicamente confirmamos los datos.

            DialogResult = DialogResult.OK;
            Close();
        }

        // BOTÓN CANCELAR
        private void BtnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
