using System.Globalization;
using System.Text.RegularExpressions;

namespace CEIBIO.Negocio
{
    /// <summary>Validaciones comunes. También se pueden usar desde los formularios.</summary>
    public static class Validacion
    {
        public static bool Vacio(string? texto) => string.IsNullOrWhiteSpace(texto);

        /// <summary>DNI: exactamente 8 dígitos.</summary>
        public static bool EsDni(string? dni) => !Vacio(dni) && Regex.IsMatch(dni!.Trim(), @"^\d{8}$");

        /// <summary>Teléfono: 7 a 9 dígitos.</summary>
        public static bool EsTelefono(string? telefono) => !Vacio(telefono) && Regex.IsMatch(telefono!.Trim(), @"^\d{7,9}$");

        /// <summary>Convierte un texto a número aceptando punto o coma como separador decimal.</summary>
        public static bool EsNumero(string? texto, out decimal valor)
        {
            valor = 0;
            if (Vacio(texto)) return false;
            string normalizado = texto!.Trim().Replace(',', '.');
            return decimal.TryParse(normalizado, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
        }

        /// <summary>Acepta "AT-000012", "at-12" o "12" y devuelve "AT-000012".</summary>
        public static string NumeroAtencion(string? texto)
        {
            if (Vacio(texto)) return string.Empty;
            string t = texto!.Trim().ToUpperInvariant().Replace("AT-", "").Replace("AT", "");
            return int.TryParse(t, out int n) ? "AT-" + n.ToString("000000") : texto.Trim().ToUpperInvariant();
        }

        public static string? TextoONulo(string? texto) => Vacio(texto) ? null : texto!.Trim();
    }
}
