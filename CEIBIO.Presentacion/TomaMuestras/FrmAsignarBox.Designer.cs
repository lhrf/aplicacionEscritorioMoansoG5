namespace CEIBIO.Presentacion.TomaMuestras
{
    partial class kodi
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
            lblCodigo = new Label();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnAsignar = new Button();
            grpEspera = new GroupBox();
            grpAsignacion = new GroupBox();
            cboBox = new ComboBox();
            lblBox = new Label();
            dgvEspera = new DataGridView();
            colTurno = new DataGridViewTextBoxColumn();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpEspera.SuspendLayout();
            grpAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspera).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblCodigo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(984, 49);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI", 9F);
            lblCodigo.Location = new Point(934, 17);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(40, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "CU-26";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Asignar box de extracción";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnAsignar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 479);
            flpBotones.Name = "flpBotones";
            flpBotones.Size = new Size(984, 60);
            flpBotones.TabIndex = 1;
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
            btnCerrar.Location = new Point(851, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(11, 61, 110);
            btnAsignar.Cursor = Cursors.Hand;
            btnAsignar.FlatAppearance.BorderSize = 0;
            btnAsignar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAsignar.ForeColor = Color.White;
            btnAsignar.Location = new Point(676, 3);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(169, 36);
            btnAsignar.TabIndex = 3;
            btnAsignar.Text = "Asignar y derivar";
            btnAsignar.UseVisualStyleBackColor = false;
            // 
            // grpEspera
            // 
            grpEspera.BackColor = Color.White;
            grpEspera.Controls.Add(grpAsignacion);
            grpEspera.Controls.Add(dgvEspera);
            grpEspera.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEspera.ForeColor = Color.FromArgb(11, 61, 110);
            grpEspera.Location = new Point(20, 70);
            grpEspera.Name = "grpEspera";
            grpEspera.Padding = new Padding(10, 8, 10, 10);
            grpEspera.Size = new Size(952, 406);
            grpEspera.TabIndex = 4;
            grpEspera.TabStop = false;
            grpEspera.Text = "Pacientes en espera (por turno)";
            // 
            // grpAsignacion
            // 
            grpAsignacion.BackColor = Color.White;
            grpAsignacion.Controls.Add(cboBox);
            grpAsignacion.Controls.Add(lblBox);
            grpAsignacion.Location = new Point(0, 328);
            grpAsignacion.Name = "grpAsignacion";
            grpAsignacion.Size = new Size(938, 78);
            grpAsignacion.TabIndex = 1;
            grpAsignacion.TabStop = false;
            grpAsignacion.Text = "Asignación";
            grpAsignacion.Enter += grpAsignacion_Enter;
            // 
            // cboBox
            // 
            cboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBox.Font = new Font("Segoe UI", 10F);
            cboBox.ForeColor = Color.FromArgb(31, 35, 40);
            cboBox.FormattingEnabled = true;
            cboBox.Location = new Point(137, 40);
            cboBox.Name = "cboBox";
            cboBox.Size = new Size(200, 25);
            cboBox.TabIndex = 2;
            cboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblBox
            // 
            lblBox.AutoSize = true;
            lblBox.BackColor = Color.Transparent;
            lblBox.Font = new Font("Segoe UI", 10F);
            lblBox.ForeColor = Color.FromArgb(31, 35, 40);
            lblBox.Location = new Point(6, 38);
            lblBox.Name = "lblBox";
            lblBox.Size = new Size(125, 19);
            lblBox.TabIndex = 2;
            lblBox.Text = "Box de extracción *";
            lblBox.Click += lblBox_Click;
            // 
            // dgvEspera
            // 
            dgvEspera.AllowUserToAddRows = false;
            dgvEspera.AllowUserToDeleteRows = false;
            dgvEspera.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvEspera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspera.BackgroundColor = Color.White;
            dgvEspera.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEspera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEspera.ColumnHeadersHeight = 34;
            dgvEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEspera.Columns.AddRange(new DataGridViewColumn[] { colTurno, colNAtencion, colPaciente, colExamenes });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEspera.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEspera.Dock = DockStyle.Fill;
            dgvEspera.EnableHeadersVisualStyles = false;
            dgvEspera.GridColor = Color.FromArgb(208, 215, 222);
            dgvEspera.Location = new Point(10, 26);
            dgvEspera.MultiSelect = false;
            dgvEspera.Name = "dgvEspera";
            dgvEspera.ReadOnly = true;
            dgvEspera.RowHeadersVisible = false;
            dgvEspera.RowTemplate.Height = 28;
            dgvEspera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspera.Size = new Size(932, 370);
            dgvEspera.TabIndex = 0;
            // 
            // colTurno
            // 
            dataGridViewCellStyle3.BackColor = Color.Black;
            colTurno.DefaultCellStyle = dataGridViewCellStyle3;
            colTurno.HeaderText = "Turno";
            colTurno.Name = "colTurno";
            colTurno.ReadOnly = true;
            // 
            // colNAtencion
            // 
            colNAtencion.HeaderText = "N.° atención";
            colNAtencion.Name = "colNAtencion";
            colNAtencion.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colExamenes
            // 
            colExamenes.HeaderText = "Exámenes";
            colExamenes.Name = "colExamenes";
            colExamenes.ReadOnly = true;
            // 
            // kodi
            // 
            AcceptButton = btnAsignar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            CancelButton = btnCerrar;
            ClientSize = new Size(984, 539);
            Controls.Add(grpEspera);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(191, 215, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "kodi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar box de extracción";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpEspera.ResumeLayout(false);
            grpAsignacion.ResumeLayout(false);
            grpAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblCodigo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnAsignar;
        private GroupBox grpEspera;
        private DataGridView dgvEspera;
        private GroupBox grpAsignacion;
        private Label lblBox;
        private ComboBox cboBox;
        private DataGridViewTextBoxColumn colTurno;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colExamenes;
    }
}
