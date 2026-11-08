
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    // CU-46: Validar resultados clínicos
    public partial class FrmValidarResultados : Form
    {
        private TextBox txtPaciente;
        private TextBox txtSexo;
        private TextBox txtEdad;
        private TextBox txtNumeroAtencion;

        private DataGridView dgvResultados;
        private DataGridView dgvAnteriores;

        private Button btnValidar;
        private Button btnRetener;
        private Button btnCerrar;

        private readonly Color azul = Color.FromArgb(11, 61, 110);
        private readonly Color fondo = Color.FromArgb(244, 246, 249);
        private readonly Color rojo = Color.FromArgb(180, 35, 24);

        public FrmValidarResultados()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            Text = "Validar resultados clínicos";
            ClientSize = new Size(1000, 700);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = fondo;
            Font = new Font("Segoe UI", 10);
            AutoScroll = true;

            // CABECERA
            Panel cabecera = new Panel
            {
                Name = "pnlCabecera",
                Location = new Point(0, 0),
                Size = new Size(1000, 56),
                BackColor = azul
            };

            Label titulo = new Label
            {
                Name = "lblTitulo",
                Text = "Validar resultados clínicos",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 17, FontStyle.Bold),
                Location = new Point(20, 12),
                AutoSize = true
            };

            Label codigo = new Label
            {
                Name = "lblCodigoCU",
                Text = "",
                ForeColor = Color.LightBlue,
                Location = new Point(900, 20),
                AutoSize = true
            };

            cabecera.Controls.Add(titulo);
            cabecera.Controls.Add(codigo);
            Controls.Add(cabecera);

            // DATOS DEL PACIENTE
            GroupBox grpPaciente = CrearGrupo(
                "grpPaciente", "Paciente",
                20, 70, 960, 116);

            CrearEtiqueta(grpPaciente, "lblPaciente",
                "Paciente", 15, 35);

            txtPaciente = CrearTexto(
                grpPaciente, "txtPaciente",
                125, 32, 300, true);

            CrearEtiqueta(grpPaciente, "lblSexo",
                "Sexo", 15, 73);

            txtSexo = CrearTexto(
                grpPaciente, "txtSexo",
                125, 70, 100, true);

            CrearEtiqueta(grpPaciente, "lblEdad",
                "Edad", 495, 35);

            txtEdad = CrearTexto(
                grpPaciente, "txtEdad",
                629, 32, 80, true);

            CrearEtiqueta(grpPaciente, "lblNumeroAtencion",
                "N.° de atención", 495, 73);

            txtNumeroAtencion = CrearTexto(
                grpPaciente, "txtNumeroAtencion",
                629, 70, 120, true);

            // RESULTADOS A VALIDAR
            GroupBox grpResultados = CrearGrupo(
                "grpResultados", "Resultados a validar",
                20, 196, 960, 268);

            dgvResultados = CrearTabla(
                grpResultados, "dgvResultados",
                new string[]
                {
                    "Examen",
                    "Parámetro",
                    "Valor",
                    "Unidad",
                    "Intervalo de referencia",
                    "Fuera de rango",
                    "Estado"
                });

            // ANCHOS PARA LOS ENCABEZADOS LARGOS
            dgvResultados.Columns[0].FillWeight = 90;
            dgvResultados.Columns[1].FillWeight = 110;
            dgvResultados.Columns[2].FillWeight = 75;
            dgvResultados.Columns[3].FillWeight = 85;
            dgvResultados.Columns[4].FillWeight = 150;
            dgvResultados.Columns[5].FillWeight = 115;
            dgvResultados.Columns[6].FillWeight = 85;

            // RESULTADOS ANTERIORES
            GroupBox grpAnteriores = CrearGrupo(
                "grpAnteriores",
                "Resultados anteriores del paciente",
                20, 474, 960, 148);

            dgvAnteriores = CrearTabla(
                grpAnteriores, "dgvAnteriores",
                new string[]
                {
                    "Fecha",
                    "Parámetro",
                    "Valor"
                });

            // BARRA INFERIOR
            Panel barra = new Panel
            {
                Name = "pnlAcciones",
                Location = new Point(0, 640),
                Size = new Size(1000, 60),
                BackColor = Color.White
            };

            btnCerrar = CrearBoton(
                "btnCerrar", "Cerrar",
                850, 12, 130,
                Color.FromArgb(229, 231, 235),
                Color.Black);

            btnValidar = CrearBoton(
                "btnValidar", "Validar",
                710, 12, 130,
                azul, Color.White);

            btnRetener = CrearBoton(
                "btnRetener", "Retener y repetir",
                531, 12, 169,
                rojo, Color.White);

            btnCerrar.Click += BtnCerrar_Click;
            btnValidar.Click += BtnValidar_Click;
            btnRetener.Click += BtnRetener_Click;

            barra.Controls.Add(btnCerrar);
            barra.Controls.Add(btnValidar);
            barra.Controls.Add(btnRetener);

            Controls.Add(barra);

            ResumeLayout(false);
        }

        // CREAR GRUPOS
        private GroupBox CrearGrupo(
            string nombre, string titulo,
            int x, int y, int ancho, int alto)
        {
            GroupBox grupo = new GroupBox
            {
                Name = nombre,
                Text = titulo,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                BackColor = Color.White,
                ForeColor = azul,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            Controls.Add(grupo);
            return grupo;
        }

        // CREAR ETIQUETAS
        private void CrearEtiqueta(
            Control padre, string nombre,
            string texto, int x, int y)
        {
            Label etiqueta = new Label
            {
                Name = nombre,
                Text = texto,
                Location = new Point(x, y),
                AutoSize = true,
                ForeColor = Color.FromArgb(31, 35, 40),
                Font = new Font("Segoe UI", 10)
            };

            padre.Controls.Add(etiqueta);
        }

        // CREAR CUADROS DE TEXTO
        private TextBox CrearTexto(
            Control padre, string nombre,
            int x, int y, int ancho, bool lectura)
        {
            TextBox caja = new TextBox
            {
                Name = nombre,
                Location = new Point(x, y),
                Size = new Size(ancho, 27),
                ReadOnly = lectura,
                BackColor = lectura
                    ? Color.FromArgb(233, 238, 243)
                    : Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            padre.Controls.Add(caja);
            return caja;
        }

        // CREAR TABLAS
        private DataGridView CrearTabla(
            Control padre, string nombre,
            string[] columnas)
        {
            DataGridView tabla = new DataGridView
            {
                Name = nombre,
                Location = new Point(12, 30),
                Size = new Size(
                    padre.Width - 24,
                    padre.Height - 42),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                EnableHeadersVisualStyles = false,

                // CORRECCIÓN DE ENCABEZADOS
                ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode
                    .DisableResizing,

                ColumnHeadersHeight = 60
            };

            tabla.ColumnHeadersDefaultCellStyle.BackColor = azul;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                azul;

            tabla.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            tabla.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            tabla.RowTemplate.Height = 30;

            tabla.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(227, 236, 246);

            tabla.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            foreach (string columna in columnas)
            {
                tabla.Columns.Add(columna, columna);
            }

            foreach (DataGridViewColumn columna in tabla.Columns)
            {
                columna.HeaderCell.Style.WrapMode =
                    DataGridViewTriState.True;

                columna.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            padre.Controls.Add(tabla);
            return tabla;
        }

        // CREAR BOTONES
        private Button CrearBoton(
            string nombre, string texto,
            int x, int y, int ancho,
            Color colorFondo, Color colorTexto)
        {
            Button boton = new Button
            {
                Name = nombre,
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, 36),
                BackColor = colorFondo,
                ForeColor = colorTexto,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            boton.FlatAppearance.BorderSize = 0;

            return boton;
        }

        // EVENTOS DE LOS BOTONES
        private void BtnCerrar_Click(
            object sender, EventArgs e)
        {
            Close();
        }

        private void BtnValidar_Click(
            object sender, EventArgs e)
        {
            if (dgvResultados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un resultado para validar.",
                    "CEIBIO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                "La validación debe conectarse con " +
                "la lógica de negocio del sistema.",
                "CEIBIO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnRetener_Click(
            object sender, EventArgs e)
        {
            if (dgvResultados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un resultado para retener.",
                    "CEIBIO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "La retención y repetición debe conectarse " +
                "con la lógica de negocio del sistema.",
                "CEIBIO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
