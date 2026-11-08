using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public static class Sesion
    {
        public static Usuario? Usuario { get; private set; }

        public static bool Activa => Usuario != null;

        public static int IdUsuario => Usuario?.IdUsuario ?? throw new InvalidOperationException("No hay una sesión iniciada.");

        public static string NombreUsuario => Usuario?.NombreCompleto ?? string.Empty;

        public static string Rol => Usuario?.NombreRol ?? string.Empty;

        internal static void Iniciar(Usuario usuario) => Usuario = usuario;

        public static void Cerrar() => Usuario = null;
    }
}
