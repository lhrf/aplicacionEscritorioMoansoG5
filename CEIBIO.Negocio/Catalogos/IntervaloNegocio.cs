using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-54 Mantenedor de intervalos biológicos de referencia.</summary>
    public class IntervaloNegocio
    {
        private readonly IntervaloDatos datos = new();

        public static readonly string[] Sexos = { "Ambos", "Femenino", "Masculino" };

        public List<IntervaloReferencia> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        public IntervaloReferencia? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(IntervaloReferencia i) => Respuesta.Intentar(() =>
        {
            i.ReferenciaTexto = Validacion.TextoONulo(i.ReferenciaTexto);
            if (i.IdParametro <= 0) return Respuesta.Error("Seleccione el examen y el parámetro.");
            if (!i.ValorMinimo.HasValue && !i.ValorMaximo.HasValue && i.ReferenciaTexto == null)
                return Respuesta.Error("Ingrese el valor mínimo y/o máximo, o el valor de referencia en texto.");
            if (i.ValorMinimo.HasValue && i.ValorMaximo.HasValue && i.ValorMinimo >= i.ValorMaximo)
                return Respuesta.Error("El valor mínimo debe ser menor que el valor máximo.");
            if (i.EdadMinima < 0 || i.EdadMaxima > 120 || i.EdadMinima > i.EdadMaxima)
                return Respuesta.Error("Revise el rango de edad (0 a 120 años, mínima menor o igual a la máxima).");
            if (!Sexos.Contains(i.Sexo)) return Respuesta.Error("Seleccione el sexo.");
            if (datos.ExisteSuperposicion(i))
                return Respuesta.Error("El intervalo se superpone con otro intervalo habilitado del mismo parámetro y sexo (o «Ambos») para ese rango de edad.");

            if (i.IdIntervalo == 0)
                return Respuesta.Ok("Intervalo registrado.", datos.Insertar(i, Sesion.IdUsuario));
            datos.Actualizar(i, Sesion.IdUsuario);
            return Respuesta.Ok("Intervalo actualizado.", i.IdIntervalo);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Intervalo inhabilitado.");
        });

        /// <summary>
        /// Elige el intervalo que corresponde al sexo y la edad del paciente.
        /// Prefiere el del mismo sexo sobre "Ambos". Null si no hay intervalo.
        /// </summary>
        public static IntervaloReferencia? Elegir(IEnumerable<IntervaloReferencia> intervalos, int idParametro, string sexo, int edad)
        {
            return intervalos
                .Where(x => x.IdParametro == idParametro && x.Habilitado && edad >= x.EdadMinima && edad <= x.EdadMaxima
                            && (x.Sexo == sexo || x.Sexo == "Ambos"))
                .OrderBy(x => x.Sexo == sexo ? 0 : 1)
                .FirstOrDefault();
        }
    }
}
