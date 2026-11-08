using CEIBIO.Entidades;
using Microsoft.Data.SqlClient;
using static CEIBIO.Datos.Db;

namespace CEIBIO.Datos
{
    public class BoxDatos
    {
        private static Box Mapear(SqlDataReader r) => new Box
        {
            IdBox = Leer.Entero(r, "IdBox"),
            Numero = Leer.Texto(r, "Numero"),
            Descripcion = Leer.TextoNulo(r, "Descripcion"),
            Habilitado = Leer.Booleano(r, "Habilitado")
        };

        public List<Box> Listar(string filtro) => Db.Listar("usp_Box_Listar", Mapear, P("@Filtro", filtro));

        /// <summary>Boxes habilitados que no tienen un paciente en toma de muestra (CU-26).</summary>
        public List<Box> ListarLibres() => Db.Listar("usp_Box_ListarLibres", Mapear);

        public Box? ObtenerPorId(int id) => Db.Obtener("usp_Box_ObtenerPorId", Mapear, P("@IdBox", id));

        public bool ExisteNumero(string numero, int idExcluir) =>
            Db.Entero("usp_Box_ExisteNumero", P("@Numero", numero), P("@IdExcluir", idExcluir)) > 0;

        /// <summary>CU-32 A3: el box tiene una atención en toma de muestra.</summary>
        public bool EstaEnUso(int idBox) => Db.Entero("usp_Box_EstaEnUso", P("@IdBox", idBox)) > 0;

        public int Insertar(Box b, int idUsuario) =>
            Db.Entero("usp_Box_Insertar", P("@Numero", b.Numero), P("@Descripcion", b.Descripcion), P("@IdUsuario", idUsuario));

        public void Actualizar(Box b, int idUsuario) =>
            Db.Ejecutar("usp_Box_Actualizar", P("@IdBox", b.IdBox), P("@Numero", b.Numero), P("@Descripcion", b.Descripcion), P("@IdUsuario", idUsuario));

        public void CambiarEstado(int id, bool habilitado, int idUsuario) =>
            Db.Ejecutar("usp_Box_CambiarEstado", P("@IdBox", id), P("@Habilitado", habilitado), P("@IdUsuario", idUsuario));
    }
}
