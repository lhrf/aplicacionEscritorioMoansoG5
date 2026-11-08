using System.Text;
using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    /// <summary>
    /// CU-49 Elaborar Reporte clínico, CU-50 Revisar, CU-51 Autorizar, CU-52 Devolver para completar validaciones,
    /// CU-55 Consultar Reportes clínicos y CU-56 Consultar historial de revisiones.
    /// </summary>
    public class ReporteNegocio
    {
        private readonly ReporteDatos datos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly PacienteDatos pacienteDatos = new();
        private readonly ResultadoDatos resultadoDatos = new();
        private readonly PlantillaDatos plantillaDatos = new();
        private readonly IntervaloDatos intervaloDatos = new();

        // ---------------- CU-49 ----------------
        /// <summary>
        /// CU-49 paso 2: atenciones "Lista para reporte" que el Digitador debe trabajar
        /// (sin reporte, en borrador, observado, devuelto, revisado o autorizado). Atencion.EstadoReporte trae el estado del reporte.
        /// </summary>
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

        /// <summary>CU-49: una sección por examen con la plantilla usada; version null = versión vigente.</summary>
        public List<ReporteSeccion> ListarSecciones(int idReporte, int? version = null) => datos.ListarSecciones(idReporte, version);

        /// <summary>
        /// CU-49 paso 4: genera el reporte con una sección por examen según su plantilla (A4: si un examen no tiene plantilla,
        /// no se genera). Si el reporte estaba observado o devuelto, se crea una nueva versión (A1). Respuesta.Id = IdReporte.
        /// </summary>
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

        /// <summary>Texto para imprimir. Si es borrador, se marca como «BORRADOR» (CU-49 paso 5).</summary>
        public static string TextoImpresion(ReporteClinico r)
        {
            bool final = r.Definitivo && (r.Estado == EstadoReporte.Revisado || r.Estado == EstadoReporte.PendienteAutorizacion ||
                                          r.Estado == EstadoReporte.Autorizado || r.Estado == EstadoReporte.DisponibleEntrega ||
                                          r.Estado == EstadoReporte.Entregado || r.Estado == EstadoReporte.EntregaRetenida);
            if (final) return r.Contenido;
            return "******************** BORRADOR ********************" + Environment.NewLine + r.Contenido +
                   Environment.NewLine + "******************** BORRADOR ********************";
        }

        /// <summary>CU-49 pasos 6-7.</summary>
        public Respuesta EnviarARevision(int idReporte) =>
            CambiarEstado(idReporte, new[] { EstadoReporte.Borrador }, EstadoReporte.EnRevision, "Enviado a revisión", null,
                "Reporte enviado a revisión de calidad.");

        /// <summary>CU-49 A2: guarda el reporte definitivo (después de la conformidad del Supervisor de Calidad).</summary>
        public Respuesta GuardarDefinitivo(int idReporte) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null) return Respuesta.Error("Seleccione un reporte.");
            if (r.Estado != EstadoReporte.Revisado) return Respuesta.Error("Solo se guarda como definitivo un reporte revisado.");
            if (r.Definitivo) return Respuesta.Error("El reporte ya está guardado como definitivo.");
            datos.MarcarDefinitivo(idReporte, Sesion.IdUsuario);
            return Respuesta.Ok("Reporte definitivo guardado. Imprímalo en papel membretado y envíelo a autorización.", idReporte);
        });

        /// <summary>CU-49 A2.</summary>
        public Respuesta EnviarAAutorizacion(int idReporte) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null) return Respuesta.Error("Seleccione un reporte.");
            if (r.Estado != EstadoReporte.Revisado || !r.Definitivo) return Respuesta.Error("Primero guarde el reporte revisado como definitivo.");
            datos.CambiarEstado(idReporte, EstadoReporte.PendienteAutorizacion, "Enviado a autorización", null, Sesion.IdUsuario);
            return Respuesta.Ok("Reporte enviado a autorización del Director Médico.", idReporte);
        });

        /// <summary>CU-49 A3.</summary>
        public Respuesta EnviarAEntrega(int idReporte) =>
            CambiarEstado(idReporte, new[] { EstadoReporte.Autorizado }, EstadoReporte.DisponibleEntrega, "Enviado a entrega", null,
                "Reporte disponible para entrega.");

        // ---------------- CU-50 ----------------
        public List<ReporteClinico> ListarEnRevision() => datos.ListarPorEstado(EstadoReporte.EnRevision);

        /// <summary>Resultados validados de la atención para comparar con el reporte.</summary>
        public List<ResultadoAnalitico> ListarResultadosValidados(int idAtencion) =>
            resultadoDatos.ListarPorAtencion(idAtencion).Where(r => r.Estado == EstadoResultado.Validado).ToList();

        public Respuesta DarConformidad(int idReporte) =>
            CambiarEstado(idReporte, new[] { EstadoReporte.EnRevision }, EstadoReporte.Revisado, "Conformidad de calidad", null,
                "Conformidad registrada. El reporte está revisado.");

        /// <summary>CU-50 A1: registra las observaciones y devuelve el reporte al Digitador.</summary>
        public Respuesta Observar(int idReporte, string observaciones)
        {
            if (Validacion.Vacio(observaciones)) return Respuesta.Error("Ingrese las observaciones.");
            return CambiarEstado(idReporte, new[] { EstadoReporte.EnRevision }, EstadoReporte.Observado, "Observado por calidad", observaciones.Trim(),
                "Reporte observado y devuelto al Digitador Clínico.");
        }

        // ---------------- CU-51 / CU-52 ----------------
        public List<ReporteClinico> ListarPendientesAutorizacion() => datos.ListarPorEstado(EstadoReporte.PendienteAutorizacion);

        /// <summary>CU-51 paso 4: estado de validación de cada resultado (ValidadoTexto, NombreMedico, FechaValidacion).</summary>
        public List<ResultadoAnalitico> ListarValidaciones(int idAtencion) => resultadoDatos.ListarPorAtencion(idAtencion);

        /// <summary>CU-51: autoriza el reporte; después ya no se puede modificar. Si falta validar algo, usar DevolverAlMedico (CU-52).</summary>
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

        /// <summary>CU-52: devuelve el reporte al Médico Patólogo; los resultados vuelven a "Pendiente de validación".</summary>
        public Respuesta DevolverAlMedico(int idReporte, string observacion) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null || r.Estado != EstadoReporte.PendienteAutorizacion) return Respuesta.Error("Seleccione un reporte pendiente de autorización.");
            if (Validacion.Vacio(observacion)) return Respuesta.Error("Ingrese la observación para el Médico Patólogo.");
            datos.DevolverAlMedico(idReporte, observacion.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Reporte devuelto al Médico Patólogo para completar las validaciones.", idReporte);
        });

        /// <summary>CU-51 A2: anula la autorización (antes de la entrega); se generará una nueva versión.</summary>
        public Respuesta AnularAutorizacion(int idReporte, string motivo) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idReporte);
            if (r == null || (r.Estado != EstadoReporte.Autorizado && r.Estado != EstadoReporte.DisponibleEntrega))
                return Respuesta.Error("Solo se anula la autorización de un reporte autorizado que aún no se entregó.");
            if (Validacion.Vacio(motivo)) return Respuesta.Error("Ingrese el motivo de la anulación.");
            datos.AnularAutorizacion(idReporte, motivo.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Autorización anulada. El Digitador Clínico deberá generar una nueva versión.", idReporte);
        });

        /// <summary>Reportes autorizados (para la anulación en CU-51 A2).</summary>
        public List<ReporteClinico> ListarAutorizados() =>
            datos.ListarPorEstado(EstadoReporte.Autorizado).Concat(datos.ListarPorEstado(EstadoReporte.DisponibleEntrega)).ToList();

        // ---------------- CU-55 / CU-56 ----------------
        /// <summary>CU-55: si se indica DNI se busca por DNI; si no, por rango de fechas. Estado "(Todos)" o vacío = todos.</summary>
        public List<ReporteClinico> Consultar(string? dni, DateTime desde, DateTime hasta, string? estado)
        {
            if (estado == "(Todos)") estado = null;
            return datos.Consultar(dni, desde, hasta, estado);
        }

        /// <summary>CU-56: historial del reporte de una atención (acepta "AT-000012" o "12").</summary>
        public List<ReporteHistorial> ListarHistorial(string numeroAtencion)
        {
            var atencion = atencionDatos.ObtenerPorNumero(Validacion.NumeroAtencion(numeroAtencion));
            if (atencion == null) return new List<ReporteHistorial>();
            var reporte = datos.ObtenerPorAtencion(atencion.IdAtencion);
            return reporte == null ? new List<ReporteHistorial>() : datos.ListarHistorial(reporte.IdReporte);
        }

        // ---------------- auxiliares ----------------
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

        /// <summary>
        /// Arma el contenido completo del reporte y, por separado, una sección por examen con su plantilla (ReporteSeccion).
        /// El contenido completo es la cabecera más las secciones agrupadas por plantilla.
        /// </summary>
        private string ConstruirContenido(Atencion atencion, List<AtencionExamen> examenes, Dictionary<int, Plantilla> plantillas, int version,
                                          out List<ReporteSeccion> secciones)
        {
            var paciente = pacienteDatos.ObtenerPorId(atencion.IdPaciente);
            var resultados = resultadoDatos.ListarPorAtencion(atencion.IdAtencion);
            var intervalos = intervaloDatos.ListarPorAtencion(atencion.IdAtencion);
            string sexo = paciente?.Sexo ?? "";
            int edad = paciente?.Edad ?? 0;

            // Una sección por examen
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

            // Contenido completo: cabecera + secciones agrupadas por plantilla
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
