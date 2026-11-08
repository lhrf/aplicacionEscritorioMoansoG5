namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantMediosPago
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
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colRequiereAutorizacion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            grpDatos = new GroupBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            chkRequiereAutorizacion = new CheckBox();
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
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(342, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenedor de medios de pago";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.FromArgb(255, 255, 255);
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
            flpBotones.TabIndex = 4;
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
            btnCerrar.TabIndex = 0;
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
            btnCancelar.TabIndex = 1;
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
            btnGuardar.ForeColor = Color.FromArgb(255, 255, 255);
            btnGuardar.Location = new Point(575, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 2;
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
            btnInhabilitar.ForeColor = Color.FromArgb(255, 255, 255);
            btnInhabilitar.Location = new Point(439, 15);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(130, 36);
            btnInhabilitar.TabIndex = 3;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 255);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(11, 61, 110);
            btnEditar.Location = new Point(303, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(255, 255, 255);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.FromArgb(11, 61, 110);
            btnNuevo.Location = new Point(167, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 36);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.BackColor = Color.FromArgb(255, 255, 255);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBusqueda.ForeColor = Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new Point(20, 70);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(960, 78);
            grpBusqueda.TabIndex = 1;
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
            txtBuscar.BackColor = Color.FromArgb(255, 255, 255);
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
            btnBuscar.BackColor = Color.FromArgb(255, 255, 255);
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
            grpRegistros.BackColor = Color.FromArgb(255, 255, 255);
            grpRegistros.Controls.Add(dgvRegistros);
            grpRegistros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegistros.ForeColor = Color.FromArgb(11, 61, 110);
            grpRegistros.Location = new Point(20, 158);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Padding = new Padding(10, 8, 10, 10);
            grpRegistros.Size = new Size(960, 238);
            grpRegistros.TabIndex = 2;
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
            dgvRegistros.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvRegistros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.ColumnHeadersHeight = 34;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colRequiereAutorizacion, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
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
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colRequiereAutorizacion
            // 
            colRequiereAutorizacion.HeaderText = "Requiere autorización";
            colRequiereAutorizacion.Name = "colRequiereAutorizacion";
            colRequiereAutorizacion.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.FromArgb(255, 255, 255);
            grpDatos.Controls.Add(lblCodigo);
            grpDatos.Controls.Add(txtCodigo);
            grpDatos.Controls.Add(lblDescripcion);
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(chkRequiereAutorizacion);
            grpDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDatos.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatos.Location = new Point(20, 406);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(960, 154);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            lblCodigo.Location = new Point(15, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(63, 19);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código *";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(255, 255, 255);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            txtCodigo.Location = new Point(125, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 25);
            txtCodigo.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(31, 35, 40);
            lblDescripcion.Location = new Point(15, 73);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 19);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 255, 255);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(31, 35, 40);
            txtDescripcion.Location = new Point(125, 70);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(260, 25);
            txtDescripcion.TabIndex = 3;
            // 
            // chkRequiereAutorizacion
            // 
            chkRequiereAutorizacion.AutoSize = true;
            chkRequiereAutorizacion.BackColor = Color.Transparent;
            chkRequiereAutorizacion.Font = new Font("Segoe UI", 10F);
            chkRequiereAutorizacion.ForeColor = Color.FromArgb(31, 35, 40);
            chkRequiereAutorizacion.Location = new Point(495, 33);
            chkRequiereAutorizacion.Name = "chkRequiereAutorizacion";
            chkRequiereAutorizacion.Size = new Size(320, 23);
            chkRequiereAutorizacion.TabIndex = 4;
            chkRequiereAutorizacion.Text = "Requiere autorización del Supervisor de Turno";
            chkRequiereAutorizacion.UseVisualStyleBackColor = false;
            // 
            // FrmMantMediosPago
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
            Name = "FrmMantMediosPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenedor de medios de pago";
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

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequiereAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkRequiereAutorizacion;
    }
}
