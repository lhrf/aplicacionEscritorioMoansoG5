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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            pnlEncabezado = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblCodigo = new System.Windows.Forms.Label();
            flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            btnCerrar = new System.Windows.Forms.Button();
            btnRegistrar = new System.Windows.Forms.Button();
            btnFalla = new System.Windows.Forms.Button();
            grpUsoDelEquipo = new System.Windows.Forms.GroupBox();
            lblEquipo = new System.Windows.Forms.Label();
            cboEquipo = new System.Windows.Forms.ComboBox();
            lblCodigoMuestra = new System.Windows.Forms.Label();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblHoraInicio = new System.Windows.Forms.Label();
            txtHoraInicio = new System.Windows.Forms.TextBox();
            grpUsos = new System.Windows.Forms.GroupBox();
            dgvUsos = new System.Windows.Forms.DataGridView();
            colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpUsoDelEquipo.SuspendLayout();
            grpUsos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsos).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlEncabezado.Controls.Add(lblCodigo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new System.Drawing.Size(1000, 56);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new System.Drawing.Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(229, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar uso del equipo";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = System.Drawing.Color.Transparent;
            lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(191, 215, 238);
            lblCodigo.Location = new System.Drawing.Point(939, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(41, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "CU-41";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnRegistrar);
            flpBotones.Controls.Add(btnFalla);
            flpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            flpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpBotones.Location = new System.Drawing.Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            flpBotones.Size = new System.Drawing.Size(1000, 60);
            flpBotones.TabIndex = 3;
            flpBotones.WrapContents = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCerrar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new System.Drawing.Point(860, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = true;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(20, 90, 158);
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnRegistrar.Location = new System.Drawing.Point(718, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(136, 36);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.TabStop = true;
            btnRegistrar.Text = "Registrar uso";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnFalla
            // 
            btnFalla.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            btnFalla.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFalla.FlatAppearance.BorderSize = 0;
            btnFalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 28, 19);
            btnFalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFalla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnFalla.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnFalla.Location = new System.Drawing.Point(559, 12);
            btnFalla.Name = "btnFalla";
            btnFalla.Size = new System.Drawing.Size(153, 36);
            btnFalla.TabIndex = 2;
            btnFalla.TabStop = true;
            btnFalla.Text = "Registrar falla";
            btnFalla.UseVisualStyleBackColor = false;
            // 
            // grpUsoDelEquipo
            // 
            grpUsoDelEquipo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpUsoDelEquipo.Controls.Add(lblEquipo);
            grpUsoDelEquipo.Controls.Add(cboEquipo);
            grpUsoDelEquipo.Controls.Add(lblCodigoMuestra);
            grpUsoDelEquipo.Controls.Add(txtCodigo);
            grpUsoDelEquipo.Controls.Add(lblHoraInicio);
            grpUsoDelEquipo.Controls.Add(txtHoraInicio);
            grpUsoDelEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpUsoDelEquipo.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpUsoDelEquipo.Location = new System.Drawing.Point(20, 70);
            grpUsoDelEquipo.Name = "grpUsoDelEquipo";
            grpUsoDelEquipo.Size = new System.Drawing.Size(960, 154);
            grpUsoDelEquipo.TabIndex = 1;
            grpUsoDelEquipo.TabStop = false;
            grpUsoDelEquipo.Text = "Uso del equipo";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.BackColor = System.Drawing.Color.Transparent;
            lblEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblEquipo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblEquipo.Location = new System.Drawing.Point(15, 35);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new System.Drawing.Size(67, 19);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo *";
            // 
            // cboEquipo
            // 
            cboEquipo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            cboEquipo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            cboEquipo.FormattingEnabled = true;
            cboEquipo.Location = new System.Drawing.Point(182, 32);
            cboEquipo.Name = "cboEquipo";
            cboEquipo.Size = new System.Drawing.Size(260, 25);
            cboEquipo.TabIndex = 1;
            // 
            // lblCodigoMuestra
            // 
            lblCodigoMuestra.AutoSize = true;
            lblCodigoMuestra.BackColor = System.Drawing.Color.Transparent;
            lblCodigoMuestra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblCodigoMuestra.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblCodigoMuestra.Location = new System.Drawing.Point(15, 73);
            lblCodigoMuestra.Name = "lblCodigoMuestra";
            lblCodigoMuestra.Size = new System.Drawing.Size(128, 19);
            lblCodigoMuestra.TabIndex = 2;
            lblCodigoMuestra.Text = "Código de muestra *";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtCodigo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtCodigo.Location = new System.Drawing.Point(182, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(150, 25);
            txtCodigo.TabIndex = 3;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.BackColor = System.Drawing.Color.Transparent;
            lblHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblHoraInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblHoraInicio.Location = new System.Drawing.Point(15, 111);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new System.Drawing.Size(92, 19);
            lblHoraInicio.TabIndex = 4;
            lblHoraInicio.Text = "Hora de inicio";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            txtHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtHoraInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtHoraInicio.Location = new System.Drawing.Point(182, 108);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ReadOnly = true;
            txtHoraInicio.Size = new System.Drawing.Size(120, 25);
            txtHoraInicio.TabIndex = 5;
            txtHoraInicio.TabStop = false;
            // 
            // grpUsos
            // 
            grpUsos.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpUsos.Controls.Add(dgvUsos);
            grpUsos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpUsos.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpUsos.Location = new System.Drawing.Point(20, 234);
            grpUsos.Name = "grpUsos";
            grpUsos.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            grpUsos.Size = new System.Drawing.Size(960, 346);
            grpUsos.TabIndex = 2;
            grpUsos.TabStop = false;
            grpUsos.Text = "Usos registrados hoy";
            // 
            // dgvUsos
            // 
            dgvUsos.AllowUserToAddRows = false;
            dgvUsos.AllowUserToDeleteRows = false;
            dgvUsos.AllowUserToResizeRows = false;
            dgvUsos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsos.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvUsos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsos.ColumnHeadersHeight = 34;
            dgvUsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colHora, colEquipo, colMuestra, colTecnico });
            dgvUsos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsos.EnableHeadersVisualStyles = false;
            dgvUsos.GridColor = System.Drawing.Color.FromArgb(208, 215, 222);
            dgvUsos.Location = new System.Drawing.Point(10, 31);
            dgvUsos.MultiSelect = false;
            dgvUsos.Name = "dgvUsos";
            dgvUsos.ReadOnly = true;
            dgvUsos.RowHeadersVisible = false;
            dgvUsos.RowTemplate.Height = 28;
            dgvUsos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsos.Size = new System.Drawing.Size(940, 305);
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
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new System.Drawing.Size(1000, 650);
            Controls.Add(grpUsos);
            Controls.Add(grpUsoDelEquipo);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarUsoEquipo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblCodigo;
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
