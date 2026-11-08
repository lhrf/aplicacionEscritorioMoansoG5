// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmHistorialRevisiones
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
            this.dgvHistorialCol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorialCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorialCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorialCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorialCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.lblNumeroAtencion = new System.Windows.Forms.Label();
            this.txtNumeroAtencion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Historial de revisiones del Reporte clínico";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(960, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpBusqueda
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Location = new System.Drawing.Point(20, 70);
            this.grpBusqueda.Size = new System.Drawing.Size(960, 78);
            this.grpBusqueda.Text = "Búsqueda";
            this.grpBusqueda.BackColor = System.Drawing.Color.White;
            this.grpBusqueda.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpBusqueda);
            
            // lblNumeroAtencion
            this.lblNumeroAtencion.Name = "lblNumeroAtencion";
            this.lblNumeroAtencion.Location = new System.Drawing.Point(15, 35);
            this.lblNumeroAtencion.Text = "N.° de atención *";
            this.lblNumeroAtencion.AutoSize = true;
            this.lblNumeroAtencion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblNumeroAtencion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpBusqueda.Controls.Add(this.lblNumeroAtencion);
            
            // txtNumeroAtencion
            this.txtNumeroAtencion.Name = "txtNumeroAtencion";
            this.txtNumeroAtencion.Location = new System.Drawing.Point(166, 32);
            this.txtNumeroAtencion.Size = new System.Drawing.Size(120, 27);
            this.txtNumeroAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAtencion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroAtencion.ReadOnly = false;
            this.txtNumeroAtencion.BackColor = System.Drawing.Color.White;
            this.grpBusqueda.Controls.Add(this.txtNumeroAtencion);
            
            // btnBuscar
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Location = new System.Drawing.Point(296, 28);
            this.btnBuscar.Size = new System.Drawing.Size(110, 34);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            
            // grpHistorial
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Location = new System.Drawing.Point(20, 158);
            this.grpHistorial.Size = new System.Drawing.Size(960, 438);
            this.grpHistorial.Text = "Historial del Reporte clínico";
            this.grpHistorial.BackColor = System.Drawing.Color.White;
            this.grpHistorial.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpHistorial);
            
            // dgvHistorial
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Location = new System.Drawing.Point(12, 30);
            this.dgvHistorial.Size = new System.Drawing.Size(936, 396);
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.ColumnHeadersHeight = 36;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.RowTemplate.Height = 30;
            this.dgvHistorial.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvHistorial.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHistorialCol1.HeaderText = "Versión";
            this.dgvHistorialCol1.Name = "dgvHistorialCol1";
            this.dgvHistorialCol1.ReadOnly = true;
            this.dgvHistorialCol1.FillWeight = 100F;
            this.dgvHistorialCol2.HeaderText = "Acción";
            this.dgvHistorialCol2.Name = "dgvHistorialCol2";
            this.dgvHistorialCol2.ReadOnly = true;
            this.dgvHistorialCol2.FillWeight = 100F;
            this.dgvHistorialCol3.HeaderText = "Observación";
            this.dgvHistorialCol3.Name = "dgvHistorialCol3";
            this.dgvHistorialCol3.ReadOnly = true;
            this.dgvHistorialCol3.FillWeight = 100F;
            this.dgvHistorialCol4.HeaderText = "Responsable";
            this.dgvHistorialCol4.Name = "dgvHistorialCol4";
            this.dgvHistorialCol4.ReadOnly = true;
            this.dgvHistorialCol4.FillWeight = 100F;
            this.dgvHistorialCol5.HeaderText = "Fecha";
            this.dgvHistorialCol5.Name = "dgvHistorialCol5";
            this.dgvHistorialCol5.ReadOnly = true;
            this.dgvHistorialCol5.FillWeight = 100F;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvHistorialCol1, this.dgvHistorialCol2, this.dgvHistorialCol3, this.dgvHistorialCol4, this.dgvHistorialCol5});
            this.grpHistorial.Controls.Add(this.dgvHistorial);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 610);
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
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Text = "Historial de revisiones del Reporte clínico";
            this.Name = "FrmHistorialRevisiones";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblNumeroAtencion;
        private System.Windows.Forms.TextBox txtNumeroAtencion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorialCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorialCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorialCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorialCol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistorialCol5;
    }
}
