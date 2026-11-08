// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantPlantillas
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
            this.dgvRegistrosCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistrosCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistrosCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistrosCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpRegistros = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblExamenes = new System.Windows.Forms.Label();
            this.clbExamenes = new System.Windows.Forms.CheckedListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Mantenedor de plantillas de Reporte clínico";
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
            
            // lblBuscar
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Location = new System.Drawing.Point(15, 35);
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpBusqueda.Controls.Add(this.lblBuscar);
            
            // txtBuscar
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Location = new System.Drawing.Point(125, 32);
            this.txtBuscar.Size = new System.Drawing.Size(300, 27);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.grpBusqueda.Controls.Add(this.txtBuscar);
            
            // btnBuscar
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Location = new System.Drawing.Point(435, 28);
            this.btnBuscar.Size = new System.Drawing.Size(110, 34);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            
            // grpRegistros
            this.grpRegistros.Name = "grpRegistros";
            this.grpRegistros.Location = new System.Drawing.Point(20, 158);
            this.grpRegistros.Size = new System.Drawing.Size(960, 238);
            this.grpRegistros.Text = "Registros";
            this.grpRegistros.BackColor = System.Drawing.Color.White;
            this.grpRegistros.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpRegistros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpRegistros);
            
            // dgvRegistros
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Location = new System.Drawing.Point(12, 30);
            this.dgvRegistros.Size = new System.Drawing.Size(936, 196);
            this.dgvRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.MultiSelect = false;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.EnableHeadersVisualStyles = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRegistros.ColumnHeadersHeight = 36;
            this.dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRegistros.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvRegistros.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.RowTemplate.Height = 30;
            this.dgvRegistros.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvRegistros.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRegistrosCol1.HeaderText = "Nombre";
            this.dgvRegistrosCol1.Name = "dgvRegistrosCol1";
            this.dgvRegistrosCol1.ReadOnly = true;
            this.dgvRegistrosCol1.FillWeight = 100F;
            this.dgvRegistrosCol2.HeaderText = "Formato";
            this.dgvRegistrosCol2.Name = "dgvRegistrosCol2";
            this.dgvRegistrosCol2.ReadOnly = true;
            this.dgvRegistrosCol2.FillWeight = 100F;
            this.dgvRegistrosCol3.HeaderText = "Exámenes";
            this.dgvRegistrosCol3.Name = "dgvRegistrosCol3";
            this.dgvRegistrosCol3.ReadOnly = true;
            this.dgvRegistrosCol3.FillWeight = 100F;
            this.dgvRegistrosCol4.HeaderText = "Estado";
            this.dgvRegistrosCol4.Name = "dgvRegistrosCol4";
            this.dgvRegistrosCol4.ReadOnly = true;
            this.dgvRegistrosCol4.FillWeight = 100F;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvRegistrosCol1, this.dgvRegistrosCol2, this.dgvRegistrosCol3, this.dgvRegistrosCol4});
            this.grpRegistros.Controls.Add(this.dgvRegistros);
            
            // grpDatos
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Location = new System.Drawing.Point(20, 406);
            this.grpDatos.Size = new System.Drawing.Size(960, 144);
            this.grpDatos.Text = "Datos";
            this.grpDatos.BackColor = System.Drawing.Color.White;
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpDatos);
            
            // lblNombre
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Location = new System.Drawing.Point(15, 35);
            this.lblNombre.Text = "Nombre *";
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblNombre);
            
            // txtNombre
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(182, 32);
            this.txtNombre.Size = new System.Drawing.Size(280, 27);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ReadOnly = false;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.grpDatos.Controls.Add(this.txtNombre);
            
            // lblFormato
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Location = new System.Drawing.Point(15, 73);
            this.lblFormato.Text = "Formato (archivo) *";
            this.lblFormato.AutoSize = true;
            this.lblFormato.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblFormato.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblFormato);
            
            // txtFormato
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Location = new System.Drawing.Point(182, 70);
            this.txtFormato.Size = new System.Drawing.Size(163, 27);
            this.txtFormato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormato.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFormato.ReadOnly = false;
            this.txtFormato.BackColor = System.Drawing.Color.White;
            this.grpDatos.Controls.Add(this.txtFormato);
            
            // btnExaminar
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Location = new System.Drawing.Point(355, 66);
            this.btnExaminar.Size = new System.Drawing.Size(110, 34);
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.BackColor = System.Drawing.Color.White;
            this.btnExaminar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpDatos.Controls.Add(this.btnExaminar);
            
            // lblExamenes
            this.lblExamenes.Name = "lblExamenes";
            this.lblExamenes.Location = new System.Drawing.Point(495, 35);
            this.lblExamenes.Text = "Exámenes asociados";
            this.lblExamenes.AutoSize = true;
            this.lblExamenes.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblExamenes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblExamenes);
            
            // clbExamenes
            this.clbExamenes.Name = "clbExamenes";
            this.clbExamenes.Location = new System.Drawing.Point(654, 32);
            this.clbExamenes.Size = new System.Drawing.Size(280, 92);
            this.clbExamenes.CheckOnClick = true;
            this.grpDatos.Controls.Add(this.clbExamenes);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 560);
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
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(710, 12);
            this.btnCancelar.Size = new System.Drawing.Size(130, 36);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(570, 12);
            this.btnGuardar.Size = new System.Drawing.Size(130, 36);
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.Location = new System.Drawing.Point(430, 12);
            this.btnInhabilitar.Size = new System.Drawing.Size(130, 36);
            this.btnInhabilitar.BackColor = System.Drawing.Color.FromArgb(180, 35, 24);
            this.btnInhabilitar.ForeColor = System.Drawing.Color.White;
            this.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitar.FlatAppearance.BorderSize = 0;
            this.btnInhabilitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInhabilitar.UseVisualStyleBackColor = false;
            this.btnInhabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnInhabilitar);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.Location = new System.Drawing.Point(290, 12);
            this.btnEditar.Size = new System.Drawing.Size(130, 36);
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 1;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Location = new System.Drawing.Point(150, 12);
            this.btnNuevo.Size = new System.Drawing.Size(130, 36);
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.FlatAppearance.BorderSize = 1;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Text = "Mantenedor de plantillas de Reporte clínico";
            this.Name = "FrmMantPlantillas";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblExamenes;
        private System.Windows.Forms.CheckedListBox clbExamenes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol4;
    }
}
