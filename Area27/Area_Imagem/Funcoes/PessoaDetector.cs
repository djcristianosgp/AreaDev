using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace Area_Imagem.Funcoes
{
    public class PessoaDetector
    {
        public static int ContarPessoas(string caminhoImagem)
        {
            // Carrega o classificador em cascata para detecção de rostos
            var classificadorRosto = new CascadeClassifier("haarcascade_frontalface_default.xml");

            // Carrega a imagem
            using (var imagem = new Image<Bgr, byte>(caminhoImagem))
            {
                // Converte para escala de cinza
                var imagemCinza = imagem.Convert<Gray, byte>();
                // Detecta rostos
                var rostos = classificadorRosto.DetectMultiScale(imagemCinza, 1.1, 10, Size.Empty);

                // Retorna o número de rostos detectados
                return rostos.Length;
            }
        }
    }
}
