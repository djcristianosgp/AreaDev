using System.IO;

namespace area_27_dashboard.Uteis
{
    public class InicializaSystem
    {
        public InicializaSystem()
        {
            GerarPastas();
            GerarArquivos();
        }

        public async Task GerarPastas()
        {
            foreach (var item in UteisGerais.ListaDePastas)
            {
                if (!Directory.Exists(item))
                    Directory.CreateDirectory(item);
            }
        }
        public async Task GerarArquivos()
        {
            foreach (var item in UteisGerais.ListaDeArquivo)
            {
                if (!File.Exists(item))
                    using (var fileStream = File.Create(item)) { }
            }
        }
    }
}
