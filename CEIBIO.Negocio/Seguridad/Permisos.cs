using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>
    /// Formularios que puede abrir cada rol (CU-63: el menú muestra solo las opciones del rol).
    /// En FrmMenuPrincipal: opcion.Visible = Permisos.PuedeAbrir("FrmRegistrarAtencion");
    /// El Administrador del Sistema puede abrir todos.
    /// </summary>
    public static class Permisos
    {
        private static readonly string[] Todos = { "FrmMenuPrincipal", "FrmCambiarClave" };

        private static readonly Dictionary<string, string[]> PorRol = new()
        {
            [Roles.AsesorAdmision] = new[] { "FrmRegistrarAtencion", "FrmProgramarVisita", "FrmConsultarAtenciones", "FrmConsultarVisitas" },
            [Roles.AuxiliarArchivo] = new[] { "FrmBuscarFicha", "FrmRegistrarFicha" },
            [Roles.EnfermeraEvaluadora] = new[] { "FrmRegistrarObservaciones", "FrmResultadoEvaluacion", "FrmSuspenderAtencion", "FrmConsultarSuspendidas" },
            [Roles.Cajero] = new[] { "FrmRegistrarPago", "FrmEmitirComprobante", "FrmDerivarAtencion", "FrmConsultarRecaudacion", "FrmConsultarComprobantes" },
            [Roles.SupervisorTurno] = new[] { "FrmAutorizarTransferencia", "FrmRechazarTransferencia", "FrmConsultarTransferencias" },
            [Roles.TecnicoItinerante] = new[] { "FrmVisitasAsignadas", "FrmTomaMuestraDomicilio" },
            [Roles.OrientadorSala] = new[] { "FrmAsignarBox" },
            [Roles.TecnicoFlebotomista] = new[] { "FrmTomaMuestraSede", "FrmRechazoMuestra", "FrmConsultarRechazadas" },
            [Roles.AuxiliarLaboratorio] = new[] { "FrmAcondicionarMuestra", "FrmConsultarTransito", "FrmPendientesAcondicionar" },
            [Roles.TecnicoAnalista] = new[] { "FrmRecepcionMuestra", "FrmDevolverMuestra", "FrmRegistrarResultados", "FrmRegistrarUsoEquipo",
                                              "FrmFallaAnalitica", "FrmConsultarBitacora", "FrmRepetirAnalisis" },
            [Roles.MedicoPatologo] = new[] { "FrmPendientesValidacion", "FrmValidarResultados", "FrmRetenerResultado" },
            [Roles.DigitadorClinico] = new[] { "FrmElaborarReporte", "FrmConsultarReportes" },
            [Roles.SupervisorCalidad] = new[] { "FrmRevisarReporte" },
            [Roles.DirectorMedico] = new[] { "FrmAutorizarReporte", "FrmDevolverReporte", "FrmHistorialRevisiones",
                                             "FrmMantCondiciones", "FrmMantParametros", "FrmMantPlantillas", "FrmMantIntervalos" },
            [Roles.EncargadoEntregas] = new[] { "FrmRegistrarEntrega", "FrmRetenerEntrega", "FrmCerrarAtencion", "FrmPendientesEntrega", "FrmConsultarEntregas" },
            [Roles.Administrador] = new[] { "FrmMantExamenes", "FrmMantConvenios", "FrmMantMediosPago", "FrmMantTubos", "FrmMantBoxes",
                                            "FrmMantEquipos", "FrmMantUsuarios" },
        };

        /// <summary>True si el usuario en sesión puede abrir el formulario.</summary>
        public static bool PuedeAbrir(string nombreFormulario)
        {
            if (!Sesion.Activa) return false;
            if (Sesion.Rol == Roles.Administrador) return true;
            if (Todos.Contains(nombreFormulario)) return true;
            return PorRol.TryGetValue(Sesion.Rol, out var formularios) && formularios.Contains(nombreFormulario);
        }

        /// <summary>Formularios propios de un rol (sin contar los comunes a todos).</summary>
        public static string[] FormulariosDelRol(string rol) =>
            PorRol.TryGetValue(rol, out var formularios) ? formularios : Array.Empty<string>();
    }
}
