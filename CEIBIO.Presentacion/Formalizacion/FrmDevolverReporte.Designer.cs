// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmDevolverReporte
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
            this.grpDevolucion = new System.Windows.Forms.GroupBox();
            this.lblNumeroAtencion = new System.Windows.Forms.Label();
            this.txtNumeroAtencion = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(520, 46);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Devolver Reporte para completar validaciones";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(480, 32);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpDevolucion
            this.grpDevolucion.Name = "grpDevolucion";
            this.grpDevolucion.Location = new System.Drawing.Point(20, 60);
            this.grpDevolucion.Size = new System.Drawing.Size(480, 188);
            this.grpDevolucion.Text = "Devolución";
            this.grpDevolucion.BackColor = System.Drawing.Color.White;
            this.grpDevolucion.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpDevolucion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpDevolucion);
            
            // lblNumeroAtencion
            this.lblNumeroAtencion.Name = "lblNumeroAtencion";
            this.lblNumeroAtencion.Location = new System.Drawing.Point(15, 35);
            this.lblNumeroAtencion.Text = "N.° de atención";
            this.lblNumeroAtencion.AutoSize = true;
            this.lblNumeroAtencion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblNumeroAtencion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDevolucion.Controls.Add(this.lblNumeroAtencion);
            
            // txtNumeroAtencion
            this.txtNumeroAtencion.Name = "txtNumeroAtencion";
            this.txtNumeroAtencion.Location = new System.Drawing.Point(149, 32);
            this.txtNumeroAtencion.Size = new System.Drawing.Size(120, 27);
            this.txtNumeroAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAtencion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroAtencion.ReadOnly = true;
            this.txtNumeroAtencion.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpDevolucion.Controls.Add(this.txtNumeroAtencion);
            
            // lblPaciente
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Location = new System.Drawing.Point(15, 73);
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDevolucion.Controls.Add(this.lblPaciente);
            
            // txtPaciente
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Location = new System.Drawing.Point(149, 70);
            this.txtPaciente.Size = new System.Drawing.Size(260, 27);
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpDevolucion.Controls.Add(this.txtPaciente);
            
            // lblObservacion
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Location = new System.Drawing.Point(15, 111);
            this.lblObservacion.Text = "Observación *";
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDevolucion.Controls.Add(this.lblObservacion);
            
            // txtObservacion
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Location = new System.Drawing.Point(149, 108);
            this.txtObservacion.Size = new System.Drawing.Size(260, 60);
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservacion.ReadOnly = false;
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grpDevolucion.Controls.Add(this.txtObservacion);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 300);
            this.pnlAcciones.Size = new System.Drawing.Size(520, 60);
            this.pnlAcciones.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(370, 12);
            this.btnCancelar.Size = new System.Drawing.Size(130, 36);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.Location = new System.Drawing.Point(230, 12);
            this.btnDevolver.Size = new System.Drawing.Size(130, 36);
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnDevolver);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Text = "Devolver Reporte para completar validaciones";
            this.Name = "FrmDevolverReporte";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpDevolucion;
        private System.Windows.Forms.Label lblNumeroAtencion;
        private System.Windows.Forms.TextBox txtNumeroAtencion;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;

    }
}
