namespace CEIBIO.Presentacion.Entregas
{
    partial class FrmRetenerEntrega
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
            btnRetener = new Button();
            grpRetencion = new GroupBox();
            lblNumeroAtencion = new Label();
            txtNumeroAtencion = new TextBox();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpRetencion.SuspendLayout();
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
            pnlEncabezado.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Retener entrega";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnRetener);
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
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new Point(367, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRetener
            // 
            btnRetener.BackColor = Color.FromArgb(180, 35, 24);
            btnRetener.Cursor = Cursors.Hand;
            btnRetener.FlatAppearance.BorderSize = 0;
            btnRetener.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnRetener.FlatStyle = FlatStyle.Flat;
            btnRetener.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRetener.ForeColor = Color.White;
            btnRetener.Location = new Point(231, 15);
            btnRetener.Name = "btnRetener";
            btnRetener.Size = new Size(130, 36);
            btnRetener.TabIndex = 0;
            btnRetener.Text = "Retener";
            btnRetener.UseVisualStyleBackColor = false;
            // 
            // grpRetencion
            // 
            grpRetencion.BackColor = Color.White;
            grpRetencion.Controls.Add(lblNumeroAtencion);
            grpRetencion.Controls.Add(txtNumeroAtencion);
            grpRetencion.Controls.Add(lblPaciente);
            grpRetencion.Controls.Add(txtPaciente);
            grpRetencion.Controls.Add(lblMotivo);
            grpRetencion.Controls.Add(txtMotivo);
            grpRetencion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRetencion.ForeColor = Color.FromArgb(11, 61, 110);
            grpRetencion.Location = new Point(20, 60);
            grpRetencion.Name = "grpRetencion";
            grpRetencion.Size = new Size(480, 188);
            grpRetencion.TabIndex = 0;
            grpRetencion.TabStop = false;
            grpRetencion.Text = "Retención";
            // 
            // lblNumeroAtencion
            // 
            lblNumeroAtencion.AutoSize = true;
            lblNumeroAtencion.BackColor = Color.Transparent;
            lblNumeroAtencion.Font = new Font("Segoe UI", 10F);
            lblNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroAtencion.Location = new Point(15, 35);
            lblNumeroAtencion.Name = "lblNumeroAtencion";
            lblNumeroAtencion.Size = new Size(102, 19);
            lblNumeroAtencion.TabIndex = 0;
            lblNumeroAtencion.Text = "N.° de atención";
            // 
            // txtNumeroAtencion
            // 
            txtNumeroAtencion.BackColor = Color.FromArgb(233, 238, 243);
            txtNumeroAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroAtencion.Font = new Font("Segoe UI", 10F);
            txtNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroAtencion.Location = new Point(149, 32);
            txtNumeroAtencion.Name = "txtNumeroAtencion";
            txtNumeroAtencion.ReadOnly = true;
            txtNumeroAtencion.Size = new Size(120, 25);
            txtNumeroAtencion.TabIndex = 1;
            txtNumeroAtencion.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.Font = new Font("Segoe UI", 10F);
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(15, 73);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(60, 19);
            lblPaciente.TabIndex = 2;
            lblPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.Font = new Font("Segoe UI", 10F);
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(149, 70);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(260, 25);
            txtPaciente.TabIndex = 3;
            txtPaciente.TabStop = false;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.BackColor = Color.Transparent;
            lblMotivo.Font = new Font("Segoe UI", 10F);
            lblMotivo.ForeColor = Color.FromArgb(31, 35, 40);
            lblMotivo.Location = new Point(15, 111);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(63, 19);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "Motivo *";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.White;
            txtMotivo.BorderStyle = BorderStyle.FixedSingle;
            txtMotivo.Font = new Font("Segoe UI", 10F);
            txtMotivo.ForeColor = Color.FromArgb(31, 35, 40);
            txtMotivo.Location = new Point(149, 108);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(260, 60);
            txtMotivo.TabIndex = 5;
            // 
            // FrmRetenerEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new Size(520, 360);
            Controls.Add(grpRetencion);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRetenerEntrega";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Retener entrega";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpRetencion.ResumeLayout(false);
            grpRetencion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnRetener;
        private GroupBox grpRetencion;
        private Label lblNumeroAtencion;
        private TextBox txtNumeroAtencion;
        private Label lblPaciente;
        private TextBox txtPaciente;
        private Label lblMotivo;
        private TextBox txtMotivo;
    }
}
