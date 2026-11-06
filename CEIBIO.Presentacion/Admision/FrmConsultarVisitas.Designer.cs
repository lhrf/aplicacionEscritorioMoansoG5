namespace CEIBIO.Presentacion.Admision
{
    partial class FrmConsultarVisitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            grpFiltros = new GroupBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            grpVisitas = new GroupBox();
            dgvVisitas = new DataGridView();
            colPaciente = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            colTecnicoAsignado = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpVisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1000, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar visitas domiciliarias";
            // 
            // flpBotones
            // 
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 540);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 1;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // grpFiltros
            // 
            grpFiltros.BackColor = Color.White;
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(lblFecha);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 78);
            grpFiltros.TabIndex = 2;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.ForeColor = Color.FromArgb(31, 35, 40);
            lblFecha.Location = new Point(15, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(125, 32);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 30);
            dtpFecha.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(335, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpVisitas
            // 
            grpVisitas.Controls.Add(dgvVisitas);
            grpVisitas.ForeColor = Color.FromArgb(11, 61, 110);
            grpVisitas.Location = new Point(20, 158);
            grpVisitas.Name = "grpVisitas";
            grpVisitas.Padding = new Padding(10, 8, 10, 10);
            grpVisitas.Size = new Size(960, 438);
            grpVisitas.TabIndex = 3;
            grpVisitas.TabStop = false;
            grpVisitas.Text = "Visitas programadas";
            // 
            // dgvVisitas
            // 
            dgvVisitas.AllowUserToAddRows = false;
            dgvVisitas.AllowUserToDeleteRows = false;
            dgvVisitas.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvVisitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisitas.BackgroundColor = Color.White;
            dgvVisitas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVisitas.ColumnHeadersHeight = 34;
            dgvVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVisitas.Columns.AddRange(new DataGridViewColumn[] { colPaciente, colDireccion, colTelefono, colExamenes, colTecnicoAsignado, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVisitas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVisitas.Dock = DockStyle.Fill;
            dgvVisitas.EnableHeadersVisualStyles = false;
            dgvVisitas.GridColor = Color.FromArgb(208, 215, 222);
            dgvVisitas.Location = new Point(10, 31);
            dgvVisitas.MultiSelect = false;
            dgvVisitas.Name = "dgvVisitas";
            dgvVisitas.ReadOnly = true;
            dgvVisitas.RowHeadersVisible = false;
            dgvVisitas.RowHeadersWidth = 51;
            dgvVisitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitas.Size = new Size(940, 397);
            dgvVisitas.TabIndex = 0;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.MinimumWidth = 6;
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colExamenes
            // 
            colExamenes.HeaderText = "Exámenes";
            colExamenes.MinimumWidth = 6;
            colExamenes.Name = "colExamenes";
            colExamenes.ReadOnly = true;
            // 
            // colTecnicoAsignado
            // 
            colTecnicoAsignado.HeaderText = "Técnico asignado";
            colTecnicoAsignado.MinimumWidth = 6;
            colTecnicoAsignado.Name = "colTecnicoAsignado";
            colTecnicoAsignado.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmConsultarVisitas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(grpVisitas);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarVisitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar visitas domiciliarias";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpVisitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private GroupBox grpFiltros;
        private Button btnBuscar;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private GroupBox grpVisitas;
        private DataGridView dgvVisitas;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colExamenes;
        private DataGridViewTextBoxColumn colTecnicoAsignado;
        private DataGridViewTextBoxColumn colEstado;
    }
}
