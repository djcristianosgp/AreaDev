using Emgu.CV;
using Emgu.CV.Structure;

namespace Area27.Telas
{
    public partial class FrmContaPessoas : Form
    {
        public FrmContaPessoas()
        {
            InitializeComponent();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int numeroDePessoas = ContarPessoas(openFileDialog.FileName);
                    lblResultado.Text = $"Número de pessoas detectadas: {numeroDePessoas}";
                }
            }
        }

        private int ContarPessoas(string caminhoImagem)
        {
            var classificadorRosto = new CascadeClassifier("haarcascade_frontalface_default.xml");
            using (var imagem = new Image<Bgr, byte>(caminhoImagem))
            {
                var imagemCinza = imagem.Convert<Gray, byte>();
                var rostos = classificadorRosto.DetectMultiScale(imagemCinza, 1.1, 10, Size.Empty);
                return rostos.Length;
            }
        }
    }
}
