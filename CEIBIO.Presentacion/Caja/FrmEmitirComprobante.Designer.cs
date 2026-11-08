namespace CEIBIO.Presentacion.Caja
{
    partial class FrmEmitirComprobante
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnEmitir = new Button();
            btnAnular = new Button();
            btnReimprimir = new Button();
            grpPagadas = new GroupBox();
            dgvPagadas = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colMedioDePago = new DataGridViewTextBoxColumn();
            colTotalS = new DataGridViewTextBoxColumn();
            grpComprobanteDePago = new GroupBox();
            lblNumeroComprobante = new Label();
            txtNumeroComprobante = new TextBox();
            lblFecha = new Label();
            txtFecha = new TextBox();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            grpDetalle = new GroupBox();
            dgvDetalle = new DataGridView();
            colExamen = new DataGridViewTextBoxColumn();
            colImporteS = new DataGridViewTextBoxColumn();
            lblDescuento = new Label();
            lblTotal = new Label();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpPagadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagadas).BeginInit();
            grpComprobanteDePago.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
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
            lblTitulo.Size = new Size(271, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Emitir Comprobante de pago";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnEmitir);
            flpBotones.Controls.Add(btnAnular);
            flpBotones.Controls.Add(btnReimprimir);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 610);
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
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(867, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnEmitir
            // 
            btnEmitir.BackColor = Color.FromArgb(11, 61, 110);
            btnEmitir.Cursor = Cursors.Hand;
            btnEmitir.FlatAppearance.BorderSize = 0;
            btnEmitir.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnEmitir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmitir.ForeColor = Color.White;
            btnEmitir.Location = new Point(692, 3);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(169, 36);
            btnEmitir.TabIndex = 1;
            btnEmitir.Text = "Emitir e imprimir";
            btnEmitir.UseVisualStyleBackColor = false;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.FromArgb(180, 35, 24);
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(509, 3);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(177, 36);
            btnAnular.TabIndex = 2;
            btnAnular.Text = "Anular comprobante";
            btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnReimprimir
            // 
            btnReimprimir.BackColor = Color.White;
            btnReimprimir.Cursor = Cursors.Hand;
            btnReimprimir.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnReimprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnReimprimir.FlatStyle = FlatStyle.Flat;
            btnReimprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReimprimir.ForeColor = Color.FromArgb(11, 61, 110);
            btnReimprimir.Location = new Point(373, 3);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(130, 36);
            btnReimprimir.TabIndex = 3;
            btnReimprimir.Text = "Reimprimir";
            btnReimprimir.UseVisualStyleBackColor = false;
            // 
            // grpPagadas
            // 
            grpPagadas.BackColor = Color.White;
            grpPagadas.Controls.Add(dgvPagadas);
            grpPagadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPagadas.ForeColor = Color.FromArgb(11, 61, 110);
            grpPagadas.Location = new Point(20, 70);
            grpPagadas.Name = "grpPagadas";
            grpPagadas.Padding = new Padding(10, 8, 10, 10);
            grpPagadas.Size = new Size(960, 188);
            grpPagadas.TabIndex = 2;
            grpPagadas.TabStop = false;
            grpPagadas.Text = "Atenciones pagadas";
            // 
            // dgvPagadas
            // 
            dgvPagadas.AllowUserToAddRows = false;
            dgvPagadas.AllowUserToDeleteRows = false;
            dgvPagadas.AllowUserToResizeColumns = false;
            dgvPagadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagadas.BackgroundColor = Color.White;
            dgvPagadas.BorderStyle = BorderStyle.None;
            dgvPagadas.ColumnHeadersHeight = 28;
            dgvPagadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPagadas.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colMedioDePago, colTotalS });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPagadas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPagadas.Dock = DockStyle.Fill;
            dgvPagadas.EnableHeadersVisualStyles = false;
            dgvPagadas.Location = new Point(10, 26);
            dgvPagadas.Name = "dgvPagadas";
            dgvPagadas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPagadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPagadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagadas.Size = new Size(940, 152);
            dgvPagadas.TabIndex = 0;
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
            // colMedioDePago
            // 
            colMedioDePago.HeaderText = "Medio de pago";
            colMedioDePago.Name = "colMedioDePago";
            colMedioDePago.ReadOnly = true;
            // 
            // colTotalS
            // 
            colTotalS.HeaderText = "Total (S/)";
            colTotalS.Name = "colTotalS";
            colTotalS.ReadOnly = true;
            // 
            // grpComprobanteDePago
            // 
            grpComprobanteDePago.BackColor = Color.White;
            grpComprobanteDePago.Controls.Add(txtDni);
            grpComprobanteDePago.Controls.Add(lblDni);
            grpComprobanteDePago.Controls.Add(txtPaciente);
            grpComprobanteDePago.Controls.Add(lblPaciente);
            grpComprobanteDePago.Controls.Add(txtFecha);
            grpComprobanteDePago.Controls.Add(lblFecha);
            grpComprobanteDePago.Controls.Add(txtNumeroComprobante);
            grpComprobanteDePago.Controls.Add(lblNumeroComprobante);
            grpComprobanteDePago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpComprobanteDePago.ForeColor = Color.FromArgb(11, 61, 110);
            grpComprobanteDePago.Location = new Point(20, 268);
            grpComprobanteDePago.Name = "grpComprobanteDePago";
            grpComprobanteDePago.Size = new Size(960, 116);
            grpComprobanteDePago.TabIndex = 3;
            grpComprobanteDePago.TabStop = false;
            grpComprobanteDePago.Text = "Comprobante de pago";
            // 
            // lblNumeroComprobante
            // 
            lblNumeroComprobante.AutoSize = true;
            lblNumeroComprobante.BackColor = Color.Transparent;
            lblNumeroComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroComprobante.Location = new Point(15, 35);
            lblNumeroComprobante.Name = "lblNumeroComprobante";
            lblNumeroComprobante.Size = new Size(132, 17);
            lblNumeroComprobante.TabIndex = 0;
            lblNumeroComprobante.Text = "N.° de comprobante";
            // 
            // txtNumeroComprobante
            // 
            txtNumeroComprobante.BackColor = Color.FromArgb(233, 238, 243);
            txtNumeroComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroComprobante.Location = new Point(174, 32);
            txtNumeroComprobante.Name = "txtNumeroComprobante";
            txtNumeroComprobante.ReadOnly = true;
            txtNumeroComprobante.Size = new Size(150, 25);
            txtNumeroComprobante.TabIndex = 1;
            txtNumeroComprobante.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.ForeColor = Color.FromArgb(31, 35, 40);
            lblFecha.Location = new Point(15, 73);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(233, 238, 243);
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.ForeColor = Color.FromArgb(31, 35, 40);
            txtFecha.Location = new Point(174, 70);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(120, 25);
            txtFecha.TabIndex = 3;
            txtFecha.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(495, 35);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(60, 17);
            lblPaciente.TabIndex = 4;
            lblPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(605, 32);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(300, 25);
            txtPaciente.TabIndex = 5;
            txtPaciente.TabStop = false;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.ForeColor = Color.FromArgb(31, 35, 40);
            lblDni.Location = new Point(495, 73);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 17);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(233, 238, 243);
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 35, 40);
            txtDni.Location = new Point(605, 70);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(120, 25);
            txtDni.TabIndex = 7;
            txtDni.TabStop = false;
            // 
            // grpDetalle
            // 
            grpDetalle.BackColor = Color.White;
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalle.ForeColor = Color.FromArgb(11, 61, 110);
            grpDetalle.Location = new Point(20, 394);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Padding = new Padding(10, 8, 10, 10);
            grpDetalle.Size = new Size(960, 148);
            grpDetalle.TabIndex = 4;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 246, 250);
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalle.ColumnHeadersHeight = 34;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colExamen, colImporteS });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.Dock = DockStyle.Fill;
            dgvDetalle.GridColor = Color.FromArgb(208, 215, 222);
            dgvDetalle.Location = new Point(10, 26);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowTemplate.Height = 28;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(940, 112);
            dgvDetalle.TabIndex = 0;
            // 
            // colExamen
            // 
            colExamen.HeaderText = "Examen";
            colExamen.Name = "colExamen";
            colExamen.ReadOnly = true;
            // 
            // colImporteS
            // 
            colImporteS.HeaderText = "Importe (S/)";
            colImporteS.Name = "colImporteS";
            colImporteS.ReadOnly = true;
            // 
            // lblDescuento
            // 
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.ForeColor = Color.FromArgb(31, 35, 40);
            lblDescuento.Location = new Point(480, 552);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(240, 34);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento: S/ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(11, 61, 110);
            lblTotal.Location = new Point(730, 552);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(240, 34);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total: S/ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmEmitirComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 670);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(grpDetalle);
            Controls.Add(grpComprobanteDePago);
            Controls.Add(grpPagadas);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmEmitirComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emitir Comprobante de pago";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpPagadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagadas).EndInit();
            grpComprobanteDePago.ResumeLayout(false);
            grpComprobanteDePago.PerformLayout();
            grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnEmitir;
        private Button btnAnular;
        private Button btnReimprimir;
        private GroupBox grpPagadas;
        private DataGridView dgvPagadas;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colMedioDePago;
        private DataGridViewTextBoxColumn colTotalS;
        private GroupBox grpComprobanteDePago;
        private TextBox txtFecha;
        private Label lblFecha;
        private TextBox txtNumeroComprobante;
        private Label lblNumeroComprobante;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private GroupBox grpDetalle;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn colExamen;
        private DataGridViewTextBoxColumn colImporteS;
        private Label lblDescuento;
        private Label lblTotal;
    }
}
