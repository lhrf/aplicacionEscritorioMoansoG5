using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class VisitaDatos
    {
        private static VisitaDomiciliaria Mapear(SqlDataReader r) => new VisitaDomiciliaria
        {
            IdVisita = Leer.Entero(r, "IdVisita"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            Direccion = Leer.Texto(r, "Direccion"),
            Referencia = Leer.TextoNulo(r, "Referencia"),
            Telefono = Leer.Texto(r, "Telefono"),
            FechaProgramada = Leer.Fecha(r, "FechaProgramada"),
            Estado = Leer.Texto(r, "Estado"),
            Motivo = Leer.TextoNulo(r, "Motivo"),
            IdTecnico = Leer.EnteroNulo(r, "IdTecnico"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            Examenes = Leer.Texto(r, "Examenes"),
            NombreTecnico = Leer.Texto(r, "NombreTecnico"),
            EstadoAtencion = Leer.Texto(r, "EstadoAtencion"),
            NumeroComprobante = Leer.Texto(r, "NumeroComprobante")
        };

        public VisitaDomiciliaria? ObtenerPorAtencion(int idAtencion) =>
            Db.Obtener("usp_Visita_ObtenerPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        /// <summary>CU-09.</summary>
        public List<VisitaDomiciliaria> ListarPorFecha(DateTime fecha) => Db.Listar("usp_Visita_ListarPorFecha", Mapear, P("@Fecha", fecha.Date));

        /// <summary>CU-23.</summary>
        public List<VisitaDomiciliaria> ListarAsignadas(int idTecnico) => Db.Listar("usp_Visita_ListarAsignadas", Mapear, P("@IdTecnico", idTecnico));

        /// <summary>CU-30.</summary>
        public List<VisitaDomiciliaria> ListarDelDia(int idTecnico, DateTime fecha) =>
            Db.Listar("usp_Visita_ListarDelDia", Mapear, P("@IdTecnico", idTecnico), P("@Fecha", fecha.Date));

        public int Insertar(VisitaDomiciliaria v, int idUsuario) =>
            Db.Entero("usp_Visita_Insertar",
                P("@IdAtencion", v.IdAtencion), P("@Direccion", v.Direccion), P("@Referencia", v.Referencia), P("@Telefono", v.Telefono),
                P("@FechaProgramada", v.FechaProgramada.Date), P("@Estado", v.Estado), P("@IdUsuario", idUsuario));

        public void Actualizar(VisitaDomiciliaria v, int idUsuario) =>
            Db.Ejecutar("usp_Visita_Actualizar",
                P("@IdVisita", v.IdVisita), P("@Direccion", v.Direccion), P("@Referencia", v.Referencia), P("@Telefono", v.Telefono),
                P("@FechaProgramada", v.FechaProgramada.Date), P("@Estado", v.Estado), P("@Motivo", v.Motivo), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int idVisita, string estado, string? motivo, int idUsuario) =>
            Db.Ejecutar("usp_Visita_CambiarEstado", P("@IdVisita", idVisita), P("@Estado", estado), P("@Motivo", motivo), P("@IdUsuario", idUsuario));
    }
}
