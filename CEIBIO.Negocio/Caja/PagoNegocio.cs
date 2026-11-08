using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-15 Registrar pago de la atención.</summary>
    public class PagoNegocio
    {
        private readonly PagoDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly MedioPagoDatos medioPagoDatos = new();

        /// <summary>CU-15 paso 2: atenciones pendientes de pago (sede y domicilio).</summary>
        public List<Atencion> ListarPendientes() => atencionDatos.ListarPorEstado(EstadoAtencion.PendientePago);

        /// <summary>CU-15 paso 4: exámenes y tarifas de la atención (el descuento y el total están en la Atencion).</summary>
        public List<AtencionExamen> ListarDetalle(int idAtencion) => atencionDatos.ListarDetalle(idAtencion);

        /// <summary>Pago en curso de la atención (pendiente de autorización o autorizado). Null si no tiene.</summary>
        public Pago? ObtenerPagoEnCurso(int idAtencion) => datos.ObtenerVigente(idAtencion);

        /// <summary>CU-15 paso 6: vuelto (0 si el monto no alcanza).</summary>
        public static decimal CalcularVuelto(decimal total, decimal montoRecibido) => montoRecibido > total ? montoRecibido - total : 0m;

        /// <summary>
        /// CU-15: registra el pago y su conformidad.
        /// - Medio sin autorización (efectivo, tarjeta): valida el monto, calcula el vuelto y la atención queda "Pagada".
        /// - Medio con autorización (transferencia): el pago queda pendiente hasta que el Supervisor de Turno lo autorice (CU-16).
        /// - Si la transferencia ya fue autorizada: registra la conformidad y la atención queda "Pagada".
        /// Respuesta.Dato = vuelto (cuando corresponde).
        /// </summary>
        public Respuesta RegistrarPago(int idAtencion, int idMedioPago, decimal montoRecibido) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null) return Respuesta.Error("Seleccione una atención.");
            if (atencion.Estado != EstadoAtencion.PendientePago) return Respuesta.Error("La atención no está pendiente de pago.");

            var enCurso = datos.ObtenerVigente(idAtencion);
            if (enCurso != null)
            {
                if (enCurso.Estado == EstadoPago.PendienteAutorizacion)
                    return Respuesta.Error("El pago por " + enCurso.MedioPago.ToLower() + " aún no fue autorizado por el Supervisor de Turno.");
                if (enCurso.Estado == EstadoPago.Autorizado)
                {
                    datos.RegistrarConformidad(enCurso.IdPago, Sesion.IdUsuario);
                    return Respuesta.Ok("Pago autorizado: conformidad registrada. La atención " + atencion.NumeroAtencion + " está pagada.", enCurso.IdPago);
                }
                if (enCurso.Estado == EstadoPago.Conforme)
                    return Respuesta.Error("La atención ya tiene un pago conforme.");
            }

            var medio = medioPagoDatos.ObtenerPorId(idMedioPago);
            if (medio == null || !medio.Habilitado) return Respuesta.Error("Seleccione un medio de pago habilitado.");

            var pago = new Pago { IdAtencion = idAtencion, IdMedioPago = idMedioPago, Importe = atencion.CostoTotal };

            if (medio.RequiereAutorizacion)
            {
                int idPendiente = datos.RegistrarPendiente(pago, Sesion.IdUsuario);
                return Respuesta.Ok("Pago por " + medio.Descripcion.ToLower() + " registrado. Queda pendiente de autorización del Supervisor de Turno; " +
                                    "cuando lo autorice, vuelva a registrar la conformidad.", idPendiente);
            }

            if (montoRecibido < atencion.CostoTotal)
                return Respuesta.Error("El monto recibido (S/ " + montoRecibido.ToString("0.00") + ") es menor que el total (S/ " + atencion.CostoTotal.ToString("0.00") + ").");

            pago.MontoRecibido = montoRecibido;
            pago.Vuelto = CalcularVuelto(atencion.CostoTotal, montoRecibido);
            int id = datos.RegistrarConforme(pago, Sesion.IdUsuario);
            return Respuesta.Ok("Pago registrado. Vuelto: S/ " + pago.Vuelto.Value.ToString("0.00") + ". La atención " + atencion.NumeroAtencion + " está pagada.",
                id, pago.Vuelto.Value.ToString("0.00"));
        });
    }
}
