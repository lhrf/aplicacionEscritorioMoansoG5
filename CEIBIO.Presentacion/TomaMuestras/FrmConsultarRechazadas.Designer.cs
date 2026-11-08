namespace CEIBIO.Presentacion.TomaMuestras
{
    partial class FrmConsultarRechazadas
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
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colExamen = new DataGridViewTextBoxColumn();
            colMotivo = new DataGridViewTextBoxColumn();
            colTecnico = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 61, 110);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(285, 25);
            label1.TabIndex = 1;
            label1.Text = "Consultar muestras rechazadas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 551);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 12, 10, 12);
            flowLayoutPanel1.Size = new Size(984, 60);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
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
            button1.TabIndex = 3;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(11, 61, 110);
            groupBox1.Location = new Point(20, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 80);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(844, 30);
            button2.Name = "button2";
            button2.Size = new Size(110, 34);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.FromArgb(31, 35, 40);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(632, 33);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 25);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(31, 35, 40);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(173, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(31, 35, 40);
            label4.Location = new Point(533, 39);
            label4.Name = "label4";
            label4.Size = new Size(80, 19);
            label4.TabIndex = 7;
            label4.Text = "Fecha final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(31, 35, 40);
            label3.Location = new Point(45, 33);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 5;
            label3.Text = "Fecha inicial";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(11, 61, 110);
            groupBox2.Location = new Point(20, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 8, 10, 10);
            groupBox2.Size = new Size(960, 418);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Muestras rechazadas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 246, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colFecha, colPaciente, colExamen, colMotivo, colTecnico });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            dataGridView1.Size = new Size(940, 382);
            dataGridView1.TabIndex = 0;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colExamen
            // 
            colExamen.HeaderText = "Examen";
            colExamen.Name = "colExamen";
            colExamen.ReadOnly = true;
            // 
            // colMotivo
            // 
            colMotivo.HeaderText = "Motivo";
            colMotivo.Name = "colMotivo";
            colMotivo.ReadOnly = true;
            // 
            // colTecnico
            // 
            colTecnico.HeaderText = "Técnico";
            colTecnico.Name = "colTecnico";
            colTecnico.ReadOnly = true;
            // 
            // FrmConsultarRechazadas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(495, 35);
            MaximizeBox = false;
            Name = "FrmConsultarRechazadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar muestras rechazadas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colExamen;
        private DataGridViewTextBoxColumn colMotivo;
        private DataGridViewTextBoxColumn colTecnico;
    }
}
