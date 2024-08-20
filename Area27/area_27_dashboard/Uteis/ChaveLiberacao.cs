using System.Text;

namespace area_27_dashboard.Uteis
{
    public class ChaveLiberacao
    {
        private static readonly char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$#%@$¨&()&*".ToCharArray();
        public async Task<string> GeraChave(string chave)
        {
            var random = new Random();
            var result = new StringBuilder(chave.Length.ToString("0000"));

            for (int iContador = 0; iContador < chave.Length; iContador++)
            {
                result.Append(chave[iContador]);
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        public async Task<string> GetChave(string chave)
        {
            int iTamanhoChave = Convert.ToInt32(chave.Substring(0, 4));
            var result = new StringBuilder();

            // Percorre a string e recupera apenas os caracteres originais
            for (int iContador = 4; iContador < chave.Length; iContador += 2)
            {
                result.Append(chave[iContador]);
            }

            return result.ToString();
        }
    }
}
