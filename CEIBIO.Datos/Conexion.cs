using Microsoft.Data.SqlClient;

namespace CEIBIO.Datos
{
    public static class Conexion
    {
        public static string Cadena { get; set; } =
            @"Server=localhost;Database=CEIBIO_DB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection Abrir()
        {
            var cn = new SqlConnection(Cadena);
            cn.Open();
            return cn;
        }

        public static bool Probar(out string mensaje)
        {
            try
            {
                using var cn = Abrir();
                mensaje = "Conexión correcta.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}
