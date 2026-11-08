namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantConvenios
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            colInstitucion = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colInicio = new DataGridViewTextBoxColumn();
            colFin = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            grpDatos = new GroupBox();
            lblInstitucion = new Label();
            txtInstitucion = new TextBox();
            lblDescuento = new Label();
            nudDescuento = new NumericUpDown();
            lblInicio = new Label();
            dtpInicio = new DateTimePicker();
            lblFin = new Label();
            dtpFin = new DateTimePicker();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
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
            lblTitulo.Size = new Size(245, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenedor de convenios";
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
            flpBotones.Location = new Point(0, 560);
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
            grpRegistros.Size = new Size(960, 266);
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
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { colInstitucion, colDescuento, colInicio, colFin, colEstado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle4;
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
            dgvRegistros.Size = new Size(940, 230);
            dgvRegistros.TabIndex = 0;
            // 
            // colInstitucion
            // 
            colInstitucion.HeaderText = "Institución";
            colInstitucion.Name = "colInstitucion";
            colInstitucion.ReadOnly = true;
            // 
            // colDescuento
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDescuento.DefaultCellStyle = dataGridViewCellStyle3;
            colDescuento.HeaderText = "Descuento (%)";
            colDescuento.Name = "colDescuento";
            colDescuento.ReadOnly = true;
            // 
            // colInicio
            // 
            colInicio.HeaderText = "Inicio";
            colInicio.Name = "colInicio";
            colInicio.ReadOnly = true;
            // 
            // colFin
            // 
            colFin.HeaderText = "Fin";
            colFin.Name = "colFin";
            colFin.ReadOnly = true;
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
            grpDatos.Controls.Add(lblInstitucion);
            grpDatos.Controls.Add(txtInstitucion);
            grpDatos.Controls.Add(lblDescuento);
            grpDatos.Controls.Add(nudDescuento);
            grpDatos.Controls.Add(lblInicio);
            grpDatos.Controls.Add(dtpInicio);
            grpDatos.Controls.Add(lblFin);
            grpDatos.Controls.Add(dtpFin);
            grpDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDatos.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatos.Location = new Point(20, 434);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(960, 116);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblInstitucion
            // 
            lblInstitucion.AutoSize = true;
            lblInstitucion.BackColor = Color.Transparent;
            lblInstitucion.Font = new Font("Segoe UI", 10F);
            lblInstitucion.ForeColor = Color.FromArgb(31, 35, 40);
            lblInstitucion.Location = new Point(15, 35);
            lblInstitucion.Name = "lblInstitucion";
            lblInstitucion.Size = new Size(83, 19);
            lblInstitucion.TabIndex = 0;
            lblInstitucion.Text = "Institución *";
            // 
            // txtInstitucion
            // 
            txtInstitucion.BackColor = Color.FromArgb(255, 255, 255);
            txtInstitucion.BorderStyle = BorderStyle.FixedSingle;
            txtInstitucion.Font = new Font("Segoe UI", 10F);
            txtInstitucion.ForeColor = Color.FromArgb(31, 35, 40);
            txtInstitucion.Location = new Point(149, 32);
            txtInstitucion.Name = "txtInstitucion";
            txtInstitucion.Size = new Size(280, 25);
            txtInstitucion.TabIndex = 1;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.Font = new Font("Segoe UI", 10F);
            lblDescuento.ForeColor = Color.FromArgb(31, 35, 40);
            lblDescuento.Location = new Point(15, 73);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(107, 19);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento (%) *";
            // 
            // nudDescuento
            // 
            nudDescuento.BackColor = Color.FromArgb(255, 255, 255);
            nudDescuento.BorderStyle = BorderStyle.FixedSingle;
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Font = new Font("Segoe UI", 10F);
            nudDescuento.ForeColor = Color.FromArgb(31, 35, 40);
            nudDescuento.Location = new Point(149, 70);
            nudDescuento.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(100, 25);
            nudDescuento.TabIndex = 3;
            nudDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = Color.Transparent;
            lblInicio.Font = new Font("Segoe UI", 10F);
            lblInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblInicio.Location = new Point(495, 35);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(123, 19);
            lblInicio.TabIndex = 4;
            lblInicio.Text = "Inicio de vigencia *";
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new Font("Segoe UI", 10F);
            dtpInicio.ForeColor = Color.FromArgb(31, 35, 40);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(671, 32);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 25);
            dtpInicio.TabIndex = 5;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.BackColor = Color.Transparent;
            lblFin.Font = new Font("Segoe UI", 10F);
            lblFin.ForeColor = Color.FromArgb(31, 35, 40);
            lblFin.Location = new Point(495, 73);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(109, 19);
            lblFin.TabIndex = 6;
            lblFin.Text = "Fin de vigencia *";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Segoe UI", 10F);
            dtpFin.ForeColor = Color.FromArgb(31, 35, 40);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(671, 70);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 25);
            dtpFin.TabIndex = 7;
            // 
            // FrmMantConvenios
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new Size(1000, 620);
            Controls.Add(grpDatos);
            Controls.Add(grpRegistros);
            Controls.Add(grpBusqueda);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMantConvenios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenedor de convenios";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstitucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}
