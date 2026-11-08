using System.Globalization;
using System.Text.RegularExpressions;

namespace CEIBIO.Negocio
{
    public static class Validacion
    {
        public static bool Vacio(string? texto) => string.IsNullOrWhiteSpace(texto);

        public static bool EsDni(string? dni) => !Vacio(dni) && Regex.IsMatch(dni!.Trim(), @"^\d{8}$");

        public static bool EsTelefono(string? telefono) => !Vacio(telefono) && Regex.IsMatch(telefono!.Trim(), @"^\d{7,9}$");

        public static bool EsNumero(string? texto, out decimal valor)
        {
            valor = 0;
            if (Vacio(texto)) return false;
            string normalizado = texto!.Trim().Replace(',', '.');
            return decimal.TryParse(normalizado, NumberStyles.Number, CultureInfo.InvariantCulture, out valor);
        }

        public static string NumeroAtencion(string? texto)
        {
            if (Vacio(texto)) return string.Empty;
            string t = texto!.Trim().ToUpperInvariant().Replace("AT-", "").Replace("AT", "");
            return int.TryParse(t, out int n) ? "AT-" + n.ToString("000000") : texto.Trim().ToUpperInvariant();
        }

        public static string? TextoONulo(string? texto) => Vacio(texto) ? null : texto!.Trim();
    }
}
