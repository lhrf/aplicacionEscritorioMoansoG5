namespace CEIBIO.Presentacion.Evaluacion
{
    partial class FrmRegistrarObservaciones
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnGuardar = new Button();
            grpPendientes = new GroupBox();
            dgvPendientes = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            grpCondiciones = new GroupBox();
            dgvCondiciones = new DataGridView();
            colExamen = new DataGridViewTextBoxColumn();
            colHorasDeAyuno = new DataGridViewTextBoxColumn();
            colMuestraQueDebeTraer = new DataGridViewTextBoxColumn();
            grpEvaluacionDelPaciente = new GroupBox();
            lblHorasAyuno = new Label();
            nudHorasAyuno = new NumericUpDown();
            lblMedicamentos = new Label();
            txtMedicamentos = new TextBox();
            chkRotulado = new CheckBox();
            chkHermetico = new CheckBox();
            chkVolumen = new CheckBox();
            chkConservacion = new CheckBox();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            grpCondiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCondiciones).BeginInit();
            grpEvaluacionDelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHorasAyuno).BeginInit();
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
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(289, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar observaciones preanalíticas";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
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
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(11, 61, 110);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(639, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(202, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar observaciones";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grpPendientes
            // 
            grpPendientes.BackColor = Color.White;
            grpPendientes.Controls.Add(dgvPendientes);
            grpPendientes.ForeColor = Color.FromArgb(11, 61, 110);
            grpPendientes.Location = new Point(20, 70);
            grpPendientes.Name = "grpPendientes";
            grpPendientes.Padding = new Padding(10, 8, 10, 10);
            grpPendientes.Size = new Size(960, 188);
            grpPendientes.TabIndex = 2;
            grpPendientes.TabStop = false;
            grpPendientes.Text = "Atenciones pendientes de evaluación";
            // 
            // dgvPendientes
            // 
            dgvPendientes.AllowUserToAddRows = false;
            dgvPendientes.AllowUserToDeleteRows = false;
            dgvPendientes.AllowUserToResizeColumns = false;
            dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientes.BackgroundColor = Color.White;
            dgvPendientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPendientes.ColumnHeadersHeight = 34;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendientes.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colExamenes });
            dgvPendientes.Dock = DockStyle.Fill;
            dgvPendientes.EnableHeadersVisualStyles = false;
            dgvPendientes.GridColor = Color.FromArgb(208, 215, 222);
            dgvPendientes.Location = new Point(10, 31);
            dgvPendientes.MultiSelect = false;
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.ReadOnly = true;
            dgvPendientes.RowHeadersVisible = false;
            dgvPendientes.RowHeadersWidth = 51;
            dgvPendientes.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(31, 35, 40);
            dgvPendientes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dgvPendientes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dgvPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendientes.Size = new Size(940, 147);
            dgvPendientes.TabIndex = 0;
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
            // colExamenes
            // 
            colExamenes.HeaderText = "Exámenes";
            colExamenes.MinimumWidth = 6;
            colExamenes.Name = "colExamenes";
            colExamenes.ReadOnly = true;
            // 
            // grpCondiciones
            // 
            grpCondiciones.BackColor = Color.White;
            grpCondiciones.Controls.Add(dgvCondiciones);
            grpCondiciones.ForeColor = Color.FromArgb(11, 61, 110);
            grpCondiciones.Location = new Point(20, 268);
            grpCondiciones.Name = "grpCondiciones";
            grpCondiciones.Padding = new Padding(10, 8, 10, 10);
            grpCondiciones.Size = new Size(960, 148);
            grpCondiciones.TabIndex = 3;
            grpCondiciones.TabStop = false;
            grpCondiciones.Text = "Condiciones que exige cada examen";
            // 
            // dgvCondiciones
            // 
            dgvCondiciones.AllowUserToAddRows = false;
            dgvCondiciones.AllowUserToDeleteRows = false;
            dgvCondiciones.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 246, 250);
            dgvCondiciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCondiciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCondiciones.BackgroundColor = Color.White;
            dgvCondiciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCondiciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCondiciones.ColumnHeadersHeight = 34;
            dgvCondiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCondiciones.Columns.AddRange(new DataGridViewColumn[] { colExamen, colHorasDeAyuno, colMuestraQueDebeTraer });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCondiciones.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCondiciones.Dock = DockStyle.Fill;
            dgvCondiciones.EnableHeadersVisualStyles = false;
            dgvCondiciones.GridColor = Color.FromArgb(208, 215, 222);
            dgvCondiciones.Location = new Point(10, 31);
            dgvCondiciones.MultiSelect = false;
            dgvCondiciones.Name = "dgvCondiciones";
            dgvCondiciones.ReadOnly = true;
            dgvCondiciones.RowHeadersVisible = false;
            dgvCondiciones.RowHeadersWidth = 51;
            dgvCondiciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCondiciones.Size = new Size(940, 107);
            dgvCondiciones.TabIndex = 1;
            // 
            // colExamen
            // 
            colExamen.HeaderText = "Examen";
            colExamen.MinimumWidth = 6;
            colExamen.Name = "colExamen";
            colExamen.ReadOnly = true;
            // 
            // colHorasDeAyuno
            // 
            colHorasDeAyuno.HeaderText = "Horas de ayuno";
            colHorasDeAyuno.MinimumWidth = 6;
            colHorasDeAyuno.Name = "colHorasDeAyuno";
            colHorasDeAyuno.ReadOnly = true;
            // 
            // colMuestraQueDebeTraer
            // 
            colMuestraQueDebeTraer.HeaderText = "Muestra que debe traer";
            colMuestraQueDebeTraer.MinimumWidth = 6;
            colMuestraQueDebeTraer.Name = "colMuestraQueDebeTraer";
            colMuestraQueDebeTraer.ReadOnly = true;
            // 
            // grpEvaluacionDelPaciente
            // 
            grpEvaluacionDelPaciente.BackColor = Color.White;
            grpEvaluacionDelPaciente.Controls.Add(txtObservaciones);
            grpEvaluacionDelPaciente.Controls.Add(lblObservaciones);
            grpEvaluacionDelPaciente.Controls.Add(chkConservacion);
            grpEvaluacionDelPaciente.Controls.Add(chkVolumen);
            grpEvaluacionDelPaciente.Controls.Add(chkHermetico);
            grpEvaluacionDelPaciente.Controls.Add(chkRotulado);
            grpEvaluacionDelPaciente.Controls.Add(txtMedicamentos);
            grpEvaluacionDelPaciente.Controls.Add(lblMedicamentos);
            grpEvaluacionDelPaciente.Controls.Add(nudHorasAyuno);
            grpEvaluacionDelPaciente.Controls.Add(lblHorasAyuno);
            grpEvaluacionDelPaciente.ForeColor = Color.FromArgb(11, 61, 110);
            grpEvaluacionDelPaciente.Location = new Point(20, 426);
            grpEvaluacionDelPaciente.Name = "grpEvaluacionDelPaciente";
            grpEvaluacionDelPaciente.Size = new Size(960, 180);
            grpEvaluacionDelPaciente.TabIndex = 4;
            grpEvaluacionDelPaciente.TabStop = false;
            grpEvaluacionDelPaciente.Text = "Evaluación del paciente";
            // 
            // lblHorasAyuno
            // 
            lblHorasAyuno.AutoSize = true;
            lblHorasAyuno.BackColor = Color.Transparent;
            lblHorasAyuno.ForeColor = Color.FromArgb(31, 35, 40);
            lblHorasAyuno.Location = new Point(15, 35);
            lblHorasAyuno.Name = "lblHorasAyuno";
            lblHorasAyuno.Size = new Size(130, 23);
            lblHorasAyuno.TabIndex = 0;
            lblHorasAyuno.Text = "Horas de ayuno";
            // 
            // nudHorasAyuno
            // 
            nudHorasAyuno.BorderStyle = BorderStyle.FixedSingle;
            nudHorasAyuno.ForeColor = Color.FromArgb(31, 35, 40);
            nudHorasAyuno.Location = new Point(239, 32);
            nudHorasAyuno.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudHorasAyuno.Name = "nudHorasAyuno";
            nudHorasAyuno.Size = new Size(80, 30);
            nudHorasAyuno.TabIndex = 1;
            nudHorasAyuno.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMedicamentos
            // 
            lblMedicamentos.AutoSize = true;
            lblMedicamentos.BackColor = Color.Transparent;
            lblMedicamentos.ForeColor = Color.FromArgb(31, 35, 40);
            lblMedicamentos.Location = new Point(15, 73);
            lblMedicamentos.Name = "lblMedicamentos";
            lblMedicamentos.Size = new Size(218, 23);
            lblMedicamentos.TabIndex = 2;
            lblMedicamentos.Text = "Medicamentos consumidos";
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.BackColor = Color.White;
            txtMedicamentos.BorderStyle = BorderStyle.FixedSingle;
            txtMedicamentos.ForeColor = Color.FromArgb(31, 35, 40);
            txtMedicamentos.Location = new Point(239, 68);
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new Size(250, 30);
            txtMedicamentos.TabIndex = 3;
            // 
            // chkRotulado
            // 
            chkRotulado.AutoSize = true;
            chkRotulado.Cursor = Cursors.Hand;
            chkRotulado.ForeColor = Color.FromArgb(31, 35, 40);
            chkRotulado.Location = new Point(15, 108);
            chkRotulado.Name = "chkRotulado";
            chkRotulado.Size = new Size(169, 27);
            chkRotulado.TabIndex = 4;
            chkRotulado.Text = "Rotulado correcto";
            chkRotulado.UseVisualStyleBackColor = true;
            // 
            // chkHermetico
            // 
            chkHermetico.AutoSize = true;
            chkHermetico.Cursor = Cursors.Hand;
            chkHermetico.ForeColor = Color.FromArgb(31, 35, 40);
            chkHermetico.Location = new Point(15, 140);
            chkHermetico.Name = "chkHermetico";
            chkHermetico.Size = new Size(193, 27);
            chkHermetico.TabIndex = 5;
            chkHermetico.Text = "Recipiente hermético";
            chkHermetico.UseVisualStyleBackColor = true;
            // 
            // chkVolumen
            // 
            chkVolumen.AutoSize = true;
            chkVolumen.Cursor = Cursors.Hand;
            chkVolumen.ForeColor = Color.FromArgb(31, 35, 40);
            chkVolumen.Location = new Point(619, 29);
            chkVolumen.Name = "chkVolumen";
            chkVolumen.Size = new Size(177, 27);
            chkVolumen.TabIndex = 6;
            chkVolumen.Text = "Volumen suficiente";
            chkVolumen.UseVisualStyleBackColor = true;
            // 
            // chkConservacion
            // 
            chkConservacion.AutoSize = true;
            chkConservacion.Cursor = Cursors.Hand;
            chkConservacion.ForeColor = Color.FromArgb(31, 35, 40);
            chkConservacion.Location = new Point(619, 62);
            chkConservacion.Name = "chkConservacion";
            chkConservacion.Size = new Size(213, 27);
            chkConservacion.TabIndex = 7;
            chkConservacion.Text = "Conservación adecuada";
            chkConservacion.UseVisualStyleBackColor = true;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.BackColor = Color.Transparent;
            lblObservaciones.ForeColor = Color.FromArgb(31, 35, 40);
            lblObservaciones.Location = new Point(474, 112);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(120, 23);
            lblObservaciones.TabIndex = 8;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(614, 95);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(300, 60);
            txtObservaciones.TabIndex = 10;
            // 
            // FrmRegistrarObservaciones
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpEvaluacionDelPaciente);
            Controls.Add(grpCondiciones);
            Controls.Add(grpPendientes);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(31, 35, 40);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarObservaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar observaciones preanalíticas";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            grpCondiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCondiciones).EndInit();
            grpEvaluacionDelPaciente.ResumeLayout(false);
            grpEvaluacionDelPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHorasAyuno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnGuardar;
        private GroupBox grpPendientes;
        private DataGridView dgvPendientes;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colExamenes;
        private GroupBox grpCondiciones;
        private DataGridView dgvCondiciones;
        private DataGridViewTextBoxColumn colExamen;
        private DataGridViewTextBoxColumn colHorasDeAyuno;
        private DataGridViewTextBoxColumn colMuestraQueDebeTraer;
        private GroupBox grpEvaluacionDelPaciente;
        private NumericUpDown nudHorasAyuno;
        private Label lblHorasAyuno;
        private CheckBox chkRotulado;
        private TextBox txtMedicamentos;
        private Label lblMedicamentos;
        private Label lblObservaciones;
        private CheckBox chkConservacion;
        private CheckBox chkVolumen;
        private CheckBox chkHermetico;
        private TextBox txtObservaciones;
    }
}
