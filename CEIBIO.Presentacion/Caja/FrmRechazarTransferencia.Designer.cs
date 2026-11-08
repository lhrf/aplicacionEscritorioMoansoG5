namespace CEIBIO.Presentacion.Caja
{
    partial class FrmRechazarTransferencia
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnRechazar = new Button();
            grpTransferencia = new GroupBox();
            lblNumeroAtencion = new Label();
            txtNumeroAtencion = new TextBox();
            lblImporte = new Label();
            txtImporte = new TextBox();
            lblObservacion = new Label();
            txtObservacion = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpTransferencia.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(520, 46);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Rechazar transferencia";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnRechazar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 300);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(520, 60);
            flpBotones.TabIndex = 1;
            flpBotones.WrapContents = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new Point(367, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
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
            btnRechazar.Location = new Point(231, 15);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(130, 36);
            btnRechazar.TabIndex = 1;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            // 
            // grpTransferencia
            // 
            grpTransferencia.BackColor = Color.White;
            grpTransferencia.Controls.Add(txtObservacion);
            grpTransferencia.Controls.Add(lblObservacion);
            grpTransferencia.Controls.Add(txtImporte);
            grpTransferencia.Controls.Add(lblImporte);
            grpTransferencia.Controls.Add(txtNumeroAtencion);
            grpTransferencia.Controls.Add(lblNumeroAtencion);
            grpTransferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTransferencia.ForeColor = Color.FromArgb(11, 61, 110);
            grpTransferencia.Location = new Point(20, 60);
            grpTransferencia.Name = "grpTransferencia";
            grpTransferencia.Size = new Size(480, 188);
            grpTransferencia.TabIndex = 2;
            grpTransferencia.TabStop = false;
            grpTransferencia.Text = "Transferencia";
            // 
            // lblNumeroAtencion
            // 
            lblNumeroAtencion.AutoSize = true;
            lblNumeroAtencion.BackColor = Color.Transparent;
            lblNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroAtencion.Location = new Point(15, 35);
            lblNumeroAtencion.Name = "lblNumeroAtencion";
            lblNumeroAtencion.Size = new Size(103, 17);
            lblNumeroAtencion.TabIndex = 0;
            lblNumeroAtencion.Text = "N.° de atención";
            // 
            // txtNumeroAtencion
            // 
            txtNumeroAtencion.BackColor = Color.FromArgb(233, 238, 243);
            txtNumeroAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroAtencion.Location = new Point(149, 32);
            txtNumeroAtencion.Name = "txtNumeroAtencion";
            txtNumeroAtencion.ReadOnly = true;
            txtNumeroAtencion.Size = new Size(120, 25);
            txtNumeroAtencion.TabIndex = 1;
            txtNumeroAtencion.TabStop = false;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.BackColor = Color.Transparent;
            lblImporte.ForeColor = Color.FromArgb(31, 35, 40);
            lblImporte.Location = new Point(15, 73);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(84, 17);
            lblImporte.TabIndex = 2;
            lblImporte.Text = "Importe (S/)";
            // 
            // txtImporte
            // 
            txtImporte.BackColor = Color.FromArgb(233, 238, 243);
            txtImporte.ForeColor = Color.FromArgb(31, 35, 40);
            txtImporte.Location = new Point(149, 70);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(120, 25);
            txtImporte.TabIndex = 3;
            txtImporte.TabStop = false;
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.BackColor = Color.Transparent;
            lblObservacion.ForeColor = Color.FromArgb(31, 35, 40);
            lblObservacion.Location = new Point(15, 111);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(95, 17);
            lblObservacion.TabIndex = 4;
            lblObservacion.Text = "Observación *";
            // 
            // txtObservacion
            // 
            txtObservacion.BackColor = Color.White;
            txtObservacion.Location = new Point(149, 108);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.ScrollBars = ScrollBars.Vertical;
            txtObservacion.Size = new Size(260, 60);
            txtObservacion.TabIndex = 5;
            // 
            // FrmRechazarTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(520, 360);
            Controls.Add(grpTransferencia);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRechazarTransferencia";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rechazar transferencia";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpTransferencia.ResumeLayout(false);
            grpTransferencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnRechazar;
        private GroupBox grpTransferencia;
        private TextBox txtImporte;
        private Label lblImporte;
        private TextBox txtNumeroAtencion;
        private Label lblNumeroAtencion;
        private TextBox txtObservacion;
        private Label lblObservacion;
    }
}
