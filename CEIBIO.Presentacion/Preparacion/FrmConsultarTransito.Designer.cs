namespace CEIBIO.Presentacion.Preparacion
{
    partial class FrmConsultarTransito
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
            grpFiltros = new GroupBox();
            btnBuscar = new Button();
            cboEstado = new ComboBox();
            lblEstado = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaInicio = new Label();
            grpTransito = new GroupBox();
            dgvTransito = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colHoraDeIngreso = new DataGridViewTextBoxColumn();
            colCentrifugacionMin = new DataGridViewTextBoxColumn();
            colResponsable = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpTransito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransito).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(984, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(284, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Consultar tránsito de muestras";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 591);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(984, 60);
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
            btnCerrar.Location = new Point(831, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // grpFiltros
            // 
            grpFiltros.BackColor = Color.White;
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(cboEstado);
            grpFiltros.Controls.Add(lblEstado);
            grpFiltros.Controls.Add(dateTimePicker1);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 116);
            grpFiltros.TabIndex = 4;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
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
            btnBuscar.Location = new Point(844, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.White;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.Font = new Font("Segoe UI", 10F);
            cboEstado.ForeColor = Color.FromArgb(31, 35, 40);
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "(Todos)", "Muestra recolectada", "Muestra Acondicionada", "Recibida para análisis" });
            cboEstado.Location = new Point(605, 32);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(220, 25);
            cboEstado.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.ForeColor = Color.FromArgb(31, 35, 40);
            lblEstado.Location = new Point(495, 35);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(50, 19);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(31, 35, 40);
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(140, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = Color.Transparent;
            lblFechaFin.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaFin.Location = new Point(25, 82);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(80, 19);
            lblFechaFin.TabIndex = 5;
            lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarForeColor = Color.FromArgb(31, 35, 40);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(140, 42);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 25);
            dtpFechaInicio.TabIndex = 5;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Transparent;
            lblFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaInicio.Location = new Point(25, 42);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(90, 19);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // grpTransito
            // 
            grpTransito.BackColor = Color.White;
            grpTransito.Controls.Add(dgvTransito);
            grpTransito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTransito.ForeColor = Color.FromArgb(11, 61, 110);
            grpTransito.Location = new Point(20, 196);
            grpTransito.Name = "grpTransito";
            grpTransito.Padding = new Padding(10, 8, 10, 10);
            grpTransito.Size = new Size(960, 418);
            grpTransito.TabIndex = 5;
            grpTransito.TabStop = false;
            grpTransito.Text = "Tránsito de muestras";
            // 
            // dgvTransito
            // 
            dgvTransito.AllowUserToAddRows = false;
            dgvTransito.AllowUserToDeleteRows = false;
            dgvTransito.AllowUserToResizeColumns = false;
            dgvTransito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransito.BackgroundColor = Color.White;
            dgvTransito.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransito.ColumnHeadersHeight = 34;
            dgvTransito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransito.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colPaciente, colHoraDeIngreso, colCentrifugacionMin, colResponsable, colEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransito.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransito.Dock = DockStyle.Fill;
            dgvTransito.EnableHeadersVisualStyles = false;
            dgvTransito.GridColor = Color.FromArgb(208, 215, 222);
            dgvTransito.Location = new Point(10, 26);
            dgvTransito.MultiSelect = false;
            dgvTransito.Name = "dgvTransito";
            dgvTransito.ReadOnly = true;
            dgvTransito.RowTemplate.Height = 28;
            dgvTransito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransito.Size = new Size(940, 382);
            dgvTransito.TabIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colHoraDeIngreso
            // 
            colHoraDeIngreso.HeaderText = "Hora de ingreso";
            colHoraDeIngreso.Name = "colHoraDeIngreso";
            colHoraDeIngreso.ReadOnly = true;
            // 
            // colCentrifugacionMin
            // 
            colCentrifugacionMin.HeaderText = "Centrifugación (min)";
            colCentrifugacionMin.Name = "colCentrifugacionMin";
            colCentrifugacionMin.ReadOnly = true;
            // 
            // colResponsable
            // 
            colResponsable.HeaderText = "Responsable";
            colResponsable.Name = "colResponsable";
            colResponsable.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmConsultarTransito
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 651);
            Controls.Add(grpTransito);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarTransito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar tránsito de muestras";
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpTransito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private GroupBox grpFiltros;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private ComboBox cboEstado;
        private Label lblEstado;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaFin;
        private Button btnBuscar;
        private GroupBox grpTransito;
        private DataGridView dgvTransito;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colHoraDeIngreso;
        private DataGridViewTextBoxColumn colCentrifugacionMin;
        private DataGridViewTextBoxColumn colResponsable;
        private DataGridViewTextBoxColumn colEstado;
    }
}
