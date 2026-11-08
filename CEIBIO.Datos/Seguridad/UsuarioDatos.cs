using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class UsuarioDatos
    {
        private static Usuario Mapear(SqlDataReader r) => new Usuario
        {
            IdUsuario = Leer.Entero(r, "IdUsuario"),
            NombreCompleto = Leer.Texto(r, "NombreCompleto"),
            Dni = Leer.Texto(r, "Dni"),
            NombreUsuario = Leer.Texto(r, "NombreUsuario"),
            ClaveHash = Leer.Texto(r, "ClaveHash"),
            Sal = Leer.Texto(r, "Sal"),
            IdRol = Leer.Entero(r, "IdRol"),
            NombreRol = Leer.Texto(r, "NombreRol"),
            Habilitado = Leer.Booleano(r, "Habilitado"),
            FechaRegistro = Leer.Fecha(r, "FechaRegistro")
        };

        public Usuario? ObtenerPorNombreUsuario(string nombreUsuario) =>
            Db.Obtener("usp_Usuario_ObtenerPorNombreUsuario", Mapear, P("@NombreUsuario", nombreUsuario));

        public Usuario? ObtenerPorId(int idUsuario) =>
            Db.Obtener("usp_Usuario_ObtenerPorId", Mapear, P("@IdUsuario", idUsuario));

        public List<Usuario> Listar(string filtro) =>
            Db.Listar("usp_Usuario_Listar", Mapear, P("@Filtro", filtro));

        public List<Usuario> ListarPorRol(string nombreRol) =>
            Db.Listar("usp_Usuario_ListarPorRol", Mapear, P("@Rol", nombreRol));

        public bool ExisteNombreUsuario(string nombreUsuario, int idExcluir) =>
            Db.Entero("usp_Usuario_ExisteNombreUsuario", P("@NombreUsuario", nombreUsuario), P("@IdExcluir", idExcluir)) > 0;

        public bool ExisteDni(string dni, int idExcluir) =>
            Db.Entero("usp_Usuario_ExisteDni", P("@Dni", dni), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(Usuario u, int idUsuarioRegistro) =>
            Db.Entero("usp_Usuario_Insertar",
                P("@NombreCompleto", u.NombreCompleto), P("@Dni", u.Dni), P("@NombreUsuario", u.NombreUsuario),
                P("@ClaveHash", u.ClaveHash), P("@IdRol", u.IdRol), P("@IdUsuarioRegistro", idUsuarioRegistro), P("@Sal", u.Sal));

        /// <summary>idUsuarioAccion: usuario en sesión que hace el cambio (RNF-20).</summary>
        public void Actualizar(Usuario u, int idUsuarioAccion) =>
            Db.Ejecutar("usp_Usuario_Actualizar",
                P("@IdUsuario", u.IdUsuario), P("@NombreCompleto", u.NombreCompleto), P("@Dni", u.Dni),
                P("@NombreUsuario", u.NombreUsuario), P("@IdRol", u.IdRol), P("@IdUsuarioAccion", idUsuarioAccion));

        public void CambiarEstado(int idUsuario, bool habilitado, int idUsuarioAccion) =>
            Db.Ejecutar("usp_Usuario_CambiarEstado", P("@IdUsuario", idUsuario), P("@Habilitado", habilitado), P("@IdUsuarioAccion", idUsuarioAccion));

        public void CambiarClave(int idUsuario, string claveHash, string sal) =>
            Db.Ejecutar("usp_Usuario_CambiarClave", P("@IdUsuario", idUsuario), P("@ClaveHash", claveHash), P("@Sal", sal));

        public void RegistrarInicioSesion(int idUsuario) =>
            Db.Ejecutar("usp_Sesion_Registrar", P("@IdUsuario", idUsuario));

        /// <summary>RNF-20: historial de cambios; tabla e idRegistro null = todos.</summary>
        public List<Auditoria> ConsultarAuditoria(string? tabla, int? idRegistro, DateTime desde, DateTime hasta) =>
            Db.Listar("usp_Auditoria_Consultar",
                r => new Auditoria
                {
                    IdAuditoria = Leer.Entero(r, "IdAuditoria"),
                    Tabla = Leer.Texto(r, "Tabla"),
                    IdRegistro = Leer.Entero(r, "IdRegistro"),
                    Accion = Leer.Texto(r, "Accion"),
                    Detalle = Leer.TextoNulo(r, "Detalle"),
                    IdUsuario = Leer.Entero(r, "IdUsuario"),
                    NombreUsuario = Leer.Texto(r, "NombreUsuario"),
                    FechaHora = Leer.Fecha(r, "FechaHora")
                }, P("@Tabla", string.IsNullOrWhiteSpace(tabla) ? null : tabla), P("@IdRegistro", idRegistro),
                P("@Desde", desde.Date), P("@Hasta", hasta.Date));

        public List<Rol> ListarRoles() =>
            Db.Listar("usp_Rol_Listar", r => new Rol { IdRol = Leer.Entero(r, "IdRol"), Nombre = Leer.Texto(r, "Nombre") });
    }
}
