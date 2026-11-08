
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CEIBIO.Presentacion.Formalizacion
{
    // Registrar repetición del análisis (CU-48)
    public partial class FrmRepetirAnalisis : Form
    {
        private DataGridView dgvRepeticion;
        private TextBox txtResultadoAnterior;
        private TextBox txtNuevoResultado;
        private Button btnGuardar;
        private Button btnCerrar;

        private readonly Color azul =
            Color.FromArgb(11, 61, 110);

        public FrmRepetirAnalisis()
        {
            InitializeComponent();
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            SuspendLayout();
            Controls.Clear();

            Text = "Registrar repetición del análisis";
            ClientSize = new Size(1000, 650);
            BackColor = Color.FromArgb(244, 246, 249);
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Segoe UI", 10);

            // CABECERA
            Panel cabecera = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(1000, 56),
                BackColor = azul
            };

            Label titulo = new Label
            {
                Text = "Registrar repetición del análisis",
                ForeColor = Color.White,
                Font = new Font(
                    "Segoe UI", 17, FontStyle.Bold),
                Location = new Point(20, 12),
                AutoSize = true
            };

            Label codigo = new Label
            {
                Text = "",
                ForeColor = Color.LightBlue,
                Location = new Point(925, 20),
                AutoSize = true
            };

            cabecera.Controls.Add(titulo);
            cabecera.Controls.Add(codigo);
            Controls.Add(cabecera);

            // RESULTADOS EN REPETICIÓN
            GroupBox grupoResultados = new GroupBox
            {
                Name = "grpRepeticion",
                Text = "Resultados en repetición",
                Location = new Point(20, 70),
                Size = new Size(960, 298),
                BackColor = Color.White,
                ForeColor = azul,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            Controls.Add(grupoResultados);

            dgvRepeticion = new DataGridView
            {
                Name = "dgvRepeticion",
                Location = new Point(12, 30),
                Size = new Size(936, 256),
                BackgroundColor = Color.White,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill
            };

            dgvRepeticion.Columns.Add(
                "colNumeroAtencion", "N.° atención");
            dgvRepeticion.Columns.Add(
                "colPaciente", "Paciente");
            dgvRepeticion.Columns.Add(
                "colParametro", "Parámetro");
            dgvRepeticion.Columns.Add(
                "colObservacion", "Observación del médico");

            dgvRepeticion.EnableHeadersVisualStyles = false;
            dgvRepeticion.ColumnHeadersDefaultCellStyle.BackColor =
                azul;
            dgvRepeticion.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            grupoResultados.Controls.Add(dgvRepeticion);

            // REPETICIÓN
            GroupBox grupoRepeticion = new GroupBox
            {
                Name = "grpRepeticion",
                Text = "Repetición",
                Location = new Point(20, 378),
                Size = new Size(960, 202),
                BackColor = Color.White,
                ForeColor = azul,
                Font = new Font(
                    "Segoe UI", 10, FontStyle.Bold)
            };

            Controls.Add(grupoRepeticion);

            Label lblResultadoAnterior = new Label
            {
                Name = "lblResultadoAnterior",
                Text = "Resultado anterior",
                Location = new Point(15, 35),
                AutoSize = true
            };

            txtResultadoAnterior = new TextBox
            {
                Name = "txtResultadoAnterior",
                Location = new Point(174, 32),
                Size = new Size(150, 27),
                ReadOnly = true,
                BackColor = Color.FromArgb(233, 238, 243)
            };

            Label lblNuevoResultado = new Label
            {
                Name = "lblNuevoResultado",
                Text = "Nuevo resultado *",
                Location = new Point(495, 35),
                AutoSize = true
            };

            txtNuevoResultado = new TextBox
            {
                Name = "txtNuevoResultado",
                Location = new Point(646, 32),
                Size = new Size(150, 27)
            };

            grupoRepeticion.Controls.Add(lblResultadoAnterior);
            grupoRepeticion.Controls.Add(txtResultadoAnterior);
            grupoRepeticion.Controls.Add(lblNuevoResultado);
            grupoRepeticion.Controls.Add(txtNuevoResultado);

            // BARRA INFERIOR
            Panel barra = new Panel
            {
                Location = new Point(0, 590),
                Size = new Size(1000, 60),
                BackColor = Color.White
            };

            btnCerrar = new Button
            {
                Name = "btnCerrar",
                Text = "Cerrar",
                Location = new Point(850, 12),
                Size = new Size(130, 36),
                BackColor = Color.FromArgb(229, 231, 235),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };

            btnGuardar = new Button
            {
                Name = "btnGuardar",
                Text = "Guardar y reenviar",
                Location = new Point(663, 12),
                Size = new Size(177, 36),
                BackColor = azul,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnCerrar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;

            btnCerrar.Click += (s, e) => Close();

            barra.Controls.Add(btnCerrar);
            barra.Controls.Add(btnGuardar);
            Controls.Add(barra);

            ResumeLayout(false);
        }
    }
}
