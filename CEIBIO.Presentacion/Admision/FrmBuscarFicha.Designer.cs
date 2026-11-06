namespace CEIBIO.Presentacion.Admision
{
    partial class FrmBuscarFicha
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnRegistrarFicha = new Button();
            grpBusqueda = new GroupBox();
            lblDni = new Label();
            txtDni = new TextBox();
            btnBuscar = new Button();
            grpDatosDeFiliacion = new GroupBox();
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
            grpAtenciones = new GroupBox();
            dgvAtenciones = new DataGridView();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpDatosDeFiliacion.SuspendLayout();
            grpAtenciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(982, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Buscar Ficha clínica histórica";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnActualizar);
            flpBotones.Controls.Add(btnRegistrarFicha);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 543);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(982, 60);
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
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(829, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(11, 61, 110);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(662, 15);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(161, 36);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar datos";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarFicha
            // 
            btnRegistrarFicha.BackColor = Color.White;
            btnRegistrarFicha.Cursor = Cursors.Hand;
            btnRegistrarFicha.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnRegistrarFicha.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnRegistrarFicha.FlatStyle = FlatStyle.Flat;
            btnRegistrarFicha.ForeColor = Color.FromArgb(11, 61, 110);
            btnRegistrarFicha.Location = new Point(454, 15);
            btnRegistrarFicha.Name = "btnRegistrarFicha";
            btnRegistrarFicha.Size = new Size(202, 36);
            btnRegistrarFicha.TabIndex = 2;
            btnRegistrarFicha.Text = "Registrar nueva ficha";
            btnRegistrarFicha.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.BackColor = Color.White;
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Controls.Add(txtDni);
            grpBusqueda.Controls.Add(lblDni);
            grpBusqueda.ForeColor = Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new Point(20, 70);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(960, 78);
            grpBusqueda.TabIndex = 3;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.ForeColor = Color.FromArgb(31, 35, 40);
            lblDni.Location = new Point(15, 35);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(45, 20);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI *";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 35, 40);
            txtDni.Location = new Point(125, 32);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(120, 27);
            txtDni.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.Location = new Point(255, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpDatosDeFiliacion
            // 
            grpDatosDeFiliacion.BackColor = Color.White;
            grpDatosDeFiliacion.Controls.Add(txtTelefono);
            grpDatosDeFiliacion.Controls.Add(lblTelefono);
            grpDatosDeFiliacion.Controls.Add(txtDireccion);
            grpDatosDeFiliacion.Controls.Add(lblDireccion);
            grpDatosDeFiliacion.Controls.Add(cboSexo);
            grpDatosDeFiliacion.Controls.Add(lblSexo);
            grpDatosDeFiliacion.Controls.Add(dtpFechaNacimiento);
            grpDatosDeFiliacion.Controls.Add(lblFechaNacimiento);
            grpDatosDeFiliacion.Controls.Add(txtApellidos);
            grpDatosDeFiliacion.Controls.Add(lblApellidos);
            grpDatosDeFiliacion.Controls.Add(txtNombres);
            grpDatosDeFiliacion.Controls.Add(lblNombres);
            grpDatosDeFiliacion.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatosDeFiliacion.Location = new Point(20, 158);
            grpDatosDeFiliacion.Name = "grpDatosDeFiliacion";
            grpDatosDeFiliacion.Size = new Size(960, 154);
            grpDatosDeFiliacion.TabIndex = 4;
            grpDatosDeFiliacion.TabStop = false;
            grpDatosDeFiliacion.Text = "Datos de filiación";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.BackColor = Color.Transparent;
            lblNombres.ForeColor = Color.FromArgb(31, 35, 40);
            lblNombres.Location = new Point(15, 35);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.White;
            txtNombres.ForeColor = Color.FromArgb(31, 35, 40);
            txtNombres.Location = new Point(182, 32);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(260, 27);
            txtNombres.TabIndex = 1;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.BackColor = Color.Transparent;
            lblApellidos.ForeColor = Color.FromArgb(31, 35, 40);
            lblApellidos.Location = new Point(15, 73);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(72, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.White;
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.ForeColor = Color.FromArgb(31, 35, 40);
            txtApellidos.Location = new Point(182, 70);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(260, 27);
            txtApellidos.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaNacimiento.Location = new Point(15, 111);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(146, 20);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(182, 108);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 27);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.Transparent;
            lblSexo.ForeColor = Color.FromArgb(31, 35, 40);
            lblSexo.Location = new Point(495, 35);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(41, 20);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo";
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FlatStyle = FlatStyle.Flat;
            cboSexo.ForeColor = Color.FromArgb(31, 35, 40);
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cboSexo.Location = new Point(605, 32);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(150, 28);
            cboSexo.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            lblDireccion.Location = new Point(495, 73);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            txtDireccion.Location = new Point(605, 70);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(260, 27);
            txtDireccion.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            lblTelefono.Location = new Point(495, 111);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            txtTelefono.Location = new Point(605, 108);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 27);
            txtTelefono.TabIndex = 11;
            // 
            // grpAtenciones
            // 
            grpAtenciones.BackColor = Color.White;
            grpAtenciones.Controls.Add(dgvAtenciones);
            grpAtenciones.ForeColor = Color.FromArgb(11, 61, 110);
            grpAtenciones.Location = new Point(20, 322);
            grpAtenciones.Name = "grpAtenciones";
            grpAtenciones.Padding = new Padding(10, 8, 10, 10);
            grpAtenciones.Size = new Size(960, 230);
            grpAtenciones.TabIndex = 5;
            grpAtenciones.TabStop = false;
            grpAtenciones.Text = " Atenciones anteriores";
            // 
            // dgvAtenciones
            // 
            dgvAtenciones.AllowUserToAddRows = false;
            dgvAtenciones.AllowUserToDeleteRows = false;
            dgvAtenciones.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvAtenciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAtenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtenciones.BackgroundColor = Color.White;
            dgvAtenciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAtenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAtenciones.ColumnHeadersHeight = 34;
            dgvAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAtenciones.Dock = DockStyle.Fill;
            dgvAtenciones.EnableHeadersVisualStyles = false;
            dgvAtenciones.GridColor = Color.FromArgb(208, 215, 222);
            dgvAtenciones.Location = new Point(10, 28);
            dgvAtenciones.MultiSelect = false;
            dgvAtenciones.Name = "dgvAtenciones";
            dgvAtenciones.ReadOnly = true;
            dgvAtenciones.RowHeadersVisible = false;
            dgvAtenciones.RowHeadersWidth = 51;
            dgvAtenciones.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAtenciones.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(31, 35, 40);
            dgvAtenciones.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dgvAtenciones.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dgvAtenciones.RowTemplate.Height = 28;
            dgvAtenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtenciones.Size = new Size(940, 192);
            dgvAtenciones.TabIndex = 0;
            // 
            // FrmBuscarFicha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(982, 603);
            Controls.Add(grpAtenciones);
            Controls.Add(grpDatosDeFiliacion);
            Controls.Add(grpBusqueda);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Name = "FrmBuscarFicha";
            Text = "Buscar Ficha clínica histórica";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpDatosDeFiliacion.ResumeLayout(false);
            grpDatosDeFiliacion.PerformLayout();
            grpAtenciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnRegistrarFicha;
        private GroupBox grpBusqueda;
        private Label lblDni;
        private Button btnBuscar;
        private TextBox txtDni;
        private GroupBox grpDatosDeFiliacion;
        private Label lblNombres;
        private Label lblApellidos;
        private TextBox txtNombres;
        private Label lblFechaNacimiento;
        private TextBox txtApellidos;
        private ComboBox cboSexo;
        private Label lblSexo;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private GroupBox grpAtenciones;
        private DataGridView dgvAtenciones;
    }
}