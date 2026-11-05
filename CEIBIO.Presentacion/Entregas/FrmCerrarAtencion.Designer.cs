namespace CEIBIO.Presentacion.Entregas
{
    partial class FrmCerrarAtencion
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
            btnSalir = new Button();
            btnCerrarAtencion = new Button();
            grpEntregadas = new GroupBox();
            dgvEntregadas = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colRecibidoPor = new DataGridViewTextBoxColumn();
            colFechaDeEntrega = new DataGridViewTextBoxColumn();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpEntregadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntregadas).BeginInit();
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
            pnlEncabezado.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cerrar atención";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnSalir);
            flpBotones.Controls.Add(btnCerrarAtencion);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 1;
            flpBotones.WrapContents = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(229, 231, 235);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(31, 35, 40);
            btnSalir.Location = new Point(847, 15);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 36);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCerrarAtencion
            // 
            btnCerrarAtencion.BackColor = Color.FromArgb(11, 61, 110);
            btnCerrarAtencion.Cursor = Cursors.Hand;
            btnCerrarAtencion.FlatAppearance.BorderSize = 0;
            btnCerrarAtencion.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnCerrarAtencion.FlatStyle = FlatStyle.Flat;
            btnCerrarAtencion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarAtencion.ForeColor = Color.White;
            btnCerrarAtencion.Location = new Point(688, 15);
            btnCerrarAtencion.Name = "btnCerrarAtencion";
            btnCerrarAtencion.Size = new Size(153, 36);
            btnCerrarAtencion.TabIndex = 0;
            btnCerrarAtencion.Text = "Cerrar atención";
            btnCerrarAtencion.UseVisualStyleBackColor = false;
            // 
            // grpEntregadas
            // 
            grpEntregadas.BackColor = Color.White;
            grpEntregadas.Controls.Add(dgvEntregadas);
            grpEntregadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEntregadas.ForeColor = Color.FromArgb(11, 61, 110);
            grpEntregadas.Location = new Point(20, 70);
            grpEntregadas.Name = "grpEntregadas";
            grpEntregadas.Padding = new Padding(10, 8, 10, 10);
            grpEntregadas.Size = new Size(960, 510);
            grpEntregadas.TabIndex = 0;
            grpEntregadas.TabStop = false;
            grpEntregadas.Text = "Atenciones entregadas";
            // 
            // dgvEntregadas
            // 
            dgvEntregadas.AllowUserToAddRows = false;
            dgvEntregadas.AllowUserToDeleteRows = false;
            dgvEntregadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvEntregadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntregadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntregadas.BackgroundColor = Color.White;
            dgvEntregadas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEntregadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEntregadas.ColumnHeadersHeight = 34;
            dgvEntregadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEntregadas.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colRecibidoPor, colFechaDeEntrega });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEntregadas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEntregadas.Dock = DockStyle.Fill;
            dgvEntregadas.EnableHeadersVisualStyles = false;
            dgvEntregadas.GridColor = Color.FromArgb(208, 215, 222);
            dgvEntregadas.Location = new Point(10, 26);
            dgvEntregadas.MultiSelect = false;
            dgvEntregadas.Name = "dgvEntregadas";
            dgvEntregadas.ReadOnly = true;
            dgvEntregadas.RowHeadersVisible = false;
            dgvEntregadas.RowTemplate.Height = 28;
            dgvEntregadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregadas.Size = new Size(940, 474);
            dgvEntregadas.TabIndex = 0;
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
            // colRecibidoPor
            // 
            colRecibidoPor.HeaderText = "Recibido por";
            colRecibidoPor.Name = "colRecibidoPor";
            colRecibidoPor.ReadOnly = true;
            // 
            // colFechaDeEntrega
            // 
            colFechaDeEntrega.HeaderText = "Fecha de entrega";
            colFechaDeEntrega.Name = "colFechaDeEntrega";
            colFechaDeEntrega.ReadOnly = true;
            // 
            // FrmCerrarAtencion
            // 
            AcceptButton = btnCerrarAtencion;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnSalir;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpEntregadas);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCerrarAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cerrar atención";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpEntregadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntregadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnSalir;
        private Button btnCerrarAtencion;
        private GroupBox grpEntregadas;
        private DataGridView dgvEntregadas;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colRecibidoPor;
        private DataGridViewTextBoxColumn colFechaDeEntrega;
    }
}
