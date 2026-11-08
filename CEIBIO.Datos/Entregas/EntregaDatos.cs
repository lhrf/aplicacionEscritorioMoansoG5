using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class EntregaDatos
    {
        private static Entrega MapearEntrega(SqlDataReader r) => new Entrega
        {
            IdEntrega = Leer.Entero(r, "IdEntrega"),
            IdReporte = Leer.Entero(r, "IdReporte"),
            NombreRecibe = Leer.Texto(r, "NombreRecibe"),
            DniRecibe = Leer.Texto(r, "DniRecibe"),
            Relacion = Leer.Texto(r, "Relacion"),
            FechaEntrega = Leer.Fecha(r, "FechaEntrega"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            NombreUsuario = Leer.Texto(r, "NombreUsuario")
        };

        /// <summary>CU-58: busca por número de comprobante o DNI un reporte disponible para entrega (o con entrega retenida).</summary>
        public DatosEntrega? BuscarParaEntrega(string numeroComprobanteODni) =>
            Db.Obtener("usp_Entrega_BuscarParaEntrega",
                r => new DatosEntrega
                {
                    IdComprobante = Leer.Entero(r, "IdComprobante"),
                    NumeroComprobante = Leer.Texto(r, "NumeroComprobante"),
                    EstadoComprobante = Leer.Texto(r, "EstadoComprobante"),
                    PacienteComprobante = Leer.Texto(r, "PacienteComprobante"),
                    ExamenesComprobante = Leer.Texto(r, "ExamenesComprobante"),
                    IdReporte = Leer.Entero(r, "IdReporte"),
                    IdAtencion = Leer.Entero(r, "IdAtencion"),
                    NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
                    PacienteReporte = Leer.Texto(r, "PacienteReporte"),
                    EstadoReporte = Leer.Texto(r, "EstadoReporte"),
                    DniPaciente = Leer.Texto(r, "DniPaciente")
                }, P("@Texto", numeroComprobanteODni.Trim()));

        /// <summary>CU-57: registra la entrega y el reporte pasa a "Entregado". Devuelve el Id.</summary>
        public int Registrar(Entrega e, int idUsuario) =>
            Db.Entero("usp_Entrega_Registrar",
                P("@IdReporte", e.IdReporte), P("@NombreRecibe", e.NombreRecibe), P("@DniRecibe", e.DniRecibe),
                P("@Relacion", e.Relacion), P("@IdUsuario", idUsuario));

        /// <summary>CU-59.</summary>
        public void Retener(int idReporte, string motivo, int idUsuario) =>
            Db.Ejecutar("usp_Entrega_Retener", P("@IdReporte", idReporte), P("@Motivo", motivo), P("@IdUsuario", idUsuario));

        /// <summary>CU-59.</summary>
        public void LevantarRetencion(int idReporte, int idUsuario) =>
            Db.Ejecutar("usp_Entrega_LevantarRetencion", P("@IdReporte", idReporte), P("@IdUsuario", idUsuario));

        /// <summary>CU-60: atenciones entregadas que aún no se cierran.</summary>
        public List<Entrega> ListarEntregadasSinCerrar() => Db.Listar("usp_Entrega_ListarSinCerrar", MapearEntrega);

        public Entrega? ObtenerPorAtencion(int idAtencion) => Db.Obtener("usp_Entrega_ObtenerPorAtencion", MapearEntrega, P("@IdAtencion", idAtencion));

        /// <summary>CU-62.</summary>
        public List<Entrega> Consultar(DateTime desde, DateTime hasta) =>
            Db.Listar("usp_Entrega_Consultar", MapearEntrega, P("@Desde", desde.Date), P("@Hasta", hasta.Date));
    }
}
