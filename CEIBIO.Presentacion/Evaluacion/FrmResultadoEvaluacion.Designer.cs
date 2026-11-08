namespace CEIBIO.Presentacion.Evaluacion
{
    partial class FrmResultadoEvaluacion
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
            grpAtencion = new GroupBox();
            lblNumeroAtencion = new Label();
            txtNumeroAtencion = new TextBox();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnApto = new Button();
            btnSuspender = new Button();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            grpObservacionesRegistradas = new GroupBox();
            lblHorasAyuno = new Label();
            lblMedicamentos = new Label();
            lblEstadoMuestra = new Label();
            lblObservaciones = new Label();
            txtHorasAyuno = new TextBox();
            txtMedicamentos = new TextBox();
            txtEstadoMuestra = new TextBox();
            txtObservaciones = new TextBox();
            pnlEncabezado.SuspendLayout();
            grpAtencion.SuspendLayout();
            flpBotones.SuspendLayout();
            grpObservacionesRegistradas.SuspendLayout();
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
            pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Resultado de la evaluación pre-analítica";
            // 
            // grpAtencion
            // 
            grpAtencion.BackColor = Color.White;
            grpAtencion.Controls.Add(txtPaciente);
            grpAtencion.Controls.Add(lblPaciente);
            grpAtencion.Controls.Add(txtNumeroAtencion);
            grpAtencion.Controls.Add(lblNumeroAtencion);
            grpAtencion.ForeColor = Color.FromArgb(11, 61, 110);
            grpAtencion.Location = new Point(20, 70);
            grpAtencion.Name = "grpAtencion";
            grpAtencion.Size = new Size(960, 78);
            grpAtencion.TabIndex = 3;
            grpAtencion.TabStop = false;
            grpAtencion.Text = "Atención";
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
            txtNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroAtencion.Location = new Point(149, 32);
            txtNumeroAtencion.Name = "txtNumeroAtencion";
            txtNumeroAtencion.ReadOnly = true;
            txtNumeroAtencion.Size = new Size(120, 30);
            txtNumeroAtencion.TabIndex = 1;
            txtNumeroAtencion.TabStop = false;
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnApto);
            flpBotones.Controls.Add(btnSuspender);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 4;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnApto
            // 
            btnApto.BackColor = Color.FromArgb(11, 61, 110);
            btnApto.Cursor = Cursors.Hand;
            btnApto.FlatAppearance.BorderSize = 0;
            btnApto.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnApto.ForeColor = Color.White;
            btnApto.Location = new Point(557, 15);
            btnApto.Name = "btnApto";
            btnApto.Size = new Size(284, 36);
            btnApto.TabIndex = 1;
            btnApto.Text = "Registrar apto y derivar a Cajaç";
            btnApto.UseVisualStyleBackColor = false;
            // 
            // btnSuspender
            // 
            btnSuspender.BackColor = Color.FromArgb(180, 35, 24);
            btnSuspender.Cursor = Cursors.Hand;
            btnSuspender.FlatAppearance.BorderSize = 0;
            btnSuspender.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnSuspender.FlatStyle = FlatStyle.Flat;
            btnSuspender.ForeColor = Color.White;
            btnSuspender.Location = new Point(374, 15);
            btnSuspender.Name = "btnSuspender";
            btnSuspender.Size = new Size(177, 36);
            btnSuspender.TabIndex = 2;
            btnSuspender.Text = "Suspender atención";
            btnSuspender.UseVisualStyleBackColor = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(495, 35);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(74, 23);
            lblPaciente.TabIndex = 2;
            lblPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(605, 32);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(300, 30);
            txtPaciente.TabIndex = 3;
            txtPaciente.TabStop = false;
            // 
            // grpObservacionesRegistradas
            // 
            grpObservacionesRegistradas.BackColor = Color.White;
            grpObservacionesRegistradas.Controls.Add(txtObservaciones);
            grpObservacionesRegistradas.Controls.Add(txtEstadoMuestra);
            grpObservacionesRegistradas.Controls.Add(txtMedicamentos);
            grpObservacionesRegistradas.Controls.Add(txtHorasAyuno);
            grpObservacionesRegistradas.Controls.Add(lblObservaciones);
            grpObservacionesRegistradas.Controls.Add(lblEstadoMuestra);
            grpObservacionesRegistradas.Controls.Add(lblMedicamentos);
            grpObservacionesRegistradas.Controls.Add(lblHorasAyuno);
            grpObservacionesRegistradas.ForeColor = Color.FromArgb(11, 61, 110);
            grpObservacionesRegistradas.Location = new Point(20, 158);
            grpObservacionesRegistradas.Name = "grpObservacionesRegistradas";
            grpObservacionesRegistradas.Size = new Size(960, 150);
            grpObservacionesRegistradas.TabIndex = 5;
            grpObservacionesRegistradas.TabStop = false;
            grpObservacionesRegistradas.Text = "Observaciones registradas";
            // 
            // lblHorasAyuno
            // 
            lblHorasAyuno.AutoSize = true;
            lblHorasAyuno.BackColor = Color.Transparent;
            lblHorasAyuno.ForeColor = Color.FromArgb(31, 35, 40);
            lblHorasAyuno.Location = new Point(15, 35);
            lblHorasAyuno.Name = "lblHorasAyuno";
            lblHorasAyuno.Size = new Size(130, 23);
            lblHorasAyuno.TabIndex = 0;
            lblHorasAyuno.Text = "Horas de ayuno";
            // 
            // lblMedicamentos
            // 
            lblMedicamentos.AutoSize = true;
            lblMedicamentos.BackColor = Color.Transparent;
            lblMedicamentos.ForeColor = Color.FromArgb(31, 35, 40);
            lblMedicamentos.Location = new Point(15, 73);
            lblMedicamentos.Name = "lblMedicamentos";
            lblMedicamentos.Size = new Size(122, 23);
            lblMedicamentos.TabIndex = 1;
            lblMedicamentos.Text = "Medicamentos";
            // 
            // lblEstadoMuestra
            // 
            lblEstadoMuestra.AutoSize = true;
            lblEstadoMuestra.BackColor = Color.Transparent;
            lblEstadoMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            lblEstadoMuestra.Location = new Point(495, 35);
            lblEstadoMuestra.Name = "lblEstadoMuestra";
            lblEstadoMuestra.Size = new Size(170, 23);
            lblEstadoMuestra.TabIndex = 2;
            lblEstadoMuestra.Text = "Estado de la muestra";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.BackColor = Color.Transparent;
            lblObservaciones.ForeColor = Color.FromArgb(31, 35, 40);
            lblObservaciones.Location = new Point(495, 73);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(120, 23);
            lblObservaciones.TabIndex = 3;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtHorasAyuno
            // 
            txtHorasAyuno.ForeColor = Color.FromArgb(31, 35, 40);
            txtHorasAyuno.Location = new Point(141, 32);
            txtHorasAyuno.Name = "txtHorasAyuno";
            txtHorasAyuno.Size = new Size(80, 30);
            txtHorasAyuno.TabIndex = 4;
            txtHorasAyuno.TabStop = false;
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.ForeColor = Color.FromArgb(31, 35, 40);
            txtMedicamentos.Location = new Point(141, 70);
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new Size(300, 30);
            txtMedicamentos.TabIndex = 5;
            txtMedicamentos.TabStop = false;
            // 
            // txtEstadoMuestra
            // 
            txtEstadoMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            txtEstadoMuestra.Location = new Point(671, 32);
            txtEstadoMuestra.Name = "txtEstadoMuestra";
            txtEstadoMuestra.Size = new Size(274, 30);
            txtEstadoMuestra.TabIndex = 6;
            txtEstadoMuestra.TabStop = false;
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.FromArgb(233, 238, 243);
            txtObservaciones.ForeColor = Color.FromArgb(31, 35, 40);
            txtObservaciones.Location = new Point(671, 70);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ReadOnly = true;
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(274, 60);
            txtObservaciones.TabIndex = 7;
            txtObservaciones.TabStop = false;
            // 
            // FrmResultadoEvaluacion
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpObservacionesRegistradas);
            Controls.Add(flpBotones);
            Controls.Add(grpAtencion);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmResultadoEvaluacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado de la evaluación pre-analítica";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            grpAtencion.ResumeLayout(false);
            grpAtencion.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpObservacionesRegistradas.ResumeLayout(false);
            grpObservacionesRegistradas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private GroupBox grpAtencion;
        private Label lblNumeroAtencion;
        private TextBox txtNumeroAtencion;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnApto;
        private Button btnSuspender;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private GroupBox grpObservacionesRegistradas;
        private Label lblHorasAyuno;
        private TextBox txtHorasAyuno;
        private Label lblObservaciones;
        private Label lblEstadoMuestra;
        private Label lblMedicamentos;
        private TextBox txtObservaciones;
        private TextBox txtEstadoMuestra;
        private TextBox txtMedicamentos;
    }
}
