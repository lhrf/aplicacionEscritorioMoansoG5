namespace CEIBIO.Presentacion.Caja
{
    partial class FrmConsultarRecaudacion
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlEncabezado = new FlowLayoutPanel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnImprimir = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpFiltros = new GroupBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            grpRecaudacion = new GroupBox();
            dgvRecaudacion = new DataGridView();
            colNComprobante = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colMedioDePago = new DataGridViewTextBoxColumn();
            colCajero = new DataGridViewTextBoxColumn();
            colImporteS = new DataGridViewTextBoxColumn();
            lblTotalEfectivo = new Label();
            lblTotalTransferencia = new Label();
            lblTotalDia = new Label();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpRecaudacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecaudacion).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(984, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar recaudación diaria";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnImprimir);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.Location = new Point(0, 551);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(984, 60);
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
            btnCerrar.Location = new Point(13, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.FromArgb(11, 61, 110);
            btnImprimir.Location = new Point(149, 15);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(130, 36);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(lblFecha);
            grpFiltros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lblFecha.Size = new Size(43, 17);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarForeColor = Color.FromArgb(31, 35, 40);
            dtpFecha.Location = new Point(125, 32);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 25);
            dtpFecha.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new Point(335, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpRecaudacion
            // 
            grpRecaudacion.BackColor = Color.White;
            grpRecaudacion.Controls.Add(dgvRecaudacion);
            grpRecaudacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpRecaudacion.ForeColor = Color.FromArgb(11, 61, 110);
            grpRecaudacion.Location = new Point(20, 158);
            grpRecaudacion.Name = "grpRecaudacion";
            grpRecaudacion.Padding = new Padding(10, 8, 10, 10);
            grpRecaudacion.Size = new Size(960, 338);
            grpRecaudacion.TabIndex = 3;
            grpRecaudacion.TabStop = false;
            grpRecaudacion.Text = "Comprobantes del día";
            // 
            // dgvRecaudacion
            // 
            dgvRecaudacion.AllowUserToAddRows = false;
            dgvRecaudacion.AllowUserToDeleteRows = false;
            dgvRecaudacion.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 246, 250);
            dgvRecaudacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRecaudacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecaudacion.BackgroundColor = Color.White;
            dgvRecaudacion.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRecaudacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRecaudacion.ColumnHeadersHeight = 34;
            dgvRecaudacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecaudacion.Columns.AddRange(new DataGridViewColumn[] { colNComprobante, colPaciente, colMedioDePago, colCajero, colImporteS });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRecaudacion.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRecaudacion.Dock = DockStyle.Fill;
            dgvRecaudacion.EnableHeadersVisualStyles = false;
            dgvRecaudacion.GridColor = Color.FromArgb(208, 215, 222);
            dgvRecaudacion.Location = new Point(10, 26);
            dgvRecaudacion.MultiSelect = false;
            dgvRecaudacion.Name = "dgvRecaudacion";
            dgvRecaudacion.ReadOnly = true;
            dgvRecaudacion.RowHeadersVisible = false;
            dgvRecaudacion.RowTemplate.Height = 28;
            dgvRecaudacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecaudacion.Size = new Size(940, 302);
            dgvRecaudacion.TabIndex = 0;
            // 
            // colNComprobante
            // 
            colNComprobante.HeaderText = "N.° comprobante";
            colNComprobante.Name = "colNComprobante";
            colNComprobante.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colMedioDePago
            // 
            colMedioDePago.HeaderText = "Medio de pago";
            colMedioDePago.Name = "colMedioDePago";
            colMedioDePago.ReadOnly = true;
            // 
            // colCajero
            // 
            colCajero.HeaderText = "Cajero";
            colCajero.Name = "colCajero";
            colCajero.ReadOnly = true;
            // 
            // colImporteS
            // 
            colImporteS.HeaderText = "Importe (S/)";
            colImporteS.Name = "colImporteS";
            colImporteS.ReadOnly = true;
            // 
            // lblTotalEfectivo
            // 
            lblTotalEfectivo.BackColor = Color.Transparent;
            lblTotalEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEfectivo.ForeColor = Color.FromArgb(31, 35, 40);
            lblTotalEfectivo.Location = new Point(230, 506);
            lblTotalEfectivo.Name = "lblTotalEfectivo";
            lblTotalEfectivo.Size = new Size(240, 34);
            lblTotalEfectivo.TabIndex = 4;
            lblTotalEfectivo.Text = "Efectivo: S/ 0.00";
            lblTotalEfectivo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTransferencia
            // 
            lblTotalTransferencia.BackColor = Color.Transparent;
            lblTotalTransferencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransferencia.ForeColor = Color.FromArgb(31, 35, 40);
            lblTotalTransferencia.Location = new Point(480, 506);
            lblTotalTransferencia.Name = "lblTotalTransferencia";
            lblTotalTransferencia.Size = new Size(240, 34);
            lblTotalTransferencia.TabIndex = 5;
            lblTotalTransferencia.Text = "Transferencia: S/ 0.00";
            lblTotalTransferencia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalDia
            // 
            lblTotalDia.BackColor = Color.Transparent;
            lblTotalDia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDia.ForeColor = Color.FromArgb(11, 61, 110);
            lblTotalDia.Location = new Point(730, 506);
            lblTotalDia.Name = "lblTotalDia";
            lblTotalDia.Size = new Size(240, 34);
            lblTotalDia.TabIndex = 6;
            lblTotalDia.Text = "Total del día: S/ 0.00";
            lblTotalDia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmConsultarRecaudacion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 611);
            Controls.Add(lblTotalDia);
            Controls.Add(lblTotalTransferencia);
            Controls.Add(lblTotalEfectivo);
            Controls.Add(grpRecaudacion);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarRecaudacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar recaudación diaria";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpRecaudacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecaudacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnImprimir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpFiltros;
        private Button btnBuscar;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private GroupBox grpRecaudacion;
        private DataGridView dgvRecaudacion;
        private DataGridViewTextBoxColumn colNComprobante;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colMedioDePago;
        private DataGridViewTextBoxColumn colCajero;
        private DataGridViewTextBoxColumn colImporteS;
        private Label lblTotalEfectivo;
        private Label lblTotalTransferencia;
        private Label lblTotalDia;
    }
}
