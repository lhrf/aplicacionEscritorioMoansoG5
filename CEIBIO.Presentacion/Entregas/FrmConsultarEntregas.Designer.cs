namespace CEIBIO.Presentacion.Entregas
{
    partial class FrmConsultarEntregas
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
            grpEntregas = new GroupBox();
            dgvEntregas = new DataGridView();
            colPaciente = new DataGridViewTextBoxColumn();
            colRecibidoPor = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colRelacion = new DataGridViewTextBoxColumn();
            colFechaYHora = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
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
            pnlEncabezado.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar entregas realizadas";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 2;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 78);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Transparent;
            lblFechaInicio.Font = new Font("Segoe UI", 10F);
            lblFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaInicio.Location = new Point(15, 35);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(81, 19);
            lblFechaInicio.TabIndex = 0;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
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
            lblFechaFin.Font = new Font("Segoe UI", 10F);
            lblFechaFin.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaFin.Location = new Point(495, 35);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(73, 19);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.ForeColor = Color.FromArgb(31, 35, 40);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
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
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new Point(815, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpEntregas
            // 
            grpEntregas.BackColor = Color.White;
            grpEntregas.Controls.Add(dgvEntregas);
            grpEntregas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEntregas.ForeColor = Color.FromArgb(11, 61, 110);
            grpEntregas.Location = new Point(20, 158);
            grpEntregas.Name = "grpEntregas";
            grpEntregas.Padding = new Padding(10, 8, 10, 10);
            grpEntregas.Size = new Size(960, 418);
            grpEntregas.TabIndex = 1;
            grpEntregas.TabStop = false;
            grpEntregas.Text = "Entregas realizadas";
            // 
            // dgvEntregas
            // 
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.AllowUserToDeleteRows = false;
            dgvEntregas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvEntregas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntregas.BackgroundColor = Color.White;
            dgvEntregas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEntregas.ColumnHeadersHeight = 34;
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEntregas.Columns.AddRange(new DataGridViewColumn[] { colPaciente, colRecibidoPor, colDNI, colRelacion, colFechaYHora });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEntregas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEntregas.Dock = DockStyle.Fill;
            dgvEntregas.EnableHeadersVisualStyles = false;
            dgvEntregas.GridColor = Color.FromArgb(208, 215, 222);
            dgvEntregas.Location = new Point(10, 26);
            dgvEntregas.MultiSelect = false;
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.RowHeadersVisible = false;
            dgvEntregas.RowTemplate.Height = 28;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.Size = new Size(940, 382);
            dgvEntregas.TabIndex = 0;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colRecibidoPor
            // 
            colRecibidoPor.HeaderText = "Recibido por";
            colRecibidoPor.Name = "colRecibidoPor";
            colRecibidoPor.ReadOnly = true;
            // 
            // colDNI
            // 
            colDNI.HeaderText = "DNI";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            // 
            // colRelacion
            // 
            colRelacion.HeaderText = "Relación";
            colRelacion.Name = "colRelacion";
            colRelacion.ReadOnly = true;
            // 
            // colFechaYHora
            // 
            colFechaYHora.HeaderText = "Fecha y hora";
            colFechaYHora.Name = "colFechaYHora";
            colFechaYHora.ReadOnly = true;
            // 
            // FrmConsultarEntregas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpEntregas);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarEntregas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar entregas realizadas";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private GroupBox grpFiltros;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private Button btnBuscar;
        private GroupBox grpEntregas;
        private DataGridView dgvEntregas;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colRecibidoPor;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colRelacion;
        private DataGridViewTextBoxColumn colFechaYHora;
    }
}
