namespace CEIBIO.Presentacion.Caja
{
    partial class FrmVisitasAsignadas
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
            grpVisitas = new GroupBox();
            dgvVisitas = new DataGridView();
            colPaciente = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colContacto = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            colNComprobante = new DataGridViewTextBoxColumn();
            grpDetalleDeLaVisita = new GroupBox();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblReferencia = new Label();
            txtReferencia = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpVisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).BeginInit();
            grpDetalleDeLaVisita.SuspendLayout();
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
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mis visitas asignadas";
            // 
            // flpBotones
            // 
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Dock = DockStyle.Bottom;
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
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(13, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // grpVisitas
            // 
            grpVisitas.BackColor = Color.White;
            grpVisitas.Controls.Add(dgvVisitas);
            grpVisitas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpVisitas.ForeColor = Color.FromArgb(11, 61, 110);
            grpVisitas.Location = new Point(20, 70);
            grpVisitas.Name = "grpVisitas";
            grpVisitas.Padding = new Padding(10, 8, 10, 10);
            grpVisitas.Size = new Size(960, 384);
            grpVisitas.TabIndex = 2;
            grpVisitas.TabStop = false;
            grpVisitas.Text = "Mis visitas asignadas";
            // 
            // dgvVisitas
            // 
            dgvVisitas.AllowUserToAddRows = false;
            dgvVisitas.AllowUserToDeleteRows = false;
            dgvVisitas.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvVisitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisitas.BackgroundColor = Color.White;
            dgvVisitas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVisitas.ColumnHeadersHeight = 34;
            dgvVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVisitas.Columns.AddRange(new DataGridViewColumn[] { colPaciente, colDireccion, colContacto, colExamenes, colNComprobante });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVisitas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVisitas.Dock = DockStyle.Fill;
            dgvVisitas.EnableHeadersVisualStyles = false;
            dgvVisitas.GridColor = Color.FromArgb(208, 215, 222);
            dgvVisitas.Location = new Point(10, 26);
            dgvVisitas.MultiSelect = false;
            dgvVisitas.Name = "dgvVisitas";
            dgvVisitas.ReadOnly = true;
            dgvVisitas.RowHeadersVisible = false;
            dgvVisitas.RowTemplate.Height = 28;
            dgvVisitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitas.Size = new Size(940, 348);
            dgvVisitas.TabIndex = 0;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colContacto
            // 
            colContacto.HeaderText = "Contacto";
            colContacto.Name = "colContacto";
            colContacto.ReadOnly = true;
            // 
            // colExamenes
            // 
            colExamenes.HeaderText = "Exámenes";
            colExamenes.Name = "colExamenes";
            colExamenes.ReadOnly = true;
            // 
            // colNComprobante
            // 
            colNComprobante.HeaderText = "N.° comprobante";
            colNComprobante.Name = "colNComprobante";
            colNComprobante.ReadOnly = true;
            // 
            // grpDetalleDeLaVisita
            // 
            grpDetalleDeLaVisita.BackColor = Color.White;
            grpDetalleDeLaVisita.Controls.Add(txtReferencia);
            grpDetalleDeLaVisita.Controls.Add(lblReferencia);
            grpDetalleDeLaVisita.Controls.Add(txtDireccion);
            grpDetalleDeLaVisita.Controls.Add(lblDireccion);
            grpDetalleDeLaVisita.Controls.Add(txtTelefono);
            grpDetalleDeLaVisita.Controls.Add(lblTelefono);
            grpDetalleDeLaVisita.Controls.Add(txtPaciente);
            grpDetalleDeLaVisita.Controls.Add(lblPaciente);
            grpDetalleDeLaVisita.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalleDeLaVisita.ForeColor = Color.FromArgb(11, 61, 110);
            grpDetalleDeLaVisita.Location = new Point(20, 464);
            grpDetalleDeLaVisita.Name = "grpDetalleDeLaVisita";
            grpDetalleDeLaVisita.Size = new Size(960, 116);
            grpDetalleDeLaVisita.TabIndex = 3;
            grpDetalleDeLaVisita.TabStop = false;
            grpDetalleDeLaVisita.Text = "Detalle de la visita";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(15, 35);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(60, 17);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(125, 32);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(300, 25);
            txtPaciente.TabIndex = 1;
            txtPaciente.TabStop = false;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            lblTelefono.Location = new Point(15, 73);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 17);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(233, 238, 243);
            txtTelefono.ForeColor = Color.FromArgb(31, 35, 40);
            txtTelefono.Location = new Point(125, 70);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(150, 25);
            txtTelefono.TabIndex = 3;
            txtTelefono.TabStop = false;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            lblDireccion.Location = new Point(495, 35);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(66, 17);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(233, 238, 243);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.FromArgb(31, 35, 40);
            txtDireccion.Location = new Point(605, 32);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(300, 25);
            txtDireccion.TabIndex = 5;
            txtDireccion.TabStop = false;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.BackColor = Color.Transparent;
            lblReferencia.ForeColor = Color.FromArgb(31, 35, 40);
            lblReferencia.Location = new Point(495, 73);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(72, 17);
            lblReferencia.TabIndex = 6;
            lblReferencia.Text = "Referencia";
            // 
            // txtReferencia
            // 
            txtReferencia.BackColor = Color.FromArgb(233, 238, 243);
            txtReferencia.BorderStyle = BorderStyle.FixedSingle;
            txtReferencia.ForeColor = Color.FromArgb(31, 35, 40);
            txtReferencia.Location = new Point(605, 70);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.ReadOnly = true;
            txtReferencia.Size = new Size(300, 25);
            txtReferencia.TabIndex = 7;
            txtReferencia.TabStop = false;
            // 
            // FrmVisitasAsignadas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 650);
            Controls.Add(grpDetalleDeLaVisita);
            Controls.Add(grpVisitas);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmVisitasAsignadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mis visitas asignadas";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpVisitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisitas).EndInit();
            grpDetalleDeLaVisita.ResumeLayout(false);
            grpDetalleDeLaVisita.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private GroupBox grpVisitas;
        private DataGridView dgvVisitas;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colContacto;
        private DataGridViewTextBoxColumn colExamenes;
        private DataGridViewTextBoxColumn colNComprobante;
        private GroupBox grpDetalleDeLaVisita;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtReferencia;
        private Label lblReferencia;
        private TextBox txtDireccion;
    }
}
