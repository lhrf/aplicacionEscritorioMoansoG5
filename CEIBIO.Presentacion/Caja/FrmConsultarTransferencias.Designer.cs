namespace CEIBIO.Presentacion.Caja
{
    partial class FrmConsultarTransferencias
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
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnBuscar = new Button();
            grpTransferencias = new GroupBox();
            dgvTransferencias = new DataGridView();
            colNOperacion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colImporteS = new DataGridViewTextBoxColumn();
            colSupervisor = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpTransferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).BeginInit();
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
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(335, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar transferencias autorizadas";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
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
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(867, 3);
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
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 78);
            grpFiltros.TabIndex = 2;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Transparent;
            lblFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaInicio.Location = new Point(15, 35);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(84, 17);
            lblFechaInicio.TabIndex = 0;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(132, 32);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 25);
            dtpFechaInicio.TabIndex = 1;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = Color.Transparent;
            lblFechaFin.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaFin.Location = new Point(495, 35);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(75, 17);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(605, 32);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 25);
            dtpFechaFin.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(815, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpTransferencias
            // 
            grpTransferencias.BackColor = Color.White;
            grpTransferencias.Controls.Add(dgvTransferencias);
            grpTransferencias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTransferencias.ForeColor = Color.FromArgb(11, 61, 110);
            grpTransferencias.Location = new Point(20, 158);
            grpTransferencias.Name = "grpTransferencias";
            grpTransferencias.Padding = new Padding(10, 8, 10, 10);
            grpTransferencias.Size = new Size(960, 418);
            grpTransferencias.TabIndex = 3;
            grpTransferencias.TabStop = false;
            grpTransferencias.Text = "Transferencias autorizadas";
            // 
            // dgvTransferencias
            // 
            dgvTransferencias.AllowUserToAddRows = false;
            dgvTransferencias.AllowUserToDeleteRows = false;
            dgvTransferencias.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvTransferencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransferencias.BackgroundColor = Color.White;
            dgvTransferencias.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransferencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransferencias.ColumnHeadersHeight = 34;
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransferencias.Columns.AddRange(new DataGridViewColumn[] { colNOperacion, colPaciente, colImporteS, colSupervisor, colFecha });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransferencias.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransferencias.Dock = DockStyle.Fill;
            dgvTransferencias.EnableHeadersVisualStyles = false;
            dgvTransferencias.GridColor = Color.FromArgb(208, 215, 222);
            dgvTransferencias.Location = new Point(10, 26);
            dgvTransferencias.MultiSelect = false;
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.ReadOnly = true;
            dgvTransferencias.RowHeadersVisible = false;
            dgvTransferencias.RowTemplate.Height = 28;
            dgvTransferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransferencias.Size = new Size(940, 382);
            dgvTransferencias.TabIndex = 0;
            // 
            // colNOperacion
            // 
            colNOperacion.HeaderText = "N.° operación";
            colNOperacion.Name = "colNOperacion";
            colNOperacion.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colImporteS
            // 
            colImporteS.HeaderText = "Importe (S/)";
            colImporteS.Name = "colImporteS";
            colImporteS.ReadOnly = true;
            // 
            // colSupervisor
            // 
            colSupervisor.HeaderText = "Supervisor";
            colSupervisor.Name = "colSupervisor";
            colSupervisor.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // FrmConsultarTransferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 650);
            Controls.Add(grpTransferencias);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarTransferencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar transferencias autorizadas";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpTransferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private GroupBox grpFiltros;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private Button btnBuscar;
        private DateTimePicker dtpFechaFin;
        private GroupBox grpTransferencias;
        private DataGridView dgvTransferencias;
        private DataGridViewTextBoxColumn colNOperacion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colImporteS;
        private DataGridViewTextBoxColumn colSupervisor;
        private DataGridViewTextBoxColumn colFecha;
    }
}
