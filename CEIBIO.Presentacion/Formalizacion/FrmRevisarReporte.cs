
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmRevisarReporte : Form
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
        private DataGridView dgvValidados;
        private RichTextBox rtbReporte;
        private TextBox txtObservaciones;

        private Button btnCerrar;
        private Button btnConformidad;
        private Button btnObservar;

        public FrmRevisarReporte()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // =========================================
            // CONFIGURACIÓN DEL FORMULARIO
            // =========================================

            Text = "Revisar Reporte clínico";
            ClientSize = new Size(1100, 740);
            BackColor = FONDO;
            Font = new Font("Segoe UI", 10);
            StartPosition = FormStartPosition.CenterScreen;

            // =========================================
            // ENCABEZADO
            // =========================================

            Panel pnlEncabezado = new Panel
            {
                Name = "pnlEncabezado",
                Location = new Point(0, 0),
                Size = new Size(1100, 56),
                BackColor = AZUL
            };

            Label lblTitulo = new Label
            {
                Name = "lblTitulo",
                Text = "Revisar Reporte clínico",
                Location = new Point(20, 14),
                AutoSize = true,
                Font = new Font(
                    "Segoe UI", 14, FontStyle.Bold),
                ForeColor = BLANCO,
                BackColor = Color.Transparent
            };

            Label lblCodigo = new Label
            {
                Name = "lblCodigo",
                Text = "CU-50",
                Location = new Point(1030, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(191, 215, 238),
                BackColor = Color.Transparent
            };

            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblCodigo);
            Controls.Add(pnlEncabezado);

            // =========================================
            // REPORTES EN REVISIÓN DE CALIDAD
            // =========================================

            GroupBox grpReportes = CrearGrupo(
                "grpReportes",
                "Reportes en revisión de calidad",
                20, 70, 1060, 168, true);

            dgvReportes = CrearGrilla("dgvReportes");

            dgvReportes.Columns.Add(
                "colNAtencion", "N.° atención");

            dgvReportes.Columns.Add(
                "colPaciente", "Paciente");

            dgvReportes.Columns.Add(
                "colVersion", "Versión");

            dgvReportes.Columns.Add(
                "colDigitador", "Digitador");

            grpReportes.Controls.Add(dgvReportes);
            Controls.Add(grpReportes);

            // =========================================
            // REPORTE CLÍNICO
            // =========================================

            GroupBox grpReporteClinico = CrearGrupo(
                "grpReporteClinico",
                "Reporte clínico",
                20, 248, 525, 270, false);

            Label lblReporte = CrearEtiqueta(
                "lblReporte",
                "Reporte",
                15, 35);

            rtbReporte = new RichTextBox
            {
                Name = "rtbReporte",
                Location = new Point(125, 32),
                Size = new Size(385, 220),
                ReadOnly = true,
                BackColor = BLANCO,
                BorderStyle = BorderStyle.FixedSingle,
                ScrollBars = RichTextBoxScrollBars.Vertical,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                TabStop = false
            };

            grpReporteClinico.Controls.Add(lblReporte);
            grpReporteClinico.Controls.Add(rtbReporte);
            Controls.Add(grpReporteClinico);

            // =========================================
            // RESULTADOS VALIDADOS
            // =========================================

            GroupBox grpValidados = CrearGrupo(
                "grpValidados",
                "Resultados validados",
                555, 248, 525, 298, true);

            dgvValidados = CrearGrilla("dgvValidados");

            dgvValidados.Columns.Add(
                "colParametro", "Parámetro");

            dgvValidados.Columns.Add(
                "colValor", "Valor");

            dgvValidados.Columns.Add(
                "colUnidad", "Unidad");

            grpValidados.Controls.Add(dgvValidados);
            Controls.Add(grpValidados);

            // =========================================
            // OBSERVACIONES
            // =========================================

            GroupBox grpObservaciones = CrearGrupo(
                "grpObservaciones",
                "Observaciones",
                20, 556, 1060, 112, false);

            Label lblObservaciones = CrearEtiqueta(
                "lblObservaciones",
                "Observaciones",
                15, 35);

            txtObservaciones = new TextBox
            {
                Name = "txtObservaciones",
                Location = new Point(132, 32),
                Size = new Size(700, 60),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = BLANCO,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO
            };

            grpObservaciones.Controls.Add(lblObservaciones);
            grpObservaciones.Controls.Add(txtObservaciones);
            Controls.Add(grpObservaciones);

            // =========================================
            // BARRA INFERIOR
            // =========================================

            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 680),
                Size = new Size(1100, 60),
                BackColor = BLANCO
            };

            // BOTÓN CERRAR
            btnCerrar = CrearBoton(
                "btnCerrar",
                "Cerrar",
                130,
                "neu");

            btnCerrar.Location = new Point(950, 12);

            // BOTÓN DAR CONFORMIDAD
            btnConformidad = CrearBoton(
                "btnConformidad",
                "Dar conformidad",
                180,
                "pri");

            btnConformidad.Location =
                new Point(760, 12);

            // BOTÓN OBSERVAR
            btnObservar = CrearBoton(
                "btnObservar",
                "Observar",
                130,
                "dan");

            btnObservar.Location =
                new Point(620, 12);

            pnlBotones.Controls.Add(btnCerrar);
            pnlBotones.Controls.Add(btnConformidad);
            pnlBotones.Controls.Add(btnObservar);

            Controls.Add(pnlBotones);

            // =========================================
            // EVENTOS
            // =========================================

            btnCerrar.Click += (s, e) => Close();

            AcceptButton = btnConformidad;
            CancelButton = btnCerrar;

            ResumeLayout(false);
        }

        // =========================================
        // MÉTODO PARA CREAR GROUPBOX
        // =========================================

        private GroupBox CrearGrupo(
            string nombre,
            string titulo,
            int x,
            int y,
            int ancho,
            int alto,
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

        // =========================================
        // MÉTODO PARA CREAR LABEL
        // =========================================

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

        // =========================================
        // MÉTODO PARA CREAR DATAGRIDVIEW
        // =========================================

        private DataGridView CrearGrilla(string nombre)
        {
            DataGridView dgv = new DataGridView
            {
                Name = nombre,
                Dock = DockStyle.Fill,
                BackgroundColor = BLANCO,
                BorderStyle = BorderStyle.None,

                GridColor =
                    Color.FromArgb(208, 215, 222),

                EnableHeadersVisualStyles = false,

                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode
                    .DisableResizing,

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

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                AZUL;

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                BLANCO;

            dgv.ColumnHeadersDefaultCellStyle
                .SelectionBackColor = AZUL;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.DefaultCellStyle.ForeColor =
                TEXTO;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(207, 226, 243);

            dgv.DefaultCellStyle.SelectionForeColor =
                TEXTO;

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 246, 250);

            return dgv;
        }

        // =========================================
        // MÉTODO PARA CREAR BOTONES
        // =========================================

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

                TextAlign =
                    ContentAlignment.MiddleCenter,

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
