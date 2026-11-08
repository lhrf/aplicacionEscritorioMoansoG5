// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmRetenerResultado
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
            this.grpRetenerResultado = new System.Windows.Forms.GroupBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRetener = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(520, 46);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Retener y repetir resultado";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(480, 32);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpRetenerResultado
            this.grpRetenerResultado.Name = "grpRetenerResultado";
            this.grpRetenerResultado.Location = new System.Drawing.Point(20, 60);
            this.grpRetenerResultado.Size = new System.Drawing.Size(480, 188);
            this.grpRetenerResultado.Text = "Retener resultado";
            this.grpRetenerResultado.BackColor = System.Drawing.Color.White;
            this.grpRetenerResultado.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpRetenerResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpRetenerResultado);
            
            // lblParametro
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Location = new System.Drawing.Point(15, 35);
            this.lblParametro.Text = "Parámetro";
            this.lblParametro.AutoSize = true;
            this.lblParametro.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblParametro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRetenerResultado.Controls.Add(this.lblParametro);
            
            // txtParametro
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Location = new System.Drawing.Point(265, 32);
            this.txtParametro.Size = new System.Drawing.Size(200, 27);
            this.txtParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParametro.ReadOnly = true;
            this.txtParametro.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpRetenerResultado.Controls.Add(this.txtParametro);
            
            // lblValor
            this.lblValor.Name = "lblValor";
            this.lblValor.Location = new System.Drawing.Point(15, 73);
            this.lblValor.Text = "Valor";
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRetenerResultado.Controls.Add(this.lblValor);
            
            // txtValor
            this.txtValor.Name = "txtValor";
            this.txtValor.Location = new System.Drawing.Point(265, 70);
            this.txtValor.Size = new System.Drawing.Size(120, 27);
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValor.ReadOnly = true;
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpRetenerResultado.Controls.Add(this.txtValor);
            
            // lblObservacion
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Location = new System.Drawing.Point(15, 111);
            this.lblObservacion.Text = "Observación para el Técnico *";
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRetenerResultado.Controls.Add(this.lblObservacion);
            
            // txtObservacion
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Location = new System.Drawing.Point(265, 108);
            this.txtObservacion.Size = new System.Drawing.Size(200, 60);
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservacion.ReadOnly = false;
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grpRetenerResultado.Controls.Add(this.txtObservacion);
            
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
            this.btnRetener.Name = "btnRetener";
            this.btnRetener.Text = "Retener";
            this.btnRetener.Location = new System.Drawing.Point(230, 12);
            this.btnRetener.Size = new System.Drawing.Size(130, 36);
            this.btnRetener.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            this.btnRetener.ForeColor = System.Drawing.Color.White;
            this.btnRetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetener.FlatAppearance.BorderSize = 0;
            this.btnRetener.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRetener.UseVisualStyleBackColor = false;
            this.btnRetener.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnRetener);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Text = "Retener y repetir resultado";
            this.Name = "FrmRetenerResultado";
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

        private System.Windows.Forms.GroupBox grpRetenerResultado;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRetener;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;

    }
}
