using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class UsoEquipoDatos
    {
        private static UsoEquipo Mapear(SqlDataReader r) => new UsoEquipo
        {
            IdUso = Leer.Entero(r, "IdUso"),
            IdEquipo = Leer.Entero(r, "IdEquipo"),
            IdMuestra = Leer.Entero(r, "IdMuestra"),
            HoraInicio = Leer.Fecha(r, "HoraInicio"),
            RequiereNuevaCorrida = Leer.Booleano(r, "RequiereNuevaCorrida"),
            NombreEquipo = Leer.Texto(r, "NombreEquipo"),
            CodigoMuestra = Leer.Texto(r, "CodigoMuestra"),
            NombreTecnico = Leer.Texto(r, "NombreTecnico"),
            FallaAnalitica = Leer.Texto(r, "FallaAnalitica")
        };

        public UsoEquipo? ObtenerPorId(int idUso) => Db.Obtener("usp_UsoEquipo_ObtenerPorId", Mapear, P("@IdUso", idUso));

        /// <summary>CU-41: registra el inicio del procesamiento. Devuelve el Id del uso.</summary>
        public int Registrar(int idEquipo, int idMuestra, int idTecnico) =>
            Db.Entero("usp_UsoEquipo_Registrar", P("@IdEquipo", idEquipo), P("@IdMuestra", idMuestra), P("@IdTecnico", idTecnico));

        public List<UsoEquipo> ListarDelDia(DateTime fecha) => Db.Listar("usp_UsoEquipo_ListarDelDia", Mapear, P("@Fecha", fecha.Date));

        /// <summary>CU-42.</summary>
        public void RegistrarFalla(int idUso, string descripcion, int idTecnico) =>
            Db.Ejecutar("usp_UsoEquipo_RegistrarFalla", P("@IdUso", idUso), P("@Descripcion", descripcion), P("@IdTecnico", idTecnico));

        /// <summary>CU-45: idEquipo = 0 para todos.</summary>
        public List<UsoEquipo> ConsultarBitacora(int idEquipo, DateTime desde, DateTime hasta) =>
            Db.Listar("usp_UsoEquipo_ConsultarBitacora", Mapear, P("@IdEquipo", idEquipo), P("@Desde", desde.Date), P("@Hasta", hasta.Date));
    }
}
