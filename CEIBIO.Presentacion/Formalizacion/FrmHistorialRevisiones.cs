
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmHistorialRevisiones : Form
    {
        private readonly Color AZUL =
            Color.FromArgb(11, 61, 110);

        private readonly Color BLANCO = Color.White;

        private readonly Color TEXTO =
            Color.FromArgb(31, 35, 40);

        private readonly Color FONDO =
            Color.FromArgb(244, 246, 249);

        public FrmHistorialRevisiones()
        {
            InitializeComponent();
            this.btnCerrar.Click += (sender, args) => this.Close();

        }



        // CREAR GROUPBOX
        private GroupBox CrearGrupo(
            string nombre,
            string titulo,
            int x,
            int y,
            int ancho,
            int alto)
        {
            return new GroupBox
            {
                Name = nombre,
                Text = titulo,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                BackColor = BLANCO,
                ForeColor = AZUL,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };
        }

        // CREAR BOTONES
        private Button CrearBoton(
            string nombre,
            string texto,
            int ancho,
            string estilo)
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

            if (estilo == "sec")
            {
                boton.BackColor = BLANCO;
                boton.ForeColor = AZUL;

                boton.FlatAppearance.BorderSize = 1;
                boton.FlatAppearance.BorderColor = AZUL;

                boton.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(238, 244, 251);
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
