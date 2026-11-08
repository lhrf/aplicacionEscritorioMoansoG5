using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class TransferenciaNegocio
    {
        private readonly PagoDatos datos = new();

        public List<Pago> ListarPendientes() => datos.ListarPendientesAutorizacion();

        public Respuesta Autorizar(int idPago, string numeroOperacion, decimal importe, DateTime fechaOperacion) => Respuesta.Intentar(() =>
        {
            var pago = datos.ObtenerPorId(idPago);
            if (pago == null || pago.Estado != EstadoPago.PendienteAutorizacion) return Respuesta.Error("Seleccione un pago pendiente de autorización.");
            if (Validacion.Vacio(numeroOperacion)) return Respuesta.Error("Ingrese el número de operación.");
            if (fechaOperacion.Date > DateTime.Today) return Respuesta.Error("La fecha de la operación no puede ser posterior a hoy.");
            if (importe != pago.Importe)
                return Respuesta.Error("El importe (S/ " + importe.ToString("0.00") + ") es distinto al total de la atención (S/ " + pago.Importe.ToString("0.00") + "). No se registra la autorización.");

            datos.RegistrarTransferencia(new Transferencia
            {
                IdPago = idPago,
                NumeroOperacion = numeroOperacion.Trim(),
                Importe = importe,
                FechaOperacion = fechaOperacion.Date,
                Estado = "Autorizada"
            }, Sesion.IdUsuario);
            return Respuesta.Ok("Transferencia autorizada. El Cajero ya puede registrar la conformidad del pago.", idPago);
        });

        public Respuesta Rechazar(int idPago, string observacion) => Respuesta.Intentar(() =>
        {
            var pago = datos.ObtenerPorId(idPago);
            if (pago == null || pago.Estado != EstadoPago.PendienteAutorizacion) return Respuesta.Error("Seleccione un pago pendiente de autorización.");
            if (Validacion.Vacio(observacion)) return Respuesta.Error("Ingrese la observación del rechazo.");

            datos.RegistrarTransferencia(new Transferencia
            {
                IdPago = idPago,
                Estado = "Rechazada",
                Observacion = observacion.Trim()
            }, Sesion.IdUsuario);
            return Respuesta.Ok("Transferencia rechazada. La atención sigue pendiente de pago.", idPago);
        });

        public List<Transferencia> ConsultarAutorizadas(DateTime desde, DateTime hasta) => datos.ConsultarTransferencias(desde, hasta);
    }
}
