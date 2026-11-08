using System.Data;
using Microsoft.Data.SqlClient;

namespace CEIBIO.Datos
{
    /// <summary>
    /// Ejecuta los procedimientos almacenados de CEIBIO_DB (script 02_CEIBIO_Procedimientos.sql).
    /// Las operaciones que modifican varias tablas manejan su propia transacción dentro del procedimiento.
    /// </summary>
    internal static class Db
    {
        public static SqlParameter P(string nombre, object? valor) => new SqlParameter(nombre, valor ?? DBNull.Value);

        /// <summary>Procedimiento que devuelve filas (SELECT).</summary>
        public static List<T> Listar<T>(string procedimiento, Func<SqlDataReader, T> mapear, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            using var dr = cmd.ExecuteReader();
            var lista = new List<T>();
            while (dr.Read()) lista.Add(mapear(dr));
            return lista;
        }

        /// <summary>Procedimiento que devuelve una fila; null si no devuelve ninguna.</summary>
        public static T? Obtener<T>(string procedimiento, Func<SqlDataReader, T> mapear, params SqlParameter[] parametros) where T : class
        {
            return Listar(procedimiento, mapear, parametros).FirstOrDefault();
        }

        /// <summary>Procedimiento que solo inserta, actualiza o cambia estados.</summary>
        public static void Ejecutar(string procedimiento, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            cmd.ExecuteNonQuery();
        }

        /// <summary>Procedimiento que devuelve un número (Id generado, COUNT, turno, etc.).</summary>
        public static int Entero(string procedimiento, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            var valor = cmd.ExecuteScalar();
            return valor == null || valor is DBNull ? 0 : Convert.ToInt32(valor);
        }

        /// <summary>Procedimiento que devuelve un texto (primera columna de la primera fila).</summary>
        public static string Texto(string procedimiento, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            var valor = cmd.ExecuteScalar();
            return valor == null || valor is DBNull ? string.Empty : Convert.ToString(valor) ?? string.Empty;
        }

        /// <summary>Convierte una lista de Ids en el texto "1,3,5" que reciben los procedimientos.</summary>
        public static string Lista(IEnumerable<int> ids) => string.Join(",", ids.Distinct());

        private static SqlCommand Comando(SqlConnection cn, string procedimiento, SqlParameter[] parametros)
        {
            var cmd = new SqlCommand(procedimiento, cn) { CommandType = CommandType.StoredProcedure };
            foreach (var p in parametros) cmd.Parameters.Add(p);
            return cmd;
        }
    }
}
