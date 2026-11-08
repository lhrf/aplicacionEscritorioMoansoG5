namespace CEIBIO.Presentacion.Analisis
{
    partial class FrmRegistrarResultados
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            fontDialog1 = new FontDialog();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            btnCerrar = new Button();
            flpBotones = new FlowLayoutPanel();
            btnEnviar = new Button();
            btnGuardar = new Button();
            grpMuestra = new GroupBox();
            txtProcedimiento = new TextBox();
            lblProcedimiento = new Label();
            cboExamen = new ComboBox();
            lblExamen = new Label();
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpParametros = new GroupBox();
            dgvParametros = new DataGridView();
            colParametro = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            grpObservacionesMicroscopicas = new GroupBox();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            flpBotones.SuspendLayout();
            grpMuestra.SuspendLayout();
            grpParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParametros).BeginInit();
            grpObservacionesMicroscopicas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(984, 56);
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
            lblTitulo.Size = new Size(277, 25);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Registrar resultados analíticos";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(229, 231, 235);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(831, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnEnviar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 551);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(984, 60);
            flpBotones.TabIndex = 5;
            flpBotones.WrapContents = false;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(11, 61, 110);
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnEnviar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(640, 15);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(185, 36);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar a validación";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(11, 61, 110);
            btnGuardar.Location = new Point(504, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grpMuestra
            // 
            grpMuestra.BackColor = Color.White;
            grpMuestra.Controls.Add(txtProcedimiento);
            grpMuestra.Controls.Add(lblProcedimiento);
            grpMuestra.Controls.Add(cboExamen);
            grpMuestra.Controls.Add(lblExamen);
            grpMuestra.Controls.Add(txtPaciente);
            grpMuestra.Controls.Add(lblPaciente);
            grpMuestra.Controls.Add(btnBuscar);
            grpMuestra.Controls.Add(txtCodigo);
            grpMuestra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMuestra.ForeColor = Color.FromArgb(11, 61, 110);
            grpMuestra.Location = new Point(20, 70);
            grpMuestra.Name = "grpMuestra";
            grpMuestra.Size = new Size(960, 116);
            grpMuestra.TabIndex = 6;
            grpMuestra.TabStop = false;
            grpMuestra.Text = "Muestra";
            // 
            // txtProcedimiento
            // 
            txtProcedimiento.BackColor = Color.FromArgb(233, 238, 243);
            txtProcedimiento.BorderStyle = BorderStyle.FixedSingle;
            txtProcedimiento.ForeColor = Color.FromArgb(31, 35, 40);
            txtProcedimiento.Location = new Point(620, 75);
            txtProcedimiento.Name = "txtProcedimiento";
            txtProcedimiento.ReadOnly = true;
            txtProcedimiento.Size = new Size(180, 25);
            txtProcedimiento.TabIndex = 9;
            txtProcedimiento.TabStop = false;
            // 
            // lblProcedimiento
            // 
            lblProcedimiento.AutoSize = true;
            lblProcedimiento.BackColor = Color.Transparent;
            lblProcedimiento.ForeColor = Color.FromArgb(31, 35, 40);
            lblProcedimiento.Location = new Point(497, 78);
            lblProcedimiento.Name = "lblProcedimiento";
            lblProcedimiento.Size = new Size(108, 19);
            lblProcedimiento.TabIndex = 8;
            lblProcedimiento.Text = "Procedimiento";
            // 
            // cboExamen
            // 
            cboExamen.BackColor = Color.White;
            cboExamen.FlatStyle = FlatStyle.Flat;
            cboExamen.ForeColor = Color.FromArgb(31, 35, 40);
            cboExamen.FormattingEnabled = true;
            cboExamen.IntegralHeight = false;
            cboExamen.Location = new Point(620, 34);
            cboExamen.Name = "cboExamen";
            cboExamen.Size = new Size(260, 25);
            cboExamen.TabIndex = 8;
            // 
            // lblExamen
            // 
            lblExamen.AutoSize = true;
            lblExamen.BackColor = Color.Transparent;
            lblExamen.ForeColor = Color.FromArgb(31, 35, 40);
            lblExamen.Location = new Point(544, 37);
            lblExamen.Name = "lblExamen";
            lblExamen.Size = new Size(61, 19);
            lblExamen.TabIndex = 9;
            lblExamen.Text = "Examen";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.Location = new Point(164, 72);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(283, 25);
            txtPaciente.TabIndex = 8;
            txtPaciente.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(30, 78);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(66, 19);
            lblPaciente.TabIndex = 8;
            lblPaciente.Text = "Paciente";
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.Location = new Point(342, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            txtCodigo.Location = new Point(164, 24);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 25);
            txtCodigo.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // grpParametros
            // 
            grpParametros.BackColor = Color.White;
            grpParametros.Controls.Add(dgvParametros);
            grpParametros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpParametros.ForeColor = Color.FromArgb(11, 61, 110);
            grpParametros.Location = new Point(20, 196);
            grpParametros.Name = "grpParametros";
            grpParametros.Padding = new Padding(10, 8, 10, 10);
            grpParametros.Size = new Size(960, 262);
            grpParametros.TabIndex = 9;
            grpParametros.TabStop = false;
            grpParametros.Text = "Resultados por parámetro";
            // 
            // dgvParametros
            // 
            dgvParametros.AllowUserToAddRows = false;
            dgvParametros.AllowUserToDeleteRows = false;
            dgvParametros.AllowUserToOrderColumns = true;
            dgvParametros.AllowUserToResizeColumns = false;
            dgvParametros.BackgroundColor = Color.White;
            dgvParametros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvParametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvParametros.ColumnHeadersHeight = 34;
            dgvParametros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvParametros.Columns.AddRange(new DataGridViewColumn[] { colParametro, colValor, colUnidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvParametros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvParametros.Dock = DockStyle.Fill;
            dgvParametros.EnableHeadersVisualStyles = false;
            dgvParametros.GridColor = Color.FromArgb(208, 215, 222);
            dgvParametros.Location = new Point(10, 26);
            dgvParametros.MultiSelect = false;
            dgvParametros.Name = "dgvParametros";
            dgvParametros.RowHeadersVisible = false;
            dgvParametros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvParametros.Size = new Size(940, 226);
            dgvParametros.TabIndex = 0;
            // 
            // colParametro
            // 
            colParametro.HeaderText = "Parámetro";
            colParametro.Name = "colParametro";
            colParametro.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.Name = "colValor";
            // 
            // colUnidad
            // 
            colUnidad.HeaderText = "Unidad";
            colUnidad.Name = "colUnidad";
            colUnidad.ReadOnly = true;
            // 
            // grpObservacionesMicroscopicas
            // 
            grpObservacionesMicroscopicas.BackColor = Color.White;
            grpObservacionesMicroscopicas.Controls.Add(txtObservaciones);
            grpObservacionesMicroscopicas.Controls.Add(lblObservaciones);
            grpObservacionesMicroscopicas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpObservacionesMicroscopicas.ForeColor = Color.FromArgb(11, 61, 110);
            grpObservacionesMicroscopicas.Location = new Point(20, 464);
            grpObservacionesMicroscopicas.Name = "grpObservacionesMicroscopicas";
            grpObservacionesMicroscopicas.Size = new Size(960, 81);
            grpObservacionesMicroscopicas.TabIndex = 1;
            grpObservacionesMicroscopicas.TabStop = false;
            grpObservacionesMicroscopicas.Text = "Observaciones microscópicas";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.White;
            txtObservaciones.BorderStyle = BorderStyle.FixedSingle;
            txtObservaciones.ForeColor = Color.FromArgb(31, 35, 40);
            txtObservaciones.Location = new Point(133, 24);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(600, 51);
            txtObservaciones.TabIndex = 2;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.BackColor = Color.Transparent;
            lblObservaciones.ForeColor = Color.FromArgb(31, 35, 40);
            lblObservaciones.Location = new Point(6, 32);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(108, 19);
            lblObservaciones.TabIndex = 1;
            lblObservaciones.Text = "Observaciones";
            // 
            // FrmRegistrarResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 611);
            Controls.Add(grpObservacionesMicroscopicas);
            Controls.Add(grpParametros);
            Controls.Add(grpMuestra);
            Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);
            Controls.Add(flpBotones);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarResultados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar resultados analíticos";
            flpBotones.ResumeLayout(false);
            grpMuestra.ResumeLayout(false);
            grpMuestra.PerformLayout();
            grpParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParametros).EndInit();
            grpObservacionesMicroscopicas.ResumeLayout(false);
            grpObservacionesMicroscopicas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontDialog fontDialog1;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Button btnCerrar;
        private FlowLayoutPanel flpBotones;
        private Button btnEnviar;
        private Button btnGuardar;
        private GroupBox grpMuestra;
        private TextBox txtCodigo;
        private Button btnBuscar;
        private Label lblPaciente;
        private Label lblExamen;
        private TextBox txtPaciente;
        private ComboBox cboExamen;
        private TextBox txtProcedimiento;
        private Label lblProcedimiento;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpParametros;
        private DataGridView dgvParametros;
        private DataGridViewTextBoxColumn colParametro;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colUnidad;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox grpObservacionesMicroscopicas;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
    }
}
