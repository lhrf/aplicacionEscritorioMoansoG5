using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class CondicionNegocio
    {
        private readonly CondicionDatos datos = new();

        public List<CondicionPreanalitica> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        public CondicionPreanalitica? ObtenerPorId(int id) => datos.ObtenerPorId(id);

        public Respuesta Guardar(CondicionPreanalitica c) => Respuesta.Intentar(() =>
        {
            c.RestriccionMedicamentos = Validacion.TextoONulo(c.RestriccionMedicamentos);
            c.MuestraQueDebeTraer = Validacion.TextoONulo(c.MuestraQueDebeTraer);

            if (c.IdExamen <= 0) return Respuesta.Error("Seleccione el examen.");
            if (c.HorasAyuno < 0 || c.HorasAyuno > 24) return Respuesta.Error("Las horas de ayuno deben estar entre 0 y 24.");
            if (c.HorasAyuno == 0 && c.RestriccionMedicamentos == null && c.MuestraQueDebeTraer == null)
                return Respuesta.Error("Ingrese al menos una condición: horas de ayuno, restricción de medicamentos o muestra que debe traer.");
            if (datos.ExisteParaExamen(c.IdExamen, c.IdCondicion))
                return Respuesta.Error("El examen ya tiene condiciones preanalíticas registradas. Edite el registro existente.");

            if (c.IdCondicion == 0)
                return Respuesta.Ok("Condiciones registradas.", datos.Insertar(c, Sesion.IdUsuario));
            datos.Actualizar(c, Sesion.IdUsuario);
            return Respuesta.Ok("Condiciones actualizadas.", c.IdCondicion);
        });

        public Respuesta Inhabilitar(int id) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(id, false, Sesion.IdUsuario);
            return Respuesta.Ok("Condiciones inhabilitadas.");
        });
    }
}
