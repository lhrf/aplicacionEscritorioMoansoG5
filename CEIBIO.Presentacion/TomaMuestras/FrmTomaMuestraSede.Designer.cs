namespace CEIBIO.Presentacion.TomaMuestras
{
    partial class FrmTomaMuestraSede
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
            btnRechazo = new Button();
            btnImprimirEtiquetas = new Button();
            btnIniciar = new Button();
            grpAtencion = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            txtBox = new TextBox();
            lblBox = new Label();
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            txtNumeroAtencion = new TextBox();
            lblNumeroAtencion = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            colExamen = new DataGridViewTextBoxColumn();
            colTuboRecipiente = new DataGridViewTextBoxColumn();
            colColorDeTapa = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            flpBotones.SuspendLayout();
            grpAtencion.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
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
            lblTitulo.Size = new Size(319, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registrar toma de muestra en sede";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnValidar);
            flpBotones.Controls.Add(btnRechazo);
            flpBotones.Controls.Add(btnImprimirEtiquetas);
            flpBotones.Controls.Add(btnIniciar);
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
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(11, 61, 110);
            btnValidar.Cursor = Cursors.Hand;
            btnValidar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnValidar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(640, 15);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(185, 36);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "Validar recolección";
            btnValidar.UseVisualStyleBackColor = false;
            // 
            // btnRechazo
            // 
            btnRechazo.BackColor = Color.FromArgb(180, 35, 24);
            btnRechazo.Cursor = Cursors.Hand;
            btnRechazo.FlatAppearance.BorderSize = 0;
            btnRechazo.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnRechazo.FlatStyle = FlatStyle.Flat;
            btnRechazo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRechazo.ForeColor = Color.White;
            btnRechazo.Location = new Point(465, 15);
            btnRechazo.Name = "btnRechazo";
            btnRechazo.Size = new Size(169, 36);
            btnRechazo.TabIndex = 6;
            btnRechazo.Text = "Registrar rechazo";
            btnRechazo.UseVisualStyleBackColor = false;
            // 
            // btnImprimirEtiquetas
            // 
            btnImprimirEtiquetas.BackColor = Color.White;
            btnImprimirEtiquetas.Cursor = Cursors.Hand;
            btnImprimirEtiquetas.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnImprimirEtiquetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnImprimirEtiquetas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimirEtiquetas.ForeColor = Color.FromArgb(11, 61, 110);
            btnImprimirEtiquetas.Location = new Point(282, 15);
            btnImprimirEtiquetas.Name = "btnImprimirEtiquetas";
            btnImprimirEtiquetas.Size = new Size(177, 36);
            btnImprimirEtiquetas.TabIndex = 7;
            btnImprimirEtiquetas.Text = "Imprimir etiquetas";
            btnImprimirEtiquetas.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.White;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.FromArgb(11, 61, 110);
            btnIniciar.Location = new Point(146, 15);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(130, 36);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "Iniciar toma";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // grpAtencion
            // 
            grpAtencion.BackColor = Color.White;
            grpAtencion.Controls.Add(textBox1);
            grpAtencion.Controls.Add(label1);
            grpAtencion.Controls.Add(txtBox);
            grpAtencion.Controls.Add(lblBox);
            grpAtencion.Controls.Add(txtPaciente);
            grpAtencion.Controls.Add(lblPaciente);
            grpAtencion.Controls.Add(txtNumeroAtencion);
            grpAtencion.Controls.Add(lblNumeroAtencion);
            grpAtencion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAtencion.ForeColor = Color.FromArgb(11, 61, 110);
            grpAtencion.Location = new Point(20, 62);
            grpAtencion.Name = "grpAtencion";
            grpAtencion.Size = new Size(960, 124);
            grpAtencion.TabIndex = 9;
            grpAtencion.TabStop = false;
            grpAtencion.Text = "Atención";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(233, 238, 243);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(31, 35, 40);
            textBox1.Location = new Point(633, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 25);
            textBox1.TabIndex = 10;
            textBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(31, 35, 40);
            label1.Location = new Point(470, 67);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 10;
            label1.Text = "Código correlativo";
            // 
            // txtBox
            // 
            txtBox.BackColor = Color.FromArgb(233, 238, 243);
            txtBox.BorderStyle = BorderStyle.FixedSingle;
            txtBox.ForeColor = Color.FromArgb(31, 35, 40);
            txtBox.Location = new Point(633, 15);
            txtBox.Name = "txtBox";
            txtBox.ReadOnly = true;
            txtBox.Size = new Size(80, 25);
            txtBox.TabIndex = 10;
            txtBox.TabStop = false;
            // 
            // lblBox
            // 
            lblBox.AutoSize = true;
            lblBox.BackColor = Color.Transparent;
            lblBox.ForeColor = Color.FromArgb(31, 35, 40);
            lblBox.Location = new Point(510, 21);
            lblBox.Name = "lblBox";
            lblBox.Size = new Size(35, 19);
            lblBox.TabIndex = 10;
            lblBox.Text = "Box";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(132, 67);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(300, 25);
            txtPaciente.TabIndex = 10;
            txtPaciente.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(20, 67);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(66, 19);
            lblPaciente.TabIndex = 10;
            lblPaciente.Text = "Paciente";
            // 
            // txtNumeroAtencion
            // 
            txtNumeroAtencion.BackColor = Color.FromArgb(233, 238, 243);
            txtNumeroAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtNumeroAtencion.Location = new Point(146, 31);
            txtNumeroAtencion.Name = "txtNumeroAtencion";
            txtNumeroAtencion.ReadOnly = true;
            txtNumeroAtencion.Size = new Size(120, 25);
            txtNumeroAtencion.TabIndex = 10;
            txtNumeroAtencion.TabStop = false;
            // 
            // lblNumeroAtencion
            // 
            lblNumeroAtencion.AutoSize = true;
            lblNumeroAtencion.BackColor = Color.Transparent;
            lblNumeroAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            lblNumeroAtencion.Location = new Point(6, 33);
            lblNumeroAtencion.Name = "lblNumeroAtencion";
            lblNumeroAtencion.Size = new Size(111, 19);
            lblNumeroAtencion.TabIndex = 10;
            lblNumeroAtencion.Text = "N.° de atención";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(11, 61, 110);
            groupBox1.Location = new Point(20, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 8, 10, 10);
            groupBox1.Size = new Size(960, 349);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tubos y recipientes requeridos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colExamen, colTuboRecipiente, colColorDeTapa, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(208, 215, 222);
            dataGridView1.Location = new Point(10, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(940, 313);
            dataGridView1.TabIndex = 0;
            // 
            // colExamen
            // 
            colExamen.HeaderText = "Examen";
            colExamen.Name = "colExamen";
            colExamen.ReadOnly = true;
            // 
            // colTuboRecipiente
            // 
            colTuboRecipiente.HeaderText = "Tubo / recipiente";
            colTuboRecipiente.Name = "colTuboRecipiente";
            colTuboRecipiente.ReadOnly = true;
            // 
            // colColorDeTapa
            // 
            colColorDeTapa.HeaderText = "Color de tapa";
            colColorDeTapa.Name = "colColorDeTapa";
            colColorDeTapa.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(20, 469);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(960, 76);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recolección";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(31, 35, 40);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(160, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(31, 35, 40);
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 1;
            label2.Text = "Hora de extracción *";
            // 
            // FrmTomaMuestraSede
            // 
            AcceptButton = btnValidar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 61, 110);
            CancelButton = btnCerrar;
            ClientSize = new Size(984, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpAtencion);
            Controls.Add(flpBotones);
            Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTomaMuestraSede";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar toma de muestra en sede";
            flpBotones.ResumeLayout(false);
            grpAtencion.ResumeLayout(false);
            grpAtencion.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnValidar;
        private Button btnRechazo;
        private Button btnImprimirEtiquetas;
        private Button btnIniciar;
        private GroupBox grpAtencion;
        private Label lblNumeroAtencion;
        private TextBox txtNumeroAtencion;
        private Label lblPaciente;
        private TextBox txtPaciente;
        private Label lblBox;
        private Label label1;
        private TextBox txtBox;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colExamen;
        private DataGridViewTextBoxColumn colTuboRecipiente;
        private DataGridViewTextBoxColumn colColorDeTapa;
        private DataGridViewTextBoxColumn colEstado;
        private GroupBox groupBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}
