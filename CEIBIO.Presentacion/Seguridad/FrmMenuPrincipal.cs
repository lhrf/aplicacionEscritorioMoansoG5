using CEIBIO.Negocio;
using CEIBIO.Presentacion.Admision;
using CEIBIO.Presentacion.Analisis;
using CEIBIO.Presentacion.Caja;
using CEIBIO.Presentacion.Entregas;
using CEIBIO.Presentacion.Evaluacion;
using CEIBIO.Presentacion.Formalizacion;
using CEIBIO.Presentacion.Mantenedores;
using CEIBIO.Presentacion.Preparacion;
using CEIBIO.Presentacion.TomaMuestras;

namespace CEIBIO.Presentacion.Seguridad
{
    public partial class FrmMenuPrincipal : Form
    {
        public bool CerroSesion { get; private set; }

        public FrmMenuPrincipal()
        {
            InitializeComponent();

            Opcion(mnuItemRegistrarAtencion, "FrmRegistrarAtencion", () => new FrmRegistrarAtencion());
            Opcion(mnuItemBuscarFichaClinica, "FrmBuscarFicha", () => new FrmBuscarFicha());
            Opcion(mnuItemProgramarVisita, "FrmProgramarVisita", () => new FrmProgramarVisita());
            Opcion(mnuItemConsultarAtenciones, "FrmConsultarAtenciones", () => new FrmConsultarAtenciones());
            Opcion(mnuItemConsultarVisitas, "FrmConsultarVisitas", () => new FrmConsultarVisitas());

            Opcion(mnuItemRegistrarObservaciones, "FrmRegistrarObservaciones", () => new FrmRegistrarObservaciones());
            Opcion(mnuItemResultadoDeLaEvaluacion, "FrmResultadoEvaluacion", () => new FrmResultadoEvaluacion());
            Opcion(mnuItemConsultarSuspendidas, "FrmConsultarSuspendidas", () => new FrmConsultarSuspendidas());

            Opcion(mnuItemRegistrarPago, "FrmRegistrarPago", () => new FrmRegistrarPago());
            Opcion(mnuItemAutorizarTransferencias, "FrmAutorizarTransferencia", () => new FrmAutorizarTransferencia());
            Opcion(mnuItemEmitirComprobante, "FrmEmitirComprobante", () => new FrmEmitirComprobante());
            Opcion(mnuItemDerivarAtencion, "FrmDerivarAtencion", () => new FrmDerivarAtencion());
            Opcion(mnuItemMisVisitasAsignadas, "FrmVisitasAsignadas", () => new FrmVisitasAsignadas());
            Opcion(mnuItemConsultarTransferencias, "FrmConsultarTransferencias", () => new FrmConsultarTransferencias());
            Opcion(mnuItemConsultarRecaudacion, "FrmConsultarRecaudacion", () => new FrmConsultarRecaudacion());
            Opcion(mnuItemConsultarComprobantes, "FrmConsultarComprobantes", () => new FrmConsultarComprobantes());

            Opcion(mnuItemAsignarBox, "FrmAsignarBox", () => new FrmAsignarBox());
            Opcion(mnuItemTomaDeMuestraEnSede, "FrmTomaMuestraSede", () => new FrmTomaMuestraSede());
            Opcion(mnuItemTomaDeMuestraADomicilio, "FrmTomaMuestraDomicilio", () => new FrmTomaMuestraDomicilio());
            Opcion(mnuItemAcondicionarMuestra, "FrmAcondicionarMuestra", () => new FrmAcondicionarMuestra());
            Opcion(mnuItemRecepcionDeMuestras, "FrmRecepcionMuestra", () => new FrmRecepcionMuestra());
            Opcion(mnuItemConsultarRechazadas, "FrmConsultarRechazadas", () => new FrmConsultarRechazadas());
            Opcion(mnuItemConsultarTransito, "FrmConsultarTransito", () => new FrmConsultarTransito());
            Opcion(mnuItemPendientesDeAcondicionar, "FrmPendientesAcondicionar", () => new FrmPendientesAcondicionar());

            Opcion(mnuItemRegistrarResultados, "FrmRegistrarResultados", () => new FrmRegistrarResultados());
            Opcion(mnuItemPendientesDeValidacion, "FrmPendientesValidacion", () => new FrmPendientesValidacion());
            Opcion(mnuItemUsoDelEquipo, "FrmRegistrarUsoEquipo", () => new FrmRegistrarUsoEquipo());
            Opcion(mnuItemConsultarBitacora, "FrmConsultarBitacora", () => new FrmConsultarBitacora());

            Opcion(mnuItemValidarResultados, "FrmValidarResultados", () => new FrmValidarResultados());
            Opcion(mnuItemRepetirAnalisis, "FrmRepetirAnalisis", () => new FrmRepetirAnalisis());
            Opcion(mnuItemElaborarReporte, "FrmElaborarReporte", () => new FrmElaborarReporte());
            Opcion(mnuItemRevisarReporte, "FrmRevisarReporte", () => new FrmRevisarReporte());
            Opcion(mnuItemAutorizarReporte, "FrmAutorizarReporte", () => new FrmAutorizarReporte());
            Opcion(mnuItemConsultarReportes, "FrmConsultarReportes", () => new FrmConsultarReportes());
            Opcion(mnuItemHistorialDeRevisiones, "FrmHistorialRevisiones", () => new FrmHistorialRevisiones());

            Opcion(mnuItemRegistrarEntrega, "FrmRegistrarEntrega", () => new FrmRegistrarEntrega());
            Opcion(mnuItemCerrarAtencion, "FrmCerrarAtencion", () => new FrmCerrarAtencion());
            Opcion(mnuItemPendientesDeEntrega, "FrmPendientesEntrega", () => new FrmPendientesEntrega());
            Opcion(mnuItemConsultarEntregas, "FrmConsultarEntregas", () => new FrmConsultarEntregas());

            Opcion(mnuItemExamenes, "FrmMantExamenes", () => new FrmMantExamenes());
            Opcion(mnuItemConvenios, "FrmMantConvenios", () => new FrmMantConvenios());
            Opcion(mnuItemCondicionesPreanaliticas, "FrmMantCondiciones", () => new FrmMantCondiciones());
            Opcion(mnuItemMediosDePago, "FrmMantMediosPago", () => new FrmMantMediosPago());
            Opcion(mnuItemTubosYRecipientes, "FrmMantTubos", () => new FrmMantTubos());
            Opcion(mnuItemBoxesDeExtraccion, "FrmMantBoxes", () => new FrmMantBoxes());
            Opcion(mnuItemEquipos, "FrmMantEquipos", () => new FrmMantEquipos());
            Opcion(mnuItemParametros, "FrmMantParametros", () => new FrmMantParametros());
            Opcion(mnuItemPlantillas, "FrmMantPlantillas", () => new FrmMantPlantillas());
            Opcion(mnuItemIntervalosDeReferencia, "FrmMantIntervalos", () => new FrmMantIntervalos());
            Opcion(mnuItemUsuarios, "FrmMantUsuarios", () => new FrmMantUsuarios());

            Opcion(mnuItemCambiarClave, "FrmCambiarClave", () => new FrmCambiarClave());
            mnuItemCerrarSesion.Click += MnuItemCerrarSesion_Click;

            foreach (ToolStripMenuItem menu in mnuPrincipal.Items.OfType<ToolStripMenuItem>())
                menu.Visible = menu.DropDownItems.OfType<ToolStripItem>().Any(i => i.Available);

            Load += (s, e) => MostrarSesion();
        }

        private void Opcion(ToolStripMenuItem item, string formulario, Func<Form> crear)
        {
            item.Available = Permisos.PuedeAbrir(formulario);
            item.Click += (s, e) => Ui.Intentar(() =>
            {
                using var f = crear();
                f.ShowDialog(this);
            });
        }

        private void MostrarSesion()
        {
            lblBienvenida.Text = "Bienvenido(a), " + Sesion.NombreUsuario;
            lblRol.Text = "Rol: " + Sesion.Rol;
            tslUsuario.Text = "Usuario: " + Sesion.NombreUsuario;
            tslRol.Text = "Rol: " + Sesion.Rol;
            tslFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void MnuItemCerrarSesion_Click(object? sender, EventArgs e)
        {
            if (!Ui.Confirmar("¿Desea cerrar la sesión?")) return;
            new UsuarioNegocio().CerrarSesion();
            CerroSesion = true;
            Close();
        }
    }
}
