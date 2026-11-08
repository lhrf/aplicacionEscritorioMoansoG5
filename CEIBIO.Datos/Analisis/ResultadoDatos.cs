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

        public List<ResultadoAnalitico> ListarPorAtencion(int idAtencion) =>
            Db.Listar("usp_Resultado_ListarPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        public List<ResultadoAnalitico> ListarParametrosConValor(int idAtencion, int idExamen) =>
            Db.Listar("usp_Resultado_ListarParametrosConValor", Mapear, P("@IdAtencion", idAtencion), P("@IdExamen", idExamen));

        public void GuardarValores(int idAtencion, List<ResultadoAnalitico> valores, int idTecnico)
        {
            foreach (var v in valores)
                Db.Ejecutar("usp_Resultado_Guardar",
                    P("@IdAtencion", idAtencion), P("@IdParametro", v.IdParametro), P("@Valor", v.Valor), P("@IdTecnico", idTecnico));
        }

        public int EnviarAValidacion(int idAtencion, int idExamen, int idUsuario) =>
            Db.Entero("usp_Resultado_EnviarAValidacion", P("@IdAtencion", idAtencion), P("@IdExamen", idExamen), P("@IdUsuario", idUsuario));

        public List<ResultadoAnalitico> ListarAtencionesPendientes() => Db.Listar("usp_Resultado_ListarAtencionesPendientes", Mapear);

        public List<ResultadoAnalitico> ListarAnterioresDelPaciente(int idPaciente, int idAtencionActual) =>
            Db.Listar("usp_Resultado_ListarAnterioresDelPaciente", Mapear, P("@IdPaciente", idPaciente), P("@IdAtencion", idAtencionActual));

        public bool Validar(int idResultado, int idMedico) =>
            Db.Entero("usp_Resultado_Validar", P("@IdResultado", idResultado), P("@IdMedico", idMedico)) == 1;

        public void Retener(int idResultado, string observacion, int idMedico) =>
            Db.Ejecutar("usp_Resultado_Retener", P("@IdResultado", idResultado), P("@Observacion", observacion), P("@IdMedico", idMedico));

        public List<ResultadoAnalitico> ListarEnRepeticion() => Db.Listar("usp_Resultado_ListarEnRepeticion", Mapear);

        public void RegistrarRepeticion(int idResultado, string nuevoValor, int idTecnico) =>
            Db.Ejecutar("usp_Resultado_RegistrarRepeticion", P("@IdResultado", idResultado), P("@Valor", nuevoValor), P("@IdTecnico", idTecnico));
    }
}
