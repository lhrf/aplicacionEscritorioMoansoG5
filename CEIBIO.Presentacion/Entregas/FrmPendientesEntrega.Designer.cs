namespace CEIBIO.Presentacion.Entregas
{
    partial class FrmPendientesEntrega
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
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCerrar = new Button();
            btnActualizar = new Button();
            grpPendientes = new GroupBox();
            dgvPendientes = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colFechaDeAutorizacion = new DataGridViewTextBoxColumn();
            colDiasSinRecoger = new DataGridViewTextBoxColumn();
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
            lblTitulo.Size = new Size(296, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes pendientes de entrega";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnActualizar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 560);
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
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.FromArgb(11, 61, 110);
            btnActualizar.Location = new Point(711, 15);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 36);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // grpPendientes
            // 
            grpPendientes.BackColor = Color.White;
            grpPendientes.Controls.Add(dgvPendientes);
            grpPendientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPendientes.ForeColor = Color.FromArgb(11, 61, 110);
            grpPendientes.Location = new Point(20, 70);
            grpPendientes.Name = "grpPendientes";
            grpPendientes.Padding = new Padding(10, 8, 10, 10);
            grpPendientes.Size = new Size(960, 478);
            grpPendientes.TabIndex = 0;
            grpPendientes.TabStop = false;
            grpPendientes.Text = "Reportes disponibles para entrega";
            // 
            // dgvPendientes
            // 
            dgvPendientes.AllowUserToAddRows = false;
            dgvPendientes.AllowUserToDeleteRows = false;
            dgvPendientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientes.BackgroundColor = Color.White;
            dgvPendientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPendientes.ColumnHeadersHeight = 34;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendientes.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colFechaDeAutorizacion, colDiasSinRecoger });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPendientes.DefaultCellStyle = dataGridViewCellStyle4;
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
            dgvPendientes.Size = new Size(940, 442);
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
            // colFechaDeAutorizacion
            // 
            colFechaDeAutorizacion.HeaderText = "Fecha de autorización";
            colFechaDeAutorizacion.Name = "colFechaDeAutorizacion";
            colFechaDeAutorizacion.ReadOnly = true;
            // 
            // colDiasSinRecoger
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDiasSinRecoger.DefaultCellStyle = dataGridViewCellStyle3;
            colDiasSinRecoger.HeaderText = "Días sin recoger";
            colDiasSinRecoger.Name = "colDiasSinRecoger";
            colDiasSinRecoger.ReadOnly = true;
            // 
            // FrmPendientesEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new Size(1000, 620);
            Controls.Add(grpPendientes);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPendientesEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes pendientes de entrega";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnActualizar;
        private GroupBox grpPendientes;
        private DataGridView dgvPendientes;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colFechaDeAutorizacion;
        private DataGridViewTextBoxColumn colDiasSinRecoger;
    }
}
