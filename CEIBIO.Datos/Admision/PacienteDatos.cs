using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class PacienteDatos
    {
        private static Paciente Mapear(SqlDataReader r) => new Paciente
        {
            IdPaciente = Leer.Entero(r, "IdPaciente"),
            Dni = Leer.Texto(r, "Dni"),
            Nombres = Leer.Texto(r, "Nombres"),
            Apellidos = Leer.Texto(r, "Apellidos"),
            FechaNacimiento = Leer.Fecha(r, "FechaNacimiento"),
            Sexo = Leer.Texto(r, "Sexo"),
            Direccion = Leer.TextoNulo(r, "Direccion"),
            Telefono = Leer.TextoNulo(r, "Telefono")
        };

        public Paciente? ObtenerPorDni(string dni) => Db.Obtener("usp_Paciente_ObtenerPorDni", Mapear, P("@Dni", dni));

        public Paciente? ObtenerPorId(int id) => Db.Obtener("usp_Paciente_ObtenerPorId", Mapear, P("@IdPaciente", id));

        public bool ExisteDni(string dni, int idExcluir) =>
            Db.Entero("usp_Paciente_ExisteDni", P("@Dni", dni), P("@IdExcluir", idExcluir)) > 0;

        public int Insertar(Paciente p, int idUsuario) =>
            Db.Entero("usp_Paciente_Insertar",
                P("@Dni", p.Dni), P("@Nombres", p.Nombres), P("@Apellidos", p.Apellidos), P("@FechaNacimiento", p.FechaNacimiento.Date),
                P("@Sexo", p.Sexo), P("@Direccion", p.Direccion), P("@Telefono", p.Telefono), P("@IdUsuario", idUsuario));

        public void Actualizar(Paciente p, int idUsuario) =>
            Db.Ejecutar("usp_Paciente_Actualizar",
                P("@IdPaciente", p.IdPaciente), P("@Nombres", p.Nombres), P("@Apellidos", p.Apellidos), P("@FechaNacimiento", p.FechaNacimiento.Date),
                P("@Sexo", p.Sexo), P("@Direccion", p.Direccion), P("@Telefono", p.Telefono), P("@IdUsuario", idUsuario));
    }
}
