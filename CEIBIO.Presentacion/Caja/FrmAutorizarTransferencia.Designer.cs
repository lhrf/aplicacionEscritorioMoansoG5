namespace CEIBIO.Presentacion.Caja
{
    partial class FrmAutorizarTransferencia
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnAutorizar = new Button();
            btnRechazar = new Button();
            grpTransferencias = new GroupBox();
            dgvTransferencias = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colImporteS = new DataGridViewTextBoxColumn();
            colCajero = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            grpDatosDeLaOperacion = new GroupBox();
            lblNumeroOperacion = new Label();
            txtNumeroOperacion = new TextBox();
            lblImporte = new Label();
            nudImporte = new NumericUpDown();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpTransferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).BeginInit();
            grpDatosDeLaOperacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudImporte).BeginInit();
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
            lblTitulo.Size = new Size(305, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Autorizar pago por transferencia";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnAutorizar);
            flpBotones.Controls.Add(btnRechazar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 623);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 27);
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
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.FromArgb(11, 61, 110);
            btnAutorizar.Cursor = Cursors.Hand;
            btnAutorizar.FlatAppearance.BorderSize = 0;
            btnAutorizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnAutorizar.FlatStyle = FlatStyle.Flat;
            btnAutorizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorizar.ForeColor = Color.White;
            btnAutorizar.Location = new Point(711, 15);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(130, 36);
            btnAutorizar.TabIndex = 1;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.FromArgb(180, 35, 24);
            btnRechazar.Cursor = Cursors.Hand;
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechazar.ForeColor = Color.White;
            btnRechazar.Location = new Point(575, 15);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(130, 36);
            btnRechazar.TabIndex = 2;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            // 
            // grpTransferencias
            // 
            grpTransferencias.BackColor = Color.White;
            grpTransferencias.Controls.Add(dgvTransferencias);
            grpTransferencias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTransferencias.ForeColor = Color.FromArgb(11, 61, 110);
            grpTransferencias.Location = new Point(20, 70);
            grpTransferencias.Name = "grpTransferencias";
            grpTransferencias.Padding = new Padding(10, 8, 10, 10);
            grpTransferencias.Size = new Size(960, 384);
            grpTransferencias.TabIndex = 2;
            grpTransferencias.TabStop = false;
            grpTransferencias.Text = "Transferencias pendientes de autorización";
            // 
            // dgvTransferencias
            // 
            dgvTransferencias.AllowUserToAddRows = false;
            dgvTransferencias.AllowUserToDeleteRows = false;
            dgvTransferencias.AllowUserToResizeColumns = false;
            dgvTransferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransferencias.BackgroundColor = Color.White;
            dgvTransferencias.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTransferencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTransferencias.ColumnHeadersHeight = 34;
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransferencias.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colImporteS, colCajero, colFecha });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTransferencias.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTransferencias.Dock = DockStyle.Fill;
            dgvTransferencias.EnableHeadersVisualStyles = false;
            dgvTransferencias.GridColor = Color.FromArgb(208, 215, 222);
            dgvTransferencias.Location = new Point(10, 26);
            dgvTransferencias.MultiSelect = false;
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.ReadOnly = true;
            dgvTransferencias.RowHeadersVisible = false;
            dgvTransferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransferencias.Size = new Size(940, 348);
            dgvTransferencias.TabIndex = 0;
            // 
            // colNAtencion
            // 
            colNAtencion.HeaderText = "N.° atención";
            colNAtencion.Name = "colNAtencion";
            colNAtencion.ReadOnly = true;
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
            // colCajero
            // 
            colCajero.HeaderText = "Cajero";
            colCajero.Name = "colCajero";
            colCajero.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // grpDatosDeLaOperacion
            // 
            grpDatosDeLaOperacion.Controls.Add(dtpFecha);
            grpDatosDeLaOperacion.Controls.Add(lblFecha);
            grpDatosDeLaOperacion.Controls.Add(nudImporte);
            grpDatosDeLaOperacion.Controls.Add(lblImporte);
            grpDatosDeLaOperacion.Controls.Add(txtNumeroOperacion);
            grpDatosDeLaOperacion.Controls.Add(lblNumeroOperacion);
            grpDatosDeLaOperacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDatosDeLaOperacion.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatosDeLaOperacion.Location = new Point(20, 464);
            grpDatosDeLaOperacion.Name = "grpDatosDeLaOperacion";
            grpDatosDeLaOperacion.Size = new Size(960, 116);
            grpDatosDeLaOperacion.TabIndex = 3;
            grpDatosDeLaOperacion.TabStop = false;
            grpDatosDeLaOperacion.Text = "Datos de la operación";
            // 
            // lblNumeroOperacion
            // 
            lblNumeroOperacion.AutoSize = true;
            lblNumeroOperacion.BackColor = Color.Transparent;
            lblNumeroOperacion.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroOperacion.Location = new Point(15, 35);
            lblNumeroOperacion.Name = "lblNumeroOperacion";
            lblNumeroOperacion.Size = new Size(121, 17);
            lblNumeroOperacion.TabIndex = 0;
            lblNumeroOperacion.Text = "N.° de operación *";
            // 
            // txtNumeroOperacion
            // 
            txtNumeroOperacion.BackColor = Color.White;
            txtNumeroOperacion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroOperacion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroOperacion.Location = new Point(174, 32);
            txtNumeroOperacion.Name = "txtNumeroOperacion";
            txtNumeroOperacion.Size = new Size(180, 25);
            txtNumeroOperacion.TabIndex = 1;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.BackColor = Color.Transparent;
            lblImporte.ForeColor = Color.FromArgb(31, 35, 40);
            lblImporte.Location = new Point(15, 73);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(94, 17);
            lblImporte.TabIndex = 2;
            lblImporte.Text = "Importe (S/) *";
            // 
            // nudImporte
            // 
            nudImporte.BackColor = Color.White;
            nudImporte.BorderStyle = BorderStyle.FixedSingle;
            nudImporte.ForeColor = Color.FromArgb(31, 35, 40);
            nudImporte.Location = new Point(174, 70);
            nudImporte.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudImporte.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudImporte.Name = "nudImporte";
            nudImporte.Size = new Size(120, 25);
            nudImporte.TabIndex = 3;
            nudImporte.TextAlign = HorizontalAlignment.Right;
            nudImporte.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.ForeColor = Color.FromArgb(31, 35, 40);
            lblFecha.Location = new Point(429, 36);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 17);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha *";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(605, 32);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 25);
            dtpFecha.TabIndex = 5;
            // 
            // FrmAutorizarTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 650);
            Controls.Add(grpDatosDeLaOperacion);
            Controls.Add(grpTransferencias);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAutorizarTransferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autorizar pago por transferencia";
            Load += FrmAutorizarTransferencia_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpTransferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).EndInit();
            grpDatosDeLaOperacion.ResumeLayout(false);
            grpDatosDeLaOperacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudImporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnAutorizar;
        private Button btnRechazar;
        private GroupBox grpTransferencias;
        private DataGridView dgvTransferencias;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colImporteS;
        private DataGridViewTextBoxColumn colCajero;
        private DataGridViewTextBoxColumn colFecha;
        private GroupBox grpDatosDeLaOperacion;
        private Label lblNumeroOperacion;
        private TextBox txtNumeroOperacion;
        private Label lblImporte;
        private Label lblFecha;
        private NumericUpDown nudImporte;
        private DateTimePicker dtpFecha;
    }
}
