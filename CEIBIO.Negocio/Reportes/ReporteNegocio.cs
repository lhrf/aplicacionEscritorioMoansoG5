using System.Text;
using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class ReporteNegocio
    {
        private readonly ReporteDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly PacienteDatos pacienteDatos = new();
        private readonly ResultadoDatos resultadoDatos = new();
        private readonly PlantillaDatos plantillaDatos = new();
        private readonly IntervaloDatos intervaloDatos = new();

        public List<Atencion> ListarParaElaborar()
        {
            var lista = atencionDatos.ListarPorEstadoReporte(EstadoAtencion.ListaReporte, new[]
            {
                EstadoReporte.Borrador, EstadoReporte.Observado, EstadoReporte.DevueltoMedico, EstadoReporte.Revisado, EstadoReporte.Autorizado
            });
            foreach (var a in lista)
                if (Validacion.Vacio(a.EstadoReporte)) a.EstadoReporte = "Sin reporte";
            return lista;
        }

        public ReporteClinico? ObtenerPorAtencion(int idAtencion) => datos.ObtenerPorAtencion(idAtencion);

        public ReporteClinico? ObtenerPorId(int idReporte) => datos.ObtenerPorId(idReporte);

        public List<ReporteSeccion> ListarSecciones(int idReporte, int? version = null) => datos.ListarSecciones(idReporte, version);

        public Respuesta Generar(int idAtencion) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.ListaReporte) return Respuesta.Error("La atención no está lista para reporte.");

            var actual = datos.ObtenerPorAtencion(idAtencion);
            if (actual != null && actual.Estado != EstadoReporte.Borrador && actual.Estado != EstadoReporte.Observado && actual.Estado != EstadoReporte.DevueltoMedico)
                return Respuesta.Error("El reporte está «" + actual.Estado + "»; no se puede volver a generar.");

            var examenes = atencionDatos.ListarDetalle(idAtencion);
            var plantillas = new Dictionary<int, Plantilla>();
            foreach (var ex in examenes)
            {
                var plantilla = plantillaDatos.ObtenerPorExamen(ex.IdExamen);
                if (plantilla == null) return Respuesta.Error("El examen «" + ex.NombreExamen + "» no tiene plantilla asociada. No se generó el reporte.");
                plantillas[ex.IdExamen] = plantilla;
            }

            int version = actual == null ? 1 : actual.Version + (actual.Estado == EstadoReporte.Borrador ? 0 : 1);
            string contenido = ConstruirContenido(atencion, examenes, plantillas, version, out List<ReporteSeccion> secciones);

            if (actual == null)
            {
                int id = datos.Insertar(idAtencion, contenido, secciones, Sesion.IdUsuario);
                return Respuesta.Ok("Reporte clínico generado (versión 1, borrador).", id);
            }

            bool nuevaVersion = actual.Estado != EstadoReporte.Borrador;
            datos.Regenerar(actual.IdReporte, contenido, secciones, nuevaVersion, Sesion.IdUsuario);
            return Respuesta.Ok(nuevaVersion ? "Se generó la versión " + (actual.Version + 1) + " del reporte." : "Reporte regenerado.", actual.IdReporte);
        });

        public static string TextoImpresion(ReporteClinico r)
        {
            bool final = r.Definitivo && (r.Estado == EstadoReporte.Revisado || r.Estado == EstadoReporte.PendienteAutorizacion ||
                                          r.Estado == EstadoReporte.Autorizado || r.Estado == EstadoReporte.DisponibleEntrega ||
                                          r.Estado == EstadoReporte.Entregado || r.Estado == EstadoReporte.EntregaRetenida);
            if (final) return r.Contenido;
            return "******************** BORRADOR ********************" + Environment.NewLine + r.Contenido +
                   Environment.NewLine + "******************** BORRADOR ********************";
        }

        public Respuesta EnviarARevision(int idReporte) =>
            CambiarEstado(idReporte, new[] { EstadoReporte.Borrador }, EstadoReporte.EnRevision, "Enviado a revisión", null,
                "Reporte enviado a revisión de calidad.");

        public Respuesta GuardarDefinitivo(int idReporte) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null) return Respuesta.Error("Seleccione un reporte.");
            if (r.Estado != EstadoReporte.Revisado) return Respuesta.Error("Solo se guarda como definitivo un reporte revisado.");
            if (r.Definitivo) return Respuesta.Error("El reporte ya está guardado como definitivo.");
            datos.MarcarDefinitivo(idReporte, Sesion.IdUsuario);
            return Respuesta.Ok("Reporte definitivo guardado. Imprímalo en papel membretado y envíelo a autorización.", idReporte);
        });

        public Respuesta EnviarAAutorizacion(int idReporte) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null) return Respuesta.Error("Seleccione un reporte.");
            if (r.Estado != EstadoReporte.Revisado || !r.Definitivo) return Respuesta.Error("Primero guarde el reporte revisado como definitivo.");
            datos.CambiarEstado(idReporte, EstadoReporte.PendienteAutorizacion, "Enviado a autorización", null, Sesion.IdUsuario);
            return Respuesta.Ok("Reporte enviado a autorización del Director Médico.", idReporte);
        });

        public Respuesta EnviarAEntrega(int idReporte) =>
            CambiarEstado(idReporte, new[] { EstadoReporte.Autorizado }, EstadoReporte.DisponibleEntrega, "Enviado a entrega", null,
                "Reporte disponible para entrega.");

        public List<ReporteClinico> ListarEnRevision() => datos.ListarPorEstado(EstadoReporte.EnRevision);

        public List<ResultadoAnalitico> ListarResultadosValidados(int idAtencion) =>
            resultadoDatos.ListarPorAtencion(idAtencion).Where(r => r.Estado == EstadoResultado.Validado).ToList();

        public Respuesta DarConformidad(int idReporte) =>
            CambiarEstado(idReporte, new[] { EstadoReporte.EnRevision }, EstadoReporte.Revisado, "Conformidad de calidad", null,
                "Conformidad registrada. El reporte está revisado.");

        public Respuesta Observar(int idReporte, string observaciones)
        {
            if (Validacion.Vacio(observaciones)) return Respuesta.Error("Ingrese las observaciones.");
            return CambiarEstado(idReporte, new[] { EstadoReporte.EnRevision }, EstadoReporte.Observado, "Observado por calidad", observaciones.Trim(),
                "Reporte observado y devuelto al Digitador Clínico.");
        }

        public List<ReporteClinico> ListarPendientesAutorizacion() => datos.ListarPorEstado(EstadoReporte.PendienteAutorizacion);

        public List<ResultadoAnalitico> ListarValidaciones(int idAtencion) => resultadoDatos.ListarPorAtencion(idAtencion);

        public Respuesta Autorizar(int idReporte) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null || r.Estado != EstadoReporte.PendienteAutorizacion) return Respuesta.Error("Seleccione un reporte pendiente de autorización.");
            var resultados = resultadoDatos.ListarPorAtencion(r.IdAtencion);
            if (resultados.Count == 0 || resultados.Any(x => x.Estado != EstadoResultado.Validado))
                return Respuesta.Error("La validación está incompleta. Devuelva el reporte al Médico Patólogo.");
            datos.Autorizar(idReporte, Sesion.IdUsuario);
            return Respuesta.Ok("Reporte autorizado. Ya no se puede modificar.", idReporte);
        });

        public Respuesta DevolverAlMedico(int idReporte, string observacion) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null || r.Estado != EstadoReporte.PendienteAutorizacion) return Respuesta.Error("Seleccione un reporte pendiente de autorización.");
            if (Validacion.Vacio(observacion)) return Respuesta.Error("Ingrese la observación para el Médico Patólogo.");
            datos.DevolverAlMedico(idReporte, observacion.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Reporte devuelto al Médico Patólogo para completar las validaciones.", idReporte);
        });

        public Respuesta AnularAutorizacion(int idReporte, string motivo) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null || (r.Estado != EstadoReporte.Autorizado && r.Estado != EstadoReporte.DisponibleEntrega))
                return Respuesta.Error("Solo se anula la autorización de un reporte autorizado que aún no se entregó.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la anulación.");
            datos.AnularAutorizacion(idReporte, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Autorización anulada. El Digitador Clínico deberá generar una nueva versión.", idReporte);
        });

        public List<ReporteClinico> ListarAutorizados() =>
            datos.ListarPorEstado(EstadoReporte.Autorizado).Concat(datos.ListarPorEstado(EstadoReporte.DisponibleEntrega)).ToList();

        public List<ReporteClinico> Consultar(string? dni, DateTime desde, DateTime hasta, string? estado)
        {
            if (estado == "(Todos)") estado = null;
            return datos.Consultar(dni, desde, hasta, estado);
        }

        public List<ReporteHistorial> ListarHistorial(string numeroAtencion)
        {
            var atencion = atencionDatos.ObtenerPorNumero(Validacion.NumeroAtencion(numeroAtencion));
            if (atencion == null) return new List<ReporteHistorial>();
            var reporte = datos.ObtenerPorAtencion(atencion.IdAtencion);
            return reporte == null ? new List<ReporteHistorial>() : datos.ListarHistorial(reporte.IdReporte);
        }

        private Respuesta CambiarEstado(int idReporte, string[] estadosPermitidos, string nuevoEstado, string accion, string? observacion, string mensaje) =>
            Respuesta.Intentar(() =>
            {
                var r = datos.ObtenerPorId(idReporte);
                if (r == null) return Respuesta.Error("Seleccione un reporte.");
                if (!estadosPermitidos.Contains(r.Estado))
                    return Respuesta.Error("El reporte está «" + r.Estado + "»; la acción no corresponde a ese estado.");
                datos.CambiarEstado(idReporte, nuevoEstado, accion, observacion, Sesion.IdUsuario);
                return Respuesta.Ok(mensaje, idReporte);
            });

        private string ConstruirContenido(Atencion atencion, List<AtencionExamen> examenes, Dictionary<int, Plantilla> plantillas, int version,
                                          out List<ReporteSeccion> secciones)
        {
            var paciente = pacienteDatos.ObtenerPorId(atencion.IdPaciente);
            var resultados = resultadoDatos.ListarPorAtencion(atencion.IdAtencion);
            var intervalos = intervaloDatos.ListarPorAtencion(atencion.IdAtencion);
            string sexo = paciente?.Sexo ?? "";
            int edad = paciente?.Edad ?? 0;

            secciones = new List<ReporteSeccion>();
            foreach (var ex in examenes)
            {
                var sec = new StringBuilder();
                sec.AppendLine(ex.NombreExamen);
                sec.AppendLine("  " + "Parámetro".PadRight(28) + "Resultado".PadRight(14) + "Unidad".PadRight(12) + "Referencia");
                foreach (var r in resultados.Where(x => x.IdExamen == ex.IdExamen))
                {
                    var intervalo = IntervaloNegocio.Elegir(intervalos, r.IdParametro, sexo, edad);
                    string marca = ResultadoNegocio.EstaFueraDeRango(r.Valor, intervalo) ? " *" : "";
                    sec.AppendLine("  " + r.NombreParametro.PadRight(28) + ((r.Valor ?? "") + marca).PadRight(14) +
                                   (r.Unidad ?? "").PadRight(12) + (intervalo?.Texto ?? ""));
                }
                if (!Validacion.Vacio(ex.ObservacionesMicroscopicas))
                    sec.AppendLine("  Observaciones: " + ex.ObservacionesMicroscopicas);

                var plantilla = plantillas[ex.IdExamen];
                secciones.Add(new ReporteSeccion
                {
                    Version = version,
                    IdExamen = ex.IdExamen,
                    NombreExamen = ex.NombreExamen,
                    IdPlantilla = plantilla.IdPlantilla,
                    NombrePlantilla = plantilla.Nombre,
                    Contenido = sec.ToString()
                });
            }

            var sb = new StringBuilder();
            sb.AppendLine("LABORATORIO CLÍNICO CEIBIO S.A.C.");
            sb.AppendLine("REPORTE CLÍNICO - Atención " + atencion.NumeroAtencion + " - Versión " + version);
            sb.AppendLine();
            sb.AppendLine("Paciente: " + atencion.NombrePaciente);
            sb.AppendLine("DNI: " + atencion.Dni + "    Sexo: " + sexo + "    Edad: " + edad + " años");
            sb.AppendLine("Fecha de atención: " + atencion.FechaRegistro.ToString("dd/MM/yyyy"));
            sb.AppendLine("Fecha de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            foreach (var grupo in secciones.GroupBy(x => x.IdPlantilla))
            {
                sb.AppendLine();
                sb.AppendLine("==== " + grupo.First().NombrePlantilla.ToUpper() + " ====");
                foreach (var seccion in grupo) sb.Append(seccion.Contenido);
            }
            sb.AppendLine();
            sb.AppendLine("(*) Valor fuera del intervalo de referencia.");
            return sb.ToString();
        }
    }
}
