namespace CEIBIO.Entidades
{
    /// <summary>Ficha clínica histórica del paciente.</summary>
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Dni { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; } = DateTime.Today;
        public string Sexo { get; set; } = string.Empty;   // Femenino, Masculino
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        public string NombreCompleto => (Apellidos + ", " + Nombres).Trim(' ', ',');

        public int Edad
        {
            get
            {
                var hoy = DateTime.Today;
                int edad = hoy.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
                return edad < 0 ? 0 : edad;
            }
        }

        public override string ToString() => NombreCompleto;
    }
}
