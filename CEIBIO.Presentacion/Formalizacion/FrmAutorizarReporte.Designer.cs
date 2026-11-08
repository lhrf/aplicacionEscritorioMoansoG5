// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmAutorizarReporte
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
            this.dgvValidacionesCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValidacionesCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValidacionesCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValidacionesCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReportes = new System.Windows.Forms.GroupBox();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.grpValidaciones = new System.Windows.Forms.GroupBox();
            this.dgvValidaciones = new System.Windows.Forms.DataGridView();
            this.grpAnulacion = new System.Windows.Forms.GroupBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidaciones)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Autorizar Reporte clínico";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(960, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpReportes
            this.grpReportes.Name = "grpReportes";
            this.grpReportes.Location = new System.Drawing.Point(20, 70);
            this.grpReportes.Size = new System.Drawing.Size(960, 218);
            this.grpReportes.Text = "Reportes pendientes de autorización";
            this.grpReportes.BackColor = System.Drawing.Color.White;
            this.grpReportes.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpReportes);
            
            // dgvReportes
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Location = new System.Drawing.Point(12, 30);
            this.dgvReportes.Size = new System.Drawing.Size(936, 176);
            this.dgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.MultiSelect = false;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.EnableHeadersVisualStyles = false;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReportes.ColumnHeadersHeight = 36;
            this.dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReportes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvReportes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvReportes.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.RowTemplate.Height = 30;
            this.dgvReportes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvReportes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReportesCol1.HeaderText = "N.° atención";
            this.dgvReportesCol1.Name = "dgvReportesCol1";
            this.dgvReportesCol1.ReadOnly = true;
            this.dgvReportesCol1.FillWeight = 100F;
            this.dgvReportesCol2.HeaderText = "Paciente";
            this.dgvReportesCol2.Name = "dgvReportesCol2";
            this.dgvReportesCol2.ReadOnly = true;
            this.dgvReportesCol2.FillWeight = 100F;
            this.dgvReportesCol3.HeaderText = "Versión";
            this.dgvReportesCol3.Name = "dgvReportesCol3";
            this.dgvReportesCol3.ReadOnly = true;
            this.dgvReportesCol3.FillWeight = 100F;
            this.dgvReportesCol4.HeaderText = "Fecha";
            this.dgvReportesCol4.Name = "dgvReportesCol4";
            this.dgvReportesCol4.ReadOnly = true;
            this.dgvReportesCol4.FillWeight = 100F;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvReportesCol1, this.dgvReportesCol2, this.dgvReportesCol3, this.dgvReportesCol4});
            this.grpReportes.Controls.Add(this.dgvReportes);
            
            // grpValidaciones
            this.grpValidaciones.Name = "grpValidaciones";
            this.grpValidaciones.Location = new System.Drawing.Point(20, 298);
            this.grpValidaciones.Size = new System.Drawing.Size(960, 238);
            this.grpValidaciones.Text = "Estado de validación de cada resultado";
            this.grpValidaciones.BackColor = System.Drawing.Color.White;
            this.grpValidaciones.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpValidaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpValidaciones);
            
            // dgvValidaciones
            this.dgvValidaciones.Name = "dgvValidaciones";
            this.dgvValidaciones.Location = new System.Drawing.Point(12, 30);
            this.dgvValidaciones.Size = new System.Drawing.Size(936, 196);
            this.dgvValidaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvValidaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvValidaciones.ReadOnly = true;
            this.dgvValidaciones.AllowUserToAddRows = false;
            this.dgvValidaciones.AllowUserToDeleteRows = false;
            this.dgvValidaciones.MultiSelect = false;
            this.dgvValidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValidaciones.RowHeadersVisible = false;
            this.dgvValidaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValidaciones.EnableHeadersVisualStyles = false;
            this.dgvValidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvValidaciones.ColumnHeadersHeight = 36;
            this.dgvValidaciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvValidaciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvValidaciones.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvValidaciones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvValidaciones.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValidaciones.RowTemplate.Height = 30;
            this.dgvValidaciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvValidaciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvValidacionesCol1.HeaderText = "Parámetro";
            this.dgvValidacionesCol1.Name = "dgvValidacionesCol1";
            this.dgvValidacionesCol1.ReadOnly = true;
            this.dgvValidacionesCol1.FillWeight = 100F;
            this.dgvValidacionesCol2.HeaderText = "Validado";
            this.dgvValidacionesCol2.Name = "dgvValidacionesCol2";
            this.dgvValidacionesCol2.ReadOnly = true;
            this.dgvValidacionesCol2.FillWeight = 100F;
            this.dgvValidacionesCol3.HeaderText = "Médico Patólogo";
            this.dgvValidacionesCol3.Name = "dgvValidacionesCol3";
            this.dgvValidacionesCol3.ReadOnly = true;
            this.dgvValidacionesCol3.FillWeight = 100F;
            this.dgvValidacionesCol4.HeaderText = "Fecha";
            this.dgvValidacionesCol4.Name = "dgvValidacionesCol4";
            this.dgvValidacionesCol4.ReadOnly = true;
            this.dgvValidacionesCol4.FillWeight = 100F;
            this.dgvValidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvValidacionesCol1, this.dgvValidacionesCol2, this.dgvValidacionesCol3, this.dgvValidacionesCol4});
            this.grpValidaciones.Controls.Add(this.dgvValidaciones);
            
            // grpAnulacion
            this.grpAnulacion.Name = "grpAnulacion";
            this.grpAnulacion.Location = new System.Drawing.Point(20, 546);
            this.grpAnulacion.Size = new System.Drawing.Size(960, 112);
            this.grpAnulacion.Text = "Anulación";
            this.grpAnulacion.BackColor = System.Drawing.Color.White;
            this.grpAnulacion.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpAnulacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpAnulacion);
            
            // lblMotivo
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Location = new System.Drawing.Point(15, 35);
            this.lblMotivo.Text = "Motivo de anulación";
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAnulacion.Controls.Add(this.lblMotivo);
            
            // txtMotivo
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Location = new System.Drawing.Point(182, 32);
            this.txtMotivo.Size = new System.Drawing.Size(600, 60);
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotivo.ReadOnly = false;
            this.txtMotivo.BackColor = System.Drawing.Color.White;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grpAnulacion.Controls.Add(this.txtMotivo);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 670);
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
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.Location = new System.Drawing.Point(710, 12);
            this.btnAutorizar.Size = new System.Drawing.Size(130, 36);
            this.btnAutorizar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnAutorizar.ForeColor = System.Drawing.Color.White;
            this.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorizar.FlatAppearance.BorderSize = 0;
            this.btnAutorizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnAutorizar);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Text = "Anular autorización";
            this.btnAnular.Location = new System.Drawing.Point(515, 12);
            this.btnAnular.Size = new System.Drawing.Size(185, 36);
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Text = "Devolver al Médico";
            this.btnDevolver.Location = new System.Drawing.Point(328, 12);
            this.btnDevolver.Size = new System.Drawing.Size(177, 36);
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
            this.ClientSize = new System.Drawing.Size(1000, 730);
            this.Text = "Autorizar Reporte clínico";
            this.Name = "FrmAutorizarReporte";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidaciones)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpReportes;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.GroupBox grpValidaciones;
        private System.Windows.Forms.DataGridView dgvValidaciones;
        private System.Windows.Forms.GroupBox grpAnulacion;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidacionesCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidacionesCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidacionesCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidacionesCol4;
    }
}
