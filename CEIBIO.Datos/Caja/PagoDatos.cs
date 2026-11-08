using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class PagoDatos
    {
        private static Pago Mapear(SqlDataReader r) => new Pago
        {
            IdPago = Leer.Entero(r, "IdPago"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            IdMedioPago = Leer.Entero(r, "IdMedioPago"),
            Importe = Leer.Decimal(r, "Importe"),
            MontoRecibido = Leer.DecimalNulo(r, "MontoRecibido"),
            Vuelto = Leer.DecimalNulo(r, "Vuelto"),
            Estado = Leer.Texto(r, "Estado"),
            FechaRegistro = Leer.Fecha(r, "FechaRegistro"),
            FechaConformidad = Leer.FechaNula(r, "FechaConformidad"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            MedioPago = Leer.Texto(r, "MedioPago"),
            RequiereAutorizacion = Leer.Booleano(r, "RequiereAutorizacion"),
            NombreCajero = Leer.Texto(r, "NombreCajero")
        };

        /// <summary>Último pago no rechazado de la atención (pendiente, autorizado o conforme).</summary>
        public Pago? ObtenerVigente(int idAtencion) => Db.Obtener("usp_Pago_ObtenerVigente", Mapear, P("@IdAtencion", idAtencion));

        public Pago? ObtenerPorId(int idPago) => Db.Obtener("usp_Pago_ObtenerPorId", Mapear, P("@IdPago", idPago));

        /// <summary>CU-16 paso 2.</summary>
        public List<Pago> ListarPendientesAutorizacion() => Db.Listar("usp_Pago_ListarPendientesAutorizacion", Mapear);

        /// <summary>CU-15: pago con conformidad inmediata; la atención queda Pagada.</summary>
        public int RegistrarConforme(Pago pago, int idCajero) =>
            Db.Entero("usp_Pago_RegistrarConforme",
                P("@IdAtencion", pago.IdAtencion), P("@IdMedioPago", pago.IdMedioPago), P("@Importe", pago.Importe),
                P("@MontoRecibido", pago.MontoRecibido), P("@Vuelto", pago.Vuelto), P("@IdCajero", idCajero));

        /// <summary>CU-15 A1: pago pendiente de autorización del Supervisor de Turno.</summary>
        public int RegistrarPendiente(Pago pago, int idCajero) =>
            Db.Entero("usp_Pago_RegistrarPendiente",
                P("@IdAtencion", pago.IdAtencion), P("@IdMedioPago", pago.IdMedioPago), P("@Importe", pago.Importe), P("@IdCajero", idCajero));

        /// <summary>CU-15 paso 7 después de la autorización.</summary>
        public void RegistrarConformidad(int idPago, int idUsuario) =>
            Db.Ejecutar("usp_Pago_RegistrarConformidad", P("@IdPago", idPago), P("@IdUsuario", idUsuario));

        /// <summary>CU-16 (Estado "Autorizada") y CU-17 (Estado "Rechazada").</summary>
        public void RegistrarTransferencia(Transferencia t, int idSupervisor) =>
            Db.Ejecutar("usp_Transferencia_Registrar",
                P("@IdPago", t.IdPago), P("@NumeroOperacion", t.NumeroOperacion), P("@Importe", t.Importe),
                P("@FechaOperacion", t.FechaOperacion?.Date), P("@Estado", t.Estado), P("@Observacion", t.Observacion),
                P("@IdSupervisor", idSupervisor));

        /// <summary>CU-19.</summary>
        public List<Transferencia> ConsultarTransferencias(DateTime desde, DateTime hasta) =>
            Db.Listar("usp_Transferencia_ConsultarAutorizadas",
                r => new Transferencia
                {
                    IdTransferencia = Leer.Entero(r, "IdTransferencia"),
                    IdPago = Leer.Entero(r, "IdPago"),
                    NumeroOperacion = Leer.TextoNulo(r, "NumeroOperacion"),
                    Importe = Leer.DecimalNulo(r, "Importe"),
                    FechaOperacion = Leer.FechaNula(r, "FechaOperacion"),
                    Estado = Leer.Texto(r, "Estado"),
                    Observacion = Leer.TextoNulo(r, "Observacion"),
                    FechaRegistro = Leer.Fecha(r, "FechaRegistro"),
                    NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
                    NombrePaciente = Leer.Texto(r, "NombrePaciente"),
                    NombreSupervisor = Leer.Texto(r, "NombreSupervisor")
                }, P("@Desde", desde.Date), P("@Hasta", hasta.Date));
    }
}
