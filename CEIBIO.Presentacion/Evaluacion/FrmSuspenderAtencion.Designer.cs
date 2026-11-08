namespace CEIBIO.Presentacion.Evaluacion
{
    partial class FrmSuspenderAtencion
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
            btnSuspender = new Button();
            grpSuspension = new GroupBox();
            lblNumeroAtencion = new Label();
            txtNumeroAtencion = new TextBox();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblNuevaFecha = new Label();
            dtpNuevaFecha = new DateTimePicker();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpSuspension.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(520, 56);
            pnlEncabezado.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Suspender atención";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnSuspender);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 313);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(520, 60);
            flpBotones.TabIndex = 3;
            flpBotones.WrapContents = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new Point(367, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSuspender
            // 
            btnSuspender.BackColor = Color.FromArgb(180, 35, 24);
            btnSuspender.Cursor = Cursors.Hand;
            btnSuspender.FlatAppearance.BorderSize = 0;
            btnSuspender.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnSuspender.FlatStyle = FlatStyle.Flat;
            btnSuspender.ForeColor = Color.White;
            btnSuspender.Location = new Point(231, 15);
            btnSuspender.Name = "btnSuspender";
            btnSuspender.Size = new Size(130, 36);
            btnSuspender.TabIndex = 1;
            btnSuspender.Text = "Suspender";
            btnSuspender.UseVisualStyleBackColor = false;
            // 
            // grpSuspension
            // 
            grpSuspension.BackColor = Color.White;
            grpSuspension.Controls.Add(dtpNuevaFecha);
            grpSuspension.Controls.Add(lblNuevaFecha);
            grpSuspension.Controls.Add(txtMotivo);
            grpSuspension.Controls.Add(lblMotivo);
            grpSuspension.Controls.Add(txtPaciente);
            grpSuspension.Controls.Add(lblPaciente);
            grpSuspension.Controls.Add(txtNumeroAtencion);
            grpSuspension.Controls.Add(lblNumeroAtencion);
            grpSuspension.ForeColor = Color.FromArgb(11, 61, 110);
            grpSuspension.Location = new Point(20, 60);
            grpSuspension.Name = "grpSuspension";
            grpSuspension.Size = new Size(480, 239);
            grpSuspension.TabIndex = 4;
            grpSuspension.TabStop = false;
            grpSuspension.Text = "Suspensión";
            // 
            // lblNumeroAtencion
            // 
            lblNumeroAtencion.AutoSize = true;
            lblNumeroAtencion.BackColor = Color.Transparent;
            lblNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroAtencion.Location = new Point(15, 35);
            lblNumeroAtencion.Name = "lblNumeroAtencion";
            lblNumeroAtencion.Size = new Size(128, 23);
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
            txtNumeroAtencion.Size = new Size(120, 30);
            txtNumeroAtencion.TabIndex = 1;
            txtNumeroAtencion.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(15, 73);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(74, 23);
            lblPaciente.TabIndex = 2;
            lblPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(149, 70);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(260, 30);
            txtPaciente.TabIndex = 3;
            txtPaciente.TabStop = false;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.BackColor = Color.Transparent;
            lblMotivo.ForeColor = Color.FromArgb(31, 35, 40);
            lblMotivo.Location = new Point(15, 111);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(75, 23);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "Motivo *";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = Color.White;
            txtMotivo.BorderStyle = BorderStyle.FixedSingle;
            txtMotivo.ForeColor = Color.FromArgb(31, 35, 40);
            txtMotivo.Location = new Point(149, 108);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(260, 60);
            txtMotivo.TabIndex = 5;
            txtMotivo.TabStop = false;
            // 
            // lblNuevaFecha
            // 
            lblNuevaFecha.AutoSize = true;
            lblNuevaFecha.BackColor = Color.Transparent;
            lblNuevaFecha.ForeColor = Color.FromArgb(31, 35, 40);
            lblNuevaFecha.Location = new Point(15, 183);
            lblNuevaFecha.Name = "lblNuevaFecha";
            lblNuevaFecha.Size = new Size(117, 23);
            lblNuevaFecha.TabIndex = 6;
            lblNuevaFecha.Text = "Nueva fecha *";
            // 
            // dtpNuevaFecha
            // 
            dtpNuevaFecha.Format = DateTimePickerFormat.Short;
            dtpNuevaFecha.Location = new Point(149, 180);
            dtpNuevaFecha.Name = "dtpNuevaFecha";
            dtpNuevaFecha.Size = new Size(200, 30);
            dtpNuevaFecha.TabIndex = 7;
            // 
            // FrmSuspenderAtencion
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 373);
            Controls.Add(grpSuspension);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSuspenderAtencion";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Suspender atención";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpSuspension.ResumeLayout(false);
            grpSuspension.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnSuspender;
        private GroupBox grpSuspension;
        private TextBox txtNumeroAtencion;
        private Label lblNumeroAtencion;
        private Label lblMotivo;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private Label lblNuevaFecha;
        private TextBox txtMotivo;
        private DateTimePicker dtpNuevaFecha;
    }
}
