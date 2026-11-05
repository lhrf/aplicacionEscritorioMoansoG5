
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

        private TextBox txtBuscar;
        private TextBox txtNombre;
        private TextBox txtFormato;

        private DataGridView dgvRegistros;
        private CheckedListBox clbExamenes;

        private Button btnBuscar;
        private Button btnExaminar;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnInhabilitar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnCerrar;

        public FrmMantPlantillas()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // CONFIGURACIÓN DEL FORMULARIO
            Text = "Mantenedor de plantillas de Reporte clínico";
            ClientSize = new Size(1000, 620);
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
                Text = "Mantenedor de plantillas de Reporte clínico",
                Location = new Point(20, 14),
                AutoSize = true,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = BLANCO,
                BackColor = Color.Transparent
            };

            Label lblCodigo = new Label
            {
                Name = "lblCodigo",
                Text = "CU-53",
                Location = new Point(930, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(191, 215, 238),
                BackColor = Color.Transparent
            };

            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblCodigo);
            Controls.Add(pnlEncabezado);

            // BÚSQUEDA
            GroupBox grpBusqueda = CrearGrupo(
                "grpBusqueda", "Búsqueda",
                20, 70, 960, 78);

            Label lblBuscar = CrearEtiqueta(
                "lblBuscar", "Buscar", 15, 35);

            txtBuscar = CrearTexto(
                "txtBuscar", 125, 32, 300, 27);

            btnBuscar = CrearBoton(
                "btnBuscar", "Buscar", 110, "sec");

            btnBuscar.Location = new Point(435, 28);
            btnBuscar.Size = new Size(110, 34);

            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(btnBuscar);
            Controls.Add(grpBusqueda);

            // REGISTROS
            GroupBox grpRegistros = CrearGrupo(
                "grpRegistros", "Registros",
                20, 158, 960, 238);

            grpRegistros.Padding = new Padding(10, 8, 10, 10);

            dgvRegistros = CrearGrilla("dgvRegistros");

            dgvRegistros.Columns.Add(
                "colNombre", "Nombre");

            dgvRegistros.Columns.Add(
                "colFormato", "Formato");

            dgvRegistros.Columns.Add(
                "colExamenes", "Exámenes");

            dgvRegistros.Columns.Add(
                "colEstado", "Estado");

            dgvRegistros.Columns["colNombre"].FillWeight = 115;
            dgvRegistros.Columns["colFormato"].FillWeight = 115;
            dgvRegistros.Columns["colExamenes"].FillWeight = 125;
            dgvRegistros.Columns["colEstado"].FillWeight = 85;

            grpRegistros.Controls.Add(dgvRegistros);
            Controls.Add(grpRegistros);

            // DATOS
            GroupBox grpDatos = CrearGrupo(
                "grpDatos", "Datos",
                20, 406, 960, 144);

            Label lblNombre = CrearEtiqueta(
                "lblNombre", "Nombre *", 15, 35);

            txtNombre = CrearTexto(
                "txtNombre", 182, 32, 280, 27);

            Label lblFormato = CrearEtiqueta(
                "lblFormato", "Formato (archivo) *",
                15, 73);

            txtFormato = CrearTexto(
                "txtFormato", 182, 70, 163, 27);

            btnExaminar = CrearBoton(
                "btnExaminar", "Examinar", 110, "sec");

            btnExaminar.Location = new Point(355, 66);
            btnExaminar.Size = new Size(110, 34);

            Label lblExamenes = CrearEtiqueta(
                "lblExamenes", "Exámenes asociados",
                495, 35);

            clbExamenes = new CheckedListBox
            {
                Name = "clbExamenes",
                Location = new Point(654, 32),
                Size = new Size(280, 92),
                Font = new Font("Segoe UI", 10),
                BackColor = BLANCO,
                ForeColor = TEXTO,
                BorderStyle = BorderStyle.FixedSingle,
                CheckOnClick = true
            };

            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblFormato);
            grpDatos.Controls.Add(txtFormato);
            grpDatos.Controls.Add(btnExaminar);
            grpDatos.Controls.Add(lblExamenes);
            grpDatos.Controls.Add(clbExamenes);

            Controls.Add(grpDatos);

            // BARRA INFERIOR
            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 560),
                Size = new Size(1000, 60),
                BackColor = BLANCO
            };

            btnCerrar = CrearBoton(
                "btnCerrar", "Cerrar", 130, "neu");

            btnCancelar = CrearBoton(
                "btnCancelar", "Cancelar", 130, "neu");

            btnGuardar = CrearBoton(
                "btnGuardar", "Guardar", 130, "pri");

            btnInhabilitar = CrearBoton(
                "btnInhabilitar", "Inhabilitar", 130, "dan");

            btnEditar = CrearBoton(
                "btnEditar", "Editar", 130, "sec");

            btnNuevo = CrearBoton(
                "btnNuevo", "Nuevo", 130, "sec");

            // POSICIONES FIJAS, SIN SUPERPOSICIÓN
            btnCerrar.Location = new Point(860, 12);
            btnCancelar.Location = new Point(720, 12);
            btnGuardar.Location = new Point(580, 12);
            btnInhabilitar.Location = new Point(440, 12);
            btnEditar.Location = new Point(300, 12);
            btnNuevo.Location = new Point(160, 12);

            pnlBotones.Controls.Add(btnCerrar);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnInhabilitar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnNuevo);

            Controls.Add(pnlBotones);

            // EVENTOS
            btnCerrar.Click += (s, e) => Close();

            btnExaminar.Click += (s, e) =>
            {
                using (OpenFileDialog dialogo = new OpenFileDialog())
                {
                    dialogo.Title = "Seleccionar plantilla";
                    dialogo.Filter =
                        "Todos los archivos (*.*)|*.*";

                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        txtFormato.Text = dialogo.FileName;
                    }
                }
            };

            CancelButton = btnCerrar;

            ResumeLayout(false);
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
