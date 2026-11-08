using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class IntervaloDatos
    {
        private static IntervaloReferencia Mapear(SqlDataReader r) => new IntervaloReferencia
        {
            IdIntervalo = Leer.Entero(r, "IdIntervalo"),
            IdParametro = Leer.Entero(r, "IdParametro"),
            NombreParametro = Leer.Texto(r, "NombreParametro"),
            IdExamen = Leer.Entero(r, "IdExamen"),
            NombreExamen = Leer.Texto(r, "NombreExamen"),
            ValorMinimo = Leer.DecimalNulo(r, "ValorMinimo"),
            ValorMaximo = Leer.DecimalNulo(r, "ValorMaximo"),
            Sexo = Leer.Texto(r, "Sexo"),
            EdadMinima = Leer.Entero(r, "EdadMinima"),
            EdadMaxima = Leer.Entero(r, "EdadMaxima"),
            ReferenciaTexto = Leer.TextoNulo(r, "ReferenciaTexto"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<IntervaloReferencia> Listar(string filtro) => Db.Listar("usp_Intervalo_Listar", Mapear, P("@Filtro", filtro));

        public List<IntervaloReferencia> ListarPorAtencion(int idAtencion) =>
            Db.Listar("usp_Intervalo_ListarPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        public IntervaloReferencia? ObtenerPorId(int id) => Db.Obtener("usp_Intervalo_ObtenerPorId", Mapear, P("@IdIntervalo", id));

        public bool ExisteSuperposicion(IntervaloReferencia i) =>
            Db.Entero("usp_Intervalo_ExisteSuperposicion", P("@IdParametro", i.IdParametro), P("@Sexo", i.Sexo),
                P("@EdadMinima", i.EdadMinima), P("@EdadMaxima", i.EdadMaxima), P("@IdExcluir", i.IdIntervalo)) > 0;

        public int Insertar(IntervaloReferencia i, int idUsuario) =>
            Db.Entero("usp_Intervalo_Insertar",
                P("@IdParametro", i.IdParametro), P("@ValorMinimo", i.ValorMinimo), P("@ValorMaximo", i.ValorMaximo), P("@Sexo", i.Sexo),
                P("@EdadMinima", i.EdadMinima), P("@EdadMaxima", i.EdadMaxima), P("@ReferenciaTexto", i.ReferenciaTexto), P("@IdUsuario", idUsuario));

        public void Actualizar(IntervaloReferencia i, int idUsuario) =>
            Db.Ejecutar("usp_Intervalo_Actualizar",
                P("@IdIntervalo", i.IdIntervalo), P("@IdParametro", i.IdParametro), P("@ValorMinimo", i.ValorMinimo), P("@ValorMaximo", i.ValorMaximo),
                P("@Sexo", i.Sexo), P("@EdadMinima", i.EdadMinima), P("@EdadMaxima", i.EdadMaxima), P("@ReferenciaTexto", i.ReferenciaTexto), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Intervalo_CambiarEstado", P("@IdIntervalo", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
