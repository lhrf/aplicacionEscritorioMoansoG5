namespace CEIBIO.Presentacion.Caja
{
    partial class FrmRegistrarPago
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnRegistrar = new Button();
            grpPendientes = new GroupBox();
            dgvPendientes = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colModalidad = new DataGridViewTextBoxColumn();
            colTotalS = new DataGridViewTextBoxColumn();
            grpDetalle = new GroupBox();
            dgvDetalle = new DataGridView();
            colExamen = new DataGridViewTextBoxColumn();
            colTarifaS = new DataGridViewTextBoxColumn();
            grpMedioDePago = new GroupBox();
            lblDescuento = new Label();
            nudMontoRecibido = new NumericUpDown();
            lblMontoRecibido = new Label();
            cboMedioPago = new ComboBox();
            lblMedioPago = new Label();
            lblTotal = new Label();
            lblVuelto = new Label();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpMedioDePago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoRecibido).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.BackgroundImageLayout = ImageLayout.Center;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1000, 56);
            pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar pago";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnRegistrar);
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
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
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
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(11, 61, 110);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(639, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(202, 36);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar conformidad";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // grpPendientes
            // 
            grpPendientes.BackColor = Color.White;
            grpPendientes.Controls.Add(dgvPendientes);
            grpPendientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPendientes.ForeColor = Color.FromArgb(11, 61, 110);
            grpPendientes.Location = new Point(20, 70);
            grpPendientes.Name = "grpPendientes";
            grpPendientes.Padding = new Padding(10, 8, 10, 10);
            grpPendientes.Size = new Size(960, 198);
            grpPendientes.TabIndex = 3;
            grpPendientes.TabStop = false;
            grpPendientes.Text = "Atenciones pendientes de pago";
            // 
            // dgvPendientes
            // 
            dgvPendientes.AllowUserToAddRows = false;
            dgvPendientes.AllowUserToDeleteRows = false;
            dgvPendientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientes.BackgroundColor = Color.White;
            dgvPendientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPendientes.ColumnHeadersHeight = 34;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendientes.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colModalidad, colTotalS });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPendientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPendientes.Dock = DockStyle.Fill;
            dgvPendientes.EnableHeadersVisualStyles = false;
            dgvPendientes.GridColor = Color.FromArgb(208, 215, 222);
            dgvPendientes.Location = new Point(10, 26);
            dgvPendientes.MultiSelect = false;
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.ReadOnly = true;
            dgvPendientes.RowHeadersVisible = false;
            dgvPendientes.RowTemplate.Height = 28;
            dgvPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendientes.Size = new Size(940, 162);
            dgvPendientes.TabIndex = 0;
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
            // colModalidad
            // 
            colModalidad.HeaderText = "Modalidad";
            colModalidad.Name = "colModalidad";
            colModalidad.ReadOnly = true;
            // 
            // colTotalS
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTotalS.DefaultCellStyle = dataGridViewCellStyle3;
            colTotalS.HeaderText = "Total (S/)";
            colTotalS.Name = "colTotalS";
            colTotalS.ReadOnly = true;
            // 
            // grpDetalle
            // 
            grpDetalle.BackColor = Color.White;
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalle.ForeColor = Color.FromArgb(11, 61, 110);
            grpDetalle.Location = new Point(20, 278);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Padding = new Padding(10, 8, 10, 10);
            grpDetalle.Size = new Size(960, 176);
            grpDetalle.TabIndex = 4;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "  Detalle del importe";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(242, 246, 250);
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.ColumnHeadersHeight = 34;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colExamen, colTarifaS });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle8;
            dgvDetalle.Dock = DockStyle.Fill;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.FromArgb(208, 215, 222);
            dgvDetalle.Location = new Point(10, 26);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowTemplate.Height = 28;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(940, 140);
            dgvDetalle.TabIndex = 0;
            // 
            // colExamen
            // 
            colExamen.HeaderText = "Examen";
            colExamen.Name = "colExamen";
            colExamen.ReadOnly = true;
            // 
            // colTarifaS
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTarifaS.DefaultCellStyle = dataGridViewCellStyle7;
            colTarifaS.HeaderText = "Tarifa (S/)";
            colTarifaS.Name = "colTarifaS";
            colTarifaS.ReadOnly = true;
            // 
            // grpMedioDePago
            // 
            grpMedioDePago.BackColor = Color.White;
            grpMedioDePago.Controls.Add(lblDescuento);
            grpMedioDePago.Controls.Add(nudMontoRecibido);
            grpMedioDePago.Controls.Add(lblMontoRecibido);
            grpMedioDePago.Controls.Add(cboMedioPago);
            grpMedioDePago.Controls.Add(lblMedioPago);
            grpMedioDePago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMedioDePago.ForeColor = Color.FromArgb(11, 61, 110);
            grpMedioDePago.Location = new Point(20, 464);
            grpMedioDePago.Name = "grpMedioDePago";
            grpMedioDePago.Size = new Size(475, 116);
            grpMedioDePago.TabIndex = 5;
            grpMedioDePago.TabStop = false;
            grpMedioDePago.Text = "Medio de pago";
            // 
            // lblDescuento
            // 
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.Dock = DockStyle.Top;
            lblDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.ForeColor = Color.FromArgb(31, 35, 40);
            lblDescuento.Location = new Point(3, 21);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(469, 34);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "Descuento: S/ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudMontoRecibido
            // 
            nudMontoRecibido.BackColor = Color.White;
            nudMontoRecibido.BorderStyle = BorderStyle.FixedSingle;
            nudMontoRecibido.DecimalPlaces = 2;
            nudMontoRecibido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudMontoRecibido.ForeColor = Color.FromArgb(31, 35, 40);
            nudMontoRecibido.Location = new Point(182, 70);
            nudMontoRecibido.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudMontoRecibido.Name = "nudMontoRecibido";
            nudMontoRecibido.Size = new Size(120, 25);
            nudMontoRecibido.TabIndex = 3;
            nudMontoRecibido.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMontoRecibido
            // 
            lblMontoRecibido.AutoSize = true;
            lblMontoRecibido.BackColor = Color.Transparent;
            lblMontoRecibido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontoRecibido.ForeColor = Color.FromArgb(31, 35, 40);
            lblMontoRecibido.Location = new Point(15, 73);
            lblMontoRecibido.Name = "lblMontoRecibido";
            lblMontoRecibido.Size = new Size(123, 17);
            lblMontoRecibido.TabIndex = 2;
            lblMontoRecibido.Text = "Monto recibido (S/)";
            // 
            // cboMedioPago
            // 
            cboMedioPago.BackColor = Color.White;
            cboMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedioPago.FlatStyle = FlatStyle.Flat;
            cboMedioPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMedioPago.ForeColor = Color.FromArgb(31, 35, 40);
            cboMedioPago.FormattingEnabled = true;
            cboMedioPago.Location = new Point(182, 32);
            cboMedioPago.Name = "cboMedioPago";
            cboMedioPago.Size = new Size(180, 25);
            cboMedioPago.TabIndex = 1;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.BackColor = Color.Transparent;
            lblMedioPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedioPago.ForeColor = Color.FromArgb(31, 35, 40);
            lblMedioPago.Location = new Point(15, 35);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(109, 17);
            lblMedioPago.TabIndex = 0;
            lblMedioPago.Text = "Medio de pago *";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(11, 61, 110);
            lblTotal.Location = new Point(480, 464);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(240, 34);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total a pagar: S/ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVuelto
            // 
            lblVuelto.BackColor = Color.Transparent;
            lblVuelto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVuelto.ForeColor = Color.FromArgb(11, 61, 110);
            lblVuelto.Location = new Point(730, 464);
            lblVuelto.Name = "lblVuelto";
            lblVuelto.Size = new Size(240, 34);
            lblVuelto.TabIndex = 7;
            lblVuelto.Text = "Vuelto: S/ 0.00";
            lblVuelto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(lblVuelto);
            Controls.Add(lblTotal);
            Controls.Add(grpMedioDePago);
            Controls.Add(grpDetalle);
            Controls.Add(grpPendientes);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar pago";
            Load += FrmRegistrarPago_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpMedioDePago.ResumeLayout(false);
            grpMedioDePago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoRecibido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnRegistrar;
        private GroupBox grpPendientes;
        private DataGridView dgvPendientes;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colModalidad;
        private DataGridViewTextBoxColumn colTotalS;
        private GroupBox grpDetalle;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn colExamen;
        private DataGridViewTextBoxColumn colTarifaS;
        private GroupBox grpMedioDePago;
        private ComboBox cboMedioPago;
        private Label lblMedioPago;
        private NumericUpDown nudMontoRecibido;
        private Label lblMontoRecibido;
        private Label lblDescuento;
        private Label lblTotal;
        private Label lblVuelto;
    }
}
