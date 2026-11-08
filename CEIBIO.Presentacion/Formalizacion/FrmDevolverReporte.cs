
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmDevolverReporte : Form
    {
        private readonly Color AZUL =
            Color.FromArgb(11, 61, 110);

        private readonly Color BLANCO = Color.White;

        private readonly Color TEXTO =
            Color.FromArgb(31, 35, 40);

        private readonly Color FONDO =
            Color.FromArgb(244, 246, 249);

        private readonly Color RO =
            Color.FromArgb(233, 238, 243);

        private readonly Color PELIGRO =
            Color.FromArgb(180, 35, 24);

        private TextBox txtNumeroAtencion;
        private TextBox txtPaciente;
        private TextBox txtObservacion;

        private Button btnDevolver;
        private Button btnCancelar;

        public FrmDevolverReporte()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // CONFIGURACIÓN DEL FORMULARIO
            Text = "Devolver Reporte para completar validaciones";
            ClientSize = new Size(520, 360);
            BackColor = FONDO;
            Font = new Font("Segoe UI", 10);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            // ENCABEZADO
            Panel pnlEncabezado = new Panel
            {
                Name = "pnlEncabezado",
                Location = new Point(0, 0),
                Size = new Size(520, 46),
                BackColor = AZUL
            };

            Label lblTitulo = new Label
            {
                Name = "lblTitulo",
                Text = "Devolver Reporte para completar validaciones",
                Location = new Point(20, 12),
                Size = new Size(475, 24),
                AutoSize = false,
                Font = new Font(
                    "Segoe UI", 11, FontStyle.Bold),
                ForeColor = BLANCO,
                BackColor = Color.Transparent
            };

            pnlEncabezado.Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);

            // GRUPO DEVOLUCIÓN
            GroupBox grpDevolucion = new GroupBox
            {
                Name = "grpDevolucion",
                Text = "Devolución",
                Location = new Point(20, 60),
                Size = new Size(480, 188),
                BackColor = BLANCO,
                ForeColor = AZUL,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            // NÚMERO DE ATENCIÓN
            Label lblNumeroAtencion = CrearEtiqueta(
                "lblNumeroAtencion",
                "N.° de atención",
                15, 35);

            txtNumeroAtencion = CrearTexto(
                "txtNumeroAtencion",
                149, 32, 120, 27, true, false);

            // PACIENTE
            Label lblPaciente = CrearEtiqueta(
                "lblPaciente",
                "Paciente",
                15, 73);

            txtPaciente = CrearTexto(
                "txtPaciente",
                149, 70, 260, 27, true, false);

            // OBSERVACIÓN
            Label lblObservacion = CrearEtiqueta(
                "lblObservacion",
                "Observación *",
                15, 111);

            txtObservacion = CrearTexto(
                "txtObservacion",
                149, 108, 260, 60, false, true);

            grpDevolucion.Controls.Add(lblNumeroAtencion);
            grpDevolucion.Controls.Add(txtNumeroAtencion);

            grpDevolucion.Controls.Add(lblPaciente);
            grpDevolucion.Controls.Add(txtPaciente);

            grpDevolucion.Controls.Add(lblObservacion);
            grpDevolucion.Controls.Add(txtObservacion);

            Controls.Add(grpDevolucion);

            // BARRA INFERIOR
            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 300),
                Size = new Size(520, 60),
                BackColor = BLANCO
            };

            btnCancelar = CrearBoton(
                "btnCancelar", "Cancelar", 130, false);

            btnDevolver = CrearBoton(
                "btnDevolver", "Devolver", 130, true);

            btnCancelar.Location = new Point(380, 12);
            btnDevolver.Location = new Point(240, 12);

            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnDevolver);

            Controls.Add(pnlBotones);

            // EVENTOS
            btnCancelar.Click += (s, e) => Close();

            btnDevolver.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(
                    txtObservacion.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar una observación.",
                        "Campo obligatorio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtObservacion.Focus();
                    return;
                }

                // La devolución real se conectará
                // posteriormente con la capa de negocio.
                MessageBox.Show(
                    "Observación registrada para la prueba visual. " +
                    "La devolución aún no se ha guardado.",
                    "CEIBIO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            };

            CancelButton = btnCancelar;

            ResumeLayout(false);
        }

        // CREAR ETIQUETAS
        private Label CrearEtiqueta(
            string nombre,
            string texto,
            int x,
            int y)
        {
            return new Label
            {
                Name = nombre,
                Text = texto,
                Location = new Point(x, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = Color.Transparent
            };
        }

        // CREAR TEXTBOX
        private TextBox CrearTexto(
            string nombre,
            int x,
            int y,
            int ancho,
            int alto,
            bool soloLectura,
            bool multilinea)
        {
            TextBox texto = new TextBox
            {
                Name = nombre,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                Multiline = multilinea,
                ReadOnly = soloLectura,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = soloLectura ? RO : BLANCO,
                ForeColor = TEXTO,
                Font = new Font("Segoe UI", 10),
                TabStop = !soloLectura
            };

            if (multilinea)
            {
                texto.ScrollBars = ScrollBars.Vertical;
            }

            return texto;
        }

        // CREAR BOTONES
        private Button CrearBoton(
            string nombre,
            string texto,
            int ancho,
            bool peligro)
        {
            Button boton = new Button
            {
                Name = nombre,
                Text = texto,
                Size = new Size(ancho, 36),
                AutoSize = false,
                AutoEllipsis = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                TabStop = true
            };

            if (peligro)
            {
                boton.BackColor = PELIGRO;
                boton.ForeColor = BLANCO;
                boton.FlatAppearance.BorderSize = 0;
                boton.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(143, 28, 19);
            }
            else
            {
                boton.BackColor =
                    Color.FromArgb(229, 231, 235);
                boton.ForeColor = TEXTO;
                boton.FlatAppearance.BorderSize = 0;
                boton.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(209, 213, 219);
            }

            return boton;
        }
    }
}
