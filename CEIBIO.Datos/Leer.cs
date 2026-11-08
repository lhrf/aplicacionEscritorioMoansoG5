using Microsoft.Data.SqlClient;

namespace CEIBIO.Datos
{
    internal static class Leer
    {
        private static object? Valor(SqlDataReader r, string columna)
        {
            for (int i = 0; i < r.FieldCount; i++)
            {
                if (string.Equals(r.GetName(i), columna, StringComparison.OrdinalIgnoreCase))
                    return r.IsDBNull(i) ? null : r.GetValue(i);
            }
            return null;
        }

        public static string Texto(SqlDataReader r, string c) => Convert.ToString(Valor(r, c)) ?? string.Empty;
        public static string? TextoNulo(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? null : Convert.ToString(v); }
        public static int Entero(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? 0 : Convert.ToInt32(v); }
        public static int? EnteroNulo(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? null : Convert.ToInt32(v); }
        public static decimal Decimal(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? 0m : Convert.ToDecimal(v); }
        public static decimal? DecimalNulo(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? null : Convert.ToDecimal(v); }
        public static DateTime Fecha(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? DateTime.MinValue : Convert.ToDateTime(v); }
        public static DateTime? FechaNula(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? null : Convert.ToDateTime(v); }
        public static bool Booleano(SqlDataReader r, string c) { var v = Valor(r, c); return v != null && Convert.ToBoolean(v); }
        public static bool? BooleanoNulo(SqlDataReader r, string c) { var v = Valor(r, c); return v == null ? null : Convert.ToBoolean(v); }
    }
}
