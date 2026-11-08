// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmRevisarReporte
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
            this.dgvValidadosCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValidadosCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValidadosCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReportes = new System.Windows.Forms.GroupBox();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.grpReporteClinico = new System.Windows.Forms.GroupBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.rtbReporte = new System.Windows.Forms.RichTextBox();
            this.grpValidados = new System.Windows.Forms.GroupBox();
            this.dgvValidados = new System.Windows.Forms.DataGridView();
            this.grpObservaciones = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConformidad = new System.Windows.Forms.Button();
            this.btnObservar = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidados)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1100, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Revisar Reporte clínico";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(1060, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpReportes
            this.grpReportes.Name = "grpReportes";
            this.grpReportes.Location = new System.Drawing.Point(20, 70);
            this.grpReportes.Size = new System.Drawing.Size(1060, 168);
            this.grpReportes.Text = "Reportes en revisión de calidad";
            this.grpReportes.BackColor = System.Drawing.Color.White;
            this.grpReportes.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpReportes);
            
            // dgvReportes
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Location = new System.Drawing.Point(12, 30);
            this.dgvReportes.Size = new System.Drawing.Size(1036, 126);
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
            this.dgvReportesCol4.HeaderText = "Digitador";
            this.dgvReportesCol4.Name = "dgvReportesCol4";
            this.dgvReportesCol4.ReadOnly = true;
            this.dgvReportesCol4.FillWeight = 100F;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvReportesCol1, this.dgvReportesCol2, this.dgvReportesCol3, this.dgvReportesCol4});
            this.grpReportes.Controls.Add(this.dgvReportes);
            
            // grpReporteClinico
            this.grpReporteClinico.Name = "grpReporteClinico";
            this.grpReporteClinico.Location = new System.Drawing.Point(20, 248);
            this.grpReporteClinico.Size = new System.Drawing.Size(525, 270);
            this.grpReporteClinico.Text = "Reporte clínico";
            this.grpReporteClinico.BackColor = System.Drawing.Color.White;
            this.grpReporteClinico.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpReporteClinico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpReporteClinico);
            
            // lblReporte
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Location = new System.Drawing.Point(15, 35);
            this.lblReporte.Text = "Reporte";
            this.lblReporte.AutoSize = true;
            this.lblReporte.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblReporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpReporteClinico.Controls.Add(this.lblReporte);
            
            // rtbReporte
            this.rtbReporte.Name = "rtbReporte";
            this.rtbReporte.Location = new System.Drawing.Point(125, 32);
            this.rtbReporte.Size = new System.Drawing.Size(385, 220);
            this.rtbReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpReporteClinico.Controls.Add(this.rtbReporte);
            
            // grpValidados
            this.grpValidados.Name = "grpValidados";
            this.grpValidados.Location = new System.Drawing.Point(555, 248);
            this.grpValidados.Size = new System.Drawing.Size(525, 298);
            this.grpValidados.Text = "Resultados validados";
            this.grpValidados.BackColor = System.Drawing.Color.White;
            this.grpValidados.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpValidados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpValidados);
            
            // dgvValidados
            this.dgvValidados.Name = "dgvValidados";
            this.dgvValidados.Location = new System.Drawing.Point(12, 30);
            this.dgvValidados.Size = new System.Drawing.Size(501, 256);
            this.dgvValidados.BackgroundColor = System.Drawing.Color.White;
            this.dgvValidados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvValidados.ReadOnly = true;
            this.dgvValidados.AllowUserToAddRows = false;
            this.dgvValidados.AllowUserToDeleteRows = false;
            this.dgvValidados.MultiSelect = false;
            this.dgvValidados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValidados.RowHeadersVisible = false;
            this.dgvValidados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValidados.EnableHeadersVisualStyles = false;
            this.dgvValidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvValidados.ColumnHeadersHeight = 36;
            this.dgvValidados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvValidados.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvValidados.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvValidados.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvValidados.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValidados.RowTemplate.Height = 30;
            this.dgvValidados.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvValidados.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvValidadosCol1.HeaderText = "Parámetro";
            this.dgvValidadosCol1.Name = "dgvValidadosCol1";
            this.dgvValidadosCol1.ReadOnly = true;
            this.dgvValidadosCol1.FillWeight = 100F;
            this.dgvValidadosCol2.HeaderText = "Valor";
            this.dgvValidadosCol2.Name = "dgvValidadosCol2";
            this.dgvValidadosCol2.ReadOnly = true;
            this.dgvValidadosCol2.FillWeight = 100F;
            this.dgvValidadosCol3.HeaderText = "Unidad";
            this.dgvValidadosCol3.Name = "dgvValidadosCol3";
            this.dgvValidadosCol3.ReadOnly = true;
            this.dgvValidadosCol3.FillWeight = 100F;
            this.dgvValidados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvValidadosCol1, this.dgvValidadosCol2, this.dgvValidadosCol3});
            this.grpValidados.Controls.Add(this.dgvValidados);
            
            // grpObservaciones
            this.grpObservaciones.Name = "grpObservaciones";
            this.grpObservaciones.Location = new System.Drawing.Point(20, 556);
            this.grpObservaciones.Size = new System.Drawing.Size(1060, 112);
            this.grpObservaciones.Text = "Observaciones";
            this.grpObservaciones.BackColor = System.Drawing.Color.White;
            this.grpObservaciones.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpObservaciones);
            
            // lblObservaciones
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Location = new System.Drawing.Point(15, 35);
            this.lblObservaciones.Text = "Observaciones";
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpObservaciones.Controls.Add(this.lblObservaciones);
            
            // txtObservaciones
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Location = new System.Drawing.Point(132, 32);
            this.txtObservaciones.Size = new System.Drawing.Size(700, 60);
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservaciones.ReadOnly = false;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grpObservaciones.Controls.Add(this.txtObservaciones);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 680);
            this.pnlAcciones.Size = new System.Drawing.Size(1100, 60);
            this.pnlAcciones.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(950, 12);
            this.btnCerrar.Size = new System.Drawing.Size(130, 36);
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.btnConformidad.Name = "btnConformidad";
            this.btnConformidad.Text = "Dar conformidad";
            this.btnConformidad.Location = new System.Drawing.Point(787, 12);
            this.btnConformidad.Size = new System.Drawing.Size(153, 36);
            this.btnConformidad.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnConformidad.ForeColor = System.Drawing.Color.White;
            this.btnConformidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConformidad.FlatAppearance.BorderSize = 0;
            this.btnConformidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConformidad.UseVisualStyleBackColor = false;
            this.btnConformidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnConformidad);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Text = "Observar";
            this.btnObservar.Location = new System.Drawing.Point(647, 12);
            this.btnObservar.Size = new System.Drawing.Size(130, 36);
            this.btnObservar.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            this.btnObservar.ForeColor = System.Drawing.Color.White;
            this.btnObservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObservar.FlatAppearance.BorderSize = 0;
            this.btnObservar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnObservar.UseVisualStyleBackColor = false;
            this.btnObservar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnObservar);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Text = "Revisar Reporte clínico";
            this.Name = "FrmRevisarReporte";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidados)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpReportes;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.GroupBox grpReporteClinico;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.RichTextBox rtbReporte;
        private System.Windows.Forms.GroupBox grpValidados;
        private System.Windows.Forms.DataGridView dgvValidados;
        private System.Windows.Forms.GroupBox grpObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConformidad;
        private System.Windows.Forms.Button btnObservar;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidadosCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidadosCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValidadosCol3;
    }
}
