namespace CEIBIO.Presentacion.Admision
{
    partial class FrmRegistrarFicha
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
            btnGuardar = new Button();
            grpDatosDelPaciente = new GroupBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblSexo = new Label();
            cboSexo = new ComboBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpDatosDelPaciente.SuspendLayout();
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
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(242, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Ficha clínica histórica";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 390);
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
            btnCancelar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new Point(367, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(11, 61, 110);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(231, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grpDatosDelPaciente
            // 
            grpDatosDelPaciente.BackColor = Color.Transparent;
            grpDatosDelPaciente.Controls.Add(txtTelefono);
            grpDatosDelPaciente.Controls.Add(lblTelefono);
            grpDatosDelPaciente.Controls.Add(txtDireccion);
            grpDatosDelPaciente.Controls.Add(lblDireccion);
            grpDatosDelPaciente.Controls.Add(cboSexo);
            grpDatosDelPaciente.Controls.Add(lblSexo);
            grpDatosDelPaciente.Controls.Add(dtpFechaNacimiento);
            grpDatosDelPaciente.Controls.Add(lblFechaNacimiento);
            grpDatosDelPaciente.Controls.Add(txtApellidos);
            grpDatosDelPaciente.Controls.Add(lblApellidos);
            grpDatosDelPaciente.Controls.Add(txtNombres);
            grpDatosDelPaciente.Controls.Add(lblNombres);
            grpDatosDelPaciente.Controls.Add(txtDni);
            grpDatosDelPaciente.Controls.Add(lblDni);
            grpDatosDelPaciente.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatosDelPaciente.Location = new Point(20, 60);
            grpDatosDelPaciente.Name = "grpDatosDelPaciente";
            grpDatosDelPaciente.Size = new Size(480, 310);
            grpDatosDelPaciente.TabIndex = 2;
            grpDatosDelPaciente.TabStop = false;
            grpDatosDelPaciente.Text = "Datos del paciente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.ForeColor = Color.FromArgb(31, 35, 40);
            lblDni.Location = new Point(15, 35);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(52, 23);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI *";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 35, 40);
            txtDni.Location = new Point(199, 32);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(120, 30);
            txtDni.TabIndex = 1;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.BackColor = Color.Transparent;
            lblNombres.ForeColor = Color.FromArgb(31, 35, 40);
            lblNombres.Location = new Point(15, 73);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(92, 23);
            lblNombres.TabIndex = 2;
            lblNombres.Text = "Nombres *";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.White;
            txtNombres.BorderStyle = BorderStyle.FixedSingle;
            txtNombres.ForeColor = Color.FromArgb(31, 35, 40);
            txtNombres.Location = new Point(199, 70);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(266, 30);
            txtNombres.TabIndex = 3;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.Transparent;
            lblApellidos.ForeColor = Color.FromArgb(31, 35, 40);
            lblApellidos.Location = new Point(15, 111);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(91, 23);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "Apellidos *";
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.White;
            txtApellidos.ForeColor = Color.FromArgb(31, 35, 40);
            txtApellidos.Location = new Point(199, 108);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(266, 30);
            txtApellidos.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaNacimiento.Location = new Point(15, 149);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(180, 23);
            lblFechaNacimiento.TabIndex = 6;
            lblFechaNacimiento.Text = "Fecha de nacimiento *";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(199, 146);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 30);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.Transparent;
            lblSexo.ForeColor = Color.FromArgb(31, 35, 40);
            lblSexo.Location = new Point(15, 187);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(58, 23);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo *";
            // 
            // cboSexo
            // 
            cboSexo.BackColor = Color.White;
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FlatStyle = FlatStyle.Flat;
            cboSexo.ForeColor = Color.FromArgb(31, 35, 40);
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cboSexo.Location = new Point(199, 184);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(150, 31);
            cboSexo.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            lblDireccion.Location = new Point(15, 225);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(81, 23);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            txtDireccion.Location = new Point(199, 222);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(266, 30);
            txtDireccion.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            lblTelefono.Location = new Point(15, 263);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 23);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            txtTelefono.Location = new Point(199, 260);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 30);
            txtTelefono.TabIndex = 13;
            // 
            // FrmRegistrarFicha
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(grpDatosDelPaciente);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistrarFicha";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar Ficha clínica histórica";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpDatosDelPaciente.ResumeLayout(false);
            grpDatosDelPaciente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnGuardar;
        private GroupBox grpDatosDelPaciente;
        private Label lblNombres;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblFechaNacimiento;
        private TextBox txtApellidos;
        private Label lblApellidos;
        private TextBox txtNombres;
        private Label lblDireccion;
        private ComboBox cboSexo;
        private Label lblSexo;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
    }
}
