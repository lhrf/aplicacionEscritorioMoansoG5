
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Mantenedores
{
    public partial class FrmMantIntervalos : Form
    {
        private readonly Color AZUL = Color.FromArgb(11, 61, 110);
        private readonly Color BLANCO = Color.White;
        private readonly Color TEXTO = Color.FromArgb(31, 35, 40);
        private readonly Color FONDO = Color.FromArgb(244, 246, 249);
        private readonly Color PELIGRO = Color.FromArgb(180, 35, 24);

        private TextBox txtBuscar;
        private TextBox txtReferenciaTexto;
        private DataGridView dgvRegistros;

        private ComboBox cboExamen;
        private ComboBox cboParametro;
        private ComboBox cboSexo;

        private NumericUpDown nudMinimo;
        private NumericUpDown nudMaximo;
        private NumericUpDown nudEdadMinima;
        private NumericUpDown nudEdadMaxima;

        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnInhabilitar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnCerrar;

        public FrmMantIntervalos()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            // CONFIGURACIÓN GENERAL
            Text = "Mantenedor de intervalos biológicos de referencia";
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
                Text = "Mantenedor de intervalos biológicos de referencia",
                Location = new Point(20, 14),
                AutoSize = true,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = BLANCO,
                BackColor = Color.Transparent
            };

            Label lblCodigo = new Label
            {
                Name = "lblCodigo",
                Text = "CU-54",
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

            dgvRegistros.Columns.Add("colParametro", "Parámetro");
            dgvRegistros.Columns.Add("colMinimo", "Mínimo");
            dgvRegistros.Columns.Add("colMaximo", "Máximo");
            dgvRegistros.Columns.Add("colSexo", "Sexo");
            dgvRegistros.Columns.Add("colEdad", "Edad");
            dgvRegistros.Columns.Add("colReferencia", "Referencia");
            dgvRegistros.Columns.Add("colEstado", "Estado");

            // ANCHOS PROPORCIONALES
            dgvRegistros.Columns["colParametro"].FillWeight = 125;
            dgvRegistros.Columns["colMinimo"].FillWeight = 80;
            dgvRegistros.Columns["colMaximo"].FillWeight = 80;
            dgvRegistros.Columns["colSexo"].FillWeight = 80;
            dgvRegistros.Columns["colEdad"].FillWeight = 80;
            dgvRegistros.Columns["colReferencia"].FillWeight = 145;
            dgvRegistros.Columns["colEstado"].FillWeight = 85;

            foreach (DataGridViewColumn columna in dgvRegistros.Columns)
            {
                columna.HeaderCell.Style.WrapMode =
                    DataGridViewTriState.True;

                columna.HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

                columna.SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }

            grpRegistros.Controls.Add(dgvRegistros);
            Controls.Add(grpRegistros);

            // DATOS
            GroupBox grpDatos = CrearGrupo(
                "grpDatos", "Datos",
                20, 406, 960, 192);

            // EXAMEN
            Label lblExamen = CrearEtiqueta(
                "lblExamen", "Examen *", 15, 35);

            cboExamen = CrearCombo(
                "cboExamen", 125, 32, 240);

            // PARÁMETRO
            Label lblParametro = CrearEtiqueta(
                "lblParametro", "Parámetro *", 15, 73);

            cboParametro = CrearCombo(
                "cboParametro", 125, 70, 240);

            // VALOR MÍNIMO
            Label lblMinimo = CrearEtiqueta(
                "lblMinimo", "Valor mínimo", 15, 111);

            nudMinimo = CrearNumero(
                "nudMinimo", 125, 108, 100, true);

            // VALOR MÁXIMO
            Label lblMaximo = CrearEtiqueta(
                "lblMaximo", "Valor máximo", 15, 149);

            nudMaximo = CrearNumero(
                "nudMaximo", 125, 146, 100, true);

            // SEXO
            Label lblSexo = CrearEtiqueta(
                "lblSexo", "Sexo", 495, 35);

            cboSexo = CrearCombo(
                "cboSexo", 662, 32, 150);

            cboSexo.Items.AddRange(new object[]
            {
                "Ambos",
                "Femenino",
                "Masculino"
            });

            // EDAD MÍNIMA
            Label lblEdadMinima = CrearEtiqueta(
                "lblEdadMinima", "Edad mínima", 495, 73);

            nudEdadMinima = CrearNumero(
                "nudEdadMinima", 662, 70, 80, false);

            // EDAD MÁXIMA
            Label lblEdadMaxima = CrearEtiqueta(
                "lblEdadMaxima", "Edad máxima", 495, 111);

            nudEdadMaxima = CrearNumero(
                "nudEdadMaxima", 662, 108, 80, false);

            // REFERENCIA EN TEXTO
            Label lblReferenciaTexto = CrearEtiqueta(
                "lblReferenciaTexto", "Referencia en texto",
                495, 149);

            txtReferenciaTexto = CrearTexto(
                "txtReferenciaTexto", 662, 146, 240, 27);

            grpDatos.Controls.Add(lblExamen);
            grpDatos.Controls.Add(cboExamen);
            grpDatos.Controls.Add(lblParametro);
            grpDatos.Controls.Add(cboParametro);
            grpDatos.Controls.Add(lblMinimo);
            grpDatos.Controls.Add(nudMinimo);
            grpDatos.Controls.Add(lblMaximo);
            grpDatos.Controls.Add(nudMaximo);
            grpDatos.Controls.Add(lblSexo);
            grpDatos.Controls.Add(cboSexo);
            grpDatos.Controls.Add(lblEdadMinima);
            grpDatos.Controls.Add(nudEdadMinima);
            grpDatos.Controls.Add(lblEdadMaxima);
            grpDatos.Controls.Add(nudEdadMaxima);
            grpDatos.Controls.Add(lblReferenciaTexto);
            grpDatos.Controls.Add(txtReferenciaTexto);

            Controls.Add(grpDatos);

            // BARRA INFERIOR
            Panel pnlBotones = new Panel
            {
                Name = "pnlBotones",
                Location = new Point(0, 610),
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

            // POSICIONES FIJAS
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
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
        }

        // CREAR LABEL
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

        // CREAR COMBOBOX
        private ComboBox CrearCombo(
            string nombre,
            int x, int y,
            int ancho)
        {
            return new ComboBox
            {
                Name = nombre,
                Location = new Point(x, y),
                Size = new Size(ancho, 31),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
        }

        // CREAR NUMERICUPDOWN
        private NumericUpDown CrearNumero(
            string nombre,
            int x, int y,
            int ancho,
            bool decimalPermitido)
        {
            NumericUpDown numero = new NumericUpDown
            {
                Name = nombre,
                Location = new Point(x, y),
                Size = new Size(ancho, 27),
                Font = new Font("Segoe UI", 10),
                Minimum = 0,
                Maximum = 999999
            };

            if (decimalPermitido)
            {
                numero.DecimalPlaces = 2;
                numero.Increment = 0.01M;
            }
            else
            {
                numero.DecimalPlaces = 0;
                numero.Increment = 1;
            }

            return numero;
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

                ColumnHeadersHeight = 48,
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
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
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
