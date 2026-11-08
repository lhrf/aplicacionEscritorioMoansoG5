namespace CEIBIO.Entidades
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public override string ToString() => Nombre;
    }
}
