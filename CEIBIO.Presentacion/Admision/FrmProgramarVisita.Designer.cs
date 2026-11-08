namespace CEIBIO.Presentacion.Admision
{
    partial class FrmProgramarVisita
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
            btnCerrar = new Button();
            btnGuardar = new Button();
            btnCancelarVisita = new Button();
            btnReprogramar = new Button();
            grpAtencion = new GroupBox();
            lblNumeroAtencion = new Label();
            txtNumeroAtencion = new TextBox();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            grpDatosDeLaVisita = new GroupBox();
            lblDireccion = new Label();
            lblReferencia = new Label();
            lblTelefono = new Label();
            lblFechaProgramada = new Label();
            lblMotivo = new Label();
            txtDireccion = new TextBox();
            txtReferencia = new TextBox();
            txtTelefono = new TextBox();
            txtMotivo = new TextBox();
            dtpFechaProgramada = new DateTimePicker();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpAtencion.SuspendLayout();
            grpDatosDeLaVisita.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(609, 46);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Programar visita domiciliaria";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnCancelarVisita);
            flpBotones.Controls.Add(btnReprogramar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 453);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(609, 60);
            flpBotones.TabIndex = 2;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(289, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(11, 61, 110);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(425, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVisita
            // 
            btnCancelarVisita.BackColor = Color.FromArgb(180, 35, 24);
            btnCancelarVisita.Cursor = Cursors.Hand;
            btnCancelarVisita.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnCancelarVisita.FlatAppearance.BorderSize = 0;
            btnCancelarVisita.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnCancelarVisita.FlatStyle = FlatStyle.Flat;
            btnCancelarVisita.ForeColor = Color.White;
            btnCancelarVisita.Location = new Point(130, 15);
            btnCancelarVisita.Name = "btnCancelarVisita";
            btnCancelarVisita.Size = new Size(153, 36);
            btnCancelarVisita.TabIndex = 2;
            btnCancelarVisita.Text = "Cancelar visita";
            btnCancelarVisita.UseVisualStyleBackColor = false;
            // 
            // btnReprogramar
            // 
            btnReprogramar.Cursor = Cursors.Hand;
            btnReprogramar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnReprogramar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnReprogramar.FlatStyle = FlatStyle.Flat;
            btnReprogramar.ForeColor = Color.FromArgb(11, 61, 110);
            btnReprogramar.Location = new Point(-6, 15);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(130, 36);
            btnReprogramar.TabIndex = 3;
            btnReprogramar.Text = "Reprogramar";
            btnReprogramar.UseVisualStyleBackColor = false;
            // 
            // grpAtencion
            // 
            grpAtencion.Controls.Add(txtPaciente);
            grpAtencion.Controls.Add(lblPaciente);
            grpAtencion.Controls.Add(txtNumeroAtencion);
            grpAtencion.Controls.Add(lblNumeroAtencion);
            grpAtencion.ForeColor = Color.FromArgb(11, 61, 110);
            grpAtencion.Location = new Point(20, 60);
            grpAtencion.Name = "grpAtencion";
            grpAtencion.Size = new Size(570, 116);
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
            txtNumeroAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroAtencion.Location = new Point(149, 32);
            txtNumeroAtencion.Name = "txtNumeroAtencion";
            txtNumeroAtencion.ReadOnly = true;
            txtNumeroAtencion.Size = new Size(120, 30);
            txtNumeroAtencion.TabIndex = 1;
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
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(149, 70);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(280, 30);
            txtPaciente.TabIndex = 4;
            txtPaciente.TabStop = false;
            // 
            // grpDatosDeLaVisita
            // 
            grpDatosDeLaVisita.Controls.Add(dtpFechaProgramada);
            grpDatosDeLaVisita.Controls.Add(txtMotivo);
            grpDatosDeLaVisita.Controls.Add(txtTelefono);
            grpDatosDeLaVisita.Controls.Add(txtReferencia);
            grpDatosDeLaVisita.Controls.Add(txtDireccion);
            grpDatosDeLaVisita.Controls.Add(lblMotivo);
            grpDatosDeLaVisita.Controls.Add(lblFechaProgramada);
            grpDatosDeLaVisita.Controls.Add(lblTelefono);
            grpDatosDeLaVisita.Controls.Add(lblReferencia);
            grpDatosDeLaVisita.Controls.Add(lblDireccion);
            grpDatosDeLaVisita.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatosDeLaVisita.Location = new Point(20, 186);
            grpDatosDeLaVisita.Name = "grpDatosDeLaVisita";
            grpDatosDeLaVisita.Size = new Size(570, 264);
            grpDatosDeLaVisita.TabIndex = 4;
            grpDatosDeLaVisita.TabStop = false;
            grpDatosDeLaVisita.Text = "Datos de la visita";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            lblDireccion.Location = new Point(15, 35);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(93, 23);
            lblDireccion.TabIndex = 0;
            lblDireccion.Text = "Dirección *";
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.BackColor = Color.Transparent;
            lblReferencia.ForeColor = Color.FromArgb(31, 35, 40);
            lblReferencia.Location = new Point(15, 74);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(89, 23);
            lblReferencia.TabIndex = 1;
            lblReferencia.Text = "Referencia";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            lblTelefono.Location = new Point(15, 115);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 23);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono *";
            // 
            // lblFechaProgramada
            // 
            lblFechaProgramada.AutoSize = true;
            lblFechaProgramada.BackColor = Color.Transparent;
            lblFechaProgramada.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaProgramada.Location = new Point(15, 149);
            lblFechaProgramada.Name = "lblFechaProgramada";
            lblFechaProgramada.Size = new Size(165, 23);
            lblFechaProgramada.TabIndex = 3;
            lblFechaProgramada.Text = "Fecha programada *";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.BackColor = Color.Transparent;
            lblMotivo.ForeColor = Color.FromArgb(31, 35, 40);
            lblMotivo.Location = new Point(15, 187);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(257, 23);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "Motivo (reprogramar o cancelar)";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(275, 32);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 30);
            txtDireccion.TabIndex = 5;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(275, 70);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(125, 30);
            txtReferencia.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(275, 108);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 30);
            txtTelefono.TabIndex = 7;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(275, 184);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(280, 30);
            txtMotivo.TabIndex = 8;
            // 
            // dtpFechaProgramada
            // 
            dtpFechaProgramada.Format = DateTimePickerFormat.Short;
            dtpFechaProgramada.Location = new Point(275, 146);
            dtpFechaProgramada.Name = "dtpFechaProgramada";
            dtpFechaProgramada.Size = new Size(200, 30);
            dtpFechaProgramada.TabIndex = 10;
            // 
            // FrmProgramarVisita
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 513);
            Controls.Add(grpDatosDeLaVisita);
            Controls.Add(grpAtencion);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProgramarVisita";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Programar visita domiciliaria";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpAtencion.ResumeLayout(false);
            grpAtencion.PerformLayout();
            grpDatosDeLaVisita.ResumeLayout(false);
            grpDatosDeLaVisita.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnGuardar;
        private Button btnCancelarVisita;
        private Button btnReprogramar;
        private GroupBox grpAtencion;
        private Label lblNumeroAtencion;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private TextBox txtNumeroAtencion;
        private GroupBox grpDatosDeLaVisita;
        private Label lblMotivo;
        private Label lblFechaProgramada;
        private Label lblTelefono;
        private Label lblReferencia;
        private Label lblDireccion;
        private TextBox txtMotivo;
        private TextBox txtTelefono;
        private TextBox txtReferencia;
        private TextBox txtDireccion;
        private DateTimePicker dtpFechaProgramada;
    }
}
