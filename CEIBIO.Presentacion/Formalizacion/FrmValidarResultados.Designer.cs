// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Formalizacion
{
    partial class FrmValidarResultados
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
            this.dgvAnterioresCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnterioresCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnterioresCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResultadosCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblNumeroAtencion = new System.Windows.Forms.Label();
            this.txtNumeroAtencion = new System.Windows.Forms.TextBox();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.grpAnteriores = new System.Windows.Forms.GroupBox();
            this.dgvAnteriores = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnRetener = new System.Windows.Forms.Button();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnteriores)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Validar resultados clínicos";
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Size = new System.Drawing.Size(960, 42);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            
            // grpPaciente
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Location = new System.Drawing.Point(20, 70);
            this.grpPaciente.Size = new System.Drawing.Size(960, 116);
            this.grpPaciente.Text = "Paciente";
            this.grpPaciente.BackColor = System.Drawing.Color.White;
            this.grpPaciente.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpPaciente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpPaciente);
            
            // lblPaciente
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Location = new System.Drawing.Point(15, 35);
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPaciente.Controls.Add(this.lblPaciente);
            
            // txtPaciente
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Location = new System.Drawing.Point(125, 32);
            this.txtPaciente.Size = new System.Drawing.Size(300, 27);
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpPaciente.Controls.Add(this.txtPaciente);
            
            // lblSexo
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Location = new System.Drawing.Point(15, 73);
            this.lblSexo.Text = "Sexo";
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPaciente.Controls.Add(this.lblSexo);
            
            // txtSexo
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Location = new System.Drawing.Point(125, 70);
            this.txtSexo.Size = new System.Drawing.Size(100, 27);
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSexo.ReadOnly = true;
            this.txtSexo.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpPaciente.Controls.Add(this.txtSexo);
            
            // lblEdad
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Location = new System.Drawing.Point(495, 35);
            this.lblEdad.Text = "Edad";
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPaciente.Controls.Add(this.lblEdad);
            
            // txtEdad
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Location = new System.Drawing.Point(629, 32);
            this.txtEdad.Size = new System.Drawing.Size(80, 27);
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEdad.ReadOnly = true;
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpPaciente.Controls.Add(this.txtEdad);
            
            // lblNumeroAtencion
            this.lblNumeroAtencion.Name = "lblNumeroAtencion";
            this.lblNumeroAtencion.Location = new System.Drawing.Point(495, 73);
            this.lblNumeroAtencion.Text = "N.° de atención";
            this.lblNumeroAtencion.AutoSize = true;
            this.lblNumeroAtencion.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblNumeroAtencion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPaciente.Controls.Add(this.lblNumeroAtencion);
            
            // txtNumeroAtencion
            this.txtNumeroAtencion.Name = "txtNumeroAtencion";
            this.txtNumeroAtencion.Location = new System.Drawing.Point(629, 70);
            this.txtNumeroAtencion.Size = new System.Drawing.Size(120, 27);
            this.txtNumeroAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroAtencion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroAtencion.ReadOnly = true;
            this.txtNumeroAtencion.BackColor = System.Drawing.Color.FromArgb(233, 238, 243);
            this.grpPaciente.Controls.Add(this.txtNumeroAtencion);
            
            // grpResultados
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Location = new System.Drawing.Point(20, 196);
            this.grpResultados.Size = new System.Drawing.Size(960, 268);
            this.grpResultados.Text = "Resultados a validar";
            this.grpResultados.BackColor = System.Drawing.Color.White;
            this.grpResultados.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpResultados);
            
            // dgvResultados
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Location = new System.Drawing.Point(12, 30);
            this.dgvResultados.Size = new System.Drawing.Size(936, 226);
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultados.ColumnHeadersHeight = 55;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvResultados.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvResultados.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.RowTemplate.Height = 30;
            this.dgvResultados.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvResultados.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResultadosCol1.HeaderText = "Examen";
            this.dgvResultadosCol1.Name = "dgvResultadosCol1";
            this.dgvResultadosCol1.ReadOnly = true;
            this.dgvResultadosCol1.FillWeight = 100F;
            this.dgvResultadosCol2.HeaderText = "Parámetro";
            this.dgvResultadosCol2.Name = "dgvResultadosCol2";
            this.dgvResultadosCol2.ReadOnly = true;
            this.dgvResultadosCol2.FillWeight = 100F;
            this.dgvResultadosCol3.HeaderText = "Valor";
            this.dgvResultadosCol3.Name = "dgvResultadosCol3";
            this.dgvResultadosCol3.ReadOnly = true;
            this.dgvResultadosCol3.FillWeight = 100F;
            this.dgvResultadosCol4.HeaderText = "Unidad";
            this.dgvResultadosCol4.Name = "dgvResultadosCol4";
            this.dgvResultadosCol4.ReadOnly = true;
            this.dgvResultadosCol4.FillWeight = 100F;
            this.dgvResultadosCol5.HeaderText = "Intervalo de referencia";
            this.dgvResultadosCol5.Name = "dgvResultadosCol5";
            this.dgvResultadosCol5.ReadOnly = true;
            this.dgvResultadosCol5.FillWeight = 135F;
            this.dgvResultadosCol6.HeaderText = "Fuera de rango";
            this.dgvResultadosCol6.Name = "dgvResultadosCol6";
            this.dgvResultadosCol6.ReadOnly = true;
            this.dgvResultadosCol6.FillWeight = 100F;
            this.dgvResultadosCol7.HeaderText = "Estado";
            this.dgvResultadosCol7.Name = "dgvResultadosCol7";
            this.dgvResultadosCol7.ReadOnly = true;
            this.dgvResultadosCol7.FillWeight = 100F;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvResultadosCol1, this.dgvResultadosCol2, this.dgvResultadosCol3, this.dgvResultadosCol4, this.dgvResultadosCol5, this.dgvResultadosCol6, this.dgvResultadosCol7});
            this.grpResultados.Controls.Add(this.dgvResultados);
            
            // grpAnteriores
            this.grpAnteriores.Name = "grpAnteriores";
            this.grpAnteriores.Location = new System.Drawing.Point(20, 474);
            this.grpAnteriores.Size = new System.Drawing.Size(960, 148);
            this.grpAnteriores.Text = "Resultados anteriores del paciente";
            this.grpAnteriores.BackColor = System.Drawing.Color.White;
            this.grpAnteriores.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpAnteriores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpAnteriores);
            
            // dgvAnteriores
            this.dgvAnteriores.Name = "dgvAnteriores";
            this.dgvAnteriores.Location = new System.Drawing.Point(12, 30);
            this.dgvAnteriores.Size = new System.Drawing.Size(936, 106);
            this.dgvAnteriores.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnteriores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvAnteriores.ReadOnly = true;
            this.dgvAnteriores.AllowUserToAddRows = false;
            this.dgvAnteriores.AllowUserToDeleteRows = false;
            this.dgvAnteriores.MultiSelect = false;
            this.dgvAnteriores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnteriores.RowHeadersVisible = false;
            this.dgvAnteriores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnteriores.EnableHeadersVisualStyles = false;
            this.dgvAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnteriores.ColumnHeadersHeight = 36;
            this.dgvAnteriores.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvAnteriores.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAnteriores.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.dgvAnteriores.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAnteriores.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnteriores.RowTemplate.Height = 30;
            this.dgvAnteriores.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 236, 246);
            this.dgvAnteriores.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAnterioresCol1.HeaderText = "Fecha";
            this.dgvAnterioresCol1.Name = "dgvAnterioresCol1";
            this.dgvAnterioresCol1.ReadOnly = true;
            this.dgvAnterioresCol1.FillWeight = 100F;
            this.dgvAnterioresCol2.HeaderText = "Parámetro";
            this.dgvAnterioresCol2.Name = "dgvAnterioresCol2";
            this.dgvAnterioresCol2.ReadOnly = true;
            this.dgvAnterioresCol2.FillWeight = 100F;
            this.dgvAnterioresCol3.HeaderText = "Valor";
            this.dgvAnterioresCol3.Name = "dgvAnterioresCol3";
            this.dgvAnterioresCol3.ReadOnly = true;
            this.dgvAnterioresCol3.FillWeight = 100F;
            this.dgvAnteriores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvAnterioresCol1, this.dgvAnterioresCol2, this.dgvAnterioresCol3});
            this.grpAnteriores.Controls.Add(this.dgvAnteriores);
            
            // Barra de acciones
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Location = new System.Drawing.Point(0, 640);
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
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Text = "Validar";
            this.btnValidar.Location = new System.Drawing.Point(710, 12);
            this.btnValidar.Size = new System.Drawing.Size(130, 36);
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAcciones.Controls.Add(this.btnValidar);
            this.btnRetener.Name = "btnRetener";
            this.btnRetener.Text = "Retener y repetir";
            this.btnRetener.Location = new System.Drawing.Point(531, 12);
            this.btnRetener.Size = new System.Drawing.Size(169, 36);
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
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Text = "Validar resultados clínicos";
            this.Name = "FrmValidarResultados";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnteriores)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblNumeroAtencion;
        private System.Windows.Forms.TextBox txtNumeroAtencion;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox grpAnteriores;
        private System.Windows.Forms.DataGridView dgvAnteriores;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnRetener;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultadosCol7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnterioresCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnterioresCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnterioresCol3;
    }
}
