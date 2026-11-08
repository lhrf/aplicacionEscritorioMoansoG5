using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class ConvenioDatos
    {
        private static Convenio Mapear(SqlDataReader r) => new Convenio
        {
            IdConvenio = Leer.Entero(r, "IdConvenio"),
            Institucion = Leer.Texto(r, "Institucion"),
            PorcentajeDescuento = Leer.Decimal(r, "PorcentajeDescuento"),
            FechaInicio = Leer.Fecha(r, "FechaInicio"),
            FechaFin = Leer.Fecha(r, "FechaFin"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<Convenio> Listar(string filtro) => Db.Listar("usp_Convenio_Listar", Mapear, P("@Filtro", filtro));

        public List<Convenio> ListarVigentes() => Db.Listar("usp_Convenio_ListarVigentes", Mapear);

        public Convenio? ObtenerPorId(int id) => Db.Obtener("usp_Convenio_ObtenerPorId", Mapear, P("@IdConvenio", id));

        public bool ExisteInstitucion(string institucion, int idExcluir) =>
            Db.Entero("usp_Convenio_ExisteInstitucion", P("@Institucion", institucion), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(Convenio c, int idUsuario) =>
            Db.Entero("usp_Convenio_Insertar",
                P("@Institucion", c.Institucion), P("@PorcentajeDescuento", c.PorcentajeDescuento), P("@FechaInicio", c.FechaInicio.Date),
                P("@FechaFin", c.FechaFin.Date), P("@IdUsuario", idUsuario));

        public void Actualizar(Convenio c, int idUsuario) =>
            Db.Ejecutar("usp_Convenio_Actualizar",
                P("@IdConvenio", c.IdConvenio), P("@Institucion", c.Institucion), P("@PorcentajeDescuento", c.PorcentajeDescuento),
                P("@FechaInicio", c.FechaInicio.Date), P("@FechaFin", c.FechaFin.Date), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Convenio_CambiarEstado", P("@IdConvenio", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
