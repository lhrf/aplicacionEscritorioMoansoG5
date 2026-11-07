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
            pnlEncabezado = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblCodigo = new System.Windows.Forms.Label();
            flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            btnCancelar = new System.Windows.Forms.Button();
            btnRegistrar = new System.Windows.Forms.Button();
            grpFallaAnalitica = new System.Windows.Forms.GroupBox();
            lblEquipo = new System.Windows.Forms.Label();
            txtEquipo = new System.Windows.Forms.TextBox();
            lblMuestra = new System.Windows.Forms.Label();
            txtMuestra = new System.Windows.Forms.TextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpFallaAnalitica.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlEncabezado.Controls.Add(lblCodigo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new System.Drawing.Size(520, 46);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            lblTitulo.Location = new System.Drawing.Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(196, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar falla analítica";
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = System.Drawing.Color.Transparent;
            lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            lblCodigo.ForeColor = System.Drawing.Color.FromArgb(191, 215, 238);
            lblCodigo.Location = new System.Drawing.Point(459, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(41, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "CU-42";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnRegistrar);
            flpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            flpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flpBotones.Location = new System.Drawing.Point(0, 300);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            flpBotones.Size = new System.Drawing.Size(520, 60);
            flpBotones.TabIndex = 2;
            flpBotones.WrapContents = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            btnCancelar.Location = new System.Drawing.Point(377, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(130, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.TabStop = true;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 28, 19);
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnRegistrar.Location = new System.Drawing.Point(218, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(153, 36);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.TabStop = true;
            btnRegistrar.Text = "Registrar falla";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // grpFallaAnalitica
            // 
            grpFallaAnalitica.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            grpFallaAnalitica.Controls.Add(lblEquipo);
            grpFallaAnalitica.Controls.Add(txtEquipo);
            grpFallaAnalitica.Controls.Add(lblMuestra);
            grpFallaAnalitica.Controls.Add(txtMuestra);
            grpFallaAnalitica.Controls.Add(lblDescripcion);
            grpFallaAnalitica.Controls.Add(txtDescripcion);
            grpFallaAnalitica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grpFallaAnalitica.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            grpFallaAnalitica.Location = new System.Drawing.Point(20, 60);
            grpFallaAnalitica.Name = "grpFallaAnalitica";
            grpFallaAnalitica.Size = new System.Drawing.Size(480, 188);
            grpFallaAnalitica.TabIndex = 1;
            grpFallaAnalitica.TabStop = false;
            grpFallaAnalitica.Text = "Falla analítica";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.BackColor = System.Drawing.Color.Transparent;
            lblEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblEquipo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblEquipo.Location = new System.Drawing.Point(15, 35);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new System.Drawing.Size(51, 19);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // txtEquipo
            // 
            txtEquipo.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtEquipo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtEquipo.Location = new System.Drawing.Point(232, 32);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.ReadOnly = true;
            txtEquipo.Size = new System.Drawing.Size(233, 25);
            txtEquipo.TabIndex = 1;
            txtEquipo.TabStop = false;
            // 
            // lblMuestra
            // 
            lblMuestra.AutoSize = true;
            lblMuestra.BackColor = System.Drawing.Color.Transparent;
            lblMuestra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblMuestra.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblMuestra.Location = new System.Drawing.Point(15, 73);
            lblMuestra.Name = "lblMuestra";
            lblMuestra.Size = new System.Drawing.Size(57, 19);
            lblMuestra.TabIndex = 2;
            lblMuestra.Text = "Muestra";
            // 
            // txtMuestra
            // 
            txtMuestra.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            txtMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMuestra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtMuestra.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtMuestra.Location = new System.Drawing.Point(232, 70);
            txtMuestra.Name = "txtMuestra";
            txtMuestra.ReadOnly = true;
            txtMuestra.Size = new System.Drawing.Size(150, 25);
            txtMuestra.TabIndex = 3;
            txtMuestra.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            lblDescripcion.Location = new System.Drawing.Point(15, 111);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(163, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción de la falla *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            txtDescripcion.Location = new System.Drawing.Point(232, 108);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescripcion.Size = new System.Drawing.Size(233, 60);
            txtDescripcion.TabIndex = 5;
            // 
            // FrmFallaAnalitica
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(520, 360);
            Controls.Add(grpFallaAnalitica);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            Name = "FrmFallaAnalitica";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label lblCodigo;
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
