
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

        private DataGridView dgvReportes;
        private DataGridView dgvValidaciones;
        private TextBox txtMotivo;

        private Button btnCerrar;
        private Button btnAutorizar;
        private Button btnAnular;
        private Button btnDevolver;

        public FrmAutorizarReporte()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // CONFIGURACIÓN GENERAL
            Text = "Autorizar Reporte clínico";
            ClientSize = new Size(1000, 730);
            BackColor = FONDO;
            Font = new Font("Segoe UI", 10);
            StartPosition = FormStartPosition.CenterScreen;

            // ENCABEZADO
            Panel pnlEncabezado = new Panel
            {
                Name = "pnlEncabezado",
                Location = new Point(0, 0),
                Size = new Size(1000, 56),
                BackColor = AZUL
            };

            Label lblTitulo = new Label
            {
                Name = "lblTitulo",
                Text = "Autorizar Reporte clínico",
                Location = new Point(20, 14),
                AutoSize = true,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = BLANCO,
                BackColor = Color.Transparent
            };

            Label lblCodigo = new Label
            {
                Name = "lblCodigo",
                Text = "CU-51",
                Location = new Point(930, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(191, 215, 238),
                BackColor = Color.Transparent
            };

            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblCodigo);
            Controls.Add(pnlEncabezado);

            // REPORTES PENDIENTES DE AUTORIZACIÓN
            GroupBox grpReportes = CrearGrupo(
                "grpReportes",
                "Reportes pendientes de autorización",
                20, 70, 960, 218, true);

            dgvReportes = CrearGrilla("dgvReportes");

            dgvReportes.Columns.Add(
                "colNAtencion", "N.° atención");

            dgvReportes.Columns.Add(
                "colPaciente", "Paciente");

            dgvReportes.Columns.Add(
                "colVersion", "Versión");

            dgvReportes.Columns.Add(
                "colFecha", "Fecha");

            grpReportes.Controls.Add(dgvReportes);
            Controls.Add(grpReportes);

            // ESTADO DE VALIDACIÓN DE CADA RESULTADO
            GroupBox grpValidaciones = CrearGrupo(
                "grpValidaciones",
                "Estado de validación de cada resultado",
                20, 298, 960, 238, true);

            dgvValidaciones = CrearGrilla("dgvValidaciones");

            dgvValidaciones.Columns.Add(
                "colParametro", "Parámetro");

            dgvValidaciones.Columns.Add(
                "colValidado", "Validado");

            dgvValidaciones.Columns.Add(
                "colMedicoPatologo", "Médico Patólogo");

            dgvValidaciones.Columns.Add(
                "colFechaValidacion", "Fecha");

            grpValidaciones.Controls.Add(dgvValidaciones);
            Controls.Add(grpValidaciones);

            // ANULACIÓN
            GroupBox grpAnulacion = CrearGrupo(
                "grpAnulacion",
                "Anulación",
                20, 546, 960, 112, false);

            Label lblMotivo = new Label
            {
                Name = "lblMotivo",
                Text = "Motivo de anulación",
                Location = new Point(15, 35),
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = Color.Transparent
            };

            txtMotivo = new TextBox
            {
                Name = "txtMotivo",
                Location = new Point(182, 32),
                Size = new Size(600, 60),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = BLANCO,
                ForeColor = TEXTO,
                Font = new Font("Segoe UI", 10)
            };

            grpAnulacion.Controls.Add(lblMotivo);
            grpAnulacion.Controls.Add(txtMotivo);
            Controls.Add(grpAnulacion);

            // BARRA INFERIOR
            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 670),
                Size = new Size(1000, 60),
                BackColor = BLANCO
            };

            btnCerrar = CrearBoton(
                "btnCerrar", "Cerrar", 130, "neu");

            btnAutorizar = CrearBoton(
                "btnAutorizar", "Autorizar", 130, "pri");

            btnAnular = CrearBoton(
                "btnAnular", "Anular autorización", 185, "dan");

            btnDevolver = CrearBoton(
                "btnDevolver", "Devolver al Médico", 177, "dan");

            // POSICIONES FIJAS
            btnCerrar.Location = new Point(850, 12);
            btnAutorizar.Location = new Point(710, 12);
            btnAnular.Location = new Point(515, 12);
            btnDevolver.Location = new Point(328, 12);

            pnlBotones.Controls.Add(btnCerrar);
            pnlBotones.Controls.Add(btnAutorizar);
            pnlBotones.Controls.Add(btnAnular);
            pnlBotones.Controls.Add(btnDevolver);

            Controls.Add(pnlBotones);

            // EVENTOS
            btnCerrar.Click += (s, e) => Close();

            AcceptButton = btnAutorizar;
            CancelButton = btnCerrar;

            ResumeLayout(false);
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
