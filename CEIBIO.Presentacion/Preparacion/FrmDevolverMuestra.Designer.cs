namespace CEIBIO.Presentacion.Preparacion
{
    partial class FrmDevolverMuestra
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            flpBotones = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnDevolver = new Button();
            grpDevolucion = new GroupBox();
            txtDiferencia = new TextBox();
            lblDiferencia = new Label();
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            flpBotones.SuspendLayout();
            grpDevolucion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(504, 46);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(265, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Devolver muestra con diferencias";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnDevolver);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 261);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(504, 60);
            flpBotones.TabIndex = 3;
            flpBotones.WrapContents = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new Point(351, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.FromArgb(180, 35, 24);
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(215, 15);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(130, 36);
            btnDevolver.TabIndex = 4;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = false;
            // 
            // grpDevolucion
            // 
            grpDevolucion.BackColor = Color.White;
            grpDevolucion.Controls.Add(txtDiferencia);
            grpDevolucion.Controls.Add(lblDiferencia);
            grpDevolucion.Controls.Add(txtPaciente);
            grpDevolucion.Controls.Add(lblPaciente);
            grpDevolucion.Controls.Add(txtCodigo);
            grpDevolucion.Controls.Add(lblCodigo);
            grpDevolucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDevolucion.ForeColor = Color.FromArgb(11, 61, 110);
            grpDevolucion.Location = new Point(20, 60);
            grpDevolucion.Name = "grpDevolucion";
            grpDevolucion.Size = new Size(480, 188);
            grpDevolucion.TabIndex = 4;
            grpDevolucion.TabStop = false;
            grpDevolucion.Text = "Devolución";
            // 
            // txtDiferencia
            // 
            txtDiferencia.BackColor = Color.White;
            txtDiferencia.BorderStyle = BorderStyle.FixedSingle;
            txtDiferencia.Font = new Font("Segoe UI", 10F);
            txtDiferencia.ForeColor = Color.FromArgb(31, 35, 40);
            txtDiferencia.Location = new Point(215, 108);
            txtDiferencia.Multiline = true;
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.ScrollBars = ScrollBars.Vertical;
            txtDiferencia.Size = new Size(250, 60);
            txtDiferencia.TabIndex = 5;
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.BackColor = Color.Transparent;
            lblDiferencia.Font = new Font("Segoe UI", 10F);
            lblDiferencia.ForeColor = Color.FromArgb(31, 35, 40);
            lblDiferencia.Location = new Point(15, 111);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.Size = new Size(152, 19);
            lblDiferencia.TabIndex = 4;
            lblDiferencia.Text = "Diferencia encontrada *";
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(233, 238, 243);
            txtPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtPaciente.Font = new Font("Segoe UI", 10F);
            txtPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            txtPaciente.Location = new Point(215, 70);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.ReadOnly = true;
            txtPaciente.Size = new Size(250, 25);
            txtPaciente.TabIndex = 3;
            txtPaciente.TabStop = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.Transparent;
            lblPaciente.Font = new Font("Segoe UI", 10F);
            lblPaciente.ForeColor = Color.FromArgb(31, 35, 40);
            lblPaciente.Location = new Point(15, 73);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(60, 19);
            lblPaciente.TabIndex = 2;
            lblPaciente.Text = "Paciente";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(233, 238, 243);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            txtCodigo.Location = new Point(215, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(150, 25);
            txtCodigo.TabIndex = 1;
            txtCodigo.TabStop = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.ForeColor = Color.FromArgb(31, 35, 40);
            lblCodigo.Location = new Point(15, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(53, 19);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // FrmDevolverMuestra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(504, 321);
            Controls.Add(grpDevolucion);
            Controls.Add(flpBotones);
            Controls.Add(lblTitulo);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDevolverMuestra";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Devolver muestra con diferencias";
            flpBotones.ResumeLayout(false);
            grpDevolucion.ResumeLayout(false);
            grpDevolucion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnDevolver;
        private GroupBox grpDevolucion;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtDiferencia;
        private Label lblDiferencia;
    }
}
