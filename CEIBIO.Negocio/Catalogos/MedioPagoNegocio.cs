using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class MedioPagoNegocio
    {
        private readonly MedioPagoDatos datos = new();

        public List<MedioPago> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim(), false);

        public List<MedioPago> ListarHabilitados() => datos.Listar("", true);

        public MedioPago? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(MedioPago m) => Respuesta.Intentar(() =>
        {
            m.Codigo = (m.Codigo ?? "").Trim().ToUpperInvariant();
            m.Descripcion = (m.Descripcion ?? "").Trim();
            if (Validacion.Vacio(m.Codigo) || Validacion.Vacio(m.Descripcion))
                return Respuesta.Error("Complete el código y la descripción.");
            if (datos.ExisteCodigo(m.Codigo, m.IdMedioPago)) return Respuesta.Error("El código " + m.Codigo + " ya está registrado.");

            if (m.IdMedioPago == 0)
                return Respuesta.Ok("Medio de pago registrado.", datos.Insertar(m, Sesion.IdUsuario));
            datos.Actualizar(m, Sesion.IdUsuario);
            return Respuesta.Ok("Medio de pago actualizado.", m.IdMedioPago);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Medio de pago inhabilitado.");
        });
    }
}
