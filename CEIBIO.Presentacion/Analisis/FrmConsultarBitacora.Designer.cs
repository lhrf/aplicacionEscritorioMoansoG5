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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            pnlEncabezado = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblCodigo = new System.Windows.Forms.Label();
            flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            btnCerrar = new System.Windows.Forms.Button();
            grpFiltros = new System.Windows.Forms.GroupBox();
            lblEquipo = new System.Windows.Forms.Label();
            cboEquipo = new System.Windows.Forms.ComboBox();
            lblFechaInicio = new System.Windows.Forms.Label();
            dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            lblFechaFin = new System.Windows.Forms.Label();
            dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            btnBuscar = new System.Windows.Forms.Button();
            grpBitacora = new System.Windows.Forms.GroupBox();
            dgvBitacora = new System.Windows.Forms.DataGridView();
            colFechaYHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFallaAnalitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlEncabezado.Controls.Add(lblCodigo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new System.Drawing.Size(1000, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new System.Drawing.Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(381, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar bitácora de uso del equipo";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = System.Drawing.Color.Transparent;
            lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(191, 215, 238);
            lblCodigo.Location = new System.Drawing.Point(939, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(41, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "CU-45";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            flpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpBotones.Location = new System.Drawing.Point(0, 610);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            flpBotones.Size = new System.Drawing.Size(1000, 60);
            flpBotones.TabIndex = 3;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCerrar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new System.Drawing.Point(860, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = true;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // grpFiltros
            // 
            grpFiltros.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpFiltros.Controls.Add(lblEquipo);
            grpFiltros.Controls.Add(cboEquipo);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpFiltros.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new System.Drawing.Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new System.Drawing.Size(960, 116);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.BackColor = System.Drawing.Color.Transparent;
            lblEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblEquipo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblEquipo.Location = new System.Drawing.Point(15, 35);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new System.Drawing.Size(51, 19);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // cboEquipo
            // 
            cboEquipo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            cboEquipo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            cboEquipo.FormattingEnabled = true;
            cboEquipo.Location = new System.Drawing.Point(132, 32);
            cboEquipo.Name = "cboEquipo";
            cboEquipo.Size = new System.Drawing.Size(240, 25);
            cboEquipo.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblFechaInicio.Location = new System.Drawing.Point(15, 73);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new System.Drawing.Size(81, 19);
            lblFechaInicio.TabIndex = 2;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            dtpFechaInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new System.Drawing.Point(132, 70);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new System.Drawing.Size(200, 25);
            dtpFechaInicio.TabIndex = 3;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = System.Drawing.Color.Transparent;
            lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblFechaFin.Location = new System.Drawing.Point(495, 35);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new System.Drawing.Size(72, 19);
            lblFechaFin.TabIndex = 4;
            lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            dtpFechaFin.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaFin.Location = new System.Drawing.Point(605, 32);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new System.Drawing.Size(200, 25);
            dtpFechaFin.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.BorderSize = 1;
            btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBuscar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new System.Drawing.Point(815, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(110, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpBitacora
            // 
            grpBitacora.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpBitacora.Controls.Add(dgvBitacora);
            grpBitacora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpBitacora.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpBitacora.Location = new System.Drawing.Point(20, 196);
            grpBitacora.Name = "grpBitacora";
            grpBitacora.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            grpBitacora.Size = new System.Drawing.Size(960, 398);
            grpBitacora.TabIndex = 2;
            grpBitacora.TabStop = false;
            grpBitacora.Text = "Bitácora de uso";
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.AllowUserToResizeRows = false;
            dgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvBitacora.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBitacora.ColumnHeadersHeight = 34;
            dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colFechaYHora, colMuestra, colTecnico, colFallaAnalitica });
            dgvBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvBitacora.EnableHeadersVisualStyles = false;
            dgvBitacora.GridColor = System.Drawing.Color.FromArgb(208, 215, 222);
            dgvBitacora.Location = new System.Drawing.Point(10, 31);
            dgvBitacora.MultiSelect = false;
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersVisible = false;
            dgvBitacora.RowTemplate.Height = 28;
            dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.Size = new System.Drawing.Size(940, 357);
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
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new System.Drawing.Size(1000, 670);
            Controls.Add(grpBitacora);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarBitacora";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblCodigo;
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
