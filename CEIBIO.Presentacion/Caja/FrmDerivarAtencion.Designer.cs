namespace CEIBIO.Presentacion.Caja
{
    partial class FrmDerivarAtencion
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
            btnDerivar = new Button();
            grpAtenciones = new GroupBox();
            dgvAtenciones = new DataGridView();
            colNAtencion = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colModalidad = new DataGridViewTextBoxColumn();
            colNComprobante = new DataGridViewTextBoxColumn();
            grpDerivacion = new GroupBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblTurno = new Label();
            txtTurno = new TextBox();
            lblTecnico = new Label();
            cboTecnico = new ComboBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpAtenciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).BeginInit();
            grpDerivacion.SuspendLayout();
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
            lblTitulo.Size = new Size(230, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Derivar atención pagada";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnDerivar);
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
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnDerivar
            // 
            btnDerivar.BackColor = Color.FromArgb(11, 61, 110);
            btnDerivar.Cursor = Cursors.Hand;
            btnDerivar.FlatAppearance.BorderSize = 0;
            btnDerivar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnDerivar.FlatStyle = FlatStyle.Flat;
            btnDerivar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDerivar.ForeColor = Color.White;
            btnDerivar.Location = new Point(607, 15);
            btnDerivar.Name = "btnDerivar";
            btnDerivar.Size = new Size(234, 36);
            btnDerivar.TabIndex = 1;
            btnDerivar.Text = "Derivar e imprimir ticket";
            btnDerivar.UseVisualStyleBackColor = false;
            // 
            // grpAtenciones
            // 
            grpAtenciones.BackColor = Color.White;
            grpAtenciones.Controls.Add(dgvAtenciones);
            grpAtenciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAtenciones.ForeColor = Color.FromArgb(11, 61, 110);
            grpAtenciones.Location = new Point(20, 70);
            grpAtenciones.Name = "grpAtenciones";
            grpAtenciones.Padding = new Padding(10, 8, 10, 10);
            grpAtenciones.Size = new Size(960, 384);
            grpAtenciones.TabIndex = 2;
            grpAtenciones.TabStop = false;
            grpAtenciones.Text = "Atenciones con comprobante emitido";
            // 
            // dgvAtenciones
            // 
            dgvAtenciones.AllowUserToAddRows = false;
            dgvAtenciones.AllowUserToDeleteRows = false;
            dgvAtenciones.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dgvAtenciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAtenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtenciones.BackgroundColor = Color.White;
            dgvAtenciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAtenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAtenciones.ColumnHeadersHeight = 34;
            dgvAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAtenciones.Columns.AddRange(new DataGridViewColumn[] { colNAtencion, colPaciente, colModalidad, colNComprobante });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAtenciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAtenciones.Dock = DockStyle.Fill;
            dgvAtenciones.EnableHeadersVisualStyles = false;
            dgvAtenciones.GridColor = Color.FromArgb(208, 215, 222);
            dgvAtenciones.Location = new Point(10, 26);
            dgvAtenciones.MultiSelect = false;
            dgvAtenciones.Name = "dgvAtenciones";
            dgvAtenciones.ReadOnly = true;
            dgvAtenciones.RowHeadersVisible = false;
            dgvAtenciones.RowTemplate.Height = 28;
            dgvAtenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtenciones.Size = new Size(940, 348);
            dgvAtenciones.TabIndex = 0;
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
            // colModalidad
            // 
            colModalidad.HeaderText = "Modalidad";
            colModalidad.Name = "colModalidad";
            colModalidad.ReadOnly = true;
            // 
            // colNComprobante
            // 
            colNComprobante.HeaderText = "N.° comprobante";
            colNComprobante.Name = "colNComprobante";
            colNComprobante.ReadOnly = true;
            // 
            // grpDerivacion
            // 
            grpDerivacion.BackColor = Color.White;
            grpDerivacion.Controls.Add(cboTecnico);
            grpDerivacion.Controls.Add(lblTecnico);
            grpDerivacion.Controls.Add(txtTurno);
            grpDerivacion.Controls.Add(lblTurno);
            grpDerivacion.Controls.Add(txtModalidad);
            grpDerivacion.Controls.Add(lblModalidad);
            grpDerivacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDerivacion.ForeColor = Color.FromArgb(11, 61, 110);
            grpDerivacion.Location = new Point(20, 464);
            grpDerivacion.Name = "grpDerivacion";
            grpDerivacion.Size = new Size(960, 116);
            grpDerivacion.TabIndex = 3;
            grpDerivacion.TabStop = false;
            grpDerivacion.Text = "Derivación";
            // 
            // lblModalidad
            // 
            lblModalidad.AutoSize = true;
            lblModalidad.BackColor = Color.Transparent;
            lblModalidad.ForeColor = Color.FromArgb(31, 35, 40);
            lblModalidad.Location = new Point(15, 35);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(74, 17);
            lblModalidad.TabIndex = 0;
            lblModalidad.Text = "Modalidad";
            // 
            // txtModalidad
            // 
            txtModalidad.BackColor = Color.FromArgb(233, 238, 243);
            txtModalidad.BorderStyle = BorderStyle.FixedSingle;
            txtModalidad.ForeColor = Color.FromArgb(31, 35, 40);
            txtModalidad.Location = new Point(125, 32);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.ReadOnly = true;
            txtModalidad.Size = new Size(150, 25);
            txtModalidad.TabIndex = 1;
            txtModalidad.TabStop = false;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.ForeColor = Color.FromArgb(31, 35, 40);
            lblTurno.Location = new Point(15, 73);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(84, 17);
            lblTurno.TabIndex = 2;
            lblTurno.Text = "N.° de turno";
            // 
            // txtTurno
            // 
            txtTurno.BackColor = Color.FromArgb(233, 238, 243);
            txtTurno.BorderStyle = BorderStyle.FixedSingle;
            txtTurno.ForeColor = Color.FromArgb(31, 35, 40);
            txtTurno.Location = new Point(125, 70);
            txtTurno.Name = "txtTurno";
            txtTurno.ReadOnly = true;
            txtTurno.Size = new Size(100, 25);
            txtTurno.TabIndex = 3;
            txtTurno.TabStop = false;
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.BackColor = Color.Transparent;
            lblTecnico.ForeColor = Color.FromArgb(31, 35, 40);
            lblTecnico.Location = new Point(495, 35);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(118, 17);
            lblTecnico.TabIndex = 4;
            lblTecnico.Text = "Técnico itinerante";
            // 
            // cboTecnico
            // 
            cboTecnico.BackColor = Color.White;
            cboTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTecnico.FlatStyle = FlatStyle.Flat;
            cboTecnico.ForeColor = Color.FromArgb(31, 35, 40);
            cboTecnico.FormattingEnabled = true;
            cboTecnico.Location = new Point(654, 32);
            cboTecnico.Name = "cboTecnico";
            cboTecnico.Size = new Size(260, 25);
            cboTecnico.TabIndex = 5;
            // 
            // FrmDerivarAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 650);
            Controls.Add(grpDerivacion);
            Controls.Add(grpAtenciones);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDerivarAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Derivar atención pagada";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpAtenciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).EndInit();
            grpDerivacion.ResumeLayout(false);
            grpDerivacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnDerivar;
        private GroupBox grpAtenciones;
        private DataGridView dgvAtenciones;
        private DataGridViewTextBoxColumn colNAtencion;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colModalidad;
        private DataGridViewTextBoxColumn colNComprobante;
        private GroupBox grpDerivacion;
        private TextBox txtTurno;
        private Label lblTurno;
        private TextBox txtModalidad;
        private Label lblModalidad;
        private ComboBox cboTecnico;
        private Label lblTecnico;
    }
}
