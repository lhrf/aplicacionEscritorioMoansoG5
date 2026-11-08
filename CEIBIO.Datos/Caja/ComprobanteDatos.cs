using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class ComprobanteDatos
    {
        private static Comprobante Mapear(SqlDataReader r) => new Comprobante
        {
            IdComprobante = Leer.Entero(r, "IdComprobante"),
            NumeroComprobante = Leer.Texto(r, "NumeroComprobante"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            IdPago = Leer.Entero(r, "IdPago"),
            FechaEmision = Leer.Fecha(r, "FechaEmision"),
            Subtotal = Leer.Decimal(r, "Subtotal"),
            Descuento = Leer.Decimal(r, "Descuento"),
            Total = Leer.Decimal(r, "Total"),
            Estado = Leer.Texto(r, "Estado"),
            MotivoAnulacion = Leer.TextoNulo(r, "MotivoAnulacion"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            Dni = Leer.Texto(r, "Dni"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            MedioPago = Leer.Texto(r, "MedioPago"),
            NombreCajero = Leer.Texto(r, "NombreCajero")
        };

        public Comprobante? ObtenerPorId(int id) => Db.Obtener("usp_Comprobante_ObtenerPorId", Mapear, P("@IdComprobante", id));

        public Comprobante? ObtenerPorNumero(string numero) =>
            Db.Obtener("usp_Comprobante_ObtenerPorNumero", Mapear, P("@NumeroComprobante", numero));

        /// <summary>Comprobante emitido (no anulado) de la atención.</summary>
        public Comprobante? ObtenerEmitidoPorAtencion(int idAtencion) =>
            Db.Obtener("usp_Comprobante_ObtenerEmitidoPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        /// <summary>CU-25: si se indica DNI, solo los de ese paciente.</summary>
        public List<Comprobante> Consultar(DateTime desde, DateTime hasta, string? dni) =>
            Db.Listar("usp_Comprobante_Consultar", Mapear,
                P("@Desde", desde.Date), P("@Hasta", hasta.Date), P("@Dni", string.IsNullOrWhiteSpace(dni) ? null : dni.Trim()));

        /// <summary>CU-20 + CU-21: número correlativo, comprobante y recaudación en una sola transacción. Devuelve el Id.</summary>
        public int Emitir(Comprobante c, int idMedioPago, int idCajero) =>
            Db.Entero("usp_Comprobante_Emitir",
                P("@IdAtencion", c.IdAtencion), P("@IdPago", c.IdPago), P("@Subtotal", c.Subtotal), P("@Descuento", c.Descuento),
                P("@Total", c.Total), P("@IdMedioPago", idMedioPago), P("@IdCajero", idCajero));

        /// <summary>CU-20 A2: anula el comprobante y lo descuenta de la recaudación del día.</summary>
        public void Anular(int idComprobante, string motivo, int idUsuario) =>
            Db.Ejecutar("usp_Comprobante_Anular", P("@IdComprobante", idComprobante), P("@Motivo", motivo), P("@IdUsuario", idUsuario));

        /// <summary>CU-24.</summary>
        public List<Recaudacion> ListarRecaudacion(DateTime fecha) =>
            Db.Listar("usp_Recaudacion_ListarPorFecha",
                r => new Recaudacion
                {
                    IdRecaudacion = Leer.Entero(r, "IdRecaudacion"),
                    IdComprobante = Leer.Entero(r, "IdComprobante"),
                    Fecha = Leer.Fecha(r, "Fecha"),
                    Importe = Leer.Decimal(r, "Importe"),
                    IdMedioPago = Leer.Entero(r, "IdMedioPago"),
                    Tipo = Leer.Texto(r, "Tipo"),
                    NumeroComprobante = Leer.Texto(r, "NumeroComprobante"),
                    NombrePaciente = Leer.Texto(r, "NombrePaciente"),
                    MedioPago = Leer.Texto(r, "MedioPago"),
                    NombreCajero = Leer.Texto(r, "NombreCajero")
                }, P("@Fecha", fecha.Date));
    }
}
