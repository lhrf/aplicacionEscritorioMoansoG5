// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmElaborarReporte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.dgvAtencionesCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAtencionesCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAtencionesCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAtenciones = new System.Windows.Forms.GroupBox();
            this.dgvAtenciones = new System.Windows.Forms.DataGridView();
            this.grpVistaPreviaDelReporteClinico = new System.Windows.Forms.GroupBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.rtbVistaPrevia = new System.Windows.Forms.RichTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnEnviarEntrega = new System.Windows.Forms.Button();
            this.btnEnviarAutorizacion = new System.Windows.Forms.Button();
            this.btnImprimirDefinitivo = new System.Windows.Forms.Button();
            this.btnGuardarDefinitivo = new System.Windows.Forms.Button();
            this.btnEnviarRevision = new System.Windows.Forms.Button();
            this.btnImprimirBorrador = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1260, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Elaborar Reporte clínico";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(1220, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpAtenciones
            this.grpAtenciones.Name = "grpAtenciones";
            this.grpAtenciones.Location = new System.Drawing.Point(20, 70);
            this.grpAtenciones.Size = new System.Drawing.Size(411, 510);
            this.grpAtenciones.Text = "Atenciones";
            this.grpAtenciones.BackColor = System.Drawing.Color.White;
            this.grpAtenciones.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpAtenciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpAtenciones);
            
            // dgvAtenciones
            this.dgvAtenciones.Name = "dgvAtenciones";
            this.dgvAtenciones.Location = new System.Drawing.Point(12, 30);
            this.dgvAtenciones.Size = new System.Drawing.Size(387, 468);
            this.dgvAtenciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtenciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvAtenciones.ReadOnly = true;
            this.dgvAtenciones.AllowUserToAddRows = false;
            this.dgvAtenciones.AllowUserToDeleteRows = false;
            this.dgvAtenciones.MultiSelect = false;
            this.dgvAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtenciones.RowHeadersVisible = false;
            this.dgvAtenciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtenciones.EnableHeadersVisualStyles = false;
            this.dgvAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtenciones.ColumnHeadersHeight = 36;
            this.dgvAtenciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvAtenciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAtenciones.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvAtenciones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAtenciones.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAtenciones.RowTemplate.Height = 30;
            this.dgvAtenciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvAtenciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAtencionesCol1.HeaderText = "N.° atención";
            this.dgvAtencionesCol1.Name = "dgvAtencionesCol1";
            this.dgvAtencionesCol1.ReadOnly = true;
            this.dgvAtencionesCol1.FillWeight = 100F;
            this.dgvAtencionesCol2.HeaderText = "Paciente";
            this.dgvAtencionesCol2.Name = "dgvAtencionesCol2";
            this.dgvAtencionesCol2.ReadOnly = true;
            this.dgvAtencionesCol2.FillWeight = 100F;
            this.dgvAtencionesCol3.HeaderText = "Estado";
            this.dgvAtencionesCol3.Name = "dgvAtencionesCol3";
            this.dgvAtencionesCol3.ReadOnly = true;
            this.dgvAtencionesCol3.FillWeight = 100F;
            this.dgvAtenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvAtencionesCol1, this.dgvAtencionesCol2, this.dgvAtencionesCol3});
            this.grpAtenciones.Controls.Add(this.dgvAtenciones);
            
            // grpVistaPreviaDelReporteClinico
            this.grpVistaPreviaDelReporteClinico.Name = "grpVistaPreviaDelReporteClinico";
            this.grpVistaPreviaDelReporteClinico.Location = new System.Drawing.Point(441, 70);
            this.grpVistaPreviaDelReporteClinico.Size = new System.Drawing.Size(798, 418);
            this.grpVistaPreviaDelReporteClinico.Text = "Vista previa del Reporte clínico";
            this.grpVistaPreviaDelReporteClinico.BackColor = System.Drawing.Color.White;
            this.grpVistaPreviaDelReporteClinico.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpVistaPreviaDelReporteClinico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpVistaPreviaDelReporteClinico);
            
            // lblVistaPrevia
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Location = new System.Drawing.Point(15, 35);
            this.lblVistaPrevia.Text = "Vista previa";
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpVistaPreviaDelReporteClinico.Controls.Add(this.lblVistaPrevia);
            
            // rtbVistaPrevia
            this.rtbVistaPrevia.Name = "rtbVistaPrevia";
            this.rtbVistaPrevia.Location = new System.Drawing.Point(157, 32);
            this.rtbVistaPrevia.Size = new System.Drawing.Size(560, 330);
            this.rtbVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpVistaPreviaDelReporteClinico.Controls.Add(this.rtbVistaPrevia);
            
            // lblEstado
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Location = new System.Drawing.Point(15, 375);
            this.lblEstado.Text = "Estado / versión";
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpVistaPreviaDelReporteClinico.Controls.Add(this.lblEstado);
            
            // txtEstado
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Location = new System.Drawing.Point(157, 372);
            this.txtEstado.Size = new System.Drawing.Size(200, 27);
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEstado.ReadOnly = true;
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpVistaPreviaDelReporteClinico.Controls.Add(this.txtEstado);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 590);
            this.pnlAcciones.Size = new System.Drawing.Size(1260, 60);
            this.pnlAcciones.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(1110, 12);
            this.btnCerrar.Size = new System.Drawing.Size(130, 36);
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Location = new System.Drawing.Point(970, 12);
            this.btnGenerar.Size = new System.Drawing.Size(130, 36);
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnGenerar);
            this.btnEnviarEntrega.Name = "btnEnviarEntrega";
            this.btnEnviarEntrega.Text = "A entrega";
            this.btnEnviarEntrega.Location = new System.Drawing.Point(830, 12);
            this.btnEnviarEntrega.Size = new System.Drawing.Size(130, 36);
            this.btnEnviarEntrega.BackColor = System.Drawing.Color.White;
            this.btnEnviarEntrega.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEnviarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEntrega.FlatAppearance.BorderSize = 1;
            this.btnEnviarEntrega.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEnviarEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviarEntrega.UseVisualStyleBackColor = false;
            this.btnEnviarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnEnviarEntrega);
            this.btnEnviarAutorizacion.Name = "btnEnviarAutorizacion";
            this.btnEnviarAutorizacion.Text = "A autorización";
            this.btnEnviarAutorizacion.Location = new System.Drawing.Point(676, 12);
            this.btnEnviarAutorizacion.Size = new System.Drawing.Size(144, 36);
            this.btnEnviarAutorizacion.BackColor = System.Drawing.Color.White;
            this.btnEnviarAutorizacion.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEnviarAutorizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarAutorizacion.FlatAppearance.BorderSize = 1;
            this.btnEnviarAutorizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEnviarAutorizacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviarAutorizacion.UseVisualStyleBackColor = false;
            this.btnEnviarAutorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnEnviarAutorizacion);
            this.btnImprimirDefinitivo.Name = "btnImprimirDefinitivo";
            this.btnImprimirDefinitivo.Text = "Imprimir final";
            this.btnImprimirDefinitivo.Location = new System.Drawing.Point(522, 12);
            this.btnImprimirDefinitivo.Size = new System.Drawing.Size(144, 36);
            this.btnImprimirDefinitivo.BackColor = System.Drawing.Color.White;
            this.btnImprimirDefinitivo.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnImprimirDefinitivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirDefinitivo.FlatAppearance.BorderSize = 1;
            this.btnImprimirDefinitivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnImprimirDefinitivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimirDefinitivo.UseVisualStyleBackColor = false;
            this.btnImprimirDefinitivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnImprimirDefinitivo);
            this.btnGuardarDefinitivo.Name = "btnGuardarDefinitivo";
            this.btnGuardarDefinitivo.Text = "Guardar definitivo";
            this.btnGuardarDefinitivo.Location = new System.Drawing.Point(335, 12);
            this.btnGuardarDefinitivo.Size = new System.Drawing.Size(177, 36);
            this.btnGuardarDefinitivo.BackColor = System.Drawing.Color.White;
            this.btnGuardarDefinitivo.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnGuardarDefinitivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDefinitivo.FlatAppearance.BorderSize = 1;
            this.btnGuardarDefinitivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnGuardarDefinitivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarDefinitivo.UseVisualStyleBackColor = false;
            this.btnGuardarDefinitivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnGuardarDefinitivo);
            this.btnEnviarRevision.Name = "btnEnviarRevision";
            this.btnEnviarRevision.Text = "A revisión";
            this.btnEnviarRevision.Location = new System.Drawing.Point(195, 12);
            this.btnEnviarRevision.Size = new System.Drawing.Size(130, 36);
            this.btnEnviarRevision.BackColor = System.Drawing.Color.White;
            this.btnEnviarRevision.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEnviarRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarRevision.FlatAppearance.BorderSize = 1;
            this.btnEnviarRevision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEnviarRevision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviarRevision.UseVisualStyleBackColor = false;
            this.btnEnviarRevision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnEnviarRevision);
            this.btnImprimirBorrador.Name = "btnImprimirBorrador";
            this.btnImprimirBorrador.Text = "Imprimir borrador";
            this.btnImprimirBorrador.Location = new System.Drawing.Point(16, 12);
            this.btnImprimirBorrador.Size = new System.Drawing.Size(169, 36);
            this.btnImprimirBorrador.BackColor = System.Drawing.Color.White;
            this.btnImprimirBorrador.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnImprimirBorrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirBorrador.FlatAppearance.BorderSize = 1;
            this.btnImprimirBorrador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnImprimirBorrador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimirBorrador.UseVisualStyleBackColor = false;
            this.btnImprimirBorrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnImprimirBorrador);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 650);
            this.Text = "Elaborar Reporte clínico";
            this.Name = "FrmElaborarReporte";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpAtenciones;
        private System.Windows.Forms.DataGridView dgvAtenciones;
        private System.Windows.Forms.GroupBox grpVistaPreviaDelReporteClinico;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.RichTextBox rtbVistaPrevia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnEnviarEntrega;
        private System.Windows.Forms.Button btnEnviarAutorizacion;
        private System.Windows.Forms.Button btnImprimirDefinitivo;
        private System.Windows.Forms.Button btnGuardarDefinitivo;
        private System.Windows.Forms.Button btnEnviarRevision;
        private System.Windows.Forms.Button btnImprimirBorrador;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAtencionesCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAtencionesCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAtencionesCol3;
    }
}
