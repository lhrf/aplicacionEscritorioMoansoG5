namespace CEIBIO.Presentacion.Analisis
{
    partial class FrmPendientesValidacion
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
            btnValidar = new Button();
            grpPendientes = new GroupBox();
            dgvPendientes = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            colTecnico = new DataGridViewTextBoxColumn();
            colFechaDeEnvio = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
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
            lblTitulo.Size = new Size(333, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Resultados pendientes de validación";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnValidar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 2;
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
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(11, 61, 110);
            btnValidar.Cursor = Cursors.Hand;
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidar.ForeColor = Color.FromArgb(255, 255, 255);
            btnValidar.Location = new Point(711, 15);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(130, 36);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            // 
            // grpPendientes
            // 
            grpPendientes.BackColor = Color.FromArgb(255, 255, 255);
            grpPendientes.Controls.Add(dgvPendientes);
            grpPendientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPendientes.ForeColor = Color.FromArgb(11, 61, 110);
            grpPendientes.Location = new Point(20, 70);
            grpPendientes.Name = "grpPendientes";
            grpPendientes.Padding = new Padding(10, 8, 10, 10);
            grpPendientes.Size = new Size(960, 510);
            grpPendientes.TabIndex = 1;
            grpPendientes.TabStop = false;
            grpPendientes.Text = "Resultados pendientes de validación";
            // 
            // dgvPendientes
            // 
            dgvPendientes.AllowUserToAddRows = false;
            dgvPendientes.AllowUserToDeleteRows = false;
            dgvPendientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvPendientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPendientes.ColumnHeadersHeight = 34;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendientes.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colExamenes, colTecnico, colFechaDeEnvio });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPendientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPendientes.Dock = DockStyle.Fill;
            dgvPendientes.EnableHeadersVisualStyles = false;
            dgvPendientes.GridColor = Color.FromArgb(208, 215, 222);
            dgvPendientes.Location = new Point(10, 26);
            dgvPendientes.MultiSelect = false;
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.ReadOnly = true;
            dgvPendientes.RowHeadersVisible = false;
            dgvPendientes.RowTemplate.Height = 28;
            dgvPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendientes.Size = new Size(940, 474);
            dgvPendientes.TabIndex = 0;
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
            // colTecnico
            // 
            colTecnico.HeaderText = "Técnico";
            colTecnico.Name = "colTecnico";
            colTecnico.ReadOnly = true;
            // 
            // colFechaDeEnvio
            // 
            colFechaDeEnvio.HeaderText = "Fecha de envío";
            colFechaDeEnvio.Name = "colFechaDeEnvio";
            colFechaDeEnvio.ReadOnly = true;
            // 
            // FrmPendientesValidacion
            // 
            AcceptButton = btnValidar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpPendientes);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPendientesValidacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados pendientes de validación";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.GroupBox grpPendientes;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeEnvio;
    }
}
