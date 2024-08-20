using System.IO;

namespace area_27_dashboard.Uteis
{
    public class UteisGerais
    {
        //Pastas
        public static string PastaPadrao = Path.Combine(@"C:\Area27\Sistemas\Dashboard\");
        public static string PastaArquivos = Path.Combine(PastaPadrao, "Arquivo");
        public static string PastaImagens = Path.Combine(PastaPadrao, "Imagens");
        public static string PastaConfiguracoes = Path.Combine(PastaPadrao, "Configuracoes");
        public static string PastaLogs = Path.Combine(PastaPadrao, "Logs");

        //Arquivos
        public static string ArquivoConfig = Path.Combine(PastaConfiguracoes, "Configuracoes.ini");
        public static string ArquivoLog = Path.Combine(PastaLogs, $"{DateTime.Now.ToString("yyyyMMdd")}.log");


        //Listas
        public static List<string> ListaDePastas = new List<string>{
            PastaPadrao,
            PastaArquivos,
            PastaImagens,
            PastaConfiguracoes,
            PastaLogs
            };

        public static List<string> ListaDeArquivo = new List<string>{
            ArquivoConfig
            };

    }
}
