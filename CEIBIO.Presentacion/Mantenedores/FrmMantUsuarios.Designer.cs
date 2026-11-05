namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantUsuarios
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnInhabilitar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            grpBusqueda = new GroupBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            grpRegistros = new GroupBox();
            dgvRegistros = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            grpDatos = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            lblRol = new Label();
            cboRol = new ComboBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            grpDatos.SuspendLayout();
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
            pnlEncabezado.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenedor de usuarios";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Controls.Add(btnInhabilitar);
            flpBotones.Controls.Add(btnEditar);
            flpBotones.Controls.Add(btnNuevo);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 570);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 3;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
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
            btnCancelar.Location = new Point(711, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 4;
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
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(575, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.BackColor = Color.FromArgb(180, 35, 24);
            btnInhabilitar.Cursor = Cursors.Hand;
            btnInhabilitar.FlatAppearance.BorderSize = 0;
            btnInhabilitar.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnInhabilitar.FlatStyle = FlatStyle.Flat;
            btnInhabilitar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(439, 15);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(130, 36);
            btnInhabilitar.TabIndex = 2;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(11, 61, 110);
            btnEditar.Location = new Point(303, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.White;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.FromArgb(11, 61, 110);
            btnNuevo.Location = new Point(167, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 36);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.BackColor = Color.White;
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBusqueda.ForeColor = Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new Point(20, 70);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(960, 78);
            grpBusqueda.TabIndex = 0;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(31, 35, 40);
            lblBuscar.Location = new Point(15, 35);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(49, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.FromArgb(31, 35, 40);
            txtBuscar.Location = new Point(125, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(300, 25);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new Point(435, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpRegistros
            // 
            grpRegistros.BackColor = Color.White;
            grpRegistros.Controls.Add(dgvRegistros);
            grpRegistros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegistros.ForeColor = Color.FromArgb(11, 61, 110);
            grpRegistros.Location = new Point(20, 158);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Padding = new Padding(10, 8, 10, 10);
            grpRegistros.Size = new Size(960, 238);
            grpRegistros.TabIndex = 1;
            grpRegistros.TabStop = false;
            grpRegistros.Text = "Registros";
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = Color.White;
            dgvRegistros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.ColumnHeadersHeight = 34;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDNI, colUsuario, colRol, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistros.Dock = DockStyle.Fill;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.GridColor = Color.FromArgb(208, 215, 222);
            dgvRegistros.Location = new Point(10, 26);
            dgvRegistros.MultiSelect = false;
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.RowTemplate.Height = 28;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(940, 202);
            dgvRegistros.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colDNI
            // 
            colDNI.HeaderText = "DNI";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // colRol
            // 
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.White;
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(txtDni);
            grpDatos.Controls.Add(lblUsuario);
            grpDatos.Controls.Add(txtUsuario);
            grpDatos.Controls.Add(lblClave);
            grpDatos.Controls.Add(txtClave);
            grpDatos.Controls.Add(lblRol);
            grpDatos.Controls.Add(cboRol);
            grpDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDatos.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatos.Location = new Point(20, 406);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(960, 154);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(31, 35, 40);
            lblNombre.Location = new Point(15, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(130, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo *";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(31, 35, 40);
            txtNombre.Location = new Point(182, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.ForeColor = Color.FromArgb(31, 35, 40);
            lblDni.Location = new Point(15, 73);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 19);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI *";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 10F);
            txtDni.ForeColor = Color.FromArgb(31, 35, 40);
            txtDni.Location = new Point(182, 70);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(120, 25);
            txtDni.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            lblUsuario.Location = new Point(15, 111);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(137, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Nombre de usuario *";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            txtUsuario.Location = new Point(182, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 25);
            txtUsuario.TabIndex = 5;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = Color.Transparent;
            lblClave.Font = new Font("Segoe UI", 10F);
            lblClave.ForeColor = Color.FromArgb(31, 35, 40);
            lblClave.Location = new Point(495, 35);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(89, 19);
            lblClave.TabIndex = 6;
            lblClave.Text = "Clave inicial *";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.ForeColor = Color.FromArgb(31, 35, 40);
            txtClave.Location = new Point(629, 32);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(200, 25);
            txtClave.TabIndex = 7;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.ForeColor = Color.FromArgb(31, 35, 40);
            lblRol.Location = new Point(495, 73);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 19);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol *";
            // 
            // cboRol
            // 
            cboRol.BackColor = Color.White;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FlatStyle = FlatStyle.Flat;
            cboRol.Font = new Font("Segoe UI", 10F);
            cboRol.ForeColor = Color.FromArgb(31, 35, 40);
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(629, 70);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(240, 25);
            cboRol.TabIndex = 9;
            // 
            // FrmMantUsuarios
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new Size(1000, 630);
            Controls.Add(grpDatos);
            Controls.Add(grpRegistros);
            Controls.Add(grpBusqueda);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMantUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenedor de usuarios";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnInhabilitar;
        private Button btnEditar;
        private Button btnNuevo;
        private GroupBox grpBusqueda;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private GroupBox grpRegistros;
        private DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewTextBoxColumn colEstado;
        private GroupBox grpDatos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private Label lblRol;
        private ComboBox cboRol;
    }
}
