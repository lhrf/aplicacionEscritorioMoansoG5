namespace CEIBIO.Presentacion.Admision
{
    partial class FrmConsultarAtenciones
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            grpFiltros = new GroupBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnBuscar = new Button();
            grpAtenciones = new GroupBox();
            dgvAtenciones = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            colModalidad = new DataGridViewTextBoxColumn();
            colCostoTotalS = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
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
            pnlEncabezado.Size = new Size(1000, 56);
            pnlEncabezado.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar atenciones";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 624);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 6;
            flpBotones.WrapContents = false;
            // 
            // grpFiltros
            // 
            grpFiltros.BackColor = Color.White;
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(cboEstado);
            grpFiltros.Controls.Add(lblEstado);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.ForeColor = Color.FromArgb(11, 61, 110);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 116);
            grpFiltros.TabIndex = 7;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Transparent;
            lblFechaInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaInicio.Location = new Point(15, 35);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(102, 23);
            lblFechaInicio.TabIndex = 0;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(132, 32);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 30);
            dtpFechaInicio.TabIndex = 1;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = Color.Transparent;
            lblFechaFin.ForeColor = Color.FromArgb(31, 35, 40);
            lblFechaFin.Location = new Point(15, 73);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(91, 23);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha final";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(132, 70);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 30);
            dtpFechaFin.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.ForeColor = Color.FromArgb(31, 35, 40);
            lblEstado.Location = new Point(495, 35);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(61, 23);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.White;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.ForeColor = Color.FromArgb(31, 35, 40);
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "(Todos)", "Pendiente de evaluación", "Suspendida", "Pendiente de pago", "Pagada", "En espera de toma de muestra", "Visita asignada", "En toma de muestra", "Muestra recolectada", "Recibida para análisis", "Lista para reporte", "Culminada", "Anulada" });
            cboEstado.Location = new Point(605, 32);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(220, 31);
            cboEstado.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(835, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpAtenciones
            // 
            grpAtenciones.Controls.Add(dgvAtenciones);
            grpAtenciones.ForeColor = Color.FromArgb(11, 61, 110);
            grpAtenciones.Location = new Point(20, 196);
            grpAtenciones.Name = "grpAtenciones";
            grpAtenciones.Padding = new Padding(10, 8, 10, 10);
            grpAtenciones.Size = new Size(960, 418);
            grpAtenciones.TabIndex = 8;
            grpAtenciones.TabStop = false;
            grpAtenciones.Text = "Resultados";
            // 
            // dgvAtenciones
            // 
            dgvAtenciones.AllowUserToAddRows = false;
            dgvAtenciones.AllowUserToDeleteRows = false;
            dgvAtenciones.AllowUserToResizeColumns = false;
            dgvAtenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtenciones.BackgroundColor = Color.White;
            dgvAtenciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAtenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtenciones.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colFecha, colPaciente, colExamenes, colModalidad, colCostoTotalS, colEstado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAtenciones.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAtenciones.Dock = DockStyle.Fill;
            dgvAtenciones.EnableHeadersVisualStyles = false;
            dgvAtenciones.GridColor = Color.FromArgb(208, 215, 222);
            dgvAtenciones.Location = new Point(10, 31);
            dgvAtenciones.MultiSelect = false;
            dgvAtenciones.Name = "dgvAtenciones";
            dgvAtenciones.ReadOnly = true;
            dgvAtenciones.RowHeadersVisible = false;
            dgvAtenciones.RowHeadersWidth = 51;
            dgvAtenciones.RowTemplate.Height = 28;
            dgvAtenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtenciones.Size = new Size(940, 377);
            dgvAtenciones.TabIndex = 0;
            // 
            // colNAtencion
            // 
            colNAtencion.HeaderText = "N.° atención";
            colNAtencion.MinimumWidth = 6;
            colNAtencion.Name = "colNAtencion";
            colNAtencion.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.MinimumWidth = 6;
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colExamenes
            // 
            colExamenes.HeaderText = "Exámenes";
            colExamenes.MinimumWidth = 6;
            colExamenes.Name = "colExamenes";
            colExamenes.ReadOnly = true;
            // 
            // colModalidad
            // 
            colModalidad.HeaderText = "Modalidad";
            colModalidad.MinimumWidth = 6;
            colModalidad.Name = "colModalidad";
            colModalidad.ReadOnly = true;
            // 
            // colCostoTotalS
            // 
            colCostoTotalS.HeaderText = "Costo total (S/)";
            colCostoTotalS.MinimumWidth = 6;
            colCostoTotalS.Name = "colCostoTotalS";
            colCostoTotalS.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmConsultarAtenciones
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 684);
            Controls.Add(grpAtenciones);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarAtenciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar atenciones";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpAtenciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private GroupBox grpFiltros;
        private Label lblEstado;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private Button btnBuscar;
        private ComboBox cboEstado;
        private GroupBox grpAtenciones;
        private DataGridView dgvAtenciones;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colExamenes;
        private DataGridViewTextBoxColumn colModalidad;
        private DataGridViewTextBoxColumn colCostoTotalS;
        private DataGridViewTextBoxColumn colEstado;
    }
}
