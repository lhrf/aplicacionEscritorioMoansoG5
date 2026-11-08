using System.Text;
using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>
    /// CU-20 Emitir Comprobante de pago, CU-21 Registrar recaudación, CU-24 Consultar recaudación diaria
    /// y CU-25 Consultar comprobantes de pago.
    /// </summary>
    public class ComprobanteNegocio
    {
        private readonly ComprobanteDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly PagoDatos pagoDatos = new();

        /// <summary>
        /// CU-20 paso 1: atenciones pagadas. La propiedad NumeroComprobante viene vacía si aún no se emitió
        /// (Emitir) y llena si ya se emitió (Reimprimir o Anular).
        /// </summary>
        public List<Atencion> ListarAtencionesPagadas() => atencionDatos.ListarPorEstado(EstadoAtencion.Pagada);

        /// <summary>Datos para la vista previa antes de emitir (número vacío).</summary>
        public Comprobante? VistaPrevia(int idAtencion)
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null) return null;
            return new Comprobante
            {
                IdAtencion = idAtencion,
                FechaEmision = DateTime.Now,
                Subtotal = atencion.Subtotal,
                Descuento = atencion.Descuento,
                Total = atencion.CostoTotal,
                NumeroAtencion = atencion.NumeroAtencion,
                Dni = atencion.Dni,
                NombrePaciente = atencion.NombrePaciente,
                MedioPago = atencion.MedioPago,
                Detalle = atencionDatos.ListarDetalle(idAtencion)
            };
        }

        /// <summary>CU-20 + CU-21: emite el comprobante y registra la recaudación. Respuesta.Dato = número de comprobante.</summary>
        public Respuesta Emitir(int idAtencion) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.Pagada) return Respuesta.Error("Seleccione una atención pagada.");
            if (datos.ObtenerEmitidoPorAtencion(idAtencion) != null) return Respuesta.Error("La atención ya tiene un comprobante emitido. Use Reimprimir.");

            var pago = pagoDatos.ObtenerVigente(idAtencion);
            if (pago == null || pago.Estado != EstadoPago.Conforme) return Respuesta.Error("La atención no tiene un pago conforme.");

            var comprobante = new Comprobante
            {
                IdAtencion = idAtencion,
                IdPago = pago.IdPago,
                Subtotal = atencion.Subtotal,
                Descuento = atencion.Descuento,
                Total = atencion.CostoTotal
            };
            int id = datos.Emitir(comprobante, pago.IdMedioPago, Sesion.IdUsuario);
            var emitido = datos.ObtenerPorId(id);
            string numero = emitido?.NumeroComprobante ?? "";
            return Respuesta.Ok("Comprobante " + numero + " emitido y registrado en la recaudación del día.", id, numero);
        });

        /// <summary>Comprobante emitido de la atención, con su detalle (para reimprimir o mostrar). Null si no tiene.</summary>
        public Comprobante? ObtenerPorAtencion(int idAtencion)
        {
            var c = datos.ObtenerEmitidoPorAtencion(idAtencion);
            if (c != null) c.Detalle = atencionDatos.ListarDetalle(idAtencion);
            return c;
        }

        public Comprobante? ObtenerPorId(int idComprobante)
        {
            var c = datos.ObtenerPorId(idComprobante);
            if (c != null) c.Detalle = atencionDatos.ListarDetalle(c.IdAtencion);
            return c;
        }

        /// <summary>CU-20 A2: anula el comprobante (solo si la atención aún no fue derivada) y lo descuenta de la recaudación.</summary>
        public Respuesta Anular(int idComprobante, string motivo) => Respuesta.Intentar(() =>
        {
            var c = datos.ObtenerPorId(idComprobante);
            if (c == null || c.Estado != EstadoComprobante.Emitido) return Respuesta.Error("Seleccione un comprobante emitido.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la anulación.");
            var atencion = atencionDatos.ObtenerPorId(c.IdAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.Pagada)
                return Respuesta.Error("La atención ya fue derivada; el comprobante no se puede anular.");

            datos.Anular(idComprobante, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Comprobante " + c.NumeroComprobante + " anulado y descontado de la recaudación del día.", idComprobante);
        });

        /// <summary>Texto del comprobante para imprimir (PrintDocument) o mostrar.</summary>
        public static string TextoImpresion(Comprobante c)
        {
            var sb = new StringBuilder();
            sb.AppendLine("LABORATORIO CLÍNICO CEIBIO S.A.C.");
            sb.AppendLine("COMPROBANTE DE PAGO " + c.NumeroComprobante);
            sb.AppendLine("Fecha: " + c.FechaEmision.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Paciente: " + c.NombrePaciente + "   DNI: " + c.Dni);
            sb.AppendLine("Atención: " + c.NumeroAtencion);
            sb.AppendLine(new string('-', 48));
            foreach (var d in c.Detalle)
                sb.AppendLine(d.NombreExamen.PadRight(36) + ("S/ " + d.Tarifa.ToString("0.00")).PadLeft(12));
            sb.AppendLine(new string('-', 48));
            sb.AppendLine("Subtotal:".PadRight(36) + ("S/ " + c.Subtotal.ToString("0.00")).PadLeft(12));
            sb.AppendLine("Descuento:".PadRight(36) + ("S/ " + c.Descuento.ToString("0.00")).PadLeft(12));
            sb.AppendLine("TOTAL:".PadRight(36) + ("S/ " + c.Total.ToString("0.00")).PadLeft(12));
            if (!string.IsNullOrEmpty(c.MedioPago)) sb.AppendLine("Medio de pago: " + c.MedioPago);
            if (c.Estado == EstadoComprobante.Anulado) sb.AppendLine("*** ANULADO: " + c.MotivoAnulacion + " ***");
            return sb.ToString();
        }

        // ---------------- CU-24 ----------------
        public List<Recaudacion> ConsultarRecaudacion(DateTime fecha) => datos.ListarRecaudacion(fecha);

        /// <summary>Total por medio de pago, por ejemplo totales["Efectivo"].</summary>
        public static Dictionary<string, decimal> TotalesPorMedio(IEnumerable<Recaudacion> movimientos) =>
            movimientos.GroupBy(m => m.MedioPago).ToDictionary(g => g.Key, g => g.Sum(m => m.Importe));

        /// <summary>Total por cajero.</summary>
        public static Dictionary<string, decimal> TotalesPorCajero(IEnumerable<Recaudacion> movimientos) =>
            movimientos.GroupBy(m => m.NombreCajero).ToDictionary(g => g.Key, g => g.Sum(m => m.Importe));

        public static decimal TotalDia(IEnumerable<Recaudacion> movimientos) => movimientos.Sum(m => m.Importe);

        // ---------------- CU-25 ----------------
        /// <summary>Si se indica un DNI (8 dígitos), filtra por ese paciente dentro del rango de fechas.</summary>
        public List<Comprobante> Consultar(DateTime desde, DateTime hasta, string? dni) => datos.Consultar(desde, hasta, dni);
    }
}
