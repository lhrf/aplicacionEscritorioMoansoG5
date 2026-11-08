
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    // CU-46: Validar resultados clínicos
    public partial class FrmValidarResultados : Form
    {

        private readonly Color azul = Color.FromArgb(11, 61, 110);
        private readonly Color fondo = Color.FromArgb(244, 246, 249);
        private readonly Color rojo = Color.FromArgb(180, 35, 24);

        public FrmValidarResultados()
        {
            InitializeComponent();
            this.btnCerrar.Click += this.BtnCerrar_Click;
            this.btnRetener.Click += this.BtnRetener_Click;
            this.btnValidar.Click += this.BtnValidar_Click;

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
