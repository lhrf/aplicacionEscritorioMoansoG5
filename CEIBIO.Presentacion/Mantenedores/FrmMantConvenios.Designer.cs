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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            pnlEncabezado = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblCodigo = new System.Windows.Forms.Label();
            flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            btnCerrar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnInhabilitar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            grpBusqueda = new System.Windows.Forms.GroupBox();
            lblBuscar = new System.Windows.Forms.Label();
            txtBuscar = new System.Windows.Forms.TextBox();
            btnBuscar = new System.Windows.Forms.Button();
            grpRegistros = new System.Windows.Forms.GroupBox();
            dgvRegistros = new System.Windows.Forms.DataGridView();
            colInstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpDatos = new System.Windows.Forms.GroupBox();
            lblInstitucion = new System.Windows.Forms.Label();
            txtInstitucion = new System.Windows.Forms.TextBox();
            lblDescuento = new System.Windows.Forms.Label();
            nudDescuento = new System.Windows.Forms.NumericUpDown();
            lblInicio = new System.Windows.Forms.Label();
            dtpInicio = new System.Windows.Forms.DateTimePicker();
            lblFin = new System.Windows.Forms.Label();
            dtpFin = new System.Windows.Forms.DateTimePicker();
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
            pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlEncabezado.Controls.Add(lblCodigo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new System.Drawing.Size(1000, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new System.Drawing.Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(244, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenedor de convenios";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = System.Drawing.Color.Transparent;
            lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(191, 215, 238);
            lblCodigo.Location = new System.Drawing.Point(939, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(41, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "CU-07";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Controls.Add(btnInhabilitar);
            flpBotones.Controls.Add(btnEditar);
            flpBotones.Controls.Add(btnNuevo);
            flpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            flpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpBotones.Location = new System.Drawing.Point(0, 560);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            flpBotones.Size = new System.Drawing.Size(1000, 60);
            flpBotones.TabIndex = 4;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCerrar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new System.Drawing.Point(860, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = true;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new System.Drawing.Point(724, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(130, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.TabStop = true;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(20, 90, 158);
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnGuardar.Location = new System.Drawing.Point(588, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(130, 36);
            btnGuardar.TabIndex = 2;
            btnGuardar.TabStop = true;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            btnInhabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInhabilitar.FlatAppearance.BorderSize = 0;
            btnInhabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 28, 19);
            btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInhabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnInhabilitar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnInhabilitar.Location = new System.Drawing.Point(452, 12);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new System.Drawing.Size(130, 36);
            btnInhabilitar.TabIndex = 3;
            btnInhabilitar.TabStop = true;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnEditar.FlatAppearance.BorderSize = 1;
            btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 244, 251);
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEditar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnEditar.Location = new System.Drawing.Point(316, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(130, 36);
            btnEditar.TabIndex = 4;
            btnEditar.TabStop = true;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnNuevo.FlatAppearance.BorderSize = 1;
            btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 244, 251);
            btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnNuevo.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnNuevo.Location = new System.Drawing.Point(180, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(130, 36);
            btnNuevo.TabIndex = 5;
            btnNuevo.TabStop = true;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpBusqueda.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new System.Drawing.Point(20, 70);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new System.Drawing.Size(960, 78);
            grpBusqueda.TabIndex = 1;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = System.Drawing.Color.Transparent;
            lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblBuscar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblBuscar.Location = new System.Drawing.Point(15, 35);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(51, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtBuscar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtBuscar.Location = new System.Drawing.Point(125, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(300, 25);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.BorderSize = 1;
            btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBuscar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new System.Drawing.Point(435, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(110, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.TabStop = true;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpRegistros
            // 
            grpRegistros.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpRegistros.Controls.Add(dgvRegistros);
            grpRegistros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpRegistros.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpRegistros.Location = new System.Drawing.Point(20, 158);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            grpRegistros.Size = new System.Drawing.Size(960, 266);
            grpRegistros.TabIndex = 2;
            grpRegistros.TabStop = false;
            grpRegistros.Text = "Registros";
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AllowUserToResizeRows = false;
            dgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.ColumnHeadersHeight = 34;
            dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colInstitucion, colDescuento, colInicio, colFin, colEstado });
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.GridColor = System.Drawing.Color.FromArgb(208, 215, 222);
            dgvRegistros.Location = new System.Drawing.Point(10, 31);
            dgvRegistros.MultiSelect = false;
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.RowTemplate.Height = 28;
            dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new System.Drawing.Size(940, 225);
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
            colDescuento.DefaultCellStyle = dataGridViewCellStyle4;
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
            grpDatos.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpDatos.Controls.Add(lblInstitucion);
            grpDatos.Controls.Add(txtInstitucion);
            grpDatos.Controls.Add(lblDescuento);
            grpDatos.Controls.Add(nudDescuento);
            grpDatos.Controls.Add(lblInicio);
            grpDatos.Controls.Add(dtpInicio);
            grpDatos.Controls.Add(lblFin);
            grpDatos.Controls.Add(dtpFin);
            grpDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpDatos.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpDatos.Location = new System.Drawing.Point(20, 434);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new System.Drawing.Size(960, 116);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblInstitucion
            // 
            lblInstitucion.AutoSize = true;
            lblInstitucion.BackColor = System.Drawing.Color.Transparent;
            lblInstitucion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblInstitucion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblInstitucion.Location = new System.Drawing.Point(15, 35);
            lblInstitucion.Name = "lblInstitucion";
            lblInstitucion.Size = new System.Drawing.Size(84, 19);
            lblInstitucion.TabIndex = 0;
            lblInstitucion.Text = "Institución *";
            // 
            // txtInstitucion
            // 
            txtInstitucion.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txtInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtInstitucion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtInstitucion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtInstitucion.Location = new System.Drawing.Point(149, 32);
            txtInstitucion.Name = "txtInstitucion";
            txtInstitucion.Size = new System.Drawing.Size(280, 25);
            txtInstitucion.TabIndex = 1;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = System.Drawing.Color.Transparent;
            lblDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblDescuento.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblDescuento.Location = new System.Drawing.Point(15, 73);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new System.Drawing.Size(102, 19);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento (%) *";
            // 
            // nudDescuento
            // 
            nudDescuento.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            nudDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            nudDescuento.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            nudDescuento.Location = new System.Drawing.Point(149, 70);
            nudDescuento.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new System.Drawing.Size(100, 25);
            nudDescuento.TabIndex = 3;
            nudDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = System.Drawing.Color.Transparent;
            lblInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblInicio.Location = new System.Drawing.Point(495, 35);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new System.Drawing.Size(125, 19);
            lblInicio.TabIndex = 4;
            lblInicio.Text = "Inicio de vigencia *";
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            dtpInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpInicio.Location = new System.Drawing.Point(671, 32);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new System.Drawing.Size(200, 25);
            dtpInicio.TabIndex = 5;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.BackColor = System.Drawing.Color.Transparent;
            lblFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblFin.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblFin.Location = new System.Drawing.Point(495, 73);
            lblFin.Name = "lblFin";
            lblFin.Size = new System.Drawing.Size(109, 19);
            lblFin.TabIndex = 6;
            lblFin.Text = "Fin de vigencia *";
            // 
            // dtpFin
            // 
            dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            dtpFin.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFin.Location = new System.Drawing.Point(671, 70);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new System.Drawing.Size(200, 25);
            dtpFin.TabIndex = 7;
            // 
            // FrmMantConvenios
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(1000, 620);
            Controls.Add(grpDatos);
            Controls.Add(grpRegistros);
            Controls.Add(grpBusqueda);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMantConvenios";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblCodigo;
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
