
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    // CU-47: Retener y repetir resultado
    public partial class FrmRetenerResultado : Form
    {
        private TextBox txtParametro;
        private TextBox txtValor;
        private TextBox txtObservacion;

        private Button btnRetener;
        private Button btnCancelar;

        private readonly Color azul =
            Color.FromArgb(11, 61, 110);

        private readonly Color rojo =
            Color.FromArgb(180, 35, 24);

        public FrmRetenerResultado()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            Text = "Retener y repetir resultado";
            ClientSize = new Size(520, 360);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.FromArgb(244, 246, 249);
            Font = new Font("Segoe UI", 10);

            // CABECERA
            Panel cabecera = new Panel
            {
                Name = "pnlCabecera",
                Location = new Point(0, 0),
                Size = new Size(520, 46),
                BackColor = azul
            };

            Label lblTitulo = new Label
            {
                Name = "lblTitulo",
                Text = "Retener y repetir resultado",
                Location = new Point(20, 10),
                AutoSize = true,
                Font = new Font(
                    "Segoe UI", 15, FontStyle.Bold),
                ForeColor = Color.White
            };

            Label lblCU = new Label
            {
                Name = "lblCU",
                Text = "",
                Location = new Point(458, 16),
                AutoSize = true,
                ForeColor = Color.LightBlue
            };

            cabecera.Controls.Add(lblTitulo);
            cabecera.Controls.Add(lblCU);
            Controls.Add(cabecera);

            // GRUPO: RETENER RESULTADO
            GroupBox grpRetenerResultado = new GroupBox
            {
                Name = "grpRetenerResultado",
                Text = "Retener resultado",
                Location = new Point(20, 60),
                Size = new Size(480, 188),
                BackColor = Color.White,
                ForeColor = azul,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            Controls.Add(grpRetenerResultado);

            // PARÁMETRO
            CrearEtiqueta(
                grpRetenerResultado,
                "lblParametro",
                "Parámetro",
                15, 35);

            txtParametro = CrearTexto(
                grpRetenerResultado,
                "txtParametro",
                265, 32, 200, 27, true);

            // VALOR
            CrearEtiqueta(
                grpRetenerResultado,
                "lblValor",
                "Valor",
                15, 73);

            txtValor = CrearTexto(
                grpRetenerResultado,
                "txtValor",
                265, 70, 120, 27, true);

            // OBSERVACIÓN OBLIGATORIA
            CrearEtiqueta(
                grpRetenerResultado,
                "lblObservacion",
                "Observación para el Técnico *",
                15, 111);

            txtObservacion = CrearTexto(
                grpRetenerResultado,
                "txtObservacion",
                265, 108, 200, 60, false);

            txtObservacion.Multiline = true;
            txtObservacion.ScrollBars =
                ScrollBars.Vertical;
            txtObservacion.MaxLength = 1000;

            // BARRA DE ACCIONES
            Panel barra = new Panel
            {
                Name = "pnlAcciones",
                Location = new Point(0, 300),
                Size = new Size(520, 60),
                BackColor = Color.White
            };

            btnCancelar = CrearBoton(
                "btnCancelar",
                "Cancelar",
                370, 12, 130,
                Color.FromArgb(229, 231, 235),
                Color.Black);

            btnRetener = CrearBoton(
                "btnRetener",
                "Retener",
                230, 12, 130,
                rojo, Color.White);

            btnCancelar.Click += BtnCancelar_Click;
            btnRetener.Click += BtnRetener_Click;

            barra.Controls.Add(btnCancelar);
            barra.Controls.Add(btnRetener);
            Controls.Add(barra);

            CancelButton = btnCancelar;

            ResumeLayout(false);
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
