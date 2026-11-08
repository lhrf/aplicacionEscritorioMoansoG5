using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class UsoEquipoNegocio
    {
        private readonly UsoEquipoDatos datos = new();
        private readonly EquipoDatos equipoDatos = new();
        private readonly MuestraDatos muestraDatos = new();

        public List<Equipo> ListarEquipos() => equipoDatos.Listar("", true);

        public Respuesta RegistrarUso(int idEquipo, string codigoMuestra) => Respuesta.Intentar(() =>
        {
            var equipo = equipoDatos.ObtenerPorId(idEquipo);
            if (equipo == null || !equipo.Habilitado) return Respuesta.Error("Seleccione un equipo habilitado.");
            if (Validacion.Vacio(codigoMuestra)) return Respuesta.Error("Ingrese el código de la muestra.");
            var muestra = muestraDatos.ObtenerPorCodigo(codigoMuestra.Trim().ToUpperInvariant());
            if (muestra == null) return Respuesta.Error("El código de muestra no existe.");
            if (muestra.Estado != EstadoMuestra.RecibidaAnalisis) return Respuesta.Error("La muestra no está recibida para análisis.");

            int idUso = datos.Registrar(idEquipo, muestra.IdMuestra, Sesion.IdUsuario);
            return Respuesta.Ok("Uso registrado en la bitácora del equipo " + equipo.Nombre + ".", idUso, DateTime.Now.ToString("HH:mm"));
        });

        public List<UsoEquipo> ListarUsosDeHoy() => datos.ListarDelDia(DateTime.Today);

        public UsoEquipo? ObtenerUso(int idUso) => datos.ObtenerPorId(idUso);

        public Respuesta RegistrarFalla(int idUso, string descripcion) => Respuesta.Intentar(() =>
        {
            if (datos.ObtenerPorId(idUso) == null) return Respuesta.Error("Seleccione el uso del equipo en el que ocurrió la falla.");
            if (Validacion.Vacio(descripcion)) return Respuesta.Error("Describa la falla.");
            datos.RegistrarFalla(idUso, descripcion.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Falla registrada. La muestra quedó marcada para una nueva corrida.", idUso);
        });

        public List<UsoEquipo> ConsultarBitacora(int idEquipo, DateTime desde, DateTime hasta) => datos.ConsultarBitacora(idEquipo, desde, hasta);
    }
}
