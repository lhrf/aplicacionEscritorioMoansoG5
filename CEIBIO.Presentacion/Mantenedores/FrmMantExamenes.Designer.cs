namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantExamenes
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
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoDeMuestra = new DataGridViewTextBoxColumn();
            colProcedimiento = new DataGridViewTextBoxColumn();
            colTarifaS = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            grpDatos = new GroupBox();
            lblCodigoExamen = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTipoMuestra = new Label();
            cboTipoMuestra = new ComboBox();
            lblProcedimiento = new Label();
            cboProcedimiento = new ComboBox();
            lblTarifa = new Label();
            nudTarifa = new NumericUpDown();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
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
            lblTitulo.Size = new Size(243, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenedor de exámenes";
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
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colTipoDeMuestra, colProcedimiento, colTarifaS, colEstado });
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
            dgvRegistros.Size = new Size(940, 202);
            dgvRegistros.TabIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTipoDeMuestra
            // 
            colTipoDeMuestra.HeaderText = "Tipo de muestra";
            colTipoDeMuestra.Name = "colTipoDeMuestra";
            colTipoDeMuestra.ReadOnly = true;
            // 
            // colProcedimiento
            // 
            colProcedimiento.HeaderText = "Procedimiento";
            colProcedimiento.Name = "colProcedimiento";
            colProcedimiento.ReadOnly = true;
            // 
            // colTarifaS
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTarifaS.DefaultCellStyle = dataGridViewCellStyle3;
            colTarifaS.HeaderText = "Tarifa (S/)";
            colTarifaS.Name = "colTarifaS";
            colTarifaS.ReadOnly = true;
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
            grpDatos.Controls.Add(lblCodigoExamen);
            grpDatos.Controls.Add(txtCodigo);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblTipoMuestra);
            grpDatos.Controls.Add(cboTipoMuestra);
            grpDatos.Controls.Add(lblProcedimiento);
            grpDatos.Controls.Add(cboProcedimiento);
            grpDatos.Controls.Add(lblTarifa);
            grpDatos.Controls.Add(nudTarifa);
            grpDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDatos.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatos.Location = new Point(20, 406);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(960, 154);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lblCodigoExamen
            // 
            lblCodigoExamen.AutoSize = true;
            lblCodigoExamen.BackColor = Color.Transparent;
            lblCodigoExamen.Font = new Font("Segoe UI", 10F);
            lblCodigoExamen.ForeColor = Color.FromArgb(31, 35, 40);
            lblCodigoExamen.Location = new Point(15, 35);
            lblCodigoExamen.Name = "lblCodigoExamen";
            lblCodigoExamen.Size = new Size(63, 19);
            lblCodigoExamen.TabIndex = 0;
            lblCodigoExamen.Text = "Código *";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(255, 255, 255);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            txtCodigo.Location = new Point(166, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 25);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(31, 35, 40);
            lblNombre.Location = new Point(15, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre *";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 255, 255);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(31, 35, 40);
            txtNombre.Location = new Point(166, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 25);
            txtNombre.TabIndex = 3;
            // 
            // lblTipoMuestra
            // 
            lblTipoMuestra.AutoSize = true;
            lblTipoMuestra.BackColor = Color.Transparent;
            lblTipoMuestra.Font = new Font("Segoe UI", 10F);
            lblTipoMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            lblTipoMuestra.Location = new Point(15, 111);
            lblTipoMuestra.Name = "lblTipoMuestra";
            lblTipoMuestra.Size = new Size(118, 19);
            lblTipoMuestra.TabIndex = 4;
            lblTipoMuestra.Text = "Tipo de muestra *";
            // 
            // cboTipoMuestra
            // 
            cboTipoMuestra.BackColor = Color.FromArgb(255, 255, 255);
            cboTipoMuestra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoMuestra.FlatStyle = FlatStyle.Flat;
            cboTipoMuestra.Font = new Font("Segoe UI", 10F);
            cboTipoMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            cboTipoMuestra.FormattingEnabled = true;
            cboTipoMuestra.Items.AddRange(new object[] { "Sangre", "Orina", "Heces" });
            cboTipoMuestra.Location = new Point(166, 108);
            cboTipoMuestra.Name = "cboTipoMuestra";
            cboTipoMuestra.Size = new Size(180, 25);
            cboTipoMuestra.TabIndex = 5;
            // 
            // lblProcedimiento
            // 
            lblProcedimiento.AutoSize = true;
            lblProcedimiento.BackColor = Color.Transparent;
            lblProcedimiento.Font = new Font("Segoe UI", 10F);
            lblProcedimiento.ForeColor = Color.FromArgb(31, 35, 40);
            lblProcedimiento.Location = new Point(495, 35);
            lblProcedimiento.Name = "lblProcedimiento";
            lblProcedimiento.Size = new Size(107, 19);
            lblProcedimiento.TabIndex = 6;
            lblProcedimiento.Text = "Procedimiento *";
            // 
            // cboProcedimiento
            // 
            cboProcedimiento.BackColor = Color.FromArgb(255, 255, 255);
            cboProcedimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProcedimiento.FlatStyle = FlatStyle.Flat;
            cboProcedimiento.Font = new Font("Segoe UI", 10F);
            cboProcedimiento.ForeColor = Color.FromArgb(31, 35, 40);
            cboProcedimiento.FormattingEnabled = true;
            cboProcedimiento.Items.AddRange(new object[] { "Automatizado", "Microscópico" });
            cboProcedimiento.Location = new Point(629, 32);
            cboProcedimiento.Name = "cboProcedimiento";
            cboProcedimiento.Size = new Size(180, 25);
            cboProcedimiento.TabIndex = 7;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.BackColor = Color.Transparent;
            lblTarifa.Font = new Font("Segoe UI", 10F);
            lblTarifa.ForeColor = Color.FromArgb(31, 35, 40);
            lblTarifa.Location = new Point(495, 73);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(74, 19);
            lblTarifa.TabIndex = 8;
            lblTarifa.Text = "Tarifa (S/) *";
            // 
            // nudTarifa
            // 
            nudTarifa.BackColor = Color.FromArgb(255, 255, 255);
            nudTarifa.BorderStyle = BorderStyle.FixedSingle;
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Font = new Font("Segoe UI", 10F);
            nudTarifa.ForeColor = Color.FromArgb(31, 35, 40);
            nudTarifa.Location = new Point(629, 70);
            nudTarifa.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(120, 25);
            nudTarifa.TabIndex = 9;
            nudTarifa.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmMantExamenes
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
            Name = "FrmMantExamenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenedor de exámenes";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDeMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblCodigoExamen;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoMuestra;
        private System.Windows.Forms.ComboBox cboTipoMuestra;
        private System.Windows.Forms.Label lblProcedimiento;
        private System.Windows.Forms.ComboBox cboProcedimiento;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.NumericUpDown nudTarifa;
    }
}
