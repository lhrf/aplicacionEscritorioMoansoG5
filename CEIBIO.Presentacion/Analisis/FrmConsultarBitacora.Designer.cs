namespace CEIBIO.Presentacion.Analisis
{
    partial class FrmConsultarBitacora
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
            lblEquipo = new Label();
            cboEquipo = new ComboBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnBuscar = new Button();
            grpBitacora = new GroupBox();
            dgvBitacora = new DataGridView();
            colFechaYHora = new DataGridViewTextBoxColumn();
            colMuestra = new DataGridViewTextBoxColumn();
            colTecnico = new DataGridViewTextBoxColumn();
            colFallaAnalitica = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
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
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar bitácora de uso del equipo";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 610);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 3;
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
            grpFiltros.BackColor = Color.FromArgb(255, 255, 255);
            grpFiltros.Controls.Add(lblEquipo);
            grpFiltros.Controls.Add(cboEquipo);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 116);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.BackColor = Color.Transparent;
            lblEquipo.Font = new Font("Segoe UI", 10F);
            lblEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            lblEquipo.Location = new Point(15, 35);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(51, 19);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // cboEquipo
            // 
            cboEquipo.BackColor = Color.FromArgb(255, 255, 255);
            cboEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipo.FlatStyle = FlatStyle.Flat;
            cboEquipo.Font = new Font("Segoe UI", 10F);
            cboEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            cboEquipo.FormattingEnabled = true;
            cboEquipo.Location = new Point(132, 32);
            cboEquipo.Name = "cboEquipo";
            cboEquipo.Size = new Size(240, 25);
            cboEquipo.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Transparent;
            lblFechaInicio.Font = new Font("Segoe UI", 10F);
            lblFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaInicio.Location = new Point(15, 73);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(81, 19);
            lblFechaInicio.TabIndex = 2;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(132, 70);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 25);
            dtpFechaInicio.TabIndex = 3;
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
            lblFechaFin.TabIndex = 4;
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
            dtpFechaFin.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 255, 255);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new Point(815, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpBitacora
            // 
            grpBitacora.BackColor = Color.FromArgb(255, 255, 255);
            grpBitacora.Controls.Add(dgvBitacora);
            grpBitacora.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBitacora.ForeColor = Color.FromArgb(11, 61, 110);
            grpBitacora.Location = new Point(20, 196);
            grpBitacora.Name = "grpBitacora";
            grpBitacora.Padding = new Padding(10, 8, 10, 10);
            grpBitacora.Size = new Size(960, 398);
            grpBitacora.TabIndex = 2;
            grpBitacora.TabStop = false;
            grpBitacora.Text = "Bitácora de uso";
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBitacora.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvBitacora.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBitacora.ColumnHeadersHeight = 34;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBitacora.Columns.AddRange(new DataGridViewColumn[] { colFechaYHora, colMuestra, colTecnico, colFallaAnalitica });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBitacora.Dock = DockStyle.Fill;
            dgvBitacora.EnableHeadersVisualStyles = false;
            dgvBitacora.GridColor = Color.FromArgb(208, 215, 222);
            dgvBitacora.Location = new Point(10, 26);
            dgvBitacora.MultiSelect = false;
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersVisible = false;
            dgvBitacora.RowTemplate.Height = 28;
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.Size = new Size(940, 362);
            dgvBitacora.TabIndex = 0;
            // 
            // colFechaYHora
            // 
            colFechaYHora.HeaderText = "Fecha y hora";
            colFechaYHora.Name = "colFechaYHora";
            colFechaYHora.ReadOnly = true;
            // 
            // colMuestra
            // 
            colMuestra.HeaderText = "Muestra";
            colMuestra.Name = "colMuestra";
            colMuestra.ReadOnly = true;
            // 
            // colTecnico
            // 
            colTecnico.HeaderText = "Técnico";
            colTecnico.Name = "colTecnico";
            colTecnico.ReadOnly = true;
            // 
            // colFallaAnalitica
            // 
            colFallaAnalitica.HeaderText = "Falla analítica";
            colFallaAnalitica.Name = "colFallaAnalitica";
            colFallaAnalitica.ReadOnly = true;
            // 
            // FrmConsultarBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new Size(1000, 670);
            Controls.Add(grpBitacora);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarBitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar bitácora de uso del equipo";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpBitacora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpBitacora;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaYHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFallaAnalitica;
    }
}
