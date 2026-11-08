// Este formulario se puede editar en el diseñador de Windows Forms.
// Los controles se crean mediante instrucciones individuales compatibles con el diseñador.
namespace CEIBIO.Presentacion.Mantenedores
{
    partial class FrmMantIntervalos
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
            this.dgvRegistrosCol7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistrosCol6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegistrosCol5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblExamen = new System.Windows.Forms.Label();
            this.cboExamen = new System.Windows.Forms.ComboBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.cboParametro = new System.Windows.Forms.ComboBox();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.nudMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.nudMaximo = new System.Windows.Forms.NumericUpDown();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblEdadMinima = new System.Windows.Forms.Label();
            this.nudEdadMinima = new System.Windows.Forms.NumericUpDown();
            this.lblEdadMaxima = new System.Windows.Forms.Label();
            this.nudEdadMaxima = new System.Windows.Forms.NumericUpDown();
            this.lblReferenciaTexto = new System.Windows.Forms.Label();
            this.txtReferenciaTexto = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadMaxima)).BeginInit();
            
            // Encabezado del formulario
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 56);
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Mantenedor de intervalos biológicos de referencia";
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
            this.dgvRegistrosCol1.HeaderText = "Parámetro";
            this.dgvRegistrosCol1.Name = "dgvRegistrosCol1";
            this.dgvRegistrosCol1.ReadOnly = true;
            this.dgvRegistrosCol1.FillWeight = 100F;
            this.dgvRegistrosCol2.HeaderText = "Mínimo";
            this.dgvRegistrosCol2.Name = "dgvRegistrosCol2";
            this.dgvRegistrosCol2.ReadOnly = true;
            this.dgvRegistrosCol2.FillWeight = 100F;
            this.dgvRegistrosCol3.HeaderText = "Máximo";
            this.dgvRegistrosCol3.Name = "dgvRegistrosCol3";
            this.dgvRegistrosCol3.ReadOnly = true;
            this.dgvRegistrosCol3.FillWeight = 100F;
            this.dgvRegistrosCol4.HeaderText = "Sexo";
            this.dgvRegistrosCol4.Name = "dgvRegistrosCol4";
            this.dgvRegistrosCol4.ReadOnly = true;
            this.dgvRegistrosCol4.FillWeight = 100F;
            this.dgvRegistrosCol5.HeaderText = "Edad";
            this.dgvRegistrosCol5.Name = "dgvRegistrosCol5";
            this.dgvRegistrosCol5.ReadOnly = true;
            this.dgvRegistrosCol5.FillWeight = 100F;
            this.dgvRegistrosCol6.HeaderText = "Referencia";
            this.dgvRegistrosCol6.Name = "dgvRegistrosCol6";
            this.dgvRegistrosCol6.ReadOnly = true;
            this.dgvRegistrosCol6.FillWeight = 100F;
            this.dgvRegistrosCol7.HeaderText = "Estado";
            this.dgvRegistrosCol7.Name = "dgvRegistrosCol7";
            this.dgvRegistrosCol7.ReadOnly = true;
            this.dgvRegistrosCol7.FillWeight = 100F;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgvRegistrosCol1, this.dgvRegistrosCol2, this.dgvRegistrosCol3, this.dgvRegistrosCol4, this.dgvRegistrosCol5, this.dgvRegistrosCol6, this.dgvRegistrosCol7});
            this.grpRegistros.Controls.Add(this.dgvRegistros);
            
            // grpDatos
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Location = new System.Drawing.Point(20, 406);
            this.grpDatos.Size = new System.Drawing.Size(960, 192);
            this.grpDatos.Text = "Datos";
            this.grpDatos.BackColor = System.Drawing.Color.White;
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(11, 61, 110);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpDatos);
            
            // lblExamen
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Location = new System.Drawing.Point(15, 35);
            this.lblExamen.Text = "Examen *";
            this.lblExamen.AutoSize = true;
            this.lblExamen.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblExamen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblExamen);
            
            // cboExamen
            this.cboExamen.Name = "cboExamen";
            this.cboExamen.Location = new System.Drawing.Point(125, 32);
            this.cboExamen.Size = new System.Drawing.Size(240, 31);
            this.cboExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamen.Items.AddRange(new object[] {"exámenes"});
            this.grpDatos.Controls.Add(this.cboExamen);
            
            // lblParametro
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Location = new System.Drawing.Point(15, 73);
            this.lblParametro.Text = "Parámetro *";
            this.lblParametro.AutoSize = true;
            this.lblParametro.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblParametro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblParametro);
            
            // cboParametro
            this.cboParametro.Name = "cboParametro";
            this.cboParametro.Location = new System.Drawing.Point(125, 70);
            this.cboParametro.Size = new System.Drawing.Size(240, 31);
            this.cboParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParametro.Items.AddRange(new object[] {"parámetros del examen"});
            this.grpDatos.Controls.Add(this.cboParametro);
            
            // lblMinimo
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Location = new System.Drawing.Point(15, 111);
            this.lblMinimo.Text = "Valor mínimo";
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblMinimo);
            
            // nudMinimo
            this.nudMinimo.Name = "nudMinimo";
            this.nudMinimo.Location = new System.Drawing.Point(125, 108);
            this.nudMinimo.Size = new System.Drawing.Size(100, 27);
            this.nudMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudMinimo.DecimalPlaces = 2;
            this.grpDatos.Controls.Add(this.nudMinimo);
            
            // lblMaximo
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Location = new System.Drawing.Point(15, 149);
            this.lblMaximo.Text = "Valor máximo";
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblMaximo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblMaximo);
            
            // nudMaximo
            this.nudMaximo.Name = "nudMaximo";
            this.nudMaximo.Location = new System.Drawing.Point(125, 146);
            this.nudMaximo.Size = new System.Drawing.Size(100, 27);
            this.nudMaximo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudMaximo.DecimalPlaces = 2;
            this.grpDatos.Controls.Add(this.nudMaximo);
            
            // lblSexo
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Location = new System.Drawing.Point(495, 35);
            this.lblSexo.Text = "Sexo";
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblSexo);
            
            // cboSexo
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Location = new System.Drawing.Point(662, 32);
            this.cboSexo.Size = new System.Drawing.Size(150, 31);
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Items.AddRange(new object[] {"Ambos", "Femenino", "Masculino"});
            this.grpDatos.Controls.Add(this.cboSexo);
            
            // lblEdadMinima
            this.lblEdadMinima.Name = "lblEdadMinima";
            this.lblEdadMinima.Location = new System.Drawing.Point(495, 73);
            this.lblEdadMinima.Text = "Edad mínima";
            this.lblEdadMinima.AutoSize = true;
            this.lblEdadMinima.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblEdadMinima.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblEdadMinima);
            
            // nudEdadMinima
            this.nudEdadMinima.Name = "nudEdadMinima";
            this.nudEdadMinima.Location = new System.Drawing.Point(662, 70);
            this.nudEdadMinima.Size = new System.Drawing.Size(80, 27);
            this.nudEdadMinima.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.grpDatos.Controls.Add(this.nudEdadMinima);
            
            // lblEdadMaxima
            this.lblEdadMaxima.Name = "lblEdadMaxima";
            this.lblEdadMaxima.Location = new System.Drawing.Point(495, 111);
            this.lblEdadMaxima.Text = "Edad máxima";
            this.lblEdadMaxima.AutoSize = true;
            this.lblEdadMaxima.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblEdadMaxima.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblEdadMaxima);
            
            // nudEdadMaxima
            this.nudEdadMaxima.Name = "nudEdadMaxima";
            this.nudEdadMaxima.Location = new System.Drawing.Point(662, 108);
            this.nudEdadMaxima.Size = new System.Drawing.Size(80, 27);
            this.nudEdadMaxima.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.grpDatos.Controls.Add(this.nudEdadMaxima);
            
            // lblReferenciaTexto
            this.lblReferenciaTexto.Name = "lblReferenciaTexto";
            this.lblReferenciaTexto.Location = new System.Drawing.Point(495, 149);
            this.lblReferenciaTexto.Text = "Referencia en texto";
            this.lblReferenciaTexto.AutoSize = true;
            this.lblReferenciaTexto.ForeColor = System.Drawing.Color.FromArgb(31, 35, 40);
            this.lblReferenciaTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDatos.Controls.Add(this.lblReferenciaTexto);
            
            // txtReferenciaTexto
            this.txtReferenciaTexto.Name = "txtReferenciaTexto";
            this.txtReferenciaTexto.Location = new System.Drawing.Point(662, 146);
            this.txtReferenciaTexto.Size = new System.Drawing.Size(240, 27);
            this.txtReferenciaTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferenciaTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReferenciaTexto.ReadOnly = false;
            this.txtReferenciaTexto.BackColor = System.Drawing.Color.White;
            this.grpDatos.Controls.Add(this.txtReferenciaTexto);
            
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
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Text = "Mantenedor de intervalos biológicos de referencia";
            this.Name = "FrmMantIntervalos";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlAcciones);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadMaxima)).EndInit();
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
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.ComboBox cboExamen;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.ComboBox cboParametro;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.NumericUpDown nudMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.NumericUpDown nudMaximo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblEdadMinima;
        private System.Windows.Forms.NumericUpDown nudEdadMinima;
        private System.Windows.Forms.Label lblEdadMaxima;
        private System.Windows.Forms.NumericUpDown nudEdadMaxima;
        private System.Windows.Forms.Label lblReferenciaTexto;
        private System.Windows.Forms.TextBox txtReferenciaTexto;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegistrosCol7;
    }
}
