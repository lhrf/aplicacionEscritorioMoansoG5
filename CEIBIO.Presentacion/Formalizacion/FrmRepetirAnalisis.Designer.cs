// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmRepetirAnalisis
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
            this.dgvRepeticionCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRepeticionCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRepeticionCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRepeticionCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRepeticion = new System.Windows.Forms.GroupBox();
            this.dgvRepeticion = new System.Windows.Forms.DataGridView();
            this.grpRepeticionDatos = new System.Windows.Forms.GroupBox();
            this.lblResultadoAnterior = new System.Windows.Forms.Label();
            this.txtResultadoAnterior = new System.Windows.Forms.TextBox();
            this.lblNuevoResultado = new System.Windows.Forms.Label();
            this.txtNuevoResultado = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticion)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Registrar repetición del análisis";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(960, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpRepeticion
            this.grpRepeticion.Name = "grpRepeticion";
            this.grpRepeticion.Location = new System.Drawing.Point(20, 70);
            this.grpRepeticion.Size = new System.Drawing.Size(960, 298);
            this.grpRepeticion.Text = "Resultados en repetición";
            this.grpRepeticion.BackColor = System.Drawing.Color.White;
            this.grpRepeticion.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpRepeticion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpRepeticion);
            
            // dgvRepeticion
            this.dgvRepeticion.Name = "dgvRepeticion";
            this.dgvRepeticion.Location = new System.Drawing.Point(12, 30);
            this.dgvRepeticion.Size = new System.Drawing.Size(936, 256);
            this.dgvRepeticion.BackgroundColor = System.Drawing.Color.White;
            this.dgvRepeticion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvRepeticion.ReadOnly = true;
            this.dgvRepeticion.AllowUserToAddRows = false;
            this.dgvRepeticion.AllowUserToDeleteRows = false;
            this.dgvRepeticion.MultiSelect = false;
            this.dgvRepeticion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepeticion.RowHeadersVisible = false;
            this.dgvRepeticion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepeticion.EnableHeadersVisualStyles = false;
            this.dgvRepeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRepeticion.ColumnHeadersHeight = 55;
            this.dgvRepeticion.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvRepeticion.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRepeticion.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvRepeticion.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvRepeticion.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepeticion.RowTemplate.Height = 30;
            this.dgvRepeticion.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvRepeticion.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRepeticionCol1.HeaderText = "N.° atención";
            this.dgvRepeticionCol1.Name = "dgvRepeticionCol1";
            this.dgvRepeticionCol1.ReadOnly = true;
            this.dgvRepeticionCol1.FillWeight = 100F;
            this.dgvRepeticionCol2.HeaderText = "Paciente";
            this.dgvRepeticionCol2.Name = "dgvRepeticionCol2";
            this.dgvRepeticionCol2.ReadOnly = true;
            this.dgvRepeticionCol2.FillWeight = 100F;
            this.dgvRepeticionCol3.HeaderText = "Parámetro";
            this.dgvRepeticionCol3.Name = "dgvRepeticionCol3";
            this.dgvRepeticionCol3.ReadOnly = true;
            this.dgvRepeticionCol3.FillWeight = 100F;
            this.dgvRepeticionCol4.HeaderText = "Observación del médico";
            this.dgvRepeticionCol4.Name = "dgvRepeticionCol4";
            this.dgvRepeticionCol4.ReadOnly = true;
            this.dgvRepeticionCol4.FillWeight = 135F;
            this.dgvRepeticion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvRepeticionCol1, this.dgvRepeticionCol2, this.dgvRepeticionCol3, this.dgvRepeticionCol4});
            this.grpRepeticion.Controls.Add(this.dgvRepeticion);
            
            // grpRepeticionDatos
            this.grpRepeticionDatos.Name = "grpRepeticionDatos";
            this.grpRepeticionDatos.Location = new System.Drawing.Point(20, 378);
            this.grpRepeticionDatos.Size = new System.Drawing.Size(960, 202);
            this.grpRepeticionDatos.Text = "Repetición";
            this.grpRepeticionDatos.BackColor = System.Drawing.Color.White;
            this.grpRepeticionDatos.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpRepeticionDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpRepeticionDatos);
            
            // lblResultadoAnterior
            this.lblResultadoAnterior.Name = "lblResultadoAnterior";
            this.lblResultadoAnterior.Location = new System.Drawing.Point(15, 35);
            this.lblResultadoAnterior.Text = "Resultado anterior";
            this.lblResultadoAnterior.AutoSize = true;
            this.lblResultadoAnterior.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblResultadoAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRepeticionDatos.Controls.Add(this.lblResultadoAnterior);
            
            // txtResultadoAnterior
            this.txtResultadoAnterior.Name = "txtResultadoAnterior";
            this.txtResultadoAnterior.Location = new System.Drawing.Point(174, 32);
            this.txtResultadoAnterior.Size = new System.Drawing.Size(150, 27);
            this.txtResultadoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultadoAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResultadoAnterior.ReadOnly = true;
            this.txtResultadoAnterior.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpRepeticionDatos.Controls.Add(this.txtResultadoAnterior);
            
            // lblNuevoResultado
            this.lblNuevoResultado.Name = "lblNuevoResultado";
            this.lblNuevoResultado.Location = new System.Drawing.Point(495, 35);
            this.lblNuevoResultado.Text = "Nuevo resultado *";
            this.lblNuevoResultado.AutoSize = true;
            this.lblNuevoResultado.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblNuevoResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRepeticionDatos.Controls.Add(this.lblNuevoResultado);
            
            // txtNuevoResultado
            this.txtNuevoResultado.Name = "txtNuevoResultado";
            this.txtNuevoResultado.Location = new System.Drawing.Point(646, 32);
            this.txtNuevoResultado.Size = new System.Drawing.Size(150, 27);
            this.txtNuevoResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevoResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNuevoResultado.ReadOnly = false;
            this.txtNuevoResultado.BackColor = System.Drawing.Color.White;
            this.grpRepeticionDatos.Controls.Add(this.txtNuevoResultado);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 590);
            this.pnlAcciones.Size = new System.Drawing.Size(1000, 60);
            this.pnlAcciones.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(850, 12);
            this.btnCerrar.Size = new System.Drawing.Size(130, 36);
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar y reenviar";
            this.btnGuardar.Location = new System.Drawing.Point(663, 12);
            this.btnGuardar.Size = new System.Drawing.Size(177, 36);
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Text = "Registrar repetición del análisis";
            this.Name = "FrmRepetirAnalisis";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticion)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpRepeticion;
        private System.Windows.Forms.DataGridView dgvRepeticion;
        private System.Windows.Forms.GroupBox grpRepeticionDatos;
        private System.Windows.Forms.Label lblResultadoAnterior;
        private System.Windows.Forms.TextBox txtResultadoAnterior;
        private System.Windows.Forms.Label lblNuevoResultado;
        private System.Windows.Forms.TextBox txtNuevoResultado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRepeticionCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRepeticionCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRepeticionCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRepeticionCol4;
    }
}
