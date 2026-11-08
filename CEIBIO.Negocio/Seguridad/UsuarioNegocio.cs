using System.Security.Cryptography;
using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-63 Iniciar sesión, CU-64 Mantenedor de usuarios, CU-65 Cambiar clave de acceso.</summary>
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos datos = new();
        private const int LongitudMinimaClave = 6;
        private const int Iteraciones = 100_000;

        /// <summary>RNF-19: sal aleatoria de 16 bytes, en hexadecimal (32 caracteres). Una distinta por usuario.</summary>
        public static string GenerarSal() => Convert.ToHexString(RandomNumberGenerator.GetBytes(16));

        /// <summary>
        /// RNF-19: hash con sal de la clave (PBKDF2-SHA256, 100 000 iteraciones, 32 bytes en hexadecimal).
        /// Nunca se guarda la clave en texto.
        /// </summary>
        public static string Hash(string clave, string sal) =>
            Convert.ToHexString(Rfc2898DeriveBytes.Pbkdf2(clave, Convert.FromHexString(sal), Iteraciones, HashAlgorithmName.SHA256, 32));

        /// <summary>Compara la clave con el hash guardado en tiempo constante.</summary>
        private static bool ClaveCorrecta(string clave, Usuario u)
        {
            if (Validacion.Vacio(u.Sal) || Validacion.Vacio(u.ClaveHash)) return false;
            return CryptographicOperations.FixedTimeEquals(
                Convert.FromHexString(Hash(clave, u.Sal)), Convert.FromHexString(u.ClaveHash.Trim()));
        }

        // ---------------- CU-63 ----------------
        public Respuesta IniciarSesion(string nombreUsuario, string clave) => Respuesta.Intentar(() =>
        {
            if (Validacion.Vacio(nombreUsuario) || Validacion.Vacio(clave))
                return Respuesta.Error("Ingrese el usuario y la clave.");

            var usuario = datos.ObtenerPorNombreUsuario(nombreUsuario.Trim());
            if (usuario == null || !ClaveCorrecta(clave, usuario))
                return Respuesta.Error("Usuario o clave incorrectos.");
            if (!usuario.Habilitado)
                return Respuesta.Error("El usuario está inhabilitado. Comuníquese con el Administrador del Sistema.");

            Sesion.Iniciar(usuario);
            datos.RegistrarInicioSesion(usuario.IdUsuario);
            return Respuesta.Ok("Bienvenido(a), " + usuario.NombreCompleto + ".", usuario.IdUsuario, usuario.NombreRol);
        });

        public void CerrarSesion() => Sesion.Cerrar();

        // ---------------- CU-65 ----------------
        public Respuesta CambiarClave(string claveActual, string claveNueva, string confirmacion) => Respuesta.Intentar(() =>
        {
            var usuario = datos.ObtenerPorId(Sesion.IdUsuario);
            if (usuario == null) return Respuesta.Error("No se encontró el usuario de la sesión.");
            if (Validacion.Vacio(claveActual) || Validacion.Vacio(claveNueva) || Validacion.Vacio(confirmacion))
                return Respuesta.Error("Complete los tres campos.");
            if (!ClaveCorrecta(claveActual, usuario))
                return Respuesta.Error("La clave actual no es correcta.");
            if (claveNueva.Length < LongitudMinimaClave)
                return Respuesta.Error("La nueva clave debe tener al menos " + LongitudMinimaClave + " caracteres.");
            if (claveNueva != confirmacion)
                return Respuesta.Error("La nueva clave y su confirmación no coinciden.");
            if (claveNueva == claveActual)
                return Respuesta.Error("La nueva clave debe ser distinta de la actual.");

            string sal = GenerarSal();
            datos.CambiarClave(usuario.IdUsuario, Hash(claveNueva, sal), sal);
            return Respuesta.Ok("La clave se cambió correctamente.");
        });

        // ---------------- CU-64 ----------------
        public List<Usuario> Listar(string filtro = "") => datos.Listar((filtro ?? "").Trim());

        public List<Rol> ListarRoles() => datos.ListarRoles();

        /// <summary>Usuarios habilitados de un rol, por ejemplo Roles.TecnicoItinerante (CU-22).</summary>
        public List<Usuario> ListarPorRol(string nombreRol) => datos.ListarPorRol(nombreRol);

        public Usuario? ObtenerPorId(int idUsuario) => datos.ObtenerPorId(idUsuario);

        /// <summary>Registra (IdUsuario = 0) o actualiza un usuario. La clave inicial solo se usa al registrar.</summary>
        public Respuesta Guardar(Usuario u, string? claveInicial) => Respuesta.Intentar(() =>
        {
            u.NombreCompleto = (u.NombreCompleto ?? "").Trim();
            u.Dni = (u.Dni ?? "").Trim();
            u.NombreUsuario = (u.NombreUsuario ?? "").Trim();

            if (Validacion.Vacio(u.NombreCompleto) || Validacion.Vacio(u.NombreUsuario) || u.IdRol <= 0)
                return Respuesta.Error("Complete el nombre, el nombre de usuario y el rol.");
            if (!Validacion.EsDni(u.Dni))
                return Respuesta.Error("El DNI debe tener 8 dígitos.");
            if (datos.ExisteDni(u.Dni, u.IdUsuario))
                return Respuesta.Error("Ya existe un usuario con ese DNI.");
            if (datos.ExisteNombreUsuario(u.NombreUsuario, u.IdUsuario))
                return Respuesta.Error("El nombre de usuario ya está en uso.");

            if (u.IdUsuario == 0)
            {
                if (Validacion.Vacio(claveInicial) || claveInicial!.Length < LongitudMinimaClave)
                    return Respuesta.Error("La clave inicial debe tener al menos " + LongitudMinimaClave + " caracteres.");
                u.Sal = GenerarSal();
                u.ClaveHash = Hash(claveInicial!, u.Sal);
                int id = datos.Insertar(u, Sesion.IdUsuario);
                return Respuesta.Ok("Usuario registrado.", id);
            }

            datos.Actualizar(u, Sesion.IdUsuario);
            return Respuesta.Ok("Usuario actualizado.", u.IdUsuario);
        });

        public Respuesta Inhabilitar(int idUsuario) => Respuesta.Intentar(() =>
        {
            if (idUsuario == Sesion.IdUsuario) return Respuesta.Error("No puede inhabilitar su propio usuario.");
            datos.CambiarEstado(idUsuario, false, Sesion.IdUsuario);
            return Respuesta.Ok("Usuario inhabilitado.");
        });

        public Respuesta Habilitar(int idUsuario) => Respuesta.Intentar(() =>
        {
            datos.CambiarEstado(idUsuario, true, Sesion.IdUsuario);
            return Respuesta.Ok("Usuario habilitado.");
        });
    }
}
