namespace CEIBIO.Negocio
{
    public class Respuesta
    {
        public bool Exito { get; private set; }
        public string Mensaje { get; private set; } = string.Empty;
        public int Id { get; private set; }
        public string Dato { get; private set; } = string.Empty;

        public static Respuesta Ok(string mensaje, int id = 0, string dato = "") =>
            new Respuesta { Exito = true, Mensaje = mensaje, Id = id, Dato = dato };

        public static Respuesta Error(string mensaje) => new Respuesta { Exito = false, Mensaje = mensaje };

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
