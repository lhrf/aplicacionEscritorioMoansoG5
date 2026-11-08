using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class AtencionDatos
    {
        private static Atencion Mapear(SqlDataReader r) => new Atencion
        {
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            IdPaciente = Leer.Entero(r, "IdPaciente"),
            Dni = Leer.Texto(r, "Dni"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            FechaRegistro = Leer.Fecha(r, "FechaRegistro"),
            Modalidad = Leer.Texto(r, "Modalidad"),
            IdConvenio = Leer.EnteroNulo(r, "IdConvenio"),
            NombreConvenio = Leer.Texto(r, "NombreConvenio"),
            Subtotal = Leer.Decimal(r, "Subtotal"),
            Descuento = Leer.Decimal(r, "Descuento"),
            CostoTotal = Leer.Decimal(r, "CostoTotal"),
            Estado = Leer.Texto(r, "Estado"),
            MotivoAnulacion = Leer.TextoNulo(r, "MotivoAnulacion"),
            NumeroTurno = Leer.EnteroNulo(r, "NumeroTurno"),
            FechaDerivacion = Leer.FechaNula(r, "FechaDerivacion"),
            IdBox = Leer.EnteroNulo(r, "IdBox"),
            NumeroBox = Leer.Texto(r, "NumeroBox"),
            IdUsuarioRegistro = Leer.Entero(r, "IdUsuarioRegistro"),
            NombreUsuarioRegistro = Leer.Texto(r, "NombreUsuarioRegistro"),
            Examenes = Leer.Texto(r, "Examenes"),
            NumeroComprobante = Leer.Texto(r, "NumeroComprobante"),
            MedioPago = Leer.Texto(r, "MedioPago"),
            EstadoReporte = Leer.Texto(r, "EstadoReporte")
        };

        public Atencion? ObtenerPorId(int id) => Db.Obtener("usp_Atencion_ObtenerPorId", Mapear, P("@IdAtencion", id));

        public Atencion? ObtenerPorNumero(string numeroAtencion) =>
            Db.Obtener("usp_Atencion_ObtenerPorNumero", Mapear, P("@NumeroAtencion", numeroAtencion));

        public List<Atencion> ListarPorEstado(string estado) => Db.Listar("usp_Atencion_ListarPorEstado", Mapear, P("@Estado", estado));

        /// <summary>Atenciones en espera de toma de muestra ordenadas por turno (CU-26).</summary>
        public List<Atencion> ListarEnEsperaPorTurno() => Db.Listar("usp_Atencion_ListarEnEsperaPorTurno", Mapear);

        public List<Atencion> ListarPorPaciente(int idPaciente) =>
            Db.Listar("usp_Atencion_ListarPorPaciente", Mapear, P("@IdPaciente", idPaciente));

        /// <summary>CU-08: atenciones entre dos fechas; estado vacío o null = todos.</summary>
        public List<Atencion> Consultar(DateTime desde, DateTime hasta, string? estado) =>
            Db.Listar("usp_Atencion_Consultar", Mapear,
                P("@Desde", desde.Date), P("@Hasta", hasta.Date), P("@Estado", string.IsNullOrWhiteSpace(estado) ? null : estado));

        /// <summary>Atenciones pagadas con o sin Comprobante de pago emitido (CU-20 y CU-22).</summary>
        public List<Atencion> ListarPagadas(bool conComprobante) =>
            Db.Listar("usp_Atencion_ListarPagadas", Mapear, P("@ConComprobante", conComprobante));

        /// <summary>CU-49: atenciones en un estado, sin reporte o con reporte en alguno de los estados indicados.</summary>
        public List<Atencion> ListarPorEstadoReporte(string estadoAtencion, string[] estadosReporte) =>
            Db.Listar("usp_Atencion_ListarPorEstadoReporte", Mapear,
                P("@Estado", estadoAtencion), P("@EstadosReporte", string.Join("|", estadosReporte)));

        public List<AtencionExamen> ListarDetalle(int idAtencion) =>
            Db.Listar("usp_Atencion_ListarDetalle",
                r => new AtencionExamen
                {
                    IdAtencion = Leer.Entero(r, "IdAtencion"),
                    IdExamen = Leer.Entero(r, "IdExamen"),
                    Codigo = Leer.Texto(r, "Codigo"),
                    NombreExamen = Leer.Texto(r, "NombreExamen"),
                    TipoMuestra = Leer.Texto(r, "TipoMuestra"),
                    Procedimiento = Leer.Texto(r, "Procedimiento"),
                    Tarifa = Leer.Decimal(r, "Tarifa"),
                    ObservacionesMicroscopicas = Leer.TextoNulo(r, "ObservacionesMicroscopicas")
                }, P("@IdAtencion", idAtencion));

        /// <summary>CU-01: guarda la atención y sus exámenes (el procedimiento usa una transacción). Devuelve el Id.</summary>
        public int Insertar(Atencion a) =>
            Db.Entero("usp_Atencion_Insertar",
                P("@IdPaciente", a.IdPaciente), P("@Modalidad", a.Modalidad), P("@IdConvenio", a.IdConvenio),
                P("@Subtotal", a.Subtotal), P("@Descuento", a.Descuento), P("@CostoTotal", a.CostoTotal),
                P("@Estado", a.Estado), P("@IdUsuario", a.IdUsuarioRegistro), P("@IdExamenes", Lista(a.Detalle.Select(d => d.IdExamen))));

        public void CambiarEstado(int idAtencion, string estado, int idUsuario) =>
            Db.Ejecutar("usp_Atencion_CambiarEstado", P("@IdAtencion", idAtencion), P("@Estado", estado), P("@IdUsuario", idUsuario));

        public void Anular(int idAtencion, string motivo, int idUsuario) =>
            Db.Ejecutar("usp_Atencion_Anular", P("@IdAtencion", idAtencion), P("@Motivo", motivo), P("@IdUsuario", idUsuario));

        /// <summary>CU-22: asigna el siguiente número de turno del día y devuelve el turno.</summary>
        public int AsignarTurno(int idAtencion, int idUsuario) =>
            Db.Entero("usp_Atencion_AsignarTurno", P("@IdAtencion", idAtencion), P("@IdUsuario", idUsuario));

        /// <summary>CU-22 A1: deriva la atención a domicilio con el técnico itinerante.</summary>
        public void AsignarTecnico(int idAtencion, int idTecnico, int idUsuario) =>
            Db.Ejecutar("usp_Atencion_AsignarTecnico", P("@IdAtencion", idAtencion), P("@IdTecnico", idTecnico), P("@IdUsuario", idUsuario));

        /// <summary>CU-26: registra el box y pasa la atención a toma de muestra.</summary>
        public void AsignarBox(int idAtencion, int idBox, int idUsuario) =>
            Db.Ejecutar("usp_Atencion_AsignarBox", P("@IdAtencion", idAtencion), P("@IdBox", idBox), P("@IdUsuario", idUsuario));

        public void GuardarObservacionesMicroscopicas(int idAtencion, int idExamen, string? observaciones, int idUsuario) =>
            Db.Ejecutar("usp_Atencion_GuardarObservacionesMicroscopicas",
                P("@IdAtencion", idAtencion), P("@IdExamen", idExamen), P("@Observaciones", observaciones), P("@IdUsuario", idUsuario));
    }
}
