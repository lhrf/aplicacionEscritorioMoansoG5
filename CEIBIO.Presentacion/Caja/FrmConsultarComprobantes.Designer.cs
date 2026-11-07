namespace CEIBIO.Presentacion.Caja
{
    partial class FrmConsultarComprobantes
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCerrar = new Button();
            grpFiltros = new GroupBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblDni = new Label();
            txtDni = new TextBox();
            btnBuscar = new Button();
            grpComprobantes = new GroupBox();
            dgvComprobantes = new DataGridView();
            colNComprobante = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colImporteS = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpComprobantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).BeginInit();
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
            lblTitulo.Size = new Size(310, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar comprobantes de pago";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 610);
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
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            grpFiltros.Controls.Add(txtDni);
            grpFiltros.Controls.Add(lblDni);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 116);
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
            lblFechaFin.Location = new Point(15, 73);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(75, 17);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(132, 70);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 25);
            dtpFechaFin.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.ForeColor = Color.FromArgb(31, 35, 40);
            lblDni.Location = new Point(495, 35);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 17);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.ForeColor = Color.FromArgb(31, 35, 40);
            txtDni.Location = new Point(605, 32);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(120, 25);
            txtDni.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(735, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpComprobantes
            // 
            grpComprobantes.BackColor = Color.White;
            grpComprobantes.Controls.Add(dgvComprobantes);
            grpComprobantes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpComprobantes.ForeColor = Color.FromArgb(11, 61, 110);
            grpComprobantes.Location = new Point(20, 196);
            grpComprobantes.Name = "grpComprobantes";
            grpComprobantes.Padding = new Padding(10, 8, 10, 10);
            grpComprobantes.Size = new Size(960, 398);
            grpComprobantes.TabIndex = 3;
            grpComprobantes.TabStop = false;
            grpComprobantes.Text = "Comprobantes de pago";
            // 
            // dgvComprobantes
            // 
            dgvComprobantes.AllowUserToAddRows = false;
            dgvComprobantes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvComprobantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvComprobantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComprobantes.BackgroundColor = Color.White;
            dgvComprobantes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvComprobantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprobantes.Columns.AddRange(new DataGridViewColumn[] { colNComprobante, colFecha, colPaciente, colImporteS, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvComprobantes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvComprobantes.Dock = DockStyle.Fill;
            dgvComprobantes.EnableHeadersVisualStyles = false;
            dgvComprobantes.GridColor = Color.FromArgb(208, 215, 222);
            dgvComprobantes.Location = new Point(10, 26);
            dgvComprobantes.MultiSelect = false;
            dgvComprobantes.Name = "dgvComprobantes";
            dgvComprobantes.ReadOnly = true;
            dgvComprobantes.RowHeadersVisible = false;
            dgvComprobantes.RowTemplate.Height = 28;
            dgvComprobantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComprobantes.Size = new Size(940, 362);
            dgvComprobantes.TabIndex = 0;
            // 
            // colNComprobante
            // 
            colNComprobante.HeaderText = "N.° comprobante";
            colNComprobante.Name = "colNComprobante";
            colNComprobante.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
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
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmConsultarComprobantes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 670);
            Controls.Add(grpComprobantes);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarComprobantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar comprobantes de pago";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpComprobantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpFiltros;
        private Button btnBuscar;
        private TextBox txtDni;
        private Label lblDni;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private GroupBox grpComprobantes;
        private DataGridView dgvComprobantes;
        private DataGridViewTextBoxColumn colNComprobante;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colImporteS;
        private DataGridViewTextBoxColumn colEstado;
    }
}
