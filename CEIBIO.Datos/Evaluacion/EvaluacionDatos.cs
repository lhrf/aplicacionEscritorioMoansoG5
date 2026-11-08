using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class EvaluacionDatos
    {
        private static EvaluacionPreanalitica Mapear(SqlDataReader r) => new EvaluacionPreanalitica
        {
            IdEvaluacion = Leer.Entero(r, "IdEvaluacion"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            HorasAyuno = Leer.Entero(r, "HorasAyuno"),
            Medicamentos = Leer.TextoNulo(r, "Medicamentos"),
            RotuladoCorrecto = Leer.BooleanoNulo(r, "RotuladoCorrecto"),
            RecipienteHermetico = Leer.BooleanoNulo(r, "RecipienteHermetico"),
            VolumenSuficiente = Leer.BooleanoNulo(r, "VolumenSuficiente"),
            ConservacionAdecuada = Leer.BooleanoNulo(r, "ConservacionAdecuada"),
            Observaciones = Leer.TextoNulo(r, "Observaciones"),
            FechaObservacion = Leer.Fecha(r, "FechaObservacion"),
            Resultado = Leer.TextoNulo(r, "Resultado"),
            FechaResultado = Leer.FechaNula(r, "FechaResultado"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            NombreEnfermera = Leer.Texto(r, "NombreEnfermera")
        };

        private static Suspension MapearSuspension(SqlDataReader r) => new Suspension
        {
            IdSuspension = Leer.Entero(r, "IdSuspension"),
            IdAtencion = Leer.Entero(r, "IdAtencion"),
            Motivo = Leer.Texto(r, "Motivo"),
            NuevaFecha = Leer.Fecha(r, "NuevaFecha"),
            FechaRegistro = Leer.Fecha(r, "FechaRegistro"),
            Reactivada = Leer.Booleano(r, "Reactivada"),
            FechaReactivacion = Leer.FechaNula(r, "FechaReactivacion"),
            NumeroAtencion = Leer.Texto(r, "NumeroAtencion"),
            NombrePaciente = Leer.Texto(r, "NombrePaciente"),
            NombreEnfermera = Leer.Texto(r, "NombreEnfermera")
        };

        public EvaluacionPreanalitica? ObtenerPorAtencion(int idAtencion) =>
            Db.Obtener("usp_Evaluacion_ObtenerPorAtencion", Mapear, P("@IdAtencion", idAtencion));

        public void GuardarObservaciones(EvaluacionPreanalitica e, int idUsuario) =>
            Db.Ejecutar("usp_Evaluacion_GuardarObservaciones",
                P("@IdAtencion", e.IdAtencion), P("@HorasAyuno", e.HorasAyuno), P("@Medicamentos", e.Medicamentos),
                P("@RotuladoCorrecto", e.RotuladoCorrecto), P("@RecipienteHermetico", e.RecipienteHermetico),
                P("@VolumenSuficiente", e.VolumenSuficiente), P("@ConservacionAdecuada", e.ConservacionAdecuada),
                P("@Observaciones", e.Observaciones), P("@IdUsuario", idUsuario));

        public void RegistrarApto(int idAtencion, int idUsuario) =>
            Db.Ejecutar("usp_Evaluacion_RegistrarApto", P("@IdAtencion", idAtencion), P("@IdUsuario", idUsuario));

        public void Suspender(Suspension s, int idUsuario) =>
            Db.Ejecutar("usp_Evaluacion_Suspender",
                P("@IdAtencion", s.IdAtencion), P("@Motivo", s.Motivo), P("@NuevaFecha", s.NuevaFecha.Date), P("@IdUsuario", idUsuario));

        public List<Suspension> ConsultarSuspendidas(DateTime desde, DateTime hasta) =>
            Db.Listar("usp_Suspension_Consultar", MapearSuspension, P("@Desde", desde.Date), P("@Hasta", hasta.Date));

        public Suspension? ObtenerSuspension(int idSuspension) =>
            Db.Obtener("usp_Suspension_ObtenerPorId", MapearSuspension, P("@IdSuspension", idSuspension));

        public void Reactivar(int idSuspension, int idUsuario) =>
            Db.Ejecutar("usp_Suspension_Reactivar", P("@IdSuspension", idSuspension), P("@IdUsuario", idUsuario));
    }
}
