using area_27_dashboard.Models;
using System.Text;

namespace area_27_dashboard.Uteis
{
    public class KeyDecoder
    {
        public async Task<Liberacao.LiberacaoResult> DecodeKey(string key)
        {
            try
            {
                // Decodifica a string base64 para seu formato original
                byte[] decodedBytes = Convert.FromBase64String(key);
                string decodedString = Encoding.UTF8.GetString(decodedBytes);
                var retorno = new Liberacao.LiberacaoResult();
                // Separa a string decodificada para obter o identificador, a chave e a data de validade
                var parts = decodedString.Split('|');
                if (parts.Length == 4)
                {
                    retorno.identifiquer = parts[0];
                    retorno.chave = parts[1];
                    retorno.datavalidade = parts[2];
                    retorno.dias = parts[3];
                    return (retorno);
                }
                MessageBox.Show("Formato inválido: a string decodificada não contém os 3 componentes esperados.");
                return retorno;
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido: a string fornecida não é uma Base64 válida.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na decodificação da chave: {ex.Message}");
                return null;
            }
        }

    }
}
