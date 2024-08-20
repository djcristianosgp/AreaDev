using System.Text.RegularExpressions;

namespace area_27_dashboard.Uteis
{
    public class Validacoes
    {
        private static readonly Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return emailRegex.IsMatch(email);
        }

    }
}
