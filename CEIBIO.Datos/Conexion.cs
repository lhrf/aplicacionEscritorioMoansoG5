using Microsoft.Data.SqlClient;

namespace CEIBIO.Datos
{
    public static class Conexion
    {
        // Cambiar "Server" según la instancia de SQL Server de cada uno:
        //   SQL Server normal:   Server=localhost
        //   SQL Server Express:  Server=localhost\SQLEXPRESS
        public static string Cadena { get; set; } =
            @"Server=localhost;Database=CEIBIO_DB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection Abrir()
        {
            var cn = new SqlConnection(Cadena);
            cn.Open();
            return cn;
        }

        /// <summary>Devuelve true si se puede conectar a la base de datos.</summary>
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
