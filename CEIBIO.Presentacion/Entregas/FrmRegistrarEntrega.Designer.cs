namespace CEIBIO.Presentacion.Entregas
{
    partial class FrmRegistrarEntrega
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
            btnCerrar = new Button();
            btnRegistrar = new Button();
            btnLevantar = new Button();
            btnRetener = new Button();
            grpBusqueda = new GroupBox();
            lblBusqueda = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            grpComprobanteDePago = new GroupBox();
            lblComprobante = new Label();
            txtComprobante = new TextBox();
            lblPacienteComprobante = new Label();
            txtPacienteComprobante = new TextBox();
            lblExamenesComprobante = new Label();
            txtExamenesComprobante = new TextBox();
            grpReporteClinico = new GroupBox();
            lblAtencion = new Label();
            txtAtencion = new TextBox();
            lblPacienteReporte = new Label();
            txtPacienteReporte = new TextBox();
            lblEstadoReporte = new Label();
            txtEstadoReporte = new TextBox();
            grpPersonaQueRecibe = new GroupBox();
            lblNombreRecibe = new Label();
            txtNombreRecibe = new TextBox();
            lblDniRecibe = new Label();
            txtDniRecibe = new TextBox();
            lblRelacion = new Label();
            cboRelacion = new ComboBox();
            pnlEncabezado.SuspendLayout();
            flpBotones.SuspendLayout();
            grpBusqueda.SuspendLayout();
            grpComprobanteDePago.SuspendLayout();
            grpReporteClinico.SuspendLayout();
            grpPersonaQueRecibe.SuspendLayout();
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
            pnlEncabezado.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(290, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar entrega de resultados";
            // 
            // flpBotones
            // 
            flpBotones.BackColor = Color.White;
            flpBotones.Controls.Add(btnCerrar);
            flpBotones.Controls.Add(btnRegistrar);
            flpBotones.Controls.Add(btnLevantar);
            flpBotones.Controls.Add(btnRetener);
            flpBotones.Dock = DockStyle.Bottom;
            flpBotones.FlowDirection = FlowDirection.RightToLeft;
            flpBotones.Location = new Point(0, 590);
            flpBotones.Name = "flpBotones";
            flpBotones.Padding = new Padding(10, 12, 10, 12);
            flpBotones.Size = new Size(1000, 60);
            flpBotones.TabIndex = 4;
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
            btnCerrar.Location = new Point(847, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 36);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(11, 61, 110);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 90, 158);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(672, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(169, 36);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar entrega";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnLevantar
            // 
            btnLevantar.BackColor = Color.White;
            btnLevantar.Cursor = Cursors.Hand;
            btnLevantar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnLevantar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnLevantar.FlatStyle = FlatStyle.Flat;
            btnLevantar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLevantar.ForeColor = Color.FromArgb(11, 61, 110);
            btnLevantar.Location = new Point(489, 15);
            btnLevantar.Name = "btnLevantar";
            btnLevantar.Size = new Size(177, 36);
            btnLevantar.TabIndex = 1;
            btnLevantar.Text = "Levantar retención";
            btnLevantar.UseVisualStyleBackColor = false;
            // 
            // btnRetener
            // 
            btnRetener.BackColor = Color.FromArgb(180, 35, 24);
            btnRetener.Cursor = Cursors.Hand;
            btnRetener.FlatAppearance.BorderSize = 0;
            btnRetener.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 28, 19);
            btnRetener.FlatStyle = FlatStyle.Flat;
            btnRetener.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRetener.ForeColor = Color.White;
            btnRetener.Location = new Point(330, 15);
            btnRetener.Name = "btnRetener";
            btnRetener.Size = new Size(153, 36);
            btnRetener.TabIndex = 0;
            btnRetener.Text = "Retener entrega";
            btnRetener.UseVisualStyleBackColor = false;
            // 
            // grpBusqueda
            // 
            grpBusqueda.BackColor = Color.White;
            grpBusqueda.Controls.Add(lblBusqueda);
            grpBusqueda.Controls.Add(txtBusqueda);
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBusqueda.ForeColor = Color.FromArgb(11, 61, 110);
            grpBusqueda.Location = new Point(20, 70);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Size = new Size(960, 78);
            grpBusqueda.TabIndex = 0;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = "Búsqueda";
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.BackColor = Color.Transparent;
            lblBusqueda.Font = new Font("Segoe UI", 10F);
            lblBusqueda.ForeColor = Color.FromArgb(31, 35, 40);
            lblBusqueda.Location = new Point(15, 35);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(182, 19);
            lblBusqueda.TabIndex = 0;
            lblBusqueda.Text = "N.° de comprobante o DNI *";
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.White;
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Segoe UI", 10F);
            txtBusqueda.ForeColor = Color.FromArgb(31, 35, 40);
            txtBusqueda.Location = new Point(240, 32);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(160, 25);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 110);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(11, 61, 110);
            btnBuscar.Location = new Point(410, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // grpComprobanteDePago
            // 
            grpComprobanteDePago.BackColor = Color.White;
            grpComprobanteDePago.Controls.Add(lblComprobante);
            grpComprobanteDePago.Controls.Add(txtComprobante);
            grpComprobanteDePago.Controls.Add(lblPacienteComprobante);
            grpComprobanteDePago.Controls.Add(txtPacienteComprobante);
            grpComprobanteDePago.Controls.Add(lblExamenesComprobante);
            grpComprobanteDePago.Controls.Add(txtExamenesComprobante);
            grpComprobanteDePago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpComprobanteDePago.ForeColor = Color.FromArgb(11, 61, 110);
            grpComprobanteDePago.Location = new Point(20, 158);
            grpComprobanteDePago.Name = "grpComprobanteDePago";
            grpComprobanteDePago.Size = new Size(475, 154);
            grpComprobanteDePago.TabIndex = 1;
            grpComprobanteDePago.TabStop = false;
            grpComprobanteDePago.Text = "Comprobante de pago";
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.BackColor = Color.Transparent;
            lblComprobante.Font = new Font("Segoe UI", 10F);
            lblComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            lblComprobante.Location = new Point(15, 35);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(113, 19);
            lblComprobante.TabIndex = 0;
            lblComprobante.Text = "N.° comprobante";
            // 
            // txtComprobante
            // 
            txtComprobante.BackColor = Color.FromArgb(233, 238, 243);
            txtComprobante.BorderStyle = BorderStyle.FixedSingle;
            txtComprobante.Font = new Font("Segoe UI", 10F);
            txtComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            txtComprobante.Location = new Point(149, 32);
            txtComprobante.Name = "txtComprobante";
            txtComprobante.ReadOnly = true;
            txtComprobante.Size = new Size(150, 25);
            txtComprobante.TabIndex = 1;
            txtComprobante.TabStop = false;
            // 
            // lblPacienteComprobante
            // 
            lblPacienteComprobante.AutoSize = true;
            lblPacienteComprobante.BackColor = Color.Transparent;
            lblPacienteComprobante.Font = new Font("Segoe UI", 10F);
            lblPacienteComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            lblPacienteComprobante.Location = new Point(15, 73);
            lblPacienteComprobante.Name = "lblPacienteComprobante";
            lblPacienteComprobante.Size = new Size(60, 19);
            lblPacienteComprobante.TabIndex = 2;
            lblPacienteComprobante.Text = "Paciente";
            // 
            // txtPacienteComprobante
            // 
            txtPacienteComprobante.BackColor = Color.FromArgb(233, 238, 243);
            txtPacienteComprobante.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteComprobante.Font = new Font("Segoe UI", 10F);
            txtPacienteComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            txtPacienteComprobante.Location = new Point(149, 70);
            txtPacienteComprobante.Name = "txtPacienteComprobante";
            txtPacienteComprobante.ReadOnly = true;
            txtPacienteComprobante.Size = new Size(230, 25);
            txtPacienteComprobante.TabIndex = 3;
            txtPacienteComprobante.TabStop = false;
            // 
            // lblExamenesComprobante
            // 
            lblExamenesComprobante.AutoSize = true;
            lblExamenesComprobante.BackColor = Color.Transparent;
            lblExamenesComprobante.Font = new Font("Segoe UI", 10F);
            lblExamenesComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            lblExamenesComprobante.Location = new Point(15, 111);
            lblExamenesComprobante.Name = "lblExamenesComprobante";
            lblExamenesComprobante.Size = new Size(69, 19);
            lblExamenesComprobante.TabIndex = 4;
            lblExamenesComprobante.Text = "Exámenes";
            // 
            // txtExamenesComprobante
            // 
            txtExamenesComprobante.BackColor = Color.FromArgb(233, 238, 243);
            txtExamenesComprobante.BorderStyle = BorderStyle.FixedSingle;
            txtExamenesComprobante.Font = new Font("Segoe UI", 10F);
            txtExamenesComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            txtExamenesComprobante.Location = new Point(149, 108);
            txtExamenesComprobante.Name = "txtExamenesComprobante";
            txtExamenesComprobante.ReadOnly = true;
            txtExamenesComprobante.Size = new Size(230, 25);
            txtExamenesComprobante.TabIndex = 5;
            txtExamenesComprobante.TabStop = false;
            // 
            // grpReporteClinico
            // 
            grpReporteClinico.BackColor = Color.White;
            grpReporteClinico.Controls.Add(lblAtencion);
            grpReporteClinico.Controls.Add(txtAtencion);
            grpReporteClinico.Controls.Add(lblPacienteReporte);
            grpReporteClinico.Controls.Add(txtPacienteReporte);
            grpReporteClinico.Controls.Add(lblEstadoReporte);
            grpReporteClinico.Controls.Add(txtEstadoReporte);
            grpReporteClinico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpReporteClinico.ForeColor = Color.FromArgb(11, 61, 110);
            grpReporteClinico.Location = new Point(505, 158);
            grpReporteClinico.Name = "grpReporteClinico";
            grpReporteClinico.Size = new Size(475, 154);
            grpReporteClinico.TabIndex = 2;
            grpReporteClinico.TabStop = false;
            grpReporteClinico.Text = "Reporte clínico";
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.BackColor = Color.Transparent;
            lblAtencion.Font = new Font("Segoe UI", 10F);
            lblAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            lblAtencion.Location = new Point(15, 35);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(83, 19);
            lblAtencion.TabIndex = 0;
            lblAtencion.Text = "N.° atención";
            // 
            // txtAtencion
            // 
            txtAtencion.BackColor = Color.FromArgb(233, 238, 243);
            txtAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtAtencion.Font = new Font("Segoe UI", 10F);
            txtAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            txtAtencion.Location = new Point(125, 32);
            txtAtencion.Name = "txtAtencion";
            txtAtencion.ReadOnly = true;
            txtAtencion.Size = new Size(150, 25);
            txtAtencion.TabIndex = 1;
            txtAtencion.TabStop = false;
            // 
            // lblPacienteReporte
            // 
            lblPacienteReporte.AutoSize = true;
            lblPacienteReporte.BackColor = Color.Transparent;
            lblPacienteReporte.Font = new Font("Segoe UI", 10F);
            lblPacienteReporte.ForeColor = Color.FromArgb(31, 35, 40);
            lblPacienteReporte.Location = new Point(15, 73);
            lblPacienteReporte.Name = "lblPacienteReporte";
            lblPacienteReporte.Size = new Size(60, 19);
            lblPacienteReporte.TabIndex = 2;
            lblPacienteReporte.Text = "Paciente";
            // 
            // txtPacienteReporte
            // 
            txtPacienteReporte.BackColor = Color.FromArgb(233, 238, 243);
            txtPacienteReporte.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteReporte.Font = new Font("Segoe UI", 10F);
            txtPacienteReporte.ForeColor = Color.FromArgb(31, 35, 40);
            txtPacienteReporte.Location = new Point(125, 70);
            txtPacienteReporte.Name = "txtPacienteReporte";
            txtPacienteReporte.ReadOnly = true;
            txtPacienteReporte.Size = new Size(230, 25);
            txtPacienteReporte.TabIndex = 3;
            txtPacienteReporte.TabStop = false;
            // 
            // lblEstadoReporte
            // 
            lblEstadoReporte.AutoSize = true;
            lblEstadoReporte.BackColor = Color.Transparent;
            lblEstadoReporte.Font = new Font("Segoe UI", 10F);
            lblEstadoReporte.ForeColor = Color.FromArgb(31, 35, 40);
            lblEstadoReporte.Location = new Point(15, 111);
            lblEstadoReporte.Name = "lblEstadoReporte";
            lblEstadoReporte.Size = new Size(50, 19);
            lblEstadoReporte.TabIndex = 4;
            lblEstadoReporte.Text = "Estado";
            // 
            // txtEstadoReporte
            // 
            txtEstadoReporte.BackColor = Color.FromArgb(233, 238, 243);
            txtEstadoReporte.BorderStyle = BorderStyle.FixedSingle;
            txtEstadoReporte.Font = new Font("Segoe UI", 10F);
            txtEstadoReporte.ForeColor = Color.FromArgb(31, 35, 40);
            txtEstadoReporte.Location = new Point(125, 108);
            txtEstadoReporte.Name = "txtEstadoReporte";
            txtEstadoReporte.ReadOnly = true;
            txtEstadoReporte.Size = new Size(230, 25);
            txtEstadoReporte.TabIndex = 5;
            txtEstadoReporte.TabStop = false;
            // 
            // grpPersonaQueRecibe
            // 
            grpPersonaQueRecibe.BackColor = Color.White;
            grpPersonaQueRecibe.Controls.Add(lblNombreRecibe);
            grpPersonaQueRecibe.Controls.Add(txtNombreRecibe);
            grpPersonaQueRecibe.Controls.Add(lblDniRecibe);
            grpPersonaQueRecibe.Controls.Add(txtDniRecibe);
            grpPersonaQueRecibe.Controls.Add(lblRelacion);
            grpPersonaQueRecibe.Controls.Add(cboRelacion);
            grpPersonaQueRecibe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPersonaQueRecibe.ForeColor = Color.FromArgb(11, 61, 110);
            grpPersonaQueRecibe.Location = new Point(20, 322);
            grpPersonaQueRecibe.Name = "grpPersonaQueRecibe";
            grpPersonaQueRecibe.Size = new Size(960, 116);
            grpPersonaQueRecibe.TabIndex = 3;
            grpPersonaQueRecibe.TabStop = false;
            grpPersonaQueRecibe.Text = "Persona que recibe";
            // 
            // lblNombreRecibe
            // 
            lblNombreRecibe.AutoSize = true;
            lblNombreRecibe.BackColor = Color.Transparent;
            lblNombreRecibe.Font = new Font("Segoe UI", 10F);
            lblNombreRecibe.ForeColor = Color.FromArgb(31, 35, 40);
            lblNombreRecibe.Location = new Point(15, 35);
            lblNombreRecibe.Name = "lblNombreRecibe";
            lblNombreRecibe.Size = new Size(69, 19);
            lblNombreRecibe.TabIndex = 0;
            lblNombreRecibe.Text = "Nombre *";
            // 
            // txtNombreRecibe
            // 
            txtNombreRecibe.BackColor = Color.White;
            txtNombreRecibe.BorderStyle = BorderStyle.FixedSingle;
            txtNombreRecibe.Font = new Font("Segoe UI", 10F);
            txtNombreRecibe.ForeColor = Color.FromArgb(31, 35, 40);
            txtNombreRecibe.Location = new Point(125, 32);
            txtNombreRecibe.Name = "txtNombreRecibe";
            txtNombreRecibe.Size = new Size(280, 25);
            txtNombreRecibe.TabIndex = 1;
            // 
            // lblDniRecibe
            // 
            lblDniRecibe.AutoSize = true;
            lblDniRecibe.BackColor = Color.Transparent;
            lblDniRecibe.Font = new Font("Segoe UI", 10F);
            lblDniRecibe.ForeColor = Color.FromArgb(31, 35, 40);
            lblDniRecibe.Location = new Point(15, 73);
            lblDniRecibe.Name = "lblDniRecibe";
            lblDniRecibe.Size = new Size(43, 19);
            lblDniRecibe.TabIndex = 2;
            lblDniRecibe.Text = "DNI *";
            // 
            // txtDniRecibe
            // 
            txtDniRecibe.BackColor = Color.White;
            txtDniRecibe.BorderStyle = BorderStyle.FixedSingle;
            txtDniRecibe.Font = new Font("Segoe UI", 10F);
            txtDniRecibe.ForeColor = Color.FromArgb(31, 35, 40);
            txtDniRecibe.Location = new Point(125, 70);
            txtDniRecibe.MaxLength = 8;
            txtDniRecibe.Name = "txtDniRecibe";
            txtDniRecibe.Size = new Size(120, 25);
            txtDniRecibe.TabIndex = 3;
            // 
            // lblRelacion
            // 
            lblRelacion.AutoSize = true;
            lblRelacion.BackColor = Color.Transparent;
            lblRelacion.Font = new Font("Segoe UI", 10F);
            lblRelacion.ForeColor = Color.FromArgb(31, 35, 40);
            lblRelacion.Location = new Point(495, 35);
            lblRelacion.Name = "lblRelacion";
            lblRelacion.Size = new Size(69, 19);
            lblRelacion.TabIndex = 4;
            lblRelacion.Text = "Relación *";
            // 
            // cboRelacion
            // 
            cboRelacion.BackColor = Color.White;
            cboRelacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRelacion.FlatStyle = FlatStyle.Flat;
            cboRelacion.Font = new Font("Segoe UI", 10F);
            cboRelacion.ForeColor = Color.FromArgb(31, 35, 40);
            cboRelacion.FormattingEnabled = true;
            cboRelacion.Items.AddRange(new object[] { "Paciente", "Representante", "Familiar" });
            cboRelacion.Location = new Point(605, 32);
            cboRelacion.Name = "cboRelacion";
            cboRelacion.Size = new Size(180, 25);
            cboRelacion.TabIndex = 5;
            // 
            // FrmRegistrarEntrega
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            CancelButton = btnCerrar;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpPersonaQueRecibe);
            Controls.Add(grpReporteClinico);
            Controls.Add(grpComprobanteDePago);
            Controls.Add(grpBusqueda);
            Controls.Add(flpBotones);
            Controls.Add(pnlEncabezado);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar entrega de resultados";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            flpBotones.ResumeLayout(false);
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            grpComprobanteDePago.ResumeLayout(false);
            grpComprobanteDePago.PerformLayout();
            grpReporteClinico.ResumeLayout(false);
            grpReporteClinico.PerformLayout();
            grpPersonaQueRecibe.ResumeLayout(false);
            grpPersonaQueRecibe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private FlowLayoutPanel flpBotones;
        private Button btnCerrar;
        private Button btnRegistrar;
        private Button btnLevantar;
        private Button btnRetener;
        private GroupBox grpBusqueda;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private GroupBox grpComprobanteDePago;
        private Label lblComprobante;
        private TextBox txtComprobante;
        private Label lblPacienteComprobante;
        private TextBox txtPacienteComprobante;
        private Label lblExamenesComprobante;
        private TextBox txtExamenesComprobante;
        private GroupBox grpReporteClinico;
        private Label lblAtencion;
        private TextBox txtAtencion;
        private Label lblPacienteReporte;
        private TextBox txtPacienteReporte;
        private Label lblEstadoReporte;
        private TextBox txtEstadoReporte;
        private GroupBox grpPersonaQueRecibe;
        private Label lblNombreRecibe;
        private TextBox txtNombreRecibe;
        private Label lblDniRecibe;
        private TextBox txtDniRecibe;
        private Label lblRelacion;
        private ComboBox cboRelacion;
    }
}
