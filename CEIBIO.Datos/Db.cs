using System.Data;
using Microsoft.Data.SqlClient;

namespace CEIBIO.Datos
{
    internal static class Db
    {
        public static SqlParameter P(string nombre, object? valor) => new SqlParameter(nombre, valor ?? DBNull.Value);

        public static List<T> Listar<T>(string procedimiento, Func<SqlDataReader, T> mapear, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            using var dr = cmd.ExecuteReader();
            var lista = new List<T>();
            while (dr.Read()) lista.Add(mapear(dr));
            return lista;
        }

        public static T? Obtener<T>(string procedimiento, Func<SqlDataReader, T> mapear, params SqlParameter[] parametros) where T : class
        {
            return Listar(procedimiento, mapear, parametros).FirstOrDefault();
        }

        public static void Ejecutar(string procedimiento, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            cmd.ExecuteNonQuery();
        }

        public static int Entero(string procedimiento, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            var valor = cmd.ExecuteScalar();
            return valor == null || valor is DBNull ? 0 : Convert.ToInt32(valor);
        }

        public static string Texto(string procedimiento, params SqlParameter[] parametros)
        {
            using var cn = Conexion.Abrir();
            using var cmd = Comando(cn, procedimiento, parametros);
            var valor = cmd.ExecuteScalar();
            return valor == null || valor is DBNull ? string.Empty : Convert.ToString(valor) ?? string.Empty;
        }

        public static string Lista(IEnumerable<int> ids) => string.Join(",", ids.Distinct());

        private static SqlCommand Comando(SqlConnection cn, string procedimiento, SqlParameter[] parametros)
        {
            var cmd = new SqlCommand(procedimiento, cn) { CommandType = CommandType.StoredProcedure };
            foreach (var p in parametros) cmd.Parameters.Add(p);
            return cmd;
        }
    }
}
