using area_27_dashboard.Models;
using System.Text;

namespace area_27_dashboard.Uteis
{
    public class KeyGenerator
    {
        public string GenerateKey(Liberacao.LiberacaoKey liberacao)
        {
            string dataToEncrypt = $"{liberacao.identifiquer}|{liberacao.chave}|{liberacao.datavalidade}|{liberacao.dias}";

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(dataToEncrypt)); ;
        }
    }
}
