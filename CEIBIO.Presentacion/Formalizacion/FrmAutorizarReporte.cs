
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmAutorizarReporte : Form
    {
        private readonly Color AZUL =
            Color.FromArgb(11, 61, 110);

        private readonly Color BLANCO = Color.White;

        private readonly Color TEXTO =
            Color.FromArgb(31, 35, 40);

        private readonly Color FONDO =
            Color.FromArgb(244, 246, 249);

        private readonly Color PELIGRO =
            Color.FromArgb(180, 35, 24);

        public FrmAutorizarReporte()
        {
            InitializeComponent();
            this.btnCerrar.Click += (sender, args) => this.Close();

        }



        // CREAR GROUPBOX
        private GroupBox CrearGrupo(
            string nombre,
            string titulo,
            int x, int y,
            int ancho, int alto,
            bool contieneGrilla)
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
                    "Segoe UI", 10, FontStyle.Bold),
                Padding = contieneGrilla
                    ? new Padding(10, 8, 10, 10)
                    : new Padding(3)
            };
        }

        // CREAR DATAGRIDVIEW
        private DataGridView CrearGrilla(string nombre)
        {
            DataGridView dgv = new DataGridView
            {
                Name = nombre,
                Dock = DockStyle.Fill,
                BackgroundColor = BLANCO,
                BorderStyle = BorderStyle.None,
                GridColor = Color.FromArgb(208, 215, 222),
                EnableHeadersVisualStyles = false,

                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing,

                ColumnHeadersHeight = 34,
                RowHeadersVisible = false,
                ReadOnly = true,

                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,

                MultiSelect = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,

                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill
            };

            dgv.RowTemplate.Height = 28;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = AZUL;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = BLANCO;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = AZUL;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.DefaultCellStyle.ForeColor = TEXTO;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(207, 226, 243);

            dgv.DefaultCellStyle.SelectionForeColor = TEXTO;

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 246, 250);

            return dgv;
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
                TabStop = true,
                Margin = new Padding(0)
            };

            if (estilo == "pri")
            {
                boton.BackColor = AZUL;
                boton.ForeColor = BLANCO;
                boton.FlatAppearance.BorderSize = 0;
                boton.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(20, 90, 158);
            }
            else if (estilo == "dan")
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
