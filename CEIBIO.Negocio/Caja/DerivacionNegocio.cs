using System.Text;
using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>CU-22 Derivar atención pagada.</summary>
    public class DerivacionNegocio
    {
        private readonly AtencionDatos atencionDatos = new();
        private readonly VisitaDatos visitaDatos = new();
        private readonly UsuarioDatos usuarioDatos = new();

        /// <summary>CU-22 paso 1: atenciones pagadas con comprobante emitido.</summary>
        public List<Atencion> ListarParaDerivar() => atencionDatos.ListarPagadas(true);

        /// <summary>Técnicos laboratoristas itinerantes habilitados (combo).</summary>
        public List<Usuario> ListarTecnicosItinerantes() => usuarioDatos.ListarPorRol(Roles.TecnicoItinerante);

        /// <summary>
        /// CU-22: en sede asigna el número de turno (Respuesta.Dato = turno);
        /// a domicilio asigna el técnico itinerante (idTecnico obligatorio).
        /// </summary>
        public Respuesta Derivar(int idAtencion, int? idTecnico) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.Pagada) return Respuesta.Error("Seleccione una atención pagada.");
            if (Validacion.Vacio(atencion.NumeroComprobante)) return Respuesta.Error("La atención no tiene Comprobante de pago emitido.");

            if (atencion.Modalidad == Modalidad.EnSede)
            {
                int turno = atencionDatos.AsignarTurno(idAtencion, Sesion.IdUsuario);
                return Respuesta.Ok("Turno N.° " + turno + " asignado. El paciente pasa a la sala de espera.", idAtencion, turno.ToString());
            }

            // A1: atención a domicilio
            if (!idTecnico.HasValue || idTecnico.Value <= 0) return Respuesta.Error("Seleccione el técnico itinerante.");
            var visita = visitaDatos.ObtenerPorAtencion(idAtencion);
            if (visita == null || visita.Estado == EstadoVisita.Cancelada)
                return Respuesta.Error("La atención no tiene una visita domiciliaria vigente. Debe programarla el Asesor de Admisión.");
            if (!ListarTecnicosItinerantes().Any(t => t.IdUsuario == idTecnico.Value))
                return Respuesta.Error("El técnico seleccionado no es un técnico itinerante habilitado.");

            atencionDatos.AsignarTecnico(idAtencion, idTecnico.Value, Sesion.IdUsuario);
            return Respuesta.Ok("Visita asignada al técnico itinerante.", idAtencion);
        });

        /// <summary>Texto del ticket de turno para imprimir.</summary>
        public static string TextoTicket(Atencion atencion, int turno)
        {
            var sb = new StringBuilder();
            sb.AppendLine("LABORATORIO CLÍNICO CEIBIO S.A.C.");
            sb.AppendLine("TICKET DE TURNO");
            sb.AppendLine();
            sb.AppendLine("TURNO N.° " + turno.ToString("000"));
            sb.AppendLine();
            sb.AppendLine("Paciente: " + atencion.NombrePaciente);
            sb.AppendLine("Atención: " + atencion.NumeroAtencion);
            sb.AppendLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Espere su llamado en la sala de espera.");
            return sb.ToString();
        }
    }
}
