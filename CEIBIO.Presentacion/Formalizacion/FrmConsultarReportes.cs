
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    public partial class FrmConsultarReportes : Form
    {
        private readonly Color AZUL =
            Color.FromArgb(11, 61, 110);

        private readonly Color BLANCO = Color.White;

        private readonly Color TEXTO =
            Color.FromArgb(31, 35, 40);

        private readonly Color FONDO =
            Color.FromArgb(244, 246, 249);

        private DataGridView dgvReportes;
        private TextBox txtDni;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private ComboBox cboEstado;

        private Button btnBuscar;
        private Button btnReimprimir;
        private Button btnCerrar;

        public FrmConsultarReportes()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // ======================================
            // CONFIGURACIÓN DEL FORMULARIO
            // ======================================

            Text = "Consultar Reportes clínicos";
            ClientSize = new Size(1000, 650);
            BackColor = FONDO;
            Font = new Font("Segoe UI", 10);
            StartPosition = FormStartPosition.CenterScreen;

            // ======================================
            // ENCABEZADO
            // ======================================

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
                Text = "Consultar Reportes clínicos",
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
                Text = "",
                Location = new Point(930, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(191, 215, 238),
                BackColor = Color.Transparent
            };

            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblCodigo);
            Controls.Add(pnlEncabezado);

            // ======================================
            // FILTROS
            // ======================================

            GroupBox grpFiltros = CrearGrupo(
                "grpFiltros",
                "Filtros",
                20, 70, 960, 116);

            Label lblDni = CrearEtiqueta(
                "lblDni", "DNI", 15, 35);

            txtDni = new TextBox
            {
                Name = "txtDni",
                Location = new Point(132, 32),
                Size = new Size(120, 27),
                MaxLength = 8,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = BLANCO,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblFechaInicio = CrearEtiqueta(
                "lblFechaInicio",
                "Fecha inicial",
                15, 73);

            dtpFechaInicio = new DateTimePicker
            {
                Name = "dtpFechaInicio",
                Location = new Point(132, 70),
                Size = new Size(200, 27),
                Font = new Font("Segoe UI", 10),
                Format = DateTimePickerFormat.Short
            };

            Label lblFechaFin = CrearEtiqueta(
                "lblFechaFin",
                "Fecha final",
                495, 35);

            dtpFechaFin = new DateTimePicker
            {
                Name = "dtpFechaFin",
                Location = new Point(605, 32),
                Size = new Size(200, 27),
                Font = new Font("Segoe UI", 10),
                Format = DateTimePickerFormat.Short
            };

            Label lblEstado = CrearEtiqueta(
                "lblEstado",
                "Estado",
                495, 73);

            cboEstado = new ComboBox
            {
                Name = "cboEstado",
                Location = new Point(605, 70),
                Size = new Size(220, 31),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cboEstado.Items.AddRange(new object[]
            {
                "(Todos)",
                "En revisión de calidad",
                "Observado",
                "Revisado",
                "Pendiente de autorización",
                "Autorizado",
                "Disponible para entrega"
            });

            cboEstado.SelectedIndex = 0;

            btnBuscar = CrearBoton(
                "btnBuscar",
                "Buscar",
                110,
                "sec");

            btnBuscar.Location = new Point(835, 66);
            btnBuscar.Size = new Size(110, 34);

            grpFiltros.Controls.Add(lblDni);
            grpFiltros.Controls.Add(txtDni);

            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Controls.Add(dtpFechaInicio);

            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaFin);

            grpFiltros.Controls.Add(lblEstado);
            grpFiltros.Controls.Add(cboEstado);

            grpFiltros.Controls.Add(btnBuscar);

            Controls.Add(grpFiltros);

            // ======================================
            // REPORTES CLÍNICOS
            // ======================================

            GroupBox grpReportes = CrearGrupo(
                "grpReportes",
                "Reportes clínicos",
                20, 196, 960, 378);

            grpReportes.Padding =
                new Padding(10, 8, 10, 10);

            dgvReportes = new DataGridView
            {
                Name = "dgvReportes",
                Dock = DockStyle.Fill,

                BackgroundColor = BLANCO,
                BorderStyle = BorderStyle.None,

                GridColor =
                    Color.FromArgb(208, 215, 222),

                EnableHeadersVisualStyles = false,

                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode
                    .DisableResizing,

                // MÁS ALTURA PARA TEXTOS LARGOS
                ColumnHeadersHeight = 55,

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

            dgvReportes.RowTemplate.Height = 28;

            // ESTILO DE ENCABEZADOS
            dgvReportes.ColumnHeadersDefaultCellStyle.BackColor =
                AZUL;

            dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor =
                BLANCO;

            dgvReportes.ColumnHeadersDefaultCellStyle
                .SelectionBackColor = AZUL;

            dgvReportes.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI", 10, FontStyle.Bold);

            // PERMITIR DOS LÍNEAS
            dgvReportes.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            dgvReportes.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // ESTILO DE FILAS
            dgvReportes.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvReportes.DefaultCellStyle.ForeColor =
                TEXTO;

            dgvReportes.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(207, 226, 243);

            dgvReportes.DefaultCellStyle.SelectionForeColor =
                TEXTO;

            dgvReportes.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 246, 250);

            // COLUMNAS
            dgvReportes.Columns.Add(
                "colNAtencion",
                "N.° atención");

            dgvReportes.Columns.Add(
                "colPaciente",
                "Paciente");

            dgvReportes.Columns.Add(
                "colExamenes",
                "Exámenes");

            dgvReportes.Columns.Add(
                "colEstado",
                "Estado");

            dgvReportes.Columns.Add(
                "colFechaAutorizacion",
                "Fecha de autorización");

            // MÁS ESPACIO PARA LA ÚLTIMA COLUMNA
            dgvReportes.Columns["colNAtencion"].FillWeight = 90;
            dgvReportes.Columns["colPaciente"].FillWeight = 110;
            dgvReportes.Columns["colExamenes"].FillWeight = 110;
            dgvReportes.Columns["colEstado"].FillWeight = 100;
            dgvReportes.Columns["colFechaAutorizacion"].FillWeight = 145;

            // EVITAR RECORTES DE ENCABEZADOS
            foreach (DataGridViewColumn columna in
                dgvReportes.Columns)
            {
                columna.HeaderCell.Style.WrapMode =
                    DataGridViewTriState.True;

                columna.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

                columna.SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }

            grpReportes.Controls.Add(dgvReportes);
            Controls.Add(grpReportes);

            // ======================================
            // BARRA INFERIOR
            // ======================================

            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 590),
                Size = new Size(1000, 60),
                BackColor = BLANCO
            };

            btnCerrar = CrearBoton(
                "btnCerrar",
                "Cerrar",
                130,
                "neu");

            btnReimprimir = CrearBoton(
                "btnReimprimir",
                "Reimprimir",
                130,
                "sec");

            btnCerrar.Location =
                new Point(850, 12);

            btnReimprimir.Location =
                new Point(710, 12);

            pnlBotones.Controls.Add(btnCerrar);
            pnlBotones.Controls.Add(btnReimprimir);

            Controls.Add(pnlBotones);

            // ======================================
            // EVENTOS
            // ======================================

            btnCerrar.Click += (s, e) => Close();

            AcceptButton = btnBuscar;
            CancelButton = btnCerrar;

            ResumeLayout(false);
        }

        // ======================================
        // CREAR GROUPBOX
        // ======================================

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

        // ======================================
        // CREAR LABEL
        // ======================================

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

        // ======================================
        // CREAR BOTONES
        // ======================================

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
