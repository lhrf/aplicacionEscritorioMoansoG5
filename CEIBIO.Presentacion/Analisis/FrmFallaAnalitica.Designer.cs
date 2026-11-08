namespace CEIBIO.Presentacion.Analisis
{
    partial class FrmFallaAnalitica
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
            btnRegistrar = new Button();
            grpFallaAnalitica = new GroupBox();
            lblEquipo = new Label();
            txtEquipo = new TextBox();
            lblMuestra = new Label();
            txtMuestra = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFallaAnalitica.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(11, 61, 110);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(520, 46);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar falla analítica";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnRegistrar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 300);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(520, 60);
            flpBotones.TabIndex = 2;
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
            btnCancelar.Location = new Point(367, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(180, 35, 24);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.FromArgb(255, 255, 255);
            btnRegistrar.Location = new Point(208, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(153, 36);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar falla";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // grpFallaAnalitica
            // 
            grpFallaAnalitica.BackColor = Color.FromArgb(255, 255, 255);
            grpFallaAnalitica.Controls.Add(lblEquipo);
            grpFallaAnalitica.Controls.Add(txtEquipo);
            grpFallaAnalitica.Controls.Add(lblMuestra);
            grpFallaAnalitica.Controls.Add(txtMuestra);
            grpFallaAnalitica.Controls.Add(lblDescripcion);
            grpFallaAnalitica.Controls.Add(txtDescripcion);
            grpFallaAnalitica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFallaAnalitica.ForeColor = Color.FromArgb(11, 61, 110);
            grpFallaAnalitica.Location = new Point(20, 60);
            grpFallaAnalitica.Name = "grpFallaAnalitica";
            grpFallaAnalitica.Size = new Size(480, 188);
            grpFallaAnalitica.TabIndex = 1;
            grpFallaAnalitica.TabStop = false;
            grpFallaAnalitica.Text = "Falla analítica";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.BackColor = Color.Transparent;
            lblEquipo.Font = new Font("Segoe UI", 10F);
            lblEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            lblEquipo.Location = new Point(15, 35);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(51, 19);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // txtEquipo
            // 
            txtEquipo.BackColor = Color.FromArgb(233, 238, 243);
            txtEquipo.BorderStyle = BorderStyle.FixedSingle;
            txtEquipo.Font = new Font("Segoe UI", 10F);
            txtEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            txtEquipo.Location = new Point(232, 32);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.ReadOnly = true;
            txtEquipo.Size = new Size(233, 25);
            txtEquipo.TabIndex = 1;
            txtEquipo.TabStop = false;
            // 
            // lblMuestra
            // 
            lblMuestra.AutoSize = true;
            lblMuestra.BackColor = Color.Transparent;
            lblMuestra.Font = new Font("Segoe UI", 10F);
            lblMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            lblMuestra.Location = new Point(15, 73);
            lblMuestra.Name = "lblMuestra";
            lblMuestra.Size = new Size(60, 19);
            lblMuestra.TabIndex = 2;
            lblMuestra.Text = "Muestra";
            // 
            // txtMuestra
            // 
            txtMuestra.BackColor = Color.FromArgb(233, 238, 243);
            txtMuestra.BorderStyle = BorderStyle.FixedSingle;
            txtMuestra.Font = new Font("Segoe UI", 10F);
            txtMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            txtMuestra.Location = new Point(232, 70);
            txtMuestra.Name = "txtMuestra";
            txtMuestra.ReadOnly = true;
            txtMuestra.Size = new Size(150, 25);
            txtMuestra.TabIndex = 3;
            txtMuestra.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(31, 35, 40);
            lblDescripcion.Location = new Point(15, 111);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(150, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción de la falla *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 255, 255);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(31, 35, 40);
            txtDescripcion.Location = new Point(232, 108);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(233, 60);
            txtDescripcion.TabIndex = 5;
            // 
            // FrmFallaAnalitica
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new Size(520, 360);
            Controls.Add(grpFallaAnalitica);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFallaAnalitica";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar falla analítica";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpFallaAnalitica.ResumeLayout(false);
            grpFallaAnalitica.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpFallaAnalitica;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lblMuestra;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}
