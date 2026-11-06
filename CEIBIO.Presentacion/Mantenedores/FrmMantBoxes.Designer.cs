namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantBoxes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            grpRegistros = new GroupBox();
            dataGridView1 = new DataGridView();
            grpBusqueda = new GroupBox();
            button3 = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            grpDatos = new GroupBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            cancelar = new Button();
            guardar = new Button();
            btnInhabilitar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            colNumero = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpBusqueda.SuspendLayout();
            grpDatos.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(333, 25);
            label1.TabIndex = 1;
            label1.Text = "Mantenedor de boxes de extracción";
            // 
            // grpRegistros
            // 
            grpRegistros.BackColor = Color.White;
            grpRegistros.Controls.Add(dataGridView1);
            grpRegistros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegistros.ForeColor = Color.FromArgb(11, 61, 110);
            grpRegistros.Location = new Point(12, 171);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Padding = new Padding(10, 8, 10, 10);
            grpRegistros.Size = new Size(960, 239);
            grpRegistros.TabIndex = 6;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNumero, colDescripcion, colEstado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 246, 250);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(11, 61, 110);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(207, 226, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(31, 35, 40);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(940, 203);
            dataGridView1.TabIndex = 0;
            // 
            // grpBusqueda
            // 
            grpBusqueda.Controls.Add(button3);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBusqueda.ForeColor = Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new Point(12, 74);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(960, 78);
            grpBusqueda.TabIndex = 5;
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
            // grpDatos
            // 
            grpDatos.BackColor = Color.White;
            grpDatos.Controls.Add(flowLayoutPanel1);
            grpDatos.Controls.Add(textBox2);
            grpDatos.Controls.Add(textBox1);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label3);
            grpDatos.Location = new Point(12, 416);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(960, 153);
            grpDatos.TabIndex = 7;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
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
            label7.Location = new Point(480, 42);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 5;
            label7.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(31, 35, 40);
            label3.Location = new Point(25, 40);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 1;
            label3.Text = "Número";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(31, 35, 40);
            textBox2.Location = new Point(579, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 25);
            textBox2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(cancelar);
            flowLayoutPanel1.Controls.Add(guardar);
            flowLayoutPanel1.Controls.Add(btnInhabilitar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnNuevo);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 90);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 12, 10, 12);
            flowLayoutPanel1.Size = new Size(954, 60);
            flowLayoutPanel1.TabIndex = 10;
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
            button1.Location = new Point(801, 15);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 4;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // cancelar
            // 
            cancelar.BackColor = Color.FromArgb(229, 231, 235);
            cancelar.Cursor = Cursors.Hand;
            cancelar.FlatAppearance.BorderSize = 0;
            cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            cancelar.FlatStyle = FlatStyle.Flat;
            cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cancelar.ForeColor = Color.FromArgb(31, 35, 40);
            cancelar.Location = new Point(665, 15);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(130, 36);
            cancelar.TabIndex = 5;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = false;
            // 
            // guardar
            // 
            guardar.BackColor = Color.FromArgb(11, 61, 110);
            guardar.Cursor = Cursors.Hand;
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guardar.ForeColor = Color.White;
            guardar.Location = new Point(529, 15);
            guardar.Name = "guardar";
            guardar.Size = new Size(130, 36);
            guardar.TabIndex = 4;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = false;
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
            btnInhabilitar.Location = new Point(393, 15);
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
            btnEditar.Location = new Point(257, 15);
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
            btnNuevo.Location = new Point(121, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 36);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Número";
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmMantBoxes
            // 
            AcceptButton = guardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = cancelar;
            ClientSize = new Size(984, 581);
            Controls.Add(grpDatos);
            Controls.Add(grpBusqueda);
            Controls.Add(grpRegistros);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMantBoxes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenedor de boxes de extracción";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox grpRegistros;
        private DataGridView dataGridView1;
        private GroupBox grpBusqueda;
        private Button button3;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private GroupBox grpDatos;
        private TextBox textBox1;
        private Label label7;
        private Label label3;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colEstado;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button cancelar;
        private Button guardar;
        private Button btnInhabilitar;
        private Button btnEditar;
        private Button btnNuevo;
    }
}
