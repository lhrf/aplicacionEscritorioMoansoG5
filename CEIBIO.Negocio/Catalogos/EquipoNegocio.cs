using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-43 Mantenedor de equipos analizadores.</summary>
    public class EquipoNegocio
    {
        private readonly EquipoDatos datos = new();

        public static readonly string[] Tipos = { "Automatizado", "Microscopio" };

        public List<Equipo> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim(), false);

        /// <summary>Equipos habilitados (CU-41 y CU-45).</summary>
        public List<Equipo> ListarHabilitados() => datos.Listar("", true);

        public Equipo? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Equipo e) => Respuesta.Intentar(() =>
        {
            e.Codigo = (e.Codigo ?? "").Trim().ToUpperInvariant();
            e.Nombre = (e.Nombre ?? "").Trim();
            e.Marca = Validacion.TextoONulo(e.Marca);
            e.Modelo = Validacion.TextoONulo(e.Modelo);
            if (Validacion.Vacio(e.Codigo) || Validacion.Vacio(e.Nombre) || Validacion.Vacio(e.Tipo))
                return Respuesta.Error("Complete el código, el nombre y el tipo.");
            if (datos.ExisteCodigo(e.Codigo, e.IdEquipo)) return Respuesta.Error("El código " + e.Codigo + " ya está registrado.");

            if (e.IdEquipo == 0)
                return Respuesta.Ok("Equipo registrado.", datos.Insertar(e, Sesion.IdUsuario));
            datos.Actualizar(e, Sesion.IdUsuario);
            return Respuesta.Ok("Equipo actualizado.", e.IdEquipo);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Equipo inhabilitado.");
        });
    }
}
