namespace CEIBIO.Presentacion.Preparacion
{
    partial class FrmRecepcionMuestra
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
            btnConfirmar = new Button();
            btnDevolver = new Button();
            grpAcondicionadas = new GroupBox();
            grpCotejo = new GroupBox();
            txtCodigox = new TextBox();
            lblCodigox = new Label();
            dgvAcondicionadas = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colExamenes = new DataGridViewTextBoxColumn();
            colAcondicionadaPor = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            flpBotones.SuspendLayout();
            grpAcondicionadas.SuspendLayout();
            grpCotejo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAcondicionadas).BeginInit();
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
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(284, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registrar recepción formal de la muestra";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnConfirmar);
            flpBotones.Controls.Add(btnDevolver);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 551);
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
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(11, 61, 110);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(640, 15);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(185, 36);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar recepción";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.FromArgb(180, 35, 24);
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(408, 15);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(226, 36);
            btnDevolver.TabIndex = 4;
            btnDevolver.Text = "Devolver con diferencias";
            btnDevolver.UseVisualStyleBackColor = false;
            // 
            // grpAcondicionadas
            // 
            grpAcondicionadas.BackColor = Color.White;
            grpAcondicionadas.Controls.Add(grpCotejo);
            grpAcondicionadas.Controls.Add(dgvAcondicionadas);
            grpAcondicionadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAcondicionadas.ForeColor = Color.FromArgb(11, 61, 110);
            grpAcondicionadas.Location = new Point(20, 70);
            grpAcondicionadas.Name = "grpAcondicionadas";
            grpAcondicionadas.Padding = new Padding(10, 8, 10, 10);
            grpAcondicionadas.Size = new Size(960, 422);
            grpAcondicionadas.TabIndex = 4;
            grpAcondicionadas.TabStop = false;
            grpAcondicionadas.Text = "Muestras acondicionadas";
            // 
            // grpCotejo
            // 
            grpCotejo.BackColor = Color.White;
            grpCotejo.Controls.Add(txtCodigox);
            grpCotejo.Controls.Add(lblCodigox);
            grpCotejo.Location = new Point(4, 331);
            grpCotejo.Name = "grpCotejo";
            grpCotejo.Size = new Size(960, 78);
            grpCotejo.TabIndex = 1;
            grpCotejo.TabStop = false;
            grpCotejo.Text = "Cotejo";
            // 
            // txtCodigox
            // 
            txtCodigox.BackColor = Color.White;
            txtCodigox.BorderStyle = BorderStyle.FixedSingle;
            txtCodigox.Font = new Font("Segoe UI", 10F);
            txtCodigox.ForeColor = Color.FromArgb(31, 35, 40);
            txtCodigox.Location = new Point(174, 32);
            txtCodigox.Name = "txtCodigox";
            txtCodigox.Size = new Size(150, 25);
            txtCodigox.TabIndex = 3;
            // 
            // lblCodigox
            // 
            lblCodigox.AutoSize = true;
            lblCodigox.BackColor = Color.Transparent;
            lblCodigox.Font = new Font("Segoe UI", 10F);
            lblCodigox.ForeColor = Color.FromArgb(31, 35, 40);
            lblCodigox.Location = new Point(9, 35);
            lblCodigox.Name = "lblCodigox";
            lblCodigox.Size = new Size(119, 19);
            lblCodigox.TabIndex = 2;
            lblCodigox.Text = "Código a cotejar *";
            // 
            // dgvAcondicionadas
            // 
            dgvAcondicionadas.AllowUserToAddRows = false;
            dgvAcondicionadas.AllowUserToDeleteRows = false;
            dgvAcondicionadas.AllowUserToResizeColumns = false;
            dgvAcondicionadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcondicionadas.BackgroundColor = Color.White;
            dgvAcondicionadas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAcondicionadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAcondicionadas.ColumnHeadersHeight = 34;
            dgvAcondicionadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAcondicionadas.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colPaciente, colExamenes, colAcondicionadaPor, colHora });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAcondicionadas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAcondicionadas.Dock = DockStyle.Fill;
            dgvAcondicionadas.EnableHeadersVisualStyles = false;
            dgvAcondicionadas.GridColor = Color.FromArgb(208, 215, 222);
            dgvAcondicionadas.Location = new Point(10, 26);
            dgvAcondicionadas.MultiSelect = false;
            dgvAcondicionadas.Name = "dgvAcondicionadas";
            dgvAcondicionadas.ReadOnly = true;
            dgvAcondicionadas.RowTemplate.Height = 28;
            dgvAcondicionadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcondicionadas.Size = new Size(940, 386);
            dgvAcondicionadas.TabIndex = 0;
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
            // colExamenes
            // 
            colExamenes.HeaderText = "Exámenes";
            colExamenes.Name = "colExamenes";
            colExamenes.ReadOnly = true;
            // 
            // colAcondicionadaPor
            // 
            colAcondicionadaPor.HeaderText = "Acondicionada por";
            colAcondicionadaPor.Name = "colAcondicionadaPor";
            colAcondicionadaPor.ReadOnly = true;
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // FrmRecepcionMuestra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 611);
            Controls.Add(grpAcondicionadas);
            Controls.Add(flpBotones);
            Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRecepcionMuestra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar recepción formal de la muestra";
            flpBotones.ResumeLayout(false);
            grpAcondicionadas.ResumeLayout(false);
            grpCotejo.ResumeLayout(false);
            grpCotejo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAcondicionadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnConfirmar;
        private Button btnDevolver;
        private GroupBox grpAcondicionadas;
        private DataGridView dgvAcondicionadas;
        private GroupBox grpCotejo;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colExamenes;
        private DataGridViewTextBoxColumn colAcondicionadaPor;
        private DataGridViewTextBoxColumn colHora;
        private TextBox txtCodigox;
        private Label lblCodigox;
    }
}
