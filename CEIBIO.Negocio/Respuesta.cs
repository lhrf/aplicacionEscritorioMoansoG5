namespace CEIBIO.Negocio
{
    /// <summary>
    /// Resultado de una operación de la capa de negocio (guardar, anular, validar, etc.).
    /// En el formulario: var r = negocio.Guardar(x); MessageBox.Show(r.Mensaje); if (r.Exito) { ... }
    /// </summary>
    public class Respuesta
    {
        public bool Exito { get; private set; }
        public string Mensaje { get; private set; } = string.Empty;
        /// <summary>Id del registro creado o afectado (cuando corresponde).</summary>
        public int Id { get; private set; }
        /// <summary>Dato adicional para mostrar (número de atención, de comprobante, de turno, código de muestra...).</summary>
        public string Dato { get; private set; } = string.Empty;

        public static Respuesta Ok(string mensaje, int id = 0, string dato = "") =>
            new Respuesta { Exito = true, Mensaje = mensaje, Id = id, Dato = dato };

        public static Respuesta Error(string mensaje) => new Respuesta { Exito = false, Mensaje = mensaje };

        /// <summary>Ejecuta la operación y convierte cualquier error (por ejemplo, de base de datos) en una Respuesta.</summary>
        public static Respuesta Intentar(Func<Respuesta> operacion)
        {
            try
            {
                return operacion();
            }
            catch (Exception ex)
            {
                return Error("No se pudo completar la operación: " + ex.Message);
            }
        }
    }
}
