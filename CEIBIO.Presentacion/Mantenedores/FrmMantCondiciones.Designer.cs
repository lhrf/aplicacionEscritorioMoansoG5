namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantCondiciones
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
            colExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colHorasDeAyuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpDatos = new System.Windows.Forms.GroupBox();
            lblExamen = new System.Windows.Forms.Label();
            cboExamen = new System.Windows.Forms.ComboBox();
            lblHorasAyuno = new System.Windows.Forms.Label();
            nudHorasAyuno = new System.Windows.Forms.NumericUpDown();
            lblMedicamentos = new System.Windows.Forms.Label();
            txtMedicamentos = new System.Windows.Forms.TextBox();
            lblMuestra = new System.Windows.Forms.Label();
            txtMuestra = new System.Windows.Forms.TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHorasAyuno).BeginInit();
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
            lblTitulo.Size = new System.Drawing.Size(399, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenedor de condiciones preanalíticas";
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
            lblCodigo.Text = "CU-13";
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
            dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colExamen, colHorasDeAyuno, colMedicamentos, colMuestra, colEstado });
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
            // colExamen
            // 
            colExamen.HeaderText = "Examen";
            colExamen.Name = "colExamen";
            colExamen.ReadOnly = true;
            // 
            // colHorasDeAyuno
            // 
            colHorasDeAyuno.DefaultCellStyle = dataGridViewCellStyle4;
            colHorasDeAyuno.HeaderText = "Horas de ayuno";
            colHorasDeAyuno.Name = "colHorasDeAyuno";
            colHorasDeAyuno.ReadOnly = true;
            // 
            // colMedicamentos
            // 
            colMedicamentos.HeaderText = "Medicamentos";
            colMedicamentos.Name = "colMedicamentos";
            colMedicamentos.ReadOnly = true;
            // 
            // colMuestra
            // 
            colMuestra.HeaderText = "Muestra";
            colMuestra.Name = "colMuestra";
            colMuestra.ReadOnly = true;
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
            grpDatos.Controls.Add(lblExamen);
            grpDatos.Controls.Add(cboExamen);
            grpDatos.Controls.Add(lblHorasAyuno);
            grpDatos.Controls.Add(nudHorasAyuno);
            grpDatos.Controls.Add(lblMedicamentos);
            grpDatos.Controls.Add(txtMedicamentos);
            grpDatos.Controls.Add(lblMuestra);
            grpDatos.Controls.Add(txtMuestra);
            grpDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpDatos.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpDatos.Location = new System.Drawing.Point(20, 434);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new System.Drawing.Size(960, 116);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblExamen
            // 
            lblExamen.AutoSize = true;
            lblExamen.BackColor = System.Drawing.Color.Transparent;
            lblExamen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblExamen.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblExamen.Location = new System.Drawing.Point(15, 35);
            lblExamen.Name = "lblExamen";
            lblExamen.Size = new System.Drawing.Size(66, 19);
            lblExamen.TabIndex = 0;
            lblExamen.Text = "Examen *";
            // 
            // cboExamen
            // 
            cboExamen.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboExamen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            cboExamen.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            cboExamen.FormattingEnabled = true;
            cboExamen.Location = new System.Drawing.Point(141, 32);
            cboExamen.Name = "cboExamen";
            cboExamen.Size = new System.Drawing.Size(260, 25);
            cboExamen.TabIndex = 1;
            // 
            // lblHorasAyuno
            // 
            lblHorasAyuno.AutoSize = true;
            lblHorasAyuno.BackColor = System.Drawing.Color.Transparent;
            lblHorasAyuno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblHorasAyuno.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblHorasAyuno.Location = new System.Drawing.Point(15, 73);
            lblHorasAyuno.Name = "lblHorasAyuno";
            lblHorasAyuno.Size = new System.Drawing.Size(98, 19);
            lblHorasAyuno.TabIndex = 2;
            lblHorasAyuno.Text = "Horas de ayuno";
            // 
            // nudHorasAyuno
            // 
            nudHorasAyuno.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            nudHorasAyuno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nudHorasAyuno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            nudHorasAyuno.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            nudHorasAyuno.Location = new System.Drawing.Point(141, 70);
            nudHorasAyuno.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudHorasAyuno.Name = "nudHorasAyuno";
            nudHorasAyuno.Size = new System.Drawing.Size(80, 25);
            nudHorasAyuno.TabIndex = 3;
            nudHorasAyuno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMedicamentos
            // 
            lblMedicamentos.AutoSize = true;
            lblMedicamentos.BackColor = System.Drawing.Color.Transparent;
            lblMedicamentos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblMedicamentos.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblMedicamentos.Location = new System.Drawing.Point(495, 35);
            lblMedicamentos.Name = "lblMedicamentos";
            lblMedicamentos.Size = new System.Drawing.Size(194, 19);
            lblMedicamentos.TabIndex = 4;
            lblMedicamentos.Text = "Restricción de medicamentos";
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txtMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMedicamentos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtMedicamentos.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtMedicamentos.Location = new System.Drawing.Point(729, 32);
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new System.Drawing.Size(216, 25);
            txtMedicamentos.TabIndex = 5;
            // 
            // lblMuestra
            // 
            lblMuestra.AutoSize = true;
            lblMuestra.BackColor = System.Drawing.Color.Transparent;
            lblMuestra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblMuestra.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblMuestra.Location = new System.Drawing.Point(495, 73);
            lblMuestra.Name = "lblMuestra";
            lblMuestra.Size = new System.Drawing.Size(156, 19);
            lblMuestra.TabIndex = 6;
            lblMuestra.Text = "Muestra que debe traer";
            // 
            // txtMuestra
            // 
            txtMuestra.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txtMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMuestra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtMuestra.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtMuestra.Location = new System.Drawing.Point(729, 70);
            txtMuestra.Name = "txtMuestra";
            txtMuestra.Size = new System.Drawing.Size(216, 25);
            txtMuestra.TabIndex = 7;
            // 
            // FrmMantCondiciones
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
            Name = "FrmMantCondiciones";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mantenedor de condiciones preanalíticas";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHorasAyuno).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorasDeAyuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.ComboBox cboExamen;
        private System.Windows.Forms.Label lblHorasAyuno;
        private System.Windows.Forms.NumericUpDown nudHorasAyuno;
        private System.Windows.Forms.Label lblMedicamentos;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.Label lblMuestra;
        private System.Windows.Forms.TextBox txtMuestra;
    }
}
