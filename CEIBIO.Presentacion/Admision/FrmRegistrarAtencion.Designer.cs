namespace CEIBIO.Presentacion.Admision
{
    partial class FrmRegistrarAtencion
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnAnular = new Button();
            btnQuitarExamen = new Button();
            grpDatosDelPaciente = new GroupBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtNumeroAtencion = new TextBox();
            lblNumeroAtencion = new Label();
            txtFecha = new TextBox();
            lblFecha = new Label();
            rdbADomicilio = new RadioButton();
            rdbEnSede = new RadioButton();
            lblEnSede = new Label();
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            btnBuscarPaciente = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            grpExamenesSolicitados = new GroupBox();
            cboConvenio = new ComboBox();
            lblConvenio = new Label();
            btnAgregarExamen = new Button();
            txtBuscarExamen = new TextBox();
            lblBuscarExamen = new Label();
            grpExamenes = new GroupBox();
            dgvExamenes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblCostoTotal = new Label();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpDatosDelPaciente.SuspendLayout();
            grpExamenesSolicitados.SuspendLayout();
            grpExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(992, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar atención";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Controls.Add(btnAnular);
            flpBotones.Controls.Add(btnQuitarExamen);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 588);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(992, 60);
            flpBotones.TabIndex = 1;
            flpBotones.WrapContents = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new Point(839, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 2;
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
            btnGuardar.Location = new Point(703, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.FromArgb(180, 35, 24);
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(544, 15);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(153, 36);
            btnAnular.TabIndex = 4;
            btnAnular.Text = "Anular atención";
            btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnQuitarExamen
            // 
            btnQuitarExamen.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnQuitarExamen.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnQuitarExamen.FlatStyle = FlatStyle.Flat;
            btnQuitarExamen.ForeColor = Color.FromArgb(11, 61, 110);
            btnQuitarExamen.Location = new Point(402, 15);
            btnQuitarExamen.Name = "btnQuitarExamen";
            btnQuitarExamen.Size = new Size(136, 36);
            btnQuitarExamen.TabIndex = 5;
            btnQuitarExamen.Text = "Quitar examen";
            btnQuitarExamen.UseVisualStyleBackColor = true;
            // 
            // grpDatosDelPaciente
            // 
            grpDatosDelPaciente.BackColor = Color.White;
            grpDatosDelPaciente.Controls.Add(txtUsuario);
            grpDatosDelPaciente.Controls.Add(lblUsuario);
            grpDatosDelPaciente.Controls.Add(txtNumeroAtencion);
            grpDatosDelPaciente.Controls.Add(lblNumeroAtencion);
            grpDatosDelPaciente.Controls.Add(txtFecha);
            grpDatosDelPaciente.Controls.Add(lblFecha);
            grpDatosDelPaciente.Controls.Add(rdbADomicilio);
            grpDatosDelPaciente.Controls.Add(rdbEnSede);
            grpDatosDelPaciente.Controls.Add(lblEnSede);
            grpDatosDelPaciente.Controls.Add(txtPaciente);
            grpDatosDelPaciente.Controls.Add(lblPaciente);
            grpDatosDelPaciente.Controls.Add(btnBuscarPaciente);
            grpDatosDelPaciente.Controls.Add(txtDni);
            grpDatosDelPaciente.Controls.Add(lblDni);
            grpDatosDelPaciente.ForeColor = Color.FromArgb(11, 61, 110);
            grpDatosDelPaciente.Location = new Point(20, 70);
            grpDatosDelPaciente.Name = "grpDatosDelPaciente";
            grpDatosDelPaciente.Size = new Size(960, 154);
            grpDatosDelPaciente.TabIndex = 2;
            grpDatosDelPaciente.TabStop = false;
            grpDatosDelPaciente.Text = "Datos del paciente";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(233, 238, 243);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            txtUsuario.Location = new Point(629, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(200, 30);
            txtUsuario.TabIndex = 13;
            txtUsuario.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            lblUsuario.Location = new Point(495, 111);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(122, 23);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Registrado por";
            // 
            // txtNumeroAtencion
            // 
            txtNumeroAtencion.BackColor = Color.FromArgb(233, 238, 243);
            txtNumeroAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroAtencion.Location = new Point(629, 70);
            txtNumeroAtencion.Name = "txtNumeroAtencion";
            txtNumeroAtencion.ReadOnly = true;
            txtNumeroAtencion.Size = new Size(200, 30);
            txtNumeroAtencion.TabIndex = 11;
            txtNumeroAtencion.TabStop = false;
            // 
            // lblNumeroAtencion
            // 
            lblNumeroAtencion.AutoSize = true;
            lblNumeroAtencion.BackColor = Color.Transparent;
            lblNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroAtencion.Location = new Point(495, 73);
            lblNumeroAtencion.Name = "lblNumeroAtencion";
            lblNumeroAtencion.Size = new Size(128, 23);
            lblNumeroAtencion.TabIndex = 10;
            lblNumeroAtencion.Text = "N.° de atención";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(233, 238, 243);
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.ForeColor = Color.FromArgb(31, 35, 40);
            txtFecha.Location = new Point(629, 32);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(200, 30);
            txtFecha.TabIndex = 9;
            txtFecha.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.ForeColor = Color.FromArgb(31, 35, 40);
            lblFecha.Location = new Point(495, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // rdbADomicilio
            // 
            rdbADomicilio.AutoSize = true;
            rdbADomicilio.Cursor = Cursors.Hand;
            rdbADomicilio.ForeColor = Color.FromArgb(31, 35, 40);
            rdbADomicilio.Location = new Point(265, 109);
            rdbADomicilio.Name = "rdbADomicilio";
            rdbADomicilio.Size = new Size(116, 27);
            rdbADomicilio.TabIndex = 7;
            rdbADomicilio.TabStop = true;
            rdbADomicilio.Text = "A domicilio";
            rdbADomicilio.UseVisualStyleBackColor = true;
            // 
            // rdbEnSede
            // 
            rdbEnSede.AutoSize = true;
            rdbEnSede.Cursor = Cursors.Hand;
            rdbEnSede.ForeColor = Color.FromArgb(31, 35, 40);
            rdbEnSede.Location = new Point(125, 109);
            rdbEnSede.Name = "rdbEnSede";
            rdbEnSede.Size = new Size(90, 27);
            rdbEnSede.TabIndex = 6;
            rdbEnSede.TabStop = true;
            rdbEnSede.Text = "En sede";
            rdbEnSede.UseVisualStyleBackColor = true;
            // 
            // lblEnSede
            // 
            lblEnSede.AutoSize = true;
            lblEnSede.BackColor = Color.Transparent;
            lblEnSede.ForeColor = Color.FromArgb(31, 35, 40);
            lblEnSede.Location = new Point(15, 111);
            lblEnSede.Name = "lblEnSede";
            lblEnSede.Size = new Size(103, 23);
            lblEnSede.TabIndex = 5;
            lblEnSede.Text = "Modalidad *";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(125, 70);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(300, 30);
            txtPaciente.TabIndex = 4;
            txtPaciente.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(15, 73);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(74, 23);
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "Paciente";
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Cursor = Cursors.Hand;
            btnBuscarPaciente.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscarPaciente.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscarPaciente.Location = new Point(315, 28);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(110, 34);
            btnBuscarPaciente.TabIndex = 2;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 35, 40);
            txtDni.Location = new Point(125, 32);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(184, 30);
            txtDni.TabIndex = 1;
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
            // grpExamenesSolicitados
            // 
            grpExamenesSolicitados.BackColor = Color.White;
            grpExamenesSolicitados.Controls.Add(cboConvenio);
            grpExamenesSolicitados.Controls.Add(lblConvenio);
            grpExamenesSolicitados.Controls.Add(btnAgregarExamen);
            grpExamenesSolicitados.Controls.Add(txtBuscarExamen);
            grpExamenesSolicitados.Controls.Add(lblBuscarExamen);
            grpExamenesSolicitados.ForeColor = Color.FromArgb(11, 61, 110);
            grpExamenesSolicitados.Location = new Point(20, 234);
            grpExamenesSolicitados.Name = "grpExamenesSolicitados";
            grpExamenesSolicitados.Size = new Size(960, 78);
            grpExamenesSolicitados.TabIndex = 3;
            grpExamenesSolicitados.TabStop = false;
            grpExamenesSolicitados.Text = "Exámenes solicitados";
            // 
            // cboConvenio
            // 
            cboConvenio.BackColor = Color.White;
            cboConvenio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConvenio.FlatStyle = FlatStyle.Flat;
            cboConvenio.ForeColor = Color.FromArgb(31, 35, 40);
            cboConvenio.FormattingEnabled = true;
            cboConvenio.Location = new Point(629, 32);
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(305, 31);
            cboConvenio.TabIndex = 4;
            // 
            // lblConvenio
            // 
            lblConvenio.AutoSize = true;
            lblConvenio.BackColor = Color.Transparent;
            lblConvenio.ForeColor = Color.FromArgb(31, 35, 40);
            lblConvenio.Location = new Point(535, 35);
            lblConvenio.Name = "lblConvenio";
            lblConvenio.Size = new Size(82, 23);
            lblConvenio.TabIndex = 3;
            lblConvenio.Text = "Convenio";
            // 
            // btnAgregarExamen
            // 
            btnAgregarExamen.Cursor = Cursors.Hand;
            btnAgregarExamen.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnAgregarExamen.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnAgregarExamen.Location = new Point(372, 29);
            btnAgregarExamen.Name = "btnAgregarExamen";
            btnAgregarExamen.Size = new Size(110, 34);
            btnAgregarExamen.TabIndex = 2;
            btnAgregarExamen.Text = "Agregar";
            btnAgregarExamen.UseVisualStyleBackColor = false;
            // 
            // txtBuscarExamen
            // 
            txtBuscarExamen.BackColor = Color.White;
            txtBuscarExamen.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarExamen.ForeColor = Color.FromArgb(31, 35, 40);
            txtBuscarExamen.Location = new Point(146, 33);
            txtBuscarExamen.Name = "txtBuscarExamen";
            txtBuscarExamen.Size = new Size(213, 30);
            txtBuscarExamen.TabIndex = 1;
            // 
            // lblBuscarExamen
            // 
            lblBuscarExamen.AutoSize = true;
            lblBuscarExamen.BackColor = Color.Transparent;
            lblBuscarExamen.ForeColor = Color.FromArgb(31, 35, 40);
            lblBuscarExamen.Location = new Point(15, 35);
            lblBuscarExamen.Name = "lblBuscarExamen";
            lblBuscarExamen.Size = new Size(125, 23);
            lblBuscarExamen.TabIndex = 0;
            lblBuscarExamen.Text = "Buscar examen";
            // 
            // grpExamenes
            // 
            grpExamenes.Controls.Add(dgvExamenes);
            grpExamenes.ForeColor = Color.FromArgb(11, 61, 110);
            grpExamenes.Location = new Point(20, 322);
            grpExamenes.Name = "grpExamenes";
            grpExamenes.Padding = new Padding(10, 8, 10, 10);
            grpExamenes.Size = new Size(960, 208);
            grpExamenes.TabIndex = 4;
            grpExamenes.TabStop = false;
            grpExamenes.Text = "Exámenes seleccionados";
            // 
            // dgvExamenes
            // 
            dgvExamenes.AllowUserToAddRows = false;
            dgvExamenes.AllowUserToDeleteRows = false;
            dgvExamenes.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvExamenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExamenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExamenes.BackgroundColor = Color.White;
            dgvExamenes.BorderStyle = BorderStyle.None;
            dgvExamenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamenes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvExamenes.Dock = DockStyle.Fill;
            dgvExamenes.EnableHeadersVisualStyles = false;
            dgvExamenes.GridColor = Color.FromArgb(208, 215, 222);
            dgvExamenes.Location = new Point(10, 31);
            dgvExamenes.MultiSelect = false;
            dgvExamenes.Name = "dgvExamenes";
            dgvExamenes.ReadOnly = true;
            dgvExamenes.RowHeadersVisible = false;
            dgvExamenes.RowHeadersWidth = 51;
            dgvExamenes.RowTemplate.Height = 28;
            dgvExamenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExamenes.Size = new Size(940, 167);
            dgvExamenes.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Examen";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tarifa (S/)";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.ForeColor = Color.FromArgb(31, 35, 40);
            lblSubtotal.Location = new Point(259, 545);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(155, 25);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "Subtotal: S/ 0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.ForeColor = Color.FromArgb(31, 35, 40);
            lblDescuento.Location = new Point(528, 545);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(155, 25);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "Descuento: S/ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCostoTotal
            // 
            lblCostoTotal.BackColor = Color.Transparent;
            lblCostoTotal.ForeColor = Color.FromArgb(11, 61, 110);
            lblCostoTotal.Location = new Point(730, 540);
            lblCostoTotal.Name = "lblCostoTotal";
            lblCostoTotal.Size = new Size(240, 34);
            lblCostoTotal.TabIndex = 8;
            lblCostoTotal.Text = "Costo total: S/ 0.00";
            lblCostoTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmRegistrarAtencion
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 648);
            Controls.Add(lblCostoTotal);
            Controls.Add(lblDescuento);
            Controls.Add(grpExamenes);
            Controls.Add(grpExamenesSolicitados);
            Controls.Add(grpDatosDelPaciente);
            Controls.Add(flpBotones);
            Controls.Add(lblSubtotal);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar atención";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpDatosDelPaciente.ResumeLayout(false);
            grpDatosDelPaciente.PerformLayout();
            grpExamenesSolicitados.ResumeLayout(false);
            grpExamenesSolicitados.PerformLayout();
            grpExamenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnAnular;
        private Button btnQuitarExamen;
        private GroupBox grpDatosDelPaciente;
        private Label lblDni;
        private Button btnBuscarPaciente;
        private TextBox txtDni;
        private Label lblEnSede;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private TextBox txtFecha;
        private Label lblFecha;
        private RadioButton rdbADomicilio;
        private RadioButton rdbEnSede;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtNumeroAtencion;
        private Label lblNumeroAtencion;
        private GroupBox grpExamenesSolicitados;
        private Button btnAgregarExamen;
        private TextBox txtBuscarExamen;
        private Label lblBuscarExamen;
        private ComboBox cboConvenio;
        private Label lblConvenio;
        private GroupBox grpExamenes;
        private DataGridView dgvExamenes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblCostoTotal;
    }
}
