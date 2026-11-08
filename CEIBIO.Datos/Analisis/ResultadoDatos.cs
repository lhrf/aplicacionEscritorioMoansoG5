using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class ResultadoDatos
    {
        private static ResultadoAnalitico Mapear(SqlDataReader r) => new ResultadoAnalitico
        {
            IdResultado = Leer.Entero(r, "IdResultado"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            IdParametro = Leer.Entero(r, "IdParametro"),
            Valor = Leer.TextoNulo(r, "Valor"),
            Estado = Leer.Texto(r, "Estado"),
            FechaRegistro = Leer.Fecha(r, "FechaRegistro"),
            FechaEnvio = Leer.FechaNula(r, "FechaEnvio"),
            ObservacionMedico = Leer.TextoNulo(r, "ObservacionMedico"),
            FechaValidacion = Leer.FechaNula(r, "FechaValidacion"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            IdExamen = Leer.Entero(r, "IdExamen"),
            NombreExamen = Leer.Texto(r, "NombreExamen"),
            NombreParametro = Leer.Texto(r, "NombreParametro"),
            Unidad = Leer.TextoNulo(r, "Unidad"),
            NombreTecnico = Leer.Texto(r, "NombreTecnico"),
            NombreMedico = Leer.Texto(r, "NombreMedico"),
            ValorAnterior = Leer.TextoNulo(r, "ValorAnterior")
        };

        public ResultadoAnalitico? ObtenerPorId(int idResultado) =>
            Db.Obtener("usp_Resultado_ObtenerPorId", Mapear, P("@IdResultado", idResultado));

        /// <summary>CU-46 y CU-51: todos los resultados de la atención.</summary>
        public List<ResultadoAnalitico> ListarPorAtencion(int idAtencion) =>
            Db.Listar("usp_Resultado_ListarPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        /// <summary>CU-39: parámetros del examen con el valor registrado (IdResultado = 0 si aún no se registra).</summary>
        public List<ResultadoAnalitico> ListarParametrosConValor(int idAtencion, int idExamen) =>
            Db.Listar("usp_Resultado_ListarParametrosConValor", Mapear, P("@IdAtencion", idAtencion), P("@IdExamen", idExamen));

        /// <summary>CU-39: guarda los valores; el procedimiento solo modifica los que aún no se enviaron a validación.</summary>
        public void GuardarValores(int idAtencion, List<ResultadoAnalitico> valores, int idTecnico)
        {
            foreach (var v in valores)
                Db.Ejecutar("usp_Resultado_Guardar",
                    P("@IdAtencion", idAtencion), P("@IdParametro", v.IdParametro), P("@Valor", v.Valor), P("@IdTecnico", idTecnico));
        }

        /// <summary>CU-39 paso 7. Devuelve cuántos resultados se enviaron.</summary>
        public int EnviarAValidacion(int idAtencion, int idExamen, int idUsuario) =>
            Db.Entero("usp_Resultado_EnviarAValidacion", P("@IdAtencion", idAtencion), P("@IdExamen", idExamen), P("@IdUsuario", idUsuario));

        /// <summary>CU-40: un registro por atención.</summary>
        public List<ResultadoAnalitico> ListarAtencionesPendientes() => Db.Listar("usp_Resultado_ListarAtencionesPendientes", Mapear);

        /// <summary>CU-46: resultados validados de atenciones anteriores del paciente.</summary>
        public List<ResultadoAnalitico> ListarAnterioresDelPaciente(int idPaciente, int idAtencionActual) =>
            Db.Listar("usp_Resultado_ListarAnterioresDelPaciente", Mapear, P("@IdPaciente", idPaciente), P("@IdAtencion", idAtencionActual));

        /// <summary>CU-46: valida un resultado. Devuelve true si la atención quedó "Lista para reporte".</summary>
        public bool Validar(int idResultado, int idMedico) =>
            Db.Entero("usp_Resultado_Validar", P("@IdResultado", idResultado), P("@IdMedico", idMedico)) == 1;

        /// <summary>CU-47.</summary>
        public void Retener(int idResultado, string observacion, int idMedico) =>
            Db.Ejecutar("usp_Resultado_Retener", P("@IdResultado", idResultado), P("@Observacion", observacion), P("@IdMedico", idMedico));

        /// <summary>CU-48.</summary>
        public List<ResultadoAnalitico> ListarEnRepeticion() => Db.Listar("usp_Resultado_ListarEnRepeticion", Mapear);

        /// <summary>CU-48: guarda el nuevo valor, conserva el anterior y reenvía a validación.</summary>
        public void RegistrarRepeticion(int idResultado, string nuevoValor, int idTecnico) =>
            Db.Ejecutar("usp_Resultado_RegistrarRepeticion", P("@IdResultado", idResultado), P("@Valor", nuevoValor), P("@IdTecnico", idTecnico));
    }
}
