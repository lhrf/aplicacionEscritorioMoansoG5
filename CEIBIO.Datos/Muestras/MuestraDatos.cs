using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class MuestraDatos
    {
        private static Muestra Mapear(SqlDataReader r) => new Muestra
        {
            IdMuestra = Leer.Entero(r, "IdMuestra"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            Codigo = Leer.Texto(r, "Codigo"),
            FechaGeneracion = Leer.Fecha(r, "FechaGeneracion"),
            HoraExtraccion = Leer.FechaNula(r, "HoraExtraccion"),
            FechaValidacion = Leer.FechaNula(r, "FechaValidacion"),
            CondicionesDeclaradas = Leer.TextoNulo(r, "CondicionesDeclaradas"),
            RechazosOcurridos = Leer.TextoNulo(r, "RechazosOcurridos"),
            FechaIngreso = Leer.FechaNula(r, "FechaIngreso"),
            EstadoConservacion = Leer.TextoNulo(r, "EstadoConservacion"),
            MinutosCentrifugacion = Leer.EnteroNulo(r, "MinutosCentrifugacion"),
            FechaAcondicionamiento = Leer.FechaNula(r, "FechaAcondicionamiento"),
            FechaRecepcion = Leer.FechaNula(r, "FechaRecepcion"),
            Estado = Leer.Texto(r, "Estado"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            IdPaciente = Leer.Entero(r, "IdPaciente"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            Modalidad = Leer.Texto(r, "Modalidad"),
            Examenes = Leer.Texto(r, "Examenes"),
            TubosEsperados = Leer.Texto(r, "TubosEsperados"),
            NombreResponsable = Leer.Texto(r, "NombreResponsable"),
            NombreAcondiciona = Leer.Texto(r, "NombreAcondiciona")
        };

        public Muestra? ObtenerPorCodigo(string codigo) => Db.Obtener("usp_Muestra_ObtenerPorCodigo", Mapear, P("@Codigo", codigo));

        public Muestra? ObtenerPorAtencion(int idAtencion) => Db.Obtener("usp_Muestra_ObtenerPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        public Muestra? ObtenerPorId(int id) => Db.Obtener("usp_Muestra_ObtenerPorId", Mapear, P("@IdMuestra", id));

        public List<Muestra> ListarPorEstado(string estado) => Db.Listar("usp_Muestra_ListarPorEstado", Mapear, P("@Estado", estado));

        public List<Muestra> ConsultarTransito(DateTime desde, DateTime hasta, string? estado) =>
            Db.Listar("usp_Muestra_ConsultarTransito", Mapear,
                P("@Desde", desde.Date), P("@Hasta", hasta.Date), P("@Estado", string.IsNullOrWhiteSpace(estado) ? null : estado));

        public int Generar(int idAtencion, int idUsuario) =>
            Db.Entero("usp_Muestra_Generar", P("@IdAtencion", idAtencion), P("@IdUsuario", idUsuario));

        public void RegistrarRecoleccion(int idMuestra, DateTime horaExtraccion, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_RegistrarRecoleccion", P("@IdMuestra", idMuestra), P("@HoraExtraccion", horaExtraccion), P("@IdUsuario", idUsuario));

        public void RegistrarRetorno(int idMuestra, DateTime horaExtraccion, string? condiciones, string? rechazos, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_RegistrarRetorno",
                P("@IdMuestra", idMuestra), P("@HoraExtraccion", horaExtraccion), P("@CondicionesDeclaradas", condiciones),
                P("@RechazosOcurridos", rechazos), P("@IdUsuario", idUsuario));

        public void RegistrarRechazo(RechazoMuestra r, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_RegistrarRechazo",
                P("@IdMuestra", r.IdMuestra), P("@IdExamen", r.IdExamen), P("@IdTubo", r.IdTubo), P("@Motivo", r.Motivo),
                P("@Observacion", r.Observacion), P("@IdUsuario", idUsuario));

        public List<RechazoMuestra> ConsultarRechazadas(DateTime desde, DateTime hasta) =>
            Db.Listar("usp_Muestra_ConsultarRechazadas",
                r => new RechazoMuestra
                {
                    IdRechazo = Leer.Entero(r, "IdRechazo"),
                    IdMuestra = Leer.Entero(r, "IdMuestra"),
                    IdExamen = Leer.EnteroNulo(r, "IdExamen"),
                    IdTubo = Leer.EnteroNulo(r, "IdTubo"),
                    Motivo = Leer.Texto(r, "Motivo"),
                    Observacion = Leer.TextoNulo(r, "Observacion"),
                    Fecha = Leer.Fecha(r, "Fecha"),
                    CodigoMuestra = Leer.Texto(r, "CodigoMuestra"),
                    NombrePaciente = Leer.Texto(r, "NombrePaciente"),
                    NombreExamen = Leer.Texto(r, "NombreExamen"),
                    NombreTecnico = Leer.Texto(r, "NombreTecnico")
                }, P("@Desde", desde.Date), P("@Hasta", hasta.Date));

        public void RegistrarIngreso(int idMuestra, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_RegistrarIngreso", P("@IdMuestra", idMuestra), P("@IdUsuario", idUsuario));

        public void RegistrarAcondicionamiento(int idMuestra, string estadoConservacion, int? minutos, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_RegistrarAcondicionamiento",
                P("@IdMuestra", idMuestra), P("@EstadoConservacion", estadoConservacion), P("@MinutosCentrifugacion", minutos), P("@IdUsuario", idUsuario));

        public void Corregir(int idMuestra, string estadoConservacion, int? minutos, string datoAnterior, string motivo, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_Corregir",
                P("@IdMuestra", idMuestra), P("@EstadoConservacion", estadoConservacion), P("@MinutosCentrifugacion", minutos),
                P("@DatoAnterior", datoAnterior), P("@Motivo", motivo), P("@IdUsuario", idUsuario));

        public void RegistrarRecepcion(int idMuestra, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_RegistrarRecepcion", P("@IdMuestra", idMuestra), P("@IdUsuario", idUsuario));

        public List<MovimientoMuestra> ListarMovimientos(int idMuestra) =>
            Db.Listar("usp_MovimientoMuestra_Listar", MapearMovimiento, P("@IdMuestra", idMuestra));

        public List<MovimientoMuestra> ConsultarMovimientos(DateTime desde, DateTime hasta, string? tipoMovimiento) =>
            Db.Listar("usp_MovimientoMuestra_Consultar", MapearMovimiento,
                P("@Desde", desde.Date), P("@Hasta", hasta.Date), P("@TipoMovimiento", string.IsNullOrWhiteSpace(tipoMovimiento) ? null : tipoMovimiento));

        private static MovimientoMuestra MapearMovimiento(SqlDataReader r) => new MovimientoMuestra
        {
            IdMovimiento = Leer.Entero(r, "IdMovimiento"),
            IdMuestra = Leer.Entero(r, "IdMuestra"),
            TipoMovimiento = Leer.Texto(r, "TipoMovimiento"),
            FechaHora = Leer.Fecha(r, "FechaHora"),
            IdUsuario = Leer.Entero(r, "IdUsuario"),
            Detalle = Leer.TextoNulo(r, "Detalle"),
            CodigoMuestra = Leer.Texto(r, "CodigoMuestra"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            NombreUsuario = Leer.Texto(r, "NombreUsuario")
        };

        public void Devolver(int idMuestra, string diferencia, int idUsuario) =>
            Db.Ejecutar("usp_Muestra_Devolver", P("@IdMuestra", idMuestra), P("@Diferencia", diferencia), P("@IdUsuario", idUsuario));
    }
}
