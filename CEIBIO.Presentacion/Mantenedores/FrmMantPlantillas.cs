
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantPlantillas : Form
    {
        private readonly Color AZUL = Color.FromArgb(11, 61, 110);
        private readonly Color BLANCO = Color.White;
        private readonly Color TEXTO = Color.FromArgb(31, 35, 40);
        private readonly Color FONDO = Color.FromArgb(244, 246, 249);
        private readonly Color PELIGRO = Color.FromArgb(180, 35, 24);

        public FrmMantPlantillas()
        {
            InitializeComponent();
            this.btnCerrar.Click += (sender, args) => this.Close();

        }



        // CREAR GROUPBOX
        private GroupBox CrearGrupo(
            string nombre,
            string titulo,
            int x, int y,
            int ancho, int alto)
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

        // CREAR ETIQUETAS
        private Label CrearEtiqueta(
            string nombre,
            string texto,
            int x, int y)
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
            int x, int y,
            int ancho, int alto)
        {
            return new TextBox
            {
                Name = nombre,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = BLANCO,
                BorderStyle = BorderStyle.FixedSingle
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

                ColumnHeadersHeight = 45,
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

            dgv.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            dgv.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

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
                TabStop = true
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
            else if (estilo == "sec")
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
