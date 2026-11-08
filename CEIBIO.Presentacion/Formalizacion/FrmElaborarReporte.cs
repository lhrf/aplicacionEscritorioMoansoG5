
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmElaborarReporte : Form
    {
        private readonly Color AZUL = Color.FromArgb(11, 61, 110);
        private readonly Color BLANCO = Color.White;
        private readonly Color TEXTO = Color.FromArgb(31, 35, 40);
        private readonly Color FONDO = Color.FromArgb(244, 246, 249);
        private readonly Color RO = Color.FromArgb(233, 238, 243);
        private readonly Color LINEA = Color.FromArgb(214, 221, 230);

        public FrmElaborarReporte()
        {
            InitializeComponent();
            this.btnCerrar.Click += (sender, args) => this.Close();

        }



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
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                TabStop = true
            };

            switch (estilo)
            {
                case "pri":
                    boton.BackColor = AZUL;
                    boton.ForeColor = BLANCO;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.FlatAppearance.MouseOverBackColor =
                        Color.FromArgb(20, 82, 140);
                    break;

                case "sec":
                    boton.BackColor = BLANCO;
                    boton.ForeColor = AZUL;
                    boton.FlatAppearance.BorderSize = 1;
                    boton.FlatAppearance.BorderColor = AZUL;
                    boton.FlatAppearance.MouseOverBackColor =
                        Color.FromArgb(227, 236, 246);
                    break;

                case "neu":
                    boton.BackColor =
                        Color.FromArgb(229, 231, 235);
                    boton.ForeColor = TEXTO;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.FlatAppearance.MouseOverBackColor =
                        Color.FromArgb(209, 213, 219);
                    break;
            }

            return boton;
        }
    }
}
