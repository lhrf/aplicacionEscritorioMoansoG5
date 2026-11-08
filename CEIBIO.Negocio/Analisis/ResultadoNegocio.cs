using CEIBIO.Datos;
using CEIBIO.Entidades;

namespace CEIBIO.Negocio
{
    public class ResultadoNegocio
    {
        private readonly ResultadoDatos datos = new();
        private readonly MuestraDatos muestraDatos = new();
        private readonly AtencionDatos atencionDatos = new();
        private readonly PacienteDatos pacienteDatos = new();
        private readonly IntervaloDatos intervaloDatos = new();

        public Muestra? BuscarMuestra(string codigo, out string mensaje)
        {
            mensaje = string.Empty;
            if (Validacion.Vacio(codigo)) { mensaje = "Ingrese el código de la muestra."; return null; }
            var muestra = muestraDatos.ObtenerPorCodigo(codigo.Trim().ToUpperInvariant());
            if (muestra == null) { mensaje = "El código de muestra no existe."; return null; }
            if (muestra.Estado != EstadoMuestra.RecibidaAnalisis)
            {
                mensaje = "La muestra no está recibida para análisis (estado actual: " + muestra.Estado + ").";
                return null;
            }
            return muestra;
        }

        public List<AtencionExamen> ListarExamenes(int idAtencion) => atencionDatos.ListarDetalle(idAtencion);

        public List<ResultadoAnalitico> ListarParametros(int idAtencion, int idExamen) => datos.ListarParametrosConValor(idAtencion, idExamen);

        public Respuesta GuardarResultados(int idAtencion, int idExamen, List<ResultadoAnalitico> valores, string? observacionesMicroscopicas) => Respuesta.Intentar(() =>
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            if (atencion == null || atencion.Estado != EstadoAtencion.RecibidaAnalisis)
                return Respuesta.Error("La atención no está recibida para análisis.");

            var actuales = datos.ListarParametrosConValor(idAtencion, idExamen);
            var aGuardar = new List<ResultadoAnalitico>();
            foreach (var v in valores)
            {
                string valor = (v.Valor ?? "").Trim();
                if (valor.Length == 0) continue;

                var actual = actuales.FirstOrDefault(a => a.IdParametro == v.IdParametro);
                if (actual == null) return Respuesta.Error("Uno de los parámetros no pertenece al examen.");
                if (actual.IdResultado > 0 && actual.Estado != EstadoResultado.Registrado)
                {
                    if (actual.Valor != valor)
                        return Respuesta.Error("El resultado de «" + actual.NombreParametro + "» ya fue enviado a validación y no se puede modificar.");
                    continue;
                }
                if (actual.EsCuantitativo)
                {
                    if (!Validacion.EsNumero(valor, out decimal numero))
                        return Respuesta.Error("El valor de «" + actual.NombreParametro + "» debe ser numérico.");
                    valor = numero.ToString(System.Globalization.CultureInfo.InvariantCulture);
                }
                aGuardar.Add(new ResultadoAnalitico { IdParametro = v.IdParametro, Valor = valor });
            }

            if (aGuardar.Count > 0) datos.GuardarValores(idAtencion, aGuardar, Sesion.IdUsuario);
            if (observacionesMicroscopicas != null)
                atencionDatos.GuardarObservacionesMicroscopicas(idAtencion, idExamen, Validacion.TextoONulo(observacionesMicroscopicas), Sesion.IdUsuario);

            return Respuesta.Ok("Resultados guardados (" + aGuardar.Count + " parámetro(s)).", idAtencion);
        });

        public Respuesta EnviarAValidacion(int idAtencion, int idExamen) => Respuesta.Intentar(() =>
        {
            var parametros = datos.ListarParametrosConValor(idAtencion, idExamen);
            var faltantes = parametros.Where(p => p.IdResultado == 0 || Validacion.Vacio(p.Valor)).Select(p => p.NombreParametro).ToList();
            if (faltantes.Count > 0) return Respuesta.Error("Faltan registrar: " + string.Join(", ", faltantes) + ".");

            int enviados = datos.EnviarAValidacion(idAtencion, idExamen, Sesion.IdUsuario);
            if (enviados == 0) return Respuesta.Error("No hay resultados registrados pendientes de envío para este examen.");
            return Respuesta.Ok(enviados + " resultado(s) enviados a validación del Médico Patólogo.", idAtencion);
        });

        public List<ResultadoAnalitico> ListarPendientesValidacion() => datos.ListarAtencionesPendientes();

        public Paciente? ObtenerPaciente(int idAtencion)
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            return atencion == null ? null : pacienteDatos.ObtenerPorId(atencion.IdPaciente);
        }

        public List<ResultadoAnalitico> ListarParaValidar(int idAtencion)
        {
            var resultados = datos.ListarPorAtencion(idAtencion);
            var paciente = ObtenerPaciente(idAtencion);
            if (paciente == null) return resultados;

            var intervalos = intervaloDatos.ListarPorAtencion(idAtencion);
            foreach (var r in resultados)
            {
                var intervalo = IntervaloNegocio.Elegir(intervalos, r.IdParametro, paciente.Sexo, paciente.Edad);
                r.IntervaloReferencia = intervalo?.Texto ?? "";
                r.FueraDeRango = EstaFueraDeRango(r.Valor, intervalo);
            }
            return resultados;
        }

        public List<ResultadoAnalitico> ListarAnteriores(int idAtencion)
        {
            var atencion = atencionDatos.ObtenerPorId(idAtencion);
            return atencion == null ? new List<ResultadoAnalitico>() : datos.ListarAnterioresDelPaciente(atencion.IdPaciente, idAtencion);
        }

        public Respuesta Validar(int idResultado) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idResultado);
            if (r == null) return Respuesta.Error("Seleccione un resultado.");
            if (r.Estado != EstadoResultado.PendienteValidacion) return Respuesta.Error("El resultado no está pendiente de validación (estado: " + r.Estado + ").");

            bool completa = datos.Validar(idResultado, Sesion.IdUsuario);
            return completa
                ? Respuesta.Ok("Resultado validado. Todos los resultados de la atención " + r.NumeroAtencion + " están validados: pasa a «Lista para reporte».", idResultado)
                : Respuesta.Ok("Resultado validado.", idResultado);
        });

        public Respuesta Retener(int idResultado, string observacion) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idResultado);
            if (r == null) return Respuesta.Error("Seleccione un resultado.");
            if (r.Estado != EstadoResultado.PendienteValidacion) return Respuesta.Error("Solo se retienen resultados pendientes de validación.");
            if (Validacion.Vacio(observacion)) return Respuesta.Error("Ingrese la observación para el Técnico Analista.");
            datos.Retener(idResultado, observacion.Trim(), Sesion.IdUsuario);
            return Respuesta.Ok("Resultado retenido: «Retener y Repetir». Se devolvió al Técnico Analista.", idResultado);
        });

        public List<ResultadoAnalitico> ListarEnRepeticion() => datos.ListarEnRepeticion();

        public Respuesta RegistrarRepeticion(int idResultado, string nuevoValor) => Respuesta.Intentar(() =>
        {
            var r = datos.ObtenerPorId(idResultado);
            if (r == null || r.Estado != EstadoResultado.EnRepeticion) return Respuesta.Error("Seleccione un resultado en repetición.");
            string valor = (nuevoValor ?? "").Trim();
            if (valor.Length == 0) return Respuesta.Error("Ingrese el nuevo resultado.");
            if (r.EsCuantitativo)
            {
                if (!Validacion.EsNumero(valor, out decimal numero)) return Respuesta.Error("El nuevo resultado debe ser numérico.");
                valor = numero.ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
            datos.RegistrarRepeticion(idResultado, valor, Sesion.IdUsuario);
            return Respuesta.Ok("Nuevo resultado guardado y reenviado a validación. Se conservó el resultado anterior.", idResultado);
        });

        public static bool EstaFueraDeRango(string? valor, IntervaloReferencia? intervalo)
        {
            if (intervalo == null || !Validacion.EsNumero(valor, out decimal numero)) return false;
            if (intervalo.ValorMinimo.HasValue && numero < intervalo.ValorMinimo.Value) return true;
            if (intervalo.ValorMaximo.HasValue && numero > intervalo.ValorMaximo.Value) return true;
            return false;
        }
    }
}
