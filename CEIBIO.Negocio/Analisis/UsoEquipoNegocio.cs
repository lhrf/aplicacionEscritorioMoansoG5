using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-41 Registrar uso del equipo, CU-42 Registrar falla analítica y CU-45 Consultar bitácora de uso del equipo.</summary>
    public class UsoEquipoNegocio
    {
        private readonly UsoEquipoDatos datos = new();
        private readonly EquipoDatos equipoDatos = new();
        private readonly MuestraDatos muestraDatos = new();

        /// <summary>CU-41 paso 2: equipos habilitados.</summary>
        public List<Equipo> ListarEquipos() => equipoDatos.Listar("", true);

        /// <summary>CU-41: registra la hora de inicio, el equipo y la muestra. Respuesta.Id = IdUso, Respuesta.Dato = hora.</summary>
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

        /// <summary>CU-42: registra la falla de calibración y marca la muestra para una nueva corrida.</summary>
        public Respuesta RegistrarFalla(int idUso, string descripcion) => Respuesta.Intentar(() =>
        {
            if (datos.ObtenerPorId(idUso) == null) return Respuesta.Error("Seleccione el uso del equipo en el que ocurrió la falla.");
            if (Validacion.Vacio(descripcion)) return Respuesta.Error("Describa la falla.");
            datos.RegistrarFalla(idUso, descripcion.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Falla registrada. La muestra quedó marcada para una nueva corrida.", idUso);
        });

        /// <summary>CU-45: idEquipo = 0 para todos los equipos.</summary>
        public List<UsoEquipo> ConsultarBitacora(int idEquipo, DateTime desde, DateTime hasta) => datos.ConsultarBitacora(idEquipo, desde, hasta);
    }
}
