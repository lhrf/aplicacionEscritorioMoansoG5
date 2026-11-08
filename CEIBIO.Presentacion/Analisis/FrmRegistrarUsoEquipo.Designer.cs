namespace CEIBIO.Presentacion.Analisis
{
    partial class FrmRegistrarUsoEquipo
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
            btnRegistrar = new Button();
            btnFalla = new Button();
            grpUsoDelEquipo = new GroupBox();
            lblEquipo = new Label();
            cboEquipo = new ComboBox();
            lblCodigoMuestra = new Label();
            txtCodigo = new TextBox();
            lblHoraInicio = new Label();
            txtHoraInicio = new TextBox();
            grpUsos = new GroupBox();
            dgvUsos = new DataGridView();
            colHora = new DataGridViewTextBoxColumn();
            colEquipo = new DataGridViewTextBoxColumn();
            colMuestra = new DataGridViewTextBoxColumn();
            colTecnico = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpUsoDelEquipo.SuspendLayout();
            grpUsos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsos).BeginInit();
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
            lblTitulo.Size = new Size(229, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar uso del equipo";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnRegistrar);
            flpBotones.Controls.Add(btnFalla);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
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
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(11, 61, 110);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.FromArgb(255, 255, 255);
            btnRegistrar.Location = new Point(705, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(136, 36);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar uso";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnFalla
            // 
            btnFalla.BackColor = Color.FromArgb(180, 35, 24);
            btnFalla.Cursor = Cursors.Hand;
            btnFalla.FlatAppearance.BorderSize = 0;
            btnFalla.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnFalla.FlatStyle = FlatStyle.Flat;
            btnFalla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFalla.ForeColor = Color.FromArgb(255, 255, 255);
            btnFalla.Location = new Point(546, 15);
            btnFalla.Name = "btnFalla";
            btnFalla.Size = new Size(153, 36);
            btnFalla.TabIndex = 2;
            btnFalla.Text = "Registrar falla";
            btnFalla.UseVisualStyleBackColor = false;
            // 
            // grpUsoDelEquipo
            // 
            grpUsoDelEquipo.BackColor = Color.FromArgb(255, 255, 255);
            grpUsoDelEquipo.Controls.Add(lblEquipo);
            grpUsoDelEquipo.Controls.Add(cboEquipo);
            grpUsoDelEquipo.Controls.Add(lblCodigoMuestra);
            grpUsoDelEquipo.Controls.Add(txtCodigo);
            grpUsoDelEquipo.Controls.Add(lblHoraInicio);
            grpUsoDelEquipo.Controls.Add(txtHoraInicio);
            grpUsoDelEquipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpUsoDelEquipo.ForeColor = Color.FromArgb(11, 61, 110);
            grpUsoDelEquipo.Location = new Point(20, 70);
            grpUsoDelEquipo.Name = "grpUsoDelEquipo";
            grpUsoDelEquipo.Size = new Size(960, 154);
            grpUsoDelEquipo.TabIndex = 1;
            grpUsoDelEquipo.TabStop = false;
            grpUsoDelEquipo.Text = "Uso del equipo";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.BackColor = Color.Transparent;
            lblEquipo.Font = new Font("Segoe UI", 10F);
            lblEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            lblEquipo.Location = new Point(15, 35);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(61, 19);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo *";
            // 
            // cboEquipo
            // 
            cboEquipo.BackColor = Color.FromArgb(255, 255, 255);
            cboEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipo.FlatStyle = FlatStyle.Flat;
            cboEquipo.Font = new Font("Segoe UI", 10F);
            cboEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            cboEquipo.FormattingEnabled = true;
            cboEquipo.Location = new Point(182, 32);
            cboEquipo.Name = "cboEquipo";
            cboEquipo.Size = new Size(260, 25);
            cboEquipo.TabIndex = 1;
            // 
            // lblCodigoMuestra
            // 
            lblCodigoMuestra.AutoSize = true;
            lblCodigoMuestra.BackColor = Color.Transparent;
            lblCodigoMuestra.Font = new Font("Segoe UI", 10F);
            lblCodigoMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            lblCodigoMuestra.Location = new Point(15, 73);
            lblCodigoMuestra.Name = "lblCodigoMuestra";
            lblCodigoMuestra.Size = new Size(136, 19);
            lblCodigoMuestra.TabIndex = 2;
            lblCodigoMuestra.Text = "Código de muestra *";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(255, 255, 255);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            txtCodigo.Location = new Point(182, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 25);
            txtCodigo.TabIndex = 3;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.BackColor = Color.Transparent;
            lblHoraInicio.Font = new Font("Segoe UI", 10F);
            lblHoraInicio.ForeColor = Color.FromArgb(31, 35, 40);
            lblHoraInicio.Location = new Point(15, 111);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(93, 19);
            lblHoraInicio.TabIndex = 4;
            lblHoraInicio.Text = "Hora de inicio";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.BackColor = Color.FromArgb(233, 238, 243);
            txtHoraInicio.BorderStyle = BorderStyle.FixedSingle;
            txtHoraInicio.Font = new Font("Segoe UI", 10F);
            txtHoraInicio.ForeColor = Color.FromArgb(31, 35, 40);
            txtHoraInicio.Location = new Point(182, 108);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ReadOnly = true;
            txtHoraInicio.Size = new Size(120, 25);
            txtHoraInicio.TabIndex = 5;
            txtHoraInicio.TabStop = false;
            // 
            // grpUsos
            // 
            grpUsos.BackColor = Color.FromArgb(255, 255, 255);
            grpUsos.Controls.Add(dgvUsos);
            grpUsos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpUsos.ForeColor = Color.FromArgb(11, 61, 110);
            grpUsos.Location = new Point(20, 234);
            grpUsos.Name = "grpUsos";
            grpUsos.Padding = new Padding(10, 8, 10, 10);
            grpUsos.Size = new Size(960, 346);
            grpUsos.TabIndex = 2;
            grpUsos.TabStop = false;
            grpUsos.Text = "Usos registrados hoy";
            // 
            // dgvUsos
            // 
            dgvUsos.AllowUserToAddRows = false;
            dgvUsos.AllowUserToDeleteRows = false;
            dgvUsos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvUsos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvUsos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsos.ColumnHeadersHeight = 34;
            dgvUsos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsos.Columns.AddRange(new DataGridViewColumn[] { colHora, colEquipo, colMuestra, colTecnico });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsos.Dock = DockStyle.Fill;
            dgvUsos.EnableHeadersVisualStyles = false;
            dgvUsos.GridColor = Color.FromArgb(208, 215, 222);
            dgvUsos.Location = new Point(10, 26);
            dgvUsos.MultiSelect = false;
            dgvUsos.Name = "dgvUsos";
            dgvUsos.ReadOnly = true;
            dgvUsos.RowHeadersVisible = false;
            dgvUsos.RowTemplate.Height = 28;
            dgvUsos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsos.Size = new Size(940, 310);
            dgvUsos.TabIndex = 0;
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colEquipo
            // 
            colEquipo.HeaderText = "Equipo";
            colEquipo.Name = "colEquipo";
            colEquipo.ReadOnly = true;
            // 
            // colMuestra
            // 
            colMuestra.HeaderText = "Muestra";
            colMuestra.Name = "colMuestra";
            colMuestra.ReadOnly = true;
            // 
            // colTecnico
            // 
            colTecnico.HeaderText = "Técnico";
            colTecnico.Name = "colTecnico";
            colTecnico.ReadOnly = true;
            // 
            // FrmRegistrarUsoEquipo
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpUsos);
            Controls.Add(grpUsoDelEquipo);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarUsoEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar uso del equipo";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpUsoDelEquipo.ResumeLayout(false);
            grpUsoDelEquipo.PerformLayout();
            grpUsos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnFalla;
        private System.Windows.Forms.GroupBox grpUsoDelEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.Label lblCodigoMuestra;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.GroupBox grpUsos;
        private System.Windows.Forms.DataGridView dgvUsos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnico;
    }
}
