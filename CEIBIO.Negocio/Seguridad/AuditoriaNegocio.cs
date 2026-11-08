using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>RNF-20: consulta del historial de registros, modificaciones, anulaciones y cambios de estado.</summary>
    public class AuditoriaNegocio
    {
        private readonly UsuarioDatos datos = new();

        /// <summary>
        /// Historial entre dos fechas. tabla: nombre de la tabla (por ejemplo "Examen" o "Atencion"); null = todas.
        /// idRegistro: Id del registro; null = todos.
        /// </summary>
        public List<Auditoria> Consultar(string? tabla, int? idRegistro, DateTime desde, DateTime hasta) =>
            datos.ConsultarAuditoria(tabla, idRegistro, desde, hasta);

        /// <summary>Historial completo de una atención (registro, cambios de estado, anulación, etc.).</summary>
        public List<Auditoria> HistorialAtencion(int idAtencion) =>
            datos.ConsultarAuditoria("Atencion", idAtencion, new DateTime(2000, 1, 1), DateTime.Today);
    }
}
