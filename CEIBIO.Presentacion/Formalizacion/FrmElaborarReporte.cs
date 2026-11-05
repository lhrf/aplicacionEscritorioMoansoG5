
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

        private DataGridView dgvAtenciones;
        private RichTextBox rtbVistaPrevia;
        private TextBox txtEstado;

        private Button btnCerrar;
        private Button btnGenerar;
        private Button btnEnviarEntrega;
        private Button btnEnviarAutorizacion;
        private Button btnImprimirDefinitivo;
        private Button btnGuardarDefinitivo;
        private Button btnEnviarRevision;
        private Button btnImprimirBorrador;

        public FrmElaborarReporte()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // FORMULARIO
            Text = "Elaborar Reporte clínico";
            ClientSize = new Size(1260, 650);
            BackColor = FONDO;
            Font = new Font("Segoe UI", 10);

            // ENCABEZADO
            Panel pnlEncabezado = new Panel
            {
                Name = "pnlEncabezado",
                Dock = DockStyle.Top,
                Height = 56,
                BackColor = AZUL,
                BorderStyle = BorderStyle.None
            };

            Label lblTitulo = new Label
            {
                Name = "lblTitulo",
                Text = "Elaborar Reporte clínico",
                AutoSize = true,
                Location = new Point(20, 14),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = BLANCO,
                BackColor = Color.Transparent
            };

            Label lblCodigo = new Label
            {
                Name = "lblCodigo",
                Text = "CU-49",
                AutoSize = true,
                Location = new Point(1199, 20),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(191, 215, 238),
                BackColor = Color.Transparent
            };

            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblCodigo);
            Controls.Add(pnlEncabezado);

            // BARRA DE BOTONES
            FlowLayoutPanel flpBotones = new FlowLayoutPanel
            {
                Name = "flpBotones",
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = BLANCO,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(10, 12, 10, 12),
                WrapContents = false
            };

            btnCerrar = CrearBoton(
                "btnCerrar", "Cerrar", 130, "neu");

            btnGenerar = CrearBoton(
                "btnGenerar", "Generar", 130, "pri");

            btnEnviarEntrega = CrearBoton(
                "btnEnviarEntrega", "A entrega", 130, "sec");

            btnEnviarAutorizacion = CrearBoton(
                "btnEnviarAutorizacion", "A autorización", 144, "sec");

            btnImprimirDefinitivo = CrearBoton(
                "btnImprimirDefinitivo", "Imprimir final", 144, "sec");

            btnGuardarDefinitivo = CrearBoton(
                "btnGuardarDefinitivo", "Guardar definitivo", 177, "sec");

            btnEnviarRevision = CrearBoton(
                "btnEnviarRevision", "A revisión", 130, "sec");

            btnImprimirBorrador = CrearBoton(
                "btnImprimirBorrador", "Imprimir borrador", 169, "sec");

            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnGenerar);
            flpBotones.Controls.Add(btnEnviarEntrega);
            flpBotones.Controls.Add(btnEnviarAutorizacion);
            flpBotones.Controls.Add(btnImprimirDefinitivo);
            flpBotones.Controls.Add(btnGuardarDefinitivo);
            flpBotones.Controls.Add(btnEnviarRevision);
            flpBotones.Controls.Add(btnImprimirBorrador);

            Controls.Add(flpBotones);

            // GRUPO: ATENCIONES
            GroupBox grpAtenciones = new GroupBox
            {
                Name = "grpAtenciones",
                Text = "Atenciones",
                Location = new Point(20, 70),
                Size = new Size(411, 510),
                BackColor = BLANCO,
                ForeColor = AZUL,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Padding = new Padding(10, 8, 10, 10)
            };

            dgvAtenciones = new DataGridView
            {
                Name = "dgvAtenciones",
                Dock = DockStyle.Fill,
                BackgroundColor = BLANCO,
                BorderStyle = BorderStyle.None,
                GridColor = LINEA,
                EnableHeadersVisualStyles = false,
                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersHeight = 34,
                RowHeadersVisible = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill
            };

            dgvAtenciones.RowTemplate.Height = 28;

            dgvAtenciones.ColumnHeadersDefaultCellStyle.BackColor = AZUL;
            dgvAtenciones.ColumnHeadersDefaultCellStyle.ForeColor = BLANCO;
            dgvAtenciones.ColumnHeadersDefaultCellStyle.SelectionBackColor = AZUL;
            dgvAtenciones.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvAtenciones.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
            dgvAtenciones.DefaultCellStyle.ForeColor = TEXTO;
            dgvAtenciones.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(227, 236, 246);
            dgvAtenciones.DefaultCellStyle.SelectionForeColor = TEXTO;
            dgvAtenciones.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(247, 249, 252);

            dgvAtenciones.Columns.Add(
                "colNAtencion", "N.° atención");
            dgvAtenciones.Columns.Add(
                "colPaciente", "Paciente");
            dgvAtenciones.Columns.Add(
                "colEstado", "Estado");

            grpAtenciones.Controls.Add(dgvAtenciones);
            Controls.Add(grpAtenciones);

            // GRUPO: VISTA PREVIA
            GroupBox grpVistaPrevia = new GroupBox
            {
                Name = "grpVistaPreviaDelReporteClinico",
                Text = "Vista previa del Reporte clínico",
                Location = new Point(441, 70),
                Size = new Size(798, 418),
                BackColor = BLANCO,
                ForeColor = AZUL,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Padding = new Padding(3)
            };

            Label lblVistaPrevia = new Label
            {
                Name = "lblVistaPrevia",
                Text = "Vista previa",
                Location = new Point(15, 35),
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = Color.Transparent
            };

            rtbVistaPrevia = new RichTextBox
            {
                Name = "rtbVistaPrevia",
                Location = new Point(157, 32),
                Size = new Size(560, 330),
                ReadOnly = true,
                BackColor = BLANCO,
                BorderStyle = BorderStyle.FixedSingle,
                ScrollBars = RichTextBoxScrollBars.Vertical,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO
            };

            Label lblEstado = new Label
            {
                Name = "lblEstado",
                Text = "Estado / versión",
                Location = new Point(15, 375),
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                BackColor = Color.Transparent
            };

            txtEstado = new TextBox
            {
                Name = "txtEstado",
                Location = new Point(157, 372),
                Size = new Size(200, 27),
                ReadOnly = true,
                BackColor = RO,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10),
                ForeColor = TEXTO,
                TabStop = false
            };

            grpVistaPrevia.Controls.Add(lblVistaPrevia);
            grpVistaPrevia.Controls.Add(rtbVistaPrevia);
            grpVistaPrevia.Controls.Add(lblEstado);
            grpVistaPrevia.Controls.Add(txtEstado);

            Controls.Add(grpVistaPrevia);

            // BOTONES PREDETERMINADOS DEL FORMULARIO
            AcceptButton = btnGenerar;
            CancelButton = btnCerrar;

            // CERRAR VENTANA
            btnCerrar.Click += (s, e) => Close();

            ResumeLayout(false);
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
