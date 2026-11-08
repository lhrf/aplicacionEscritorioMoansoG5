namespace CEIBIO.Entidades
{
    // Textos fijos que se guardan en la base de datos.
    // Usarlos siempre desde aquí para no escribirlos mal en cada formulario.

    public static class EstadoAtencion
    {
        public const string PendienteEvaluacion = "Pendiente de evaluación";
        public const string Suspendida = "Suspendida";
        public const string PendientePago = "Pendiente de pago";
        public const string Pagada = "Pagada";
        public const string EnEsperaToma = "En espera de toma de muestra";
        public const string VisitaAsignada = "Visita asignada";
        public const string EnTomaMuestra = "En toma de muestra";
        public const string MuestraRecolectada = "Muestra recolectada";
        public const string RecibidaAnalisis = "Recibida para análisis";
        public const string ListaReporte = "Lista para reporte";
        public const string Culminada = "Culminada";
        public const string Anulada = "Anulada";

        public static readonly string[] Todos =
        {
            PendienteEvaluacion, Suspendida, PendientePago, Pagada, EnEsperaToma, VisitaAsignada,
            EnTomaMuestra, MuestraRecolectada, RecibidaAnalisis, ListaReporte, Culminada, Anulada
        };
    }

    public static class Modalidad
    {
        public const string EnSede = "En sede";
        public const string ADomicilio = "A domicilio";
    }

    public static class EstadoVisita
    {
        public const string Programada = "Programada";
        public const string Reprogramada = "Reprogramada";
        public const string Cancelada = "Cancelada";
        public const string Realizada = "Realizada";
        public const string NoRealizada = "No realizada";
    }

    public static class EstadoPago
    {
        public const string PendienteAutorizacion = "Pendiente de autorización";
        public const string Autorizado = "Autorizado";
        public const string Rechazado = "Rechazado";
        public const string Conforme = "Conforme";
    }

    public static class EstadoComprobante
    {
        public const string Emitido = "Emitido";
        public const string Anulado = "Anulado";
    }

    public static class EstadoMuestra
    {
        public const string Generada = "Generada";
        public const string Recolectada = "Muestra recolectada";
        public const string Ingresada = "Ingresada";
        public const string Acondicionada = "Muestra Acondicionada";
        public const string RecibidaAnalisis = "Recibida para análisis";
        public const string Devuelta = "Devuelta";

        public static readonly string[] Todos = { Generada, Recolectada, Ingresada, Acondicionada, RecibidaAnalisis, Devuelta };
    }

    public static class TipoMovimientoMuestra
    {
        public const string Ingreso = "Ingreso";
        public const string Acondicionamiento = "Acondicionamiento";
        public const string Recepcion = "Recepción";
        public const string Devolucion = "Devolución";
        public const string Correccion = "Corrección";

        public static readonly string[] Todos = { Ingreso, Acondicionamiento, Recepcion, Devolucion, Correccion };
    }

    public static class EstadoResultado
    {
        public const string Registrado = "Registrado";
        public const string PendienteValidacion = "Pendiente de validación";
        public const string EnRepeticion = "En repetición";
        public const string Validado = "Validado";
    }

    public static class EstadoReporte
    {
        public const string Borrador = "Borrador";
        public const string EnRevision = "En revisión de calidad";
        public const string Observado = "Observado";
        public const string Revisado = "Revisado";
        public const string PendienteAutorizacion = "Pendiente de autorización";
        public const string Autorizado = "Autorizado";
        public const string DevueltoMedico = "Devuelto al Médico Patólogo";
        public const string DisponibleEntrega = "Disponible para entrega";
        public const string EntregaRetenida = "Entrega retenida";
        public const string Entregado = "Entregado";

        public static readonly string[] Todos =
        {
            Borrador, EnRevision, Observado, Revisado, PendienteAutorizacion, Autorizado,
            DevueltoMedico, DisponibleEntrega, EntregaRetenida, Entregado
        };
    }

    public static class Roles
    {
        public const string Administrador = "Administrador del Sistema";
        public const string DirectorMedico = "Director Médico";
        public const string AsesorAdmision = "Asesor de Admisión";
        public const string AuxiliarArchivo = "Auxiliar de Archivo";
        public const string EnfermeraEvaluadora = "Enfermera Evaluadora";
        public const string Cajero = "Cajero";
        public const string SupervisorTurno = "Supervisor de Turno";
        public const string TecnicoItinerante = "Técnico Laboratorista Itinerante";
        public const string OrientadorSala = "Orientador de Sala";
        public const string TecnicoFlebotomista = "Técnico Flebotomista";
        public const string AuxiliarLaboratorio = "Auxiliar de Laboratorio";
        public const string TecnicoAnalista = "Técnico Analista";
        public const string MedicoPatologo = "Médico Patólogo";
        public const string DigitadorClinico = "Digitador Clínico";
        public const string SupervisorCalidad = "Supervisor de Calidad";
        public const string EncargadoEntregas = "Encargado de Entregas";
    }
}
