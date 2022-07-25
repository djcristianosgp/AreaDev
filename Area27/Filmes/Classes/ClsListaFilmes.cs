using Filmes.Entidades;
using Newtonsoft.Json;

namespace Filmes.Classes
{
    public class ClsListaFilmes
    {
        public static List<EntFilmes> llFilmes = new List<EntFilmes>();
        static EntFilmes entFilmesRetorno = new EntFilmes();

        public static void FU_ListaFilmes(string sPath)
        {
            llFilmes.Clear();
            string[] formatos = { "*.mp4", "*.mkv", "*.avi" };
            string[] arquivos = { };
            for (int iContador = 0; iContador < formatos.Count(); iContador++)
            {
                arquivos = Directory.GetFiles(sPath, formatos[iContador], SearchOption.AllDirectories);
                foreach (var vFilmes in arquivos)
                {
                    FileInfo fileInfo = new FileInfo(vFilmes);
                    string vJson = JsonConvert.SerializeObject(fileInfo);
                    entFilmesRetorno = JsonConvert.DeserializeObject<EntFilmes>(vJson);
                    llFilmes.Add(entFilmesRetorno);

                }
            }

        }
    }
}
