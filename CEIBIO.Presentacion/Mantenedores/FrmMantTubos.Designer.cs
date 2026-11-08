namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantTubos
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
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            btnInhabilitar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            grpBusqueda = new GroupBox();
            button3 = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            grpRegistros = new GroupBox();
            dataGridView1 = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colColorDeTapa = new DataGridViewTextBoxColumn();
            colAditivo = new DataGridViewTextBoxColumn();
            colCentrifugacionMin = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            grpDatos = new GroupBox();
            clbExamenes = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(322, 25);
            label1.TabIndex = 1;
            label1.Text = "Mantenedor de tubos y recipientes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(btnInhabilitar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnNuevo);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 561);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 12, 10, 12);
            flowLayoutPanel1.Size = new Size(984, 60);
            flowLayoutPanel1.TabIndex = 3;
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
            button1.TabIndex = 4;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 231, 235);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(31, 35, 40);
            button2.Location = new Point(695, 15);
            button2.Name = "button2";
            button2.Size = new Size(130, 36);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(11, 61, 110);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(559, 15);
            button4.Name = "button4";
            button4.Size = new Size(130, 36);
            button4.TabIndex = 4;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.BackColor = Color.FromArgb(180, 35, 24);
            btnInhabilitar.Cursor = Cursors.Hand;
            btnInhabilitar.FlatAppearance.BorderSize = 0;
            btnInhabilitar.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnInhabilitar.FlatStyle = FlatStyle.Flat;
            btnInhabilitar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(423, 15);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(130, 36);
            btnInhabilitar.TabIndex = 4;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(11, 61, 110);
            btnEditar.Location = new Point(287, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.White;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.FromArgb(11, 61, 110);
            btnNuevo.Location = new Point(151, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 36);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.Controls.Add(button3);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBusqueda.ForeColor = Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new Point(20, 74);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(960, 78);
            grpBusqueda.TabIndex = 4;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(11, 61, 110);
            button3.Location = new Point(423, 24);
            button3.Name = "button3";
            button3.Size = new Size(110, 34);
            button3.TabIndex = 5;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.FromArgb(31, 35, 40);
            txtBuscar.Location = new Point(97, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(300, 25);
            txtBuscar.TabIndex = 5;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.ForeColor = Color.FromArgb(31, 35, 40);
            lblBuscar.Location = new Point(24, 31);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(53, 19);
            lblBuscar.TabIndex = 5;
            lblBuscar.Text = "Buscar";
            // 
            // grpRegistros
            // 
            grpRegistros.BackColor = Color.White;
            grpRegistros.Controls.Add(dataGridView1);
            grpRegistros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegistros.ForeColor = Color.FromArgb(11, 61, 110);
            grpRegistros.Location = new Point(20, 158);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Padding = new Padding(10, 8, 10, 10);
            grpRegistros.Size = new Size(960, 238);
            grpRegistros.TabIndex = 5;
            grpRegistros.TabStop = false;
            grpRegistros.Text = "Registros";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTipo, colColorDeTapa, colAditivo, colCentrifugacionMin, colEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(940, 202);
            dataGridView1.TabIndex = 0;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colColorDeTapa
            // 
            colColorDeTapa.HeaderText = "Color de tapa";
            colColorDeTapa.Name = "colColorDeTapa";
            colColorDeTapa.ReadOnly = true;
            // 
            // colAditivo
            // 
            colAditivo.HeaderText = "Aditivo";
            colAditivo.Name = "colAditivo";
            colAditivo.ReadOnly = true;
            // 
            // colCentrifugacionMin
            // 
            colCentrifugacionMin.HeaderText = "Centrifugación (min)";
            colCentrifugacionMin.Name = "colCentrifugacionMin";
            colCentrifugacionMin.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.White;
            grpDatos.Controls.Add(clbExamenes);
            grpDatos.Controls.Add(numericUpDown1);
            grpDatos.Controls.Add(textBox3);
            grpDatos.Controls.Add(textBox2);
            grpDatos.Controls.Add(textBox1);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label3);
            grpDatos.Location = new Point(12, 402);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(960, 153);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // clbExamenes
            // 
            clbExamenes.BackColor = Color.White;
            clbExamenes.BorderStyle = BorderStyle.FixedSingle;
            clbExamenes.CheckOnClick = true;
            clbExamenes.ForeColor = Color.FromArgb(31, 35, 40);
            clbExamenes.FormattingEnabled = true;
            clbExamenes.Location = new Point(619, 82);
            clbExamenes.Name = "clbExamenes";
            clbExamenes.Size = new Size(181, 62);
            clbExamenes.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.ForeColor = Color.FromArgb(31, 35, 40);
            numericUpDown1.Location = new Point(619, 40);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = Color.FromArgb(31, 35, 40);
            textBox3.Location = new Point(168, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 25);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(31, 35, 40);
            textBox2.Location = new Point(168, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 25);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(31, 35, 40);
            textBox1.Location = new Point(168, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 25);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(31, 35, 40);
            label7.Location = new Point(438, 40);
            label7.Name = "label7";
            label7.Size = new Size(133, 19);
            label7.TabIndex = 5;
            label7.Text = "Centrifugación (min)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(31, 35, 40);
            label6.Location = new Point(18, 119);
            label6.Name = "label6";
            label6.Size = new Size(52, 19);
            label6.TabIndex = 4;
            label6.Text = "Aditivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(31, 35, 40);
            label5.Location = new Point(18, 82);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 3;
            label5.Text = "Color de Tapa*";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(31, 35, 40);
            label4.Location = new Point(438, 82);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 2;
            label4.Text = "Exámenes asociados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(31, 35, 40);
            label3.Location = new Point(25, 40);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 1;
            label3.Text = "Tipo *";
            label3.Click += label3_Click;
            // 
            // FrmMantTubos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 621);
            Controls.Add(grpDatos);
            Controls.Add(grpRegistros);
            Controls.Add(grpBusqueda);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMantTubos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenedor de tubos y recipientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button btnInhabilitar;
        private Button btnEditar;
        private Button btnNuevo;
        private GroupBox grpBusqueda;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button button3;
        private GroupBox grpRegistros;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colColorDeTapa;
        private DataGridViewTextBoxColumn colAditivo;
        private DataGridViewTextBoxColumn colCentrifugacionMin;
        private DataGridViewTextBoxColumn colEstado;
        private GroupBox grpDatos;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckedListBox clbExamenes;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
