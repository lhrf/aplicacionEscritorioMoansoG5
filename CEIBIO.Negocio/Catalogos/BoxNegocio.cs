using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class BoxNegocio
    {
        private readonly BoxDatos datos = new();

        public List<Box> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        public List<Box> ListarLibres() => datos.ListarLibres();

        public Box? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Box b) => Respuesta.Intentar(() =>
        {
            b.Numero = (b.Numero ?? "").Trim();
            b.Descripcion = Validacion.TextoONulo(b.Descripcion);
            if (Validacion.Vacio(b.Numero)) return Respuesta.Error("Ingrese el número del box.");
            if (datos.ExisteNumero(b.Numero, b.IdBox)) return Respuesta.Error("El box " + b.Numero + " ya está registrado.");

            if (b.IdBox == 0)
                return Respuesta.Ok("Box registrado.", datos.Insertar(b, Sesion.IdUsuario));
            datos.Actualizar(b, Sesion.IdUsuario);
            return Respuesta.Ok("Box actualizado.", b.IdBox);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            if (datos.EstaEnUso(id))
                return Respuesta.Error("El box está asignado a una atención en toma de muestra; no se puede inhabilitar.");
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Box inhabilitado.");
        });
    }
}
