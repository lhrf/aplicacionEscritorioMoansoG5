namespace CEIBIO.Presentacion.Preparacion
{
    partial class FrmPendientesAcondicionar
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
            label1 = new Label();
            flpBotones = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            dgvPendientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colHoraDeIngreso = new DataGridViewTextBoxColumn();
            colTiempoTranscurrido = new DataGridViewTextBoxColumn();
            flpBotones.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
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
            lblTitulo.Size = new Size(344, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Muestras pendientes de acondicionar";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(191, 215, 238);
            label1.Location = new Point(939, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "CU-38";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(button1);
            flpBotones.Controls.Add(button2);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 521);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(984, 60);
            flpBotones.TabIndex = 3;
            flpBotones.WrapContents = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(229, 231, 235);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(31, 35, 40);
            button1.Location = new Point(831, 15);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 4;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(11, 61, 110);
            button2.Location = new Point(695, 15);
            button2.Name = "button2";
            button2.Size = new Size(130, 36);
            button2.TabIndex = 4;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dgvPendientes);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(11, 61, 110);
            groupBox1.Location = new Point(20, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 8, 10, 10);
            groupBox1.Size = new Size(960, 460);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Muestras ingresadas sin acondicionar";
            // 
            // dgvPendientes
            // 
            dgvPendientes.AllowUserToAddRows = false;
            dgvPendientes.AllowUserToDeleteRows = false;
            dgvPendientes.AllowUserToResizeColumns = false;
            dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientes.BackgroundColor = Color.White;
            dgvPendientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendientes.ColumnHeadersHeight = 34;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colPaciente, colHoraDeIngreso, colTiempoTranscurrido });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPendientes.DefaultCellStyle = dataGridViewCellStyle2;
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
            dgvPendientes.Size = new Size(940, 424);
            dgvPendientes.TabIndex = 0;
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
            // colTiempoTranscurrido
            // 
            colTiempoTranscurrido.HeaderText = "Tiempo transcurrido";
            colTiempoTranscurrido.Name = "colTiempoTranscurrido";
            colTiempoTranscurrido.ReadOnly = true;
            // 
            // FrmPendientesAcondicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 581);
            Controls.Add(groupBox1);
            Controls.Add(flpBotones);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPendientesAcondicionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Muestras pendientes de acondicionar";
            flpBotones.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label label1;
        private FlowLayoutPanel flpBotones;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private DataGridView dgvPendientes;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colHoraDeIngreso;
        private DataGridViewTextBoxColumn colTiempoTranscurrido;
    }
}
