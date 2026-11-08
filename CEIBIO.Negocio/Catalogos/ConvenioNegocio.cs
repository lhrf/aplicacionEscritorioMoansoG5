using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-07 Mantenedor de convenios.</summary>
    public class ConvenioNegocio
    {
        private readonly ConvenioDatos datos = new();

        public List<Convenio> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        /// <summary>Convenios habilitados y vigentes hoy (combo de CU-01).</summary>
        public List<Convenio> ListarVigentes() => datos.ListarVigentes();

        public Convenio? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(Convenio c) => Respuesta.Intentar(() =>
        {
            c.Institucion = (c.Institucion ?? "").Trim();
            if (Validacion.Vacio(c.Institucion)) return Respuesta.Error("Ingrese la institución.");
            if (c.PorcentajeDescuento <= 0 || c.PorcentajeDescuento > 100)
                return Respuesta.Error("El porcentaje de descuento debe estar entre 0.01 y 100.");
            if (c.FechaFin.Date <= c.FechaInicio.Date)
                return Respuesta.Error("El fin de la vigencia debe ser posterior al inicio.");
            if (datos.ExisteInstitucion(c.Institucion, c.IdConvenio))
                return Respuesta.Error("Ya existe un convenio habilitado con esa institución.");

            if (c.IdConvenio == 0)
                return Respuesta.Ok("Convenio registrado.", datos.Insertar(c, Sesion.IdUsuario));
            datos.Actualizar(c, Sesion.IdUsuario);
            return Respuesta.Ok("Convenio actualizado.", c.IdConvenio);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Convenio inhabilitado.");
        });
    }
}
