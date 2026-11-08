// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmConsultarReportes
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
            this.dgvReportesCol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportesCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpReportes = new System.Windows.Forms.GroupBox();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Consultar Reportes clínicos";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(960, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpFiltros
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Location = new System.Drawing.Point(20, 70);
            this.grpFiltros.Size = new System.Drawing.Size(960, 116);
            this.grpFiltros.Text = "Filtros";
            this.grpFiltros.BackColor = System.Drawing.Color.White;
            this.grpFiltros.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpFiltros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpFiltros);
            
            // lblDni
            this.lblDni.Name = "lblDni";
            this.lblDni.Location = new System.Drawing.Point(15, 35);
            this.lblDni.Text = "DNI";
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpFiltros.Controls.Add(this.lblDni);
            
            // txtDni
            this.txtDni.Name = "txtDni";
            this.txtDni.Location = new System.Drawing.Point(132, 32);
            this.txtDni.Size = new System.Drawing.Size(120, 27);
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDni.ReadOnly = false;
            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.MaxLength = 8;
            this.grpFiltros.Controls.Add(this.txtDni);
            
            // lblFechaInicio
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 73);
            this.lblFechaInicio.Text = "Fecha inicial";
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpFiltros.Controls.Add(this.lblFechaInicio);
            
            // dtpFechaInicio
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Location = new System.Drawing.Point(132, 70);
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 27);
            this.grpFiltros.Controls.Add(this.dtpFechaInicio);
            
            // lblFechaFin
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Location = new System.Drawing.Point(495, 35);
            this.lblFechaFin.Text = "Fecha final";
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpFiltros.Controls.Add(this.lblFechaFin);
            
            // dtpFechaFin
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Location = new System.Drawing.Point(605, 32);
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 27);
            this.grpFiltros.Controls.Add(this.dtpFechaFin);
            
            // lblEstado
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Location = new System.Drawing.Point(495, 73);
            this.lblEstado.Text = "Estado";
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpFiltros.Controls.Add(this.lblEstado);
            
            // cboEstado
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Location = new System.Drawing.Point(605, 70);
            this.cboEstado.Size = new System.Drawing.Size(220, 31);
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Items.AddRange(new object[] {"(Todos)", "En revisión de calidad", "Observado", "Revisado", "Pendiente de autorización", "Autorizado", "Disponible para entrega"});
            this.grpFiltros.Controls.Add(this.cboEstado);
            
            // btnBuscar
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Location = new System.Drawing.Point(835, 66);
            this.btnBuscar.Size = new System.Drawing.Size(110, 34);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            
            // grpReportes
            this.grpReportes.Name = "grpReportes";
            this.grpReportes.Location = new System.Drawing.Point(20, 196);
            this.grpReportes.Size = new System.Drawing.Size(960, 378);
            this.grpReportes.Text = "Reportes clínicos";
            this.grpReportes.BackColor = System.Drawing.Color.White;
            this.grpReportes.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpReportes);
            
            // dgvReportes
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Location = new System.Drawing.Point(12, 30);
            this.dgvReportes.Size = new System.Drawing.Size(936, 336);
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
            this.dgvReportes.ColumnHeadersHeight = 55;
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
            this.dgvReportesCol3.HeaderText = "Exámenes";
            this.dgvReportesCol3.Name = "dgvReportesCol3";
            this.dgvReportesCol3.ReadOnly = true;
            this.dgvReportesCol3.FillWeight = 100F;
            this.dgvReportesCol4.HeaderText = "Estado";
            this.dgvReportesCol4.Name = "dgvReportesCol4";
            this.dgvReportesCol4.ReadOnly = true;
            this.dgvReportesCol4.FillWeight = 100F;
            this.dgvReportesCol5.HeaderText = "Fecha de autorización";
            this.dgvReportesCol5.Name = "dgvReportesCol5";
            this.dgvReportesCol5.ReadOnly = true;
            this.dgvReportesCol5.FillWeight = 135F;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvReportesCol1, this.dgvReportesCol2, this.dgvReportesCol3, this.dgvReportesCol4, this.dgvReportesCol5});
            this.grpReportes.Controls.Add(this.dgvReportes);
            
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
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.Location = new System.Drawing.Point(710, 12);
            this.btnReimprimir.Size = new System.Drawing.Size(130, 36);
            this.btnReimprimir.BackColor = System.Drawing.Color.White;
            this.btnReimprimir.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimir.FlatAppearance.BorderSize = 1;
            this.btnReimprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnReimprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnReimprimir);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Text = "Consultar Reportes clínicos";
            this.Name = "FrmConsultarReportes";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpReportes;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportesCol5;
    }
}
