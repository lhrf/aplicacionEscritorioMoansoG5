namespace CEIBIO.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string ClaveHash { get; set; } = string.Empty;
        /// <summary>Sal aleatoria del usuario (RNF-19), en hexadecimal.</summary>
        public string Sal { get; set; } = string.Empty;
        public int IdRol { get; set; }
        public string NombreRol { get; set; } = string.Empty;
        public bool Habilitado { get; set; } = true;
        public DateTime FechaRegistro { get; set; }

        public string EstadoTexto => Habilitado ? "Habilitado" : "Inhabilitado";
        public override string ToString() => NombreCompleto;
    }
}
