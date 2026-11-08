namespace CEIBIO.Presentacion.Seguridad
{
    partial class FrmCambiarClave
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
            btnGuardar = new Button();
            grpCambioDeClave = new GroupBox();
            lblClaveActual = new Label();
            txtClaveActual = new TextBox();
            lblClaveNueva = new Label();
            txtClaveNueva = new TextBox();
            lblClaveConfirmacion = new Label();
            txtClaveConfirmacion = new TextBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpCambioDeClave.SuspendLayout();
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
            pnlEncabezado.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cambiar clave de acceso";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCancelar);
            flpBotones.Controls.Add(btnGuardar);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 300);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(520, 60);
            flpBotones.TabIndex = 1;
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
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(11, 61, 110);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(231, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 36);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grpCambioDeClave
            // 
            grpCambioDeClave.BackColor = Color.White;
            grpCambioDeClave.Controls.Add(lblClaveActual);
            grpCambioDeClave.Controls.Add(txtClaveActual);
            grpCambioDeClave.Controls.Add(lblClaveNueva);
            grpCambioDeClave.Controls.Add(txtClaveNueva);
            grpCambioDeClave.Controls.Add(lblClaveConfirmacion);
            grpCambioDeClave.Controls.Add(txtClaveConfirmacion);
            grpCambioDeClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCambioDeClave.ForeColor = Color.FromArgb(11, 61, 110);
            grpCambioDeClave.Location = new Point(20, 60);
            grpCambioDeClave.Name = "grpCambioDeClave";
            grpCambioDeClave.Size = new Size(480, 154);
            grpCambioDeClave.TabIndex = 0;
            grpCambioDeClave.TabStop = false;
            grpCambioDeClave.Text = "Cambio de clave";
            // 
            // lblClaveActual
            // 
            lblClaveActual.AutoSize = true;
            lblClaveActual.BackColor = Color.Transparent;
            lblClaveActual.Font = new Font("Segoe UI", 10F);
            lblClaveActual.ForeColor = Color.FromArgb(31, 35, 40);
            lblClaveActual.Location = new Point(15, 35);
            lblClaveActual.Name = "lblClaveActual";
            lblClaveActual.Size = new Size(92, 19);
            lblClaveActual.TabIndex = 0;
            lblClaveActual.Text = "Clave actual *";
            // 
            // txtClaveActual
            // 
            txtClaveActual.BackColor = Color.White;
            txtClaveActual.BorderStyle = BorderStyle.FixedSingle;
            txtClaveActual.Font = new Font("Segoe UI", 10F);
            txtClaveActual.ForeColor = Color.FromArgb(31, 35, 40);
            txtClaveActual.Location = new Point(166, 32);
            txtClaveActual.Name = "txtClaveActual";
            txtClaveActual.Size = new Size(220, 25);
            txtClaveActual.TabIndex = 1;
            txtClaveActual.UseSystemPasswordChar = true;
            // 
            // lblClaveNueva
            // 
            lblClaveNueva.AutoSize = true;
            lblClaveNueva.BackColor = Color.Transparent;
            lblClaveNueva.Font = new Font("Segoe UI", 10F);
            lblClaveNueva.ForeColor = Color.FromArgb(31, 35, 40);
            lblClaveNueva.Location = new Point(15, 73);
            lblClaveNueva.Name = "lblClaveNueva";
            lblClaveNueva.Size = new Size(92, 19);
            lblClaveNueva.TabIndex = 2;
            lblClaveNueva.Text = "Nueva clave *";
            // 
            // txtClaveNueva
            // 
            txtClaveNueva.BackColor = Color.White;
            txtClaveNueva.BorderStyle = BorderStyle.FixedSingle;
            txtClaveNueva.Font = new Font("Segoe UI", 10F);
            txtClaveNueva.ForeColor = Color.FromArgb(31, 35, 40);
            txtClaveNueva.Location = new Point(166, 70);
            txtClaveNueva.Name = "txtClaveNueva";
            txtClaveNueva.Size = new Size(220, 25);
            txtClaveNueva.TabIndex = 3;
            txtClaveNueva.UseSystemPasswordChar = true;
            // 
            // lblClaveConfirmacion
            // 
            lblClaveConfirmacion.AutoSize = true;
            lblClaveConfirmacion.BackColor = Color.Transparent;
            lblClaveConfirmacion.Font = new Font("Segoe UI", 10F);
            lblClaveConfirmacion.ForeColor = Color.FromArgb(31, 35, 40);
            lblClaveConfirmacion.Location = new Point(15, 111);
            lblClaveConfirmacion.Name = "lblClaveConfirmacion";
            lblClaveConfirmacion.Size = new Size(114, 19);
            lblClaveConfirmacion.TabIndex = 4;
            lblClaveConfirmacion.Text = "Confirmar clave *";
            // 
            // txtClaveConfirmacion
            // 
            txtClaveConfirmacion.BackColor = Color.White;
            txtClaveConfirmacion.BorderStyle = BorderStyle.FixedSingle;
            txtClaveConfirmacion.Font = new Font("Segoe UI", 10F);
            txtClaveConfirmacion.ForeColor = Color.FromArgb(31, 35, 40);
            txtClaveConfirmacion.Location = new Point(166, 108);
            txtClaveConfirmacion.Name = "txtClaveConfirmacion";
            txtClaveConfirmacion.Size = new Size(220, 25);
            txtClaveConfirmacion.TabIndex = 5;
            txtClaveConfirmacion.UseSystemPasswordChar = true;
            // 
            // FrmCambiarClave
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCancelar;
            ClientSize = new Size(520, 360);
            Controls.Add(grpCambioDeClave);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCambiarClave";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cambiar clave de acceso";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpCambioDeClave.ResumeLayout(false);
            grpCambioDeClave.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCancelar;
        private Button btnGuardar;
        private GroupBox grpCambioDeClave;
        private Label lblClaveActual;
        private TextBox txtClaveActual;
        private Label lblClaveNueva;
        private TextBox txtClaveNueva;
        private Label lblClaveConfirmacion;
        private TextBox txtClaveConfirmacion;
    }
}
