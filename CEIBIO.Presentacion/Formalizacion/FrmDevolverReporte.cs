
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

        public FrmDevolverReporte()
        {
            InitializeComponent();
            this.btnCancelar.Click += (sender, args) => this.Close();

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
