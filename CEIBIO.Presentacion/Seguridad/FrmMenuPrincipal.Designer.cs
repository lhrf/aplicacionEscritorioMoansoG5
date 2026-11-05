namespace CEIBIO.Presentacion.Seguridad
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuPrincipal = new MenuStrip();
            mnuAdmision = new ToolStripMenuItem();
            mnuItemRegistrarAtencion = new ToolStripMenuItem();
            mnuItemBuscarFichaClinica = new ToolStripMenuItem();
            mnuItemProgramarVisita = new ToolStripMenuItem();
            mnuItemConsultarAtenciones = new ToolStripMenuItem();
            mnuItemConsultarVisitas = new ToolStripMenuItem();
            mnuEvaluacion = new ToolStripMenuItem();
            mnuItemRegistrarObservaciones = new ToolStripMenuItem();
            mnuItemResultadoDeLaEvaluacion = new ToolStripMenuItem();
            mnuItemConsultarSuspendidas = new ToolStripMenuItem();
            mnuCaja = new ToolStripMenuItem();
            mnuItemRegistrarPago = new ToolStripMenuItem();
            mnuItemAutorizarTransferencias = new ToolStripMenuItem();
            mnuItemEmitirComprobante = new ToolStripMenuItem();
            mnuItemDerivarAtencion = new ToolStripMenuItem();
            mnuItemMisVisitasAsignadas = new ToolStripMenuItem();
            mnuItemConsultarTransferencias = new ToolStripMenuItem();
            mnuItemConsultarRecaudacion = new ToolStripMenuItem();
            mnuItemConsultarComprobantes = new ToolStripMenuItem();
            mnuMuestras = new ToolStripMenuItem();
            mnuItemAsignarBox = new ToolStripMenuItem();
            mnuItemTomaDeMuestraEnSede = new ToolStripMenuItem();
            mnuItemTomaDeMuestraADomicilio = new ToolStripMenuItem();
            mnuItemAcondicionarMuestra = new ToolStripMenuItem();
            mnuItemRecepcionDeMuestras = new ToolStripMenuItem();
            mnuItemConsultarRechazadas = new ToolStripMenuItem();
            mnuItemConsultarTransito = new ToolStripMenuItem();
            mnuItemPendientesDeAcondicionar = new ToolStripMenuItem();
            mnuAnalisis = new ToolStripMenuItem();
            mnuItemRegistrarResultados = new ToolStripMenuItem();
            mnuItemPendientesDeValidacion = new ToolStripMenuItem();
            mnuItemUsoDelEquipo = new ToolStripMenuItem();
            mnuItemConsultarBitacora = new ToolStripMenuItem();
            mnuReportes = new ToolStripMenuItem();
            mnuItemValidarResultados = new ToolStripMenuItem();
            mnuItemRepetirAnalisis = new ToolStripMenuItem();
            mnuItemElaborarReporte = new ToolStripMenuItem();
            mnuItemRevisarReporte = new ToolStripMenuItem();
            mnuItemAutorizarReporte = new ToolStripMenuItem();
            mnuItemConsultarReportes = new ToolStripMenuItem();
            mnuItemHistorialDeRevisiones = new ToolStripMenuItem();
            mnuEntregas = new ToolStripMenuItem();
            mnuItemRegistrarEntrega = new ToolStripMenuItem();
            mnuItemCerrarAtencion = new ToolStripMenuItem();
            mnuItemPendientesDeEntrega = new ToolStripMenuItem();
            mnuItemConsultarEntregas = new ToolStripMenuItem();
            mnuMantenedores = new ToolStripMenuItem();
            mnuItemExamenes = new ToolStripMenuItem();
            mnuItemConvenios = new ToolStripMenuItem();
            mnuItemCondicionesPreanaliticas = new ToolStripMenuItem();
            mnuItemMediosDePago = new ToolStripMenuItem();
            mnuItemTubosYRecipientes = new ToolStripMenuItem();
            mnuItemBoxesDeExtraccion = new ToolStripMenuItem();
            mnuItemEquipos = new ToolStripMenuItem();
            mnuItemParametros = new ToolStripMenuItem();
            mnuItemPlantillas = new ToolStripMenuItem();
            mnuItemIntervalosDeReferencia = new ToolStripMenuItem();
            mnuItemUsuarios = new ToolStripMenuItem();
            mnuSesion = new ToolStripMenuItem();
            mnuItemCambiarClave = new ToolStripMenuItem();
            mnuItemCerrarSesion = new ToolStripMenuItem();
            pnlBienvenida = new Panel();
            lblBienvenida = new Label();
            lblRol = new Label();
            stsEstado = new StatusStrip();
            tslUsuario = new ToolStripStatusLabel();
            tslRol = new ToolStripStatusLabel();
            tslFecha = new ToolStripStatusLabel();
            mnuPrincipal.SuspendLayout();
            pnlBienvenida.SuspendLayout();
            stsEstado.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.BackColor = Color.FromArgb(11, 61, 110);
            mnuPrincipal.Dock = DockStyle.Top;
            mnuPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mnuPrincipal.ForeColor = Color.White;
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuAdmision, mnuEvaluacion, mnuCaja, mnuMuestras, mnuAnalisis, mnuReportes, mnuEntregas, mnuMantenedores, mnuSesion });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Padding = new Padding(8, 4, 0, 4);
            mnuPrincipal.RenderMode = ToolStripRenderMode.System;
            mnuPrincipal.Size = new Size(1200, 31);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "mnuPrincipal";
            // 
            // mnuAdmision
            // 
            mnuAdmision.DropDownItems.AddRange(new ToolStripItem[] { mnuItemRegistrarAtencion, mnuItemBuscarFichaClinica, mnuItemProgramarVisita, mnuItemConsultarAtenciones, mnuItemConsultarVisitas });
            mnuAdmision.ForeColor = Color.White;
            mnuAdmision.Name = "mnuAdmision";
            mnuAdmision.Size = new Size(70, 23);
            mnuAdmision.Text = "Admisión";
            // 
            // mnuItemRegistrarAtencion
            // 
            mnuItemRegistrarAtencion.Font = new Font("Segoe UI", 10F);
            mnuItemRegistrarAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRegistrarAtencion.Name = "mnuItemRegistrarAtencion";
            mnuItemRegistrarAtencion.Size = new Size(186, 24);
            mnuItemRegistrarAtencion.Text = "Registrar atención";
            // 
            // mnuItemBuscarFichaClinica
            // 
            mnuItemBuscarFichaClinica.Font = new Font("Segoe UI", 10F);
            mnuItemBuscarFichaClinica.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemBuscarFichaClinica.Name = "mnuItemBuscarFichaClinica";
            mnuItemBuscarFichaClinica.Size = new Size(186, 24);
            mnuItemBuscarFichaClinica.Text = "Buscar Ficha clínica";
            // 
            // mnuItemProgramarVisita
            // 
            mnuItemProgramarVisita.Font = new Font("Segoe UI", 10F);
            mnuItemProgramarVisita.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemProgramarVisita.Name = "mnuItemProgramarVisita";
            mnuItemProgramarVisita.Size = new Size(186, 24);
            mnuItemProgramarVisita.Text = "Programar visita";
            // 
            // mnuItemConsultarAtenciones
            // 
            mnuItemConsultarAtenciones.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarAtenciones.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarAtenciones.Name = "mnuItemConsultarAtenciones";
            mnuItemConsultarAtenciones.Size = new Size(186, 24);
            mnuItemConsultarAtenciones.Text = "Consultar atenciones";
            // 
            // mnuItemConsultarVisitas
            // 
            mnuItemConsultarVisitas.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarVisitas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarVisitas.Name = "mnuItemConsultarVisitas";
            mnuItemConsultarVisitas.Size = new Size(186, 24);
            mnuItemConsultarVisitas.Text = "Consultar visitas";
            // 
            // mnuEvaluacion
            // 
            mnuEvaluacion.DropDownItems.AddRange(new ToolStripItem[] { mnuItemRegistrarObservaciones, mnuItemResultadoDeLaEvaluacion, mnuItemConsultarSuspendidas });
            mnuEvaluacion.ForeColor = Color.White;
            mnuEvaluacion.Name = "mnuEvaluacion";
            mnuEvaluacion.Size = new Size(80, 23);
            mnuEvaluacion.Text = "Evaluación";
            // 
            // mnuItemRegistrarObservaciones
            // 
            mnuItemRegistrarObservaciones.Font = new Font("Segoe UI", 10F);
            mnuItemRegistrarObservaciones.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRegistrarObservaciones.Name = "mnuItemRegistrarObservaciones";
            mnuItemRegistrarObservaciones.Size = new Size(218, 24);
            mnuItemRegistrarObservaciones.Text = "Registrar observaciones";
            // 
            // mnuItemResultadoDeLaEvaluacion
            // 
            mnuItemResultadoDeLaEvaluacion.Font = new Font("Segoe UI", 10F);
            mnuItemResultadoDeLaEvaluacion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemResultadoDeLaEvaluacion.Name = "mnuItemResultadoDeLaEvaluacion";
            mnuItemResultadoDeLaEvaluacion.Size = new Size(218, 24);
            mnuItemResultadoDeLaEvaluacion.Text = "Resultado de la evaluación";
            // 
            // mnuItemConsultarSuspendidas
            // 
            mnuItemConsultarSuspendidas.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarSuspendidas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarSuspendidas.Name = "mnuItemConsultarSuspendidas";
            mnuItemConsultarSuspendidas.Size = new Size(218, 24);
            mnuItemConsultarSuspendidas.Text = "Consultar suspendidas";
            // 
            // mnuCaja
            // 
            mnuCaja.DropDownItems.AddRange(new ToolStripItem[] { mnuItemRegistrarPago, mnuItemAutorizarTransferencias, mnuItemEmitirComprobante, mnuItemDerivarAtencion, mnuItemMisVisitasAsignadas, mnuItemConsultarTransferencias, mnuItemConsultarRecaudacion, mnuItemConsultarComprobantes });
            mnuCaja.ForeColor = Color.White;
            mnuCaja.Name = "mnuCaja";
            mnuCaja.Size = new Size(39, 23);
            mnuCaja.Text = "Caja";
            // 
            // mnuItemRegistrarPago
            // 
            mnuItemRegistrarPago.Font = new Font("Segoe UI", 10F);
            mnuItemRegistrarPago.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRegistrarPago.Name = "mnuItemRegistrarPago";
            mnuItemRegistrarPago.Size = new Size(207, 24);
            mnuItemRegistrarPago.Text = "Registrar pago";
            // 
            // mnuItemAutorizarTransferencias
            // 
            mnuItemAutorizarTransferencias.Font = new Font("Segoe UI", 10F);
            mnuItemAutorizarTransferencias.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemAutorizarTransferencias.Name = "mnuItemAutorizarTransferencias";
            mnuItemAutorizarTransferencias.Size = new Size(207, 24);
            mnuItemAutorizarTransferencias.Text = "Autorizar transferencias";
            // 
            // mnuItemEmitirComprobante
            // 
            mnuItemEmitirComprobante.Font = new Font("Segoe UI", 10F);
            mnuItemEmitirComprobante.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemEmitirComprobante.Name = "mnuItemEmitirComprobante";
            mnuItemEmitirComprobante.Size = new Size(207, 24);
            mnuItemEmitirComprobante.Text = "Emitir comprobante";
            // 
            // mnuItemDerivarAtencion
            // 
            mnuItemDerivarAtencion.Font = new Font("Segoe UI", 10F);
            mnuItemDerivarAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemDerivarAtencion.Name = "mnuItemDerivarAtencion";
            mnuItemDerivarAtencion.Size = new Size(207, 24);
            mnuItemDerivarAtencion.Text = "Derivar atención";
            // 
            // mnuItemMisVisitasAsignadas
            // 
            mnuItemMisVisitasAsignadas.Font = new Font("Segoe UI", 10F);
            mnuItemMisVisitasAsignadas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemMisVisitasAsignadas.Name = "mnuItemMisVisitasAsignadas";
            mnuItemMisVisitasAsignadas.Size = new Size(207, 24);
            mnuItemMisVisitasAsignadas.Text = "Mis visitas asignadas";
            // 
            // mnuItemConsultarTransferencias
            // 
            mnuItemConsultarTransferencias.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarTransferencias.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarTransferencias.Name = "mnuItemConsultarTransferencias";
            mnuItemConsultarTransferencias.Size = new Size(207, 24);
            mnuItemConsultarTransferencias.Text = "Consultar transferencias";
            // 
            // mnuItemConsultarRecaudacion
            // 
            mnuItemConsultarRecaudacion.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarRecaudacion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarRecaudacion.Name = "mnuItemConsultarRecaudacion";
            mnuItemConsultarRecaudacion.Size = new Size(207, 24);
            mnuItemConsultarRecaudacion.Text = "Consultar recaudación";
            // 
            // mnuItemConsultarComprobantes
            // 
            mnuItemConsultarComprobantes.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarComprobantes.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarComprobantes.Name = "mnuItemConsultarComprobantes";
            mnuItemConsultarComprobantes.Size = new Size(207, 24);
            mnuItemConsultarComprobantes.Text = "Consultar comprobantes";
            // 
            // mnuMuestras
            // 
            mnuMuestras.DropDownItems.AddRange(new ToolStripItem[] { mnuItemAsignarBox, mnuItemTomaDeMuestraEnSede, mnuItemTomaDeMuestraADomicilio, mnuItemAcondicionarMuestra, mnuItemRecepcionDeMuestras, mnuItemConsultarRechazadas, mnuItemConsultarTransito, mnuItemPendientesDeAcondicionar });
            mnuMuestras.ForeColor = Color.White;
            mnuMuestras.Name = "mnuMuestras";
            mnuMuestras.Size = new Size(71, 23);
            mnuMuestras.Text = "Muestras";
            // 
            // mnuItemAsignarBox
            // 
            mnuItemAsignarBox.Font = new Font("Segoe UI", 10F);
            mnuItemAsignarBox.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemAsignarBox.Name = "mnuItemAsignarBox";
            mnuItemAsignarBox.Size = new Size(233, 24);
            mnuItemAsignarBox.Text = "Asignar box";
            // 
            // mnuItemTomaDeMuestraEnSede
            // 
            mnuItemTomaDeMuestraEnSede.Font = new Font("Segoe UI", 10F);
            mnuItemTomaDeMuestraEnSede.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemTomaDeMuestraEnSede.Name = "mnuItemTomaDeMuestraEnSede";
            mnuItemTomaDeMuestraEnSede.Size = new Size(233, 24);
            mnuItemTomaDeMuestraEnSede.Text = "Toma de muestra en sede";
            // 
            // mnuItemTomaDeMuestraADomicilio
            // 
            mnuItemTomaDeMuestraADomicilio.Font = new Font("Segoe UI", 10F);
            mnuItemTomaDeMuestraADomicilio.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemTomaDeMuestraADomicilio.Name = "mnuItemTomaDeMuestraADomicilio";
            mnuItemTomaDeMuestraADomicilio.Size = new Size(233, 24);
            mnuItemTomaDeMuestraADomicilio.Text = "Toma de muestra a domicilio";
            // 
            // mnuItemAcondicionarMuestra
            // 
            mnuItemAcondicionarMuestra.Font = new Font("Segoe UI", 10F);
            mnuItemAcondicionarMuestra.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemAcondicionarMuestra.Name = "mnuItemAcondicionarMuestra";
            mnuItemAcondicionarMuestra.Size = new Size(233, 24);
            mnuItemAcondicionarMuestra.Text = "Acondicionar muestra";
            // 
            // mnuItemRecepcionDeMuestras
            // 
            mnuItemRecepcionDeMuestras.Font = new Font("Segoe UI", 10F);
            mnuItemRecepcionDeMuestras.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRecepcionDeMuestras.Name = "mnuItemRecepcionDeMuestras";
            mnuItemRecepcionDeMuestras.Size = new Size(233, 24);
            mnuItemRecepcionDeMuestras.Text = "Recepción de muestras";
            // 
            // mnuItemConsultarRechazadas
            // 
            mnuItemConsultarRechazadas.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarRechazadas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarRechazadas.Name = "mnuItemConsultarRechazadas";
            mnuItemConsultarRechazadas.Size = new Size(233, 24);
            mnuItemConsultarRechazadas.Text = "Consultar rechazadas";
            // 
            // mnuItemConsultarTransito
            // 
            mnuItemConsultarTransito.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarTransito.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarTransito.Name = "mnuItemConsultarTransito";
            mnuItemConsultarTransito.Size = new Size(233, 24);
            mnuItemConsultarTransito.Text = "Consultar tránsito";
            // 
            // mnuItemPendientesDeAcondicionar
            // 
            mnuItemPendientesDeAcondicionar.Font = new Font("Segoe UI", 10F);
            mnuItemPendientesDeAcondicionar.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemPendientesDeAcondicionar.Name = "mnuItemPendientesDeAcondicionar";
            mnuItemPendientesDeAcondicionar.Size = new Size(233, 24);
            mnuItemPendientesDeAcondicionar.Text = "Pendientes de acondicionar";
            // 
            // mnuAnalisis
            // 
            mnuAnalisis.DropDownItems.AddRange(new ToolStripItem[] { mnuItemRegistrarResultados, mnuItemPendientesDeValidacion, mnuItemUsoDelEquipo, mnuItemConsultarBitacora });
            mnuAnalisis.ForeColor = Color.White;
            mnuAnalisis.Name = "mnuAnalisis";
            mnuAnalisis.Size = new Size(61, 23);
            mnuAnalisis.Text = "Análisis";
            // 
            // mnuItemRegistrarResultados
            // 
            mnuItemRegistrarResultados.Font = new Font("Segoe UI", 10F);
            mnuItemRegistrarResultados.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRegistrarResultados.Name = "mnuItemRegistrarResultados";
            mnuItemRegistrarResultados.Size = new Size(208, 24);
            mnuItemRegistrarResultados.Text = "Registrar resultados";
            // 
            // mnuItemPendientesDeValidacion
            // 
            mnuItemPendientesDeValidacion.Font = new Font("Segoe UI", 10F);
            mnuItemPendientesDeValidacion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemPendientesDeValidacion.Name = "mnuItemPendientesDeValidacion";
            mnuItemPendientesDeValidacion.Size = new Size(208, 24);
            mnuItemPendientesDeValidacion.Text = "Pendientes de validación";
            // 
            // mnuItemUsoDelEquipo
            // 
            mnuItemUsoDelEquipo.Font = new Font("Segoe UI", 10F);
            mnuItemUsoDelEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemUsoDelEquipo.Name = "mnuItemUsoDelEquipo";
            mnuItemUsoDelEquipo.Size = new Size(208, 24);
            mnuItemUsoDelEquipo.Text = "Uso del equipo";
            // 
            // mnuItemConsultarBitacora
            // 
            mnuItemConsultarBitacora.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarBitacora.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarBitacora.Name = "mnuItemConsultarBitacora";
            mnuItemConsultarBitacora.Size = new Size(208, 24);
            mnuItemConsultarBitacora.Text = "Consultar bitácora";
            // 
            // mnuReportes
            // 
            mnuReportes.DropDownItems.AddRange(new ToolStripItem[] { mnuItemValidarResultados, mnuItemRepetirAnalisis, mnuItemElaborarReporte, mnuItemRevisarReporte, mnuItemAutorizarReporte, mnuItemConsultarReportes, mnuItemHistorialDeRevisiones });
            mnuReportes.ForeColor = Color.White;
            mnuReportes.Name = "mnuReportes";
            mnuReportes.Size = new Size(68, 23);
            mnuReportes.Text = "Reportes";
            // 
            // mnuItemValidarResultados
            // 
            mnuItemValidarResultados.Font = new Font("Segoe UI", 10F);
            mnuItemValidarResultados.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemValidarResultados.Name = "mnuItemValidarResultados";
            mnuItemValidarResultados.Size = new Size(193, 24);
            mnuItemValidarResultados.Text = "Validar resultados";
            // 
            // mnuItemRepetirAnalisis
            // 
            mnuItemRepetirAnalisis.Font = new Font("Segoe UI", 10F);
            mnuItemRepetirAnalisis.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRepetirAnalisis.Name = "mnuItemRepetirAnalisis";
            mnuItemRepetirAnalisis.Size = new Size(193, 24);
            mnuItemRepetirAnalisis.Text = "Repetir análisis";
            // 
            // mnuItemElaborarReporte
            // 
            mnuItemElaborarReporte.Font = new Font("Segoe UI", 10F);
            mnuItemElaborarReporte.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemElaborarReporte.Name = "mnuItemElaborarReporte";
            mnuItemElaborarReporte.Size = new Size(193, 24);
            mnuItemElaborarReporte.Text = "Elaborar reporte";
            // 
            // mnuItemRevisarReporte
            // 
            mnuItemRevisarReporte.Font = new Font("Segoe UI", 10F);
            mnuItemRevisarReporte.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRevisarReporte.Name = "mnuItemRevisarReporte";
            mnuItemRevisarReporte.Size = new Size(193, 24);
            mnuItemRevisarReporte.Text = "Revisar reporte";
            // 
            // mnuItemAutorizarReporte
            // 
            mnuItemAutorizarReporte.Font = new Font("Segoe UI", 10F);
            mnuItemAutorizarReporte.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemAutorizarReporte.Name = "mnuItemAutorizarReporte";
            mnuItemAutorizarReporte.Size = new Size(193, 24);
            mnuItemAutorizarReporte.Text = "Autorizar reporte";
            // 
            // mnuItemConsultarReportes
            // 
            mnuItemConsultarReportes.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarReportes.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarReportes.Name = "mnuItemConsultarReportes";
            mnuItemConsultarReportes.Size = new Size(193, 24);
            mnuItemConsultarReportes.Text = "Consultar reportes";
            // 
            // mnuItemHistorialDeRevisiones
            // 
            mnuItemHistorialDeRevisiones.Font = new Font("Segoe UI", 10F);
            mnuItemHistorialDeRevisiones.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemHistorialDeRevisiones.Name = "mnuItemHistorialDeRevisiones";
            mnuItemHistorialDeRevisiones.Size = new Size(193, 24);
            mnuItemHistorialDeRevisiones.Text = "Historial de revisiones";
            // 
            // mnuEntregas
            // 
            mnuEntregas.DropDownItems.AddRange(new ToolStripItem[] { mnuItemRegistrarEntrega, mnuItemCerrarAtencion, mnuItemPendientesDeEntrega, mnuItemConsultarEntregas });
            mnuEntregas.ForeColor = Color.White;
            mnuEntregas.Name = "mnuEntregas";
            mnuEntregas.Size = new Size(68, 23);
            mnuEntregas.Text = "Entregas";
            // 
            // mnuItemRegistrarEntrega
            // 
            mnuItemRegistrarEntrega.Font = new Font("Segoe UI", 10F);
            mnuItemRegistrarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemRegistrarEntrega.Name = "mnuItemRegistrarEntrega";
            mnuItemRegistrarEntrega.Size = new Size(193, 24);
            mnuItemRegistrarEntrega.Text = "Registrar entrega";
            // 
            // mnuItemCerrarAtencion
            // 
            mnuItemCerrarAtencion.Font = new Font("Segoe UI", 10F);
            mnuItemCerrarAtencion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemCerrarAtencion.Name = "mnuItemCerrarAtencion";
            mnuItemCerrarAtencion.Size = new Size(193, 24);
            mnuItemCerrarAtencion.Text = "Cerrar atención";
            // 
            // mnuItemPendientesDeEntrega
            // 
            mnuItemPendientesDeEntrega.Font = new Font("Segoe UI", 10F);
            mnuItemPendientesDeEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemPendientesDeEntrega.Name = "mnuItemPendientesDeEntrega";
            mnuItemPendientesDeEntrega.Size = new Size(193, 24);
            mnuItemPendientesDeEntrega.Text = "Pendientes de entrega";
            // 
            // mnuItemConsultarEntregas
            // 
            mnuItemConsultarEntregas.Font = new Font("Segoe UI", 10F);
            mnuItemConsultarEntregas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConsultarEntregas.Name = "mnuItemConsultarEntregas";
            mnuItemConsultarEntregas.Size = new Size(193, 24);
            mnuItemConsultarEntregas.Text = "Consultar entregas";
            // 
            // mnuMantenedores
            // 
            mnuMantenedores.DropDownItems.AddRange(new ToolStripItem[] { mnuItemExamenes, mnuItemConvenios, mnuItemCondicionesPreanaliticas, mnuItemMediosDePago, mnuItemTubosYRecipientes, mnuItemBoxesDeExtraccion, mnuItemEquipos, mnuItemParametros, mnuItemPlantillas, mnuItemIntervalosDeReferencia, mnuItemUsuarios });
            mnuMantenedores.ForeColor = Color.White;
            mnuMantenedores.Name = "mnuMantenedores";
            mnuMantenedores.Size = new Size(101, 23);
            mnuMantenedores.Text = "Mantenedores";
            // 
            // mnuItemExamenes
            // 
            mnuItemExamenes.Font = new Font("Segoe UI", 10F);
            mnuItemExamenes.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemExamenes.Name = "mnuItemExamenes";
            mnuItemExamenes.Size = new Size(216, 24);
            mnuItemExamenes.Text = "Exámenes";
            // 
            // mnuItemConvenios
            // 
            mnuItemConvenios.Font = new Font("Segoe UI", 10F);
            mnuItemConvenios.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemConvenios.Name = "mnuItemConvenios";
            mnuItemConvenios.Size = new Size(216, 24);
            mnuItemConvenios.Text = "Convenios";
            // 
            // mnuItemCondicionesPreanaliticas
            // 
            mnuItemCondicionesPreanaliticas.Font = new Font("Segoe UI", 10F);
            mnuItemCondicionesPreanaliticas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemCondicionesPreanaliticas.Name = "mnuItemCondicionesPreanaliticas";
            mnuItemCondicionesPreanaliticas.Size = new Size(216, 24);
            mnuItemCondicionesPreanaliticas.Text = "Condiciones preanalíticas";
            // 
            // mnuItemMediosDePago
            // 
            mnuItemMediosDePago.Font = new Font("Segoe UI", 10F);
            mnuItemMediosDePago.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemMediosDePago.Name = "mnuItemMediosDePago";
            mnuItemMediosDePago.Size = new Size(216, 24);
            mnuItemMediosDePago.Text = "Medios de pago";
            // 
            // mnuItemTubosYRecipientes
            // 
            mnuItemTubosYRecipientes.Font = new Font("Segoe UI", 10F);
            mnuItemTubosYRecipientes.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemTubosYRecipientes.Name = "mnuItemTubosYRecipientes";
            mnuItemTubosYRecipientes.Size = new Size(216, 24);
            mnuItemTubosYRecipientes.Text = "Tubos y recipientes";
            // 
            // mnuItemBoxesDeExtraccion
            // 
            mnuItemBoxesDeExtraccion.Font = new Font("Segoe UI", 10F);
            mnuItemBoxesDeExtraccion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemBoxesDeExtraccion.Name = "mnuItemBoxesDeExtraccion";
            mnuItemBoxesDeExtraccion.Size = new Size(216, 24);
            mnuItemBoxesDeExtraccion.Text = "Boxes de extracción";
            // 
            // mnuItemEquipos
            // 
            mnuItemEquipos.Font = new Font("Segoe UI", 10F);
            mnuItemEquipos.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemEquipos.Name = "mnuItemEquipos";
            mnuItemEquipos.Size = new Size(216, 24);
            mnuItemEquipos.Text = "Equipos";
            // 
            // mnuItemParametros
            // 
            mnuItemParametros.Font = new Font("Segoe UI", 10F);
            mnuItemParametros.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemParametros.Name = "mnuItemParametros";
            mnuItemParametros.Size = new Size(216, 24);
            mnuItemParametros.Text = "Parámetros";
            // 
            // mnuItemPlantillas
            // 
            mnuItemPlantillas.Font = new Font("Segoe UI", 10F);
            mnuItemPlantillas.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemPlantillas.Name = "mnuItemPlantillas";
            mnuItemPlantillas.Size = new Size(216, 24);
            mnuItemPlantillas.Text = "Plantillas";
            // 
            // mnuItemIntervalosDeReferencia
            // 
            mnuItemIntervalosDeReferencia.Font = new Font("Segoe UI", 10F);
            mnuItemIntervalosDeReferencia.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemIntervalosDeReferencia.Name = "mnuItemIntervalosDeReferencia";
            mnuItemIntervalosDeReferencia.Size = new Size(216, 24);
            mnuItemIntervalosDeReferencia.Text = "Intervalos de referencia";
            // 
            // mnuItemUsuarios
            // 
            mnuItemUsuarios.Font = new Font("Segoe UI", 10F);
            mnuItemUsuarios.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemUsuarios.Name = "mnuItemUsuarios";
            mnuItemUsuarios.Size = new Size(216, 24);
            mnuItemUsuarios.Text = "Usuarios";
            // 
            // mnuSesion
            // 
            mnuSesion.DropDownItems.AddRange(new ToolStripItem[] { mnuItemCambiarClave, mnuItemCerrarSesion });
            mnuSesion.ForeColor = Color.White;
            mnuSesion.Name = "mnuSesion";
            mnuSesion.Size = new Size(54, 23);
            mnuSesion.Text = "Sesión";
            // 
            // mnuItemCambiarClave
            // 
            mnuItemCambiarClave.Font = new Font("Segoe UI", 10F);
            mnuItemCambiarClave.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemCambiarClave.Name = "mnuItemCambiarClave";
            mnuItemCambiarClave.Size = new Size(146, 24);
            mnuItemCambiarClave.Text = "Cambiar clave";
            // 
            // mnuItemCerrarSesion
            // 
            mnuItemCerrarSesion.Font = new Font("Segoe UI", 10F);
            mnuItemCerrarSesion.ForeColor = Color.FromArgb(31, 35, 40);
            mnuItemCerrarSesion.Name = "mnuItemCerrarSesion";
            mnuItemCerrarSesion.Size = new Size(146, 24);
            mnuItemCerrarSesion.Text = "Cerrar sesión";
            // 
            // pnlBienvenida
            // 
            pnlBienvenida.BackColor = Color.FromArgb(244, 246, 249);
            pnlBienvenida.Controls.Add(lblRol);
            pnlBienvenida.Controls.Add(lblBienvenida);
            pnlBienvenida.Dock = DockStyle.Fill;
            pnlBienvenida.Location = new Point(0, 31);
            pnlBienvenida.Name = "pnlBienvenida";
            pnlBienvenida.Size = new Size(1200, 647);
            pnlBienvenida.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(11, 61, 110);
            lblBienvenida.Location = new Point(480, 280);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(174, 37);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido(a)";
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 12F);
            lblRol.ForeColor = Color.FromArgb(31, 35, 40);
            lblRol.Location = new Point(480, 330);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(220, 21);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol: Administrador del Sistema";
            // 
            // stsEstado
            // 
            stsEstado.BackColor = Color.White;
            stsEstado.Dock = DockStyle.Bottom;
            stsEstado.Items.AddRange(new ToolStripItem[] { tslUsuario, tslRol, tslFecha });
            stsEstado.Location = new Point(0, 678);
            stsEstado.Name = "stsEstado";
            stsEstado.Size = new Size(1200, 22);
            stsEstado.TabIndex = 2;
            stsEstado.Text = "stsEstado";
            // 
            // tslUsuario
            // 
            tslUsuario.Name = "tslUsuario";
            tslUsuario.Size = new Size(53, 17);
            tslUsuario.Text = "Usuario: ";
            // 
            // tslRol
            // 
            tslRol.Name = "tslRol";
            tslRol.Size = new Size(30, 17);
            tslRol.Text = "Rol: ";
            // 
            // tslFecha
            // 
            tslFecha.Name = "tslFecha";
            tslFecha.Size = new Size(1102, 17);
            tslFecha.Spring = true;
            tslFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlBienvenida);
            Controls.Add(stsEstado);
            Controls.Add(mnuPrincipal);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = mnuPrincipal;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Resultados Clínicos CEIBIO";
            WindowState = FormWindowState.Maximized;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            pnlBienvenida.ResumeLayout(false);
            pnlBienvenida.PerformLayout();
            stsEstado.ResumeLayout(false);
            stsEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem mnuAdmision;
        private ToolStripMenuItem mnuItemRegistrarAtencion;
        private ToolStripMenuItem mnuItemBuscarFichaClinica;
        private ToolStripMenuItem mnuItemProgramarVisita;
        private ToolStripMenuItem mnuItemConsultarAtenciones;
        private ToolStripMenuItem mnuItemConsultarVisitas;
        private ToolStripMenuItem mnuEvaluacion;
        private ToolStripMenuItem mnuItemRegistrarObservaciones;
        private ToolStripMenuItem mnuItemResultadoDeLaEvaluacion;
        private ToolStripMenuItem mnuItemConsultarSuspendidas;
        private ToolStripMenuItem mnuCaja;
        private ToolStripMenuItem mnuItemRegistrarPago;
        private ToolStripMenuItem mnuItemAutorizarTransferencias;
        private ToolStripMenuItem mnuItemEmitirComprobante;
        private ToolStripMenuItem mnuItemDerivarAtencion;
        private ToolStripMenuItem mnuItemMisVisitasAsignadas;
        private ToolStripMenuItem mnuItemConsultarTransferencias;
        private ToolStripMenuItem mnuItemConsultarRecaudacion;
        private ToolStripMenuItem mnuItemConsultarComprobantes;
        private ToolStripMenuItem mnuMuestras;
        private ToolStripMenuItem mnuItemAsignarBox;
        private ToolStripMenuItem mnuItemTomaDeMuestraEnSede;
        private ToolStripMenuItem mnuItemTomaDeMuestraADomicilio;
        private ToolStripMenuItem mnuItemAcondicionarMuestra;
        private ToolStripMenuItem mnuItemRecepcionDeMuestras;
        private ToolStripMenuItem mnuItemConsultarRechazadas;
        private ToolStripMenuItem mnuItemConsultarTransito;
        private ToolStripMenuItem mnuItemPendientesDeAcondicionar;
        private ToolStripMenuItem mnuAnalisis;
        private ToolStripMenuItem mnuItemRegistrarResultados;
        private ToolStripMenuItem mnuItemPendientesDeValidacion;
        private ToolStripMenuItem mnuItemUsoDelEquipo;
        private ToolStripMenuItem mnuItemConsultarBitacora;
        private ToolStripMenuItem mnuReportes;
        private ToolStripMenuItem mnuItemValidarResultados;
        private ToolStripMenuItem mnuItemRepetirAnalisis;
        private ToolStripMenuItem mnuItemElaborarReporte;
        private ToolStripMenuItem mnuItemRevisarReporte;
        private ToolStripMenuItem mnuItemAutorizarReporte;
        private ToolStripMenuItem mnuItemConsultarReportes;
        private ToolStripMenuItem mnuItemHistorialDeRevisiones;
        private ToolStripMenuItem mnuEntregas;
        private ToolStripMenuItem mnuItemRegistrarEntrega;
        private ToolStripMenuItem mnuItemCerrarAtencion;
        private ToolStripMenuItem mnuItemPendientesDeEntrega;
        private ToolStripMenuItem mnuItemConsultarEntregas;
        private ToolStripMenuItem mnuMantenedores;
        private ToolStripMenuItem mnuItemExamenes;
        private ToolStripMenuItem mnuItemConvenios;
        private ToolStripMenuItem mnuItemCondicionesPreanaliticas;
        private ToolStripMenuItem mnuItemMediosDePago;
        private ToolStripMenuItem mnuItemTubosYRecipientes;
        private ToolStripMenuItem mnuItemBoxesDeExtraccion;
        private ToolStripMenuItem mnuItemEquipos;
        private ToolStripMenuItem mnuItemParametros;
        private ToolStripMenuItem mnuItemPlantillas;
        private ToolStripMenuItem mnuItemIntervalosDeReferencia;
        private ToolStripMenuItem mnuItemUsuarios;
        private ToolStripMenuItem mnuSesion;
        private ToolStripMenuItem mnuItemCambiarClave;
        private ToolStripMenuItem mnuItemCerrarSesion;
        private Panel pnlBienvenida;
        private Label lblBienvenida;
        private Label lblRol;
        private StatusStrip stsEstado;
        private ToolStripStatusLabel tslUsuario;
        private ToolStripStatusLabel tslRol;
        private ToolStripStatusLabel tslFecha;
    }
}
