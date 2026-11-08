
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

        private TextBox txtNumeroAtencion;
        private DataGridView dgvHistorial;

        private Button btnBuscar;
        private Button btnCerrar;

        public FrmHistorialRevisiones()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // CONFIGURACIÓN DEL FORMULARIO
            Text = "Historial de revisiones del Reporte clínico";
            ClientSize = new Size(1000, 670);
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
                Text = "Historial de revisiones del Reporte clínico",
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

            // GRUPO BÚSQUEDA
            GroupBox grpBusqueda = CrearGrupo(
                "grpBusqueda",
                "Búsqueda",
                20, 70, 960, 78);

            Label lblNumeroAtencion = new Label
            {
                Name = "lblNumeroAtencion",
                Text = "N.° de atención *",
                Location = new Point(15, 35),
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = Color.Transparent
            };

            txtNumeroAtencion = new TextBox
            {
                Name = "txtNumeroAtencion",
                Location = new Point(166, 32),
                Size = new Size(120, 27),
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = BLANCO,
                BorderStyle = BorderStyle.FixedSingle
            };

            btnBuscar = CrearBoton(
                "btnBuscar",
                "Buscar",
                110,
                "sec");

            btnBuscar.Location = new Point(296, 28);
            btnBuscar.Size = new Size(110, 34);

            grpBusqueda.Controls.Add(lblNumeroAtencion);
            grpBusqueda.Controls.Add(txtNumeroAtencion);
            grpBusqueda.Controls.Add(btnBuscar);

            Controls.Add(grpBusqueda);

            // GRUPO HISTORIAL
            GroupBox grpHistorial = CrearGrupo(
                "grpHistorial",
                "Historial del Reporte clínico",
                20, 158, 960, 438);

            grpHistorial.Padding =
                new Padding(10, 8, 10, 10);

            dgvHistorial = new DataGridView
            {
                Name = "dgvHistorial",
                Dock = DockStyle.Fill,
                BackgroundColor = BLANCO,
                BorderStyle = BorderStyle.None,
                GridColor = Color.FromArgb(208, 215, 222),

                EnableHeadersVisualStyles = false,

                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode
                    .DisableResizing,

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

            dgvHistorial.RowTemplate.Height = 28;

            // ESTILO DE ENCABEZADOS
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor =
                AZUL;

            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor =
                BLANCO;

            dgvHistorial.ColumnHeadersDefaultCellStyle
                .SelectionBackColor = AZUL;

            dgvHistorial.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvHistorial.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            dgvHistorial.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // ESTILO DE FILAS
            dgvHistorial.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvHistorial.DefaultCellStyle.ForeColor =
                TEXTO;

            dgvHistorial.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(207, 226, 243);

            dgvHistorial.DefaultCellStyle.SelectionForeColor =
                TEXTO;

            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 246, 250);

            // COLUMNAS DEL DOCUMENTO CEIBIO
            dgvHistorial.Columns.Add(
                "colVersion",
                "Versión");

            dgvHistorial.Columns.Add(
                "colAccion",
                "Acción");

            dgvHistorial.Columns.Add(
                "colObservacion",
                "Observación");

            dgvHistorial.Columns.Add(
                "colResponsable",
                "Responsable");

            dgvHistorial.Columns.Add(
                "colFecha",
                "Fecha");

            // DISTRIBUCIÓN PARA EVITAR RECORTES
            dgvHistorial.Columns["colVersion"].FillWeight = 75;
            dgvHistorial.Columns["colAccion"].FillWeight = 100;
            dgvHistorial.Columns["colObservacion"].FillWeight = 160;
            dgvHistorial.Columns["colResponsable"].FillWeight = 130;
            dgvHistorial.Columns["colFecha"].FillWeight = 100;

            foreach (DataGridViewColumn columna
                in dgvHistorial.Columns)
            {
                columna.HeaderCell.Style.WrapMode =
                    DataGridViewTriState.True;

                columna.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

                columna.SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }

            grpHistorial.Controls.Add(dgvHistorial);
            Controls.Add(grpHistorial);

            // BARRA INFERIOR
            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 610),
                Size = new Size(1000, 60),
                BackColor = BLANCO
            };

            btnCerrar = CrearBoton(
                "btnCerrar",
                "Cerrar",
                130,
                "neu");

            btnCerrar.Location = new Point(850, 12);

            pnlBotones.Controls.Add(btnCerrar);
            Controls.Add(pnlBotones);

            // EVENTOS
            btnCerrar.Click += (s, e) => Close();

            AcceptButton = btnBuscar;
            CancelButton = btnCerrar;

            ResumeLayout(false);
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
