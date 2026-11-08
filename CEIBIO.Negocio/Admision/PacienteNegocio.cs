using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class PacienteNegocio
    {
        private readonly PacienteDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();

        public static readonly string[] Sexos = { "Femenino", "Masculino" };

        public Paciente? BuscarPorDni(string dni) => Validacion.EsDni(dni) ? datos.ObtenerPorDni(dni.Trim()) : null;

        public Paciente? ObtenerPorId(int idPaciente) => datos.ObtenerPorId(idPaciente);

        public List<Atencion> ListarAtenciones(int idPaciente) => atencionDatos.ListarPorPaciente(idPaciente);

        public Respuesta Registrar(Paciente p) => Respuesta.Intentar(() =>
        {
            var error = Validar(p);
            if (error != null) return Respuesta.Error(error);
            if (datos.ExisteDni(p.Dni, 0)) return Respuesta.Error("Ya existe una Ficha clínica histórica con el DNI " + p.Dni + ".");
            int id = datos.Insertar(p, Sesion.IdUsuario);
            return Respuesta.Ok("Ficha clínica histórica registrada.", id);
        });

        public Respuesta Actualizar(Paciente p) => Respuesta.Intentar(() =>
        {
            if (p.IdPaciente <= 0) return Respuesta.Error("Primero busque al paciente.");
            var error = Validar(p);
            if (error != null) return Respuesta.Error(error);
            datos.Actualizar(p, Sesion.IdUsuario);
            return Respuesta.Ok("Datos de filiación actualizados.", p.IdPaciente);
        });

        private static string? Validar(Paciente p)
        {
            p.Dni = (p.Dni ?? "").Trim();
            p.Nombres = (p.Nombres ?? "").Trim();
            p.Apellidos = (p.Apellidos ?? "").Trim();
            p.Direccion = Validacion.TextoONulo(p.Direccion);
            p.Telefono = Validacion.TextoONulo(p.Telefono);

            if (!Validacion.EsDni(p.Dni)) return "El DNI debe tener 8 dígitos numéricos.";
            if (Validacion.Vacio(p.Nombres) || Validacion.Vacio(p.Apellidos)) return "Ingrese los nombres y los apellidos.";
            if (!Sexos.Contains(p.Sexo)) return "Seleccione el sexo.";
            if (p.FechaNacimiento.Date > DateTime.Today) return "La fecha de nacimiento no puede ser posterior a hoy.";
            if (p.FechaNacimiento.Date < DateTime.Today.AddYears(-120)) return "Revise la fecha de nacimiento.";
            if (p.Telefono != null && !Validacion.EsTelefono(p.Telefono)) return "El teléfono debe tener de 7 a 9 dígitos.";
            return null;
        }
    }
}
