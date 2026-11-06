namespace CEIBIO.Presentacion.Evaluacion
{
    partial class FrmConsultarSuspendidas
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
            btnReactivar = new Button();
            grpFiltros = new GroupBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            btnBuscar = new Button();
            grpSuspendidas = new GroupBox();
            dgvSuspendidas = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colMotivo = new DataGridViewTextBoxColumn();
            colNuevaFecha = new DataGridViewTextBoxColumn();
            colEnfermera = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpSuspendidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuspendidas).BeginInit();
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
            pnlEncabezado.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar atenciones suspendidas";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnReactivar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 581);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 4;
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
            // btnReactivar
            // 
            btnReactivar.BackColor = Color.FromArgb(11, 61, 110);
            btnReactivar.Cursor = Cursors.Hand;
            btnReactivar.FlatAppearance.BorderSize = 0;
            btnReactivar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnReactivar.FlatStyle = FlatStyle.Flat;
            btnReactivar.ForeColor = Color.White;
            btnReactivar.Location = new Point(711, 15);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(130, 36);
            btnReactivar.TabIndex = 1;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = false;
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Location = new Point(20, 70);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(960, 78);
            grpFiltros.TabIndex = 5;
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
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(605, 32);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 30);
            dtpFechaFin.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new Point(815, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpSuspendidas
            // 
            grpSuspendidas.BackColor = Color.White;
            grpSuspendidas.Controls.Add(dgvSuspendidas);
            grpSuspendidas.ForeColor = Color.FromArgb(11, 61, 110);
            grpSuspendidas.Location = new Point(20, 158);
            grpSuspendidas.Name = "grpSuspendidas";
            grpSuspendidas.Padding = new Padding(10, 8, 10, 10);
            grpSuspendidas.Size = new Size(960, 418);
            grpSuspendidas.TabIndex = 6;
            grpSuspendidas.TabStop = false;
            grpSuspendidas.Text = "Atenciones suspendidas";
            // 
            // dgvSuspendidas
            // 
            dgvSuspendidas.AllowUserToAddRows = false;
            dgvSuspendidas.AllowUserToDeleteRows = false;
            dgvSuspendidas.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvSuspendidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuspendidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuspendidas.BackgroundColor = Color.White;
            dgvSuspendidas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSuspendidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSuspendidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuspendidas.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colMotivo, colNuevaFecha, colEnfermera });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSuspendidas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSuspendidas.Dock = DockStyle.Fill;
            dgvSuspendidas.EnableHeadersVisualStyles = false;
            dgvSuspendidas.GridColor = Color.FromArgb(208, 215, 222);
            dgvSuspendidas.Location = new Point(10, 31);
            dgvSuspendidas.MultiSelect = false;
            dgvSuspendidas.Name = "dgvSuspendidas";
            dgvSuspendidas.ReadOnly = true;
            dgvSuspendidas.RowHeadersVisible = false;
            dgvSuspendidas.RowHeadersWidth = 51;
            dgvSuspendidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuspendidas.Size = new Size(940, 377);
            dgvSuspendidas.TabIndex = 0;
            // 
            // colNAtencion
            // 
            colNAtencion.HeaderText = "N.° atención";
            colNAtencion.MinimumWidth = 6;
            colNAtencion.Name = "colNAtencion";
            colNAtencion.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.MinimumWidth = 6;
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colMotivo
            // 
            colMotivo.HeaderText = "Motivo";
            colMotivo.MinimumWidth = 6;
            colMotivo.Name = "colMotivo";
            colMotivo.ReadOnly = true;
            // 
            // colNuevaFecha
            // 
            colNuevaFecha.HeaderText = "Nueva fecha";
            colNuevaFecha.MinimumWidth = 6;
            colNuevaFecha.Name = "colNuevaFecha";
            colNuevaFecha.ReadOnly = true;
            // 
            // colEnfermera
            // 
            colEnfermera.HeaderText = "Enfermera";
            colEnfermera.MinimumWidth = 6;
            colEnfermera.Name = "colEnfermera";
            colEnfermera.ReadOnly = true;
            // 
            // FrmConsultarSuspendidas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 641);
            Controls.Add(grpSuspendidas);
            Controls.Add(grpFiltros);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarSuspendidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar atenciones suspendidas";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpSuspendidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuspendidas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnReactivar;
        private GroupBox grpFiltros;
        private Button btnBuscar;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private GroupBox grpSuspendidas;
        private DataGridView dgvSuspendidas;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colMotivo;
        private DataGridViewTextBoxColumn colNuevaFecha;
        private DataGridViewTextBoxColumn colEnfermera;
    }
}
