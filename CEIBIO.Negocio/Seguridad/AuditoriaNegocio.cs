using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class AuditoriaNegocio
    {
        private readonly UsuarioDatos datos = new();

        public List<Auditoria> Consultar(string? tabla, int? idRegistro, DateTime desde, DateTime hasta) =>
            datos.ConsultarAuditoria(tabla, idRegistro, desde, hasta);

        public List<Auditoria> HistorialAtencion(int idAtencion) =>
            datos.ConsultarAuditoria("Atencion", idAtencion, new DateTime(2000, 1, 1), DateTime.Today);
    }
}
