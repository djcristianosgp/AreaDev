namespace Musicas.Telas
{
    public partial class FrmDadosMusica : Form
    {
        [Windows.Foundation.Metadata.ContractVersion(typeof(Windows.Foundation.UniversalApiContract), 65536)]
        public FrmDadosMusica()
        {
            InitializeComponent();
        }
        public string sMusica = @"D:\Users\Homologacao01\Music\japaozin-solinho-do-brabo-d56c033d.mp3";
        private void FrmDadosMusica_Load(object sender, EventArgs e)
        {
            lblMusica.Text = sMusica;
        }


        private void BuscaDados()
        {

            var fileee = TagLib.File.Create(sMusica).Tag;
            txtRetorno.Clear();

            txtRetorno.Text += "1 - " + fileee.Copyright + "\r\n";
                txtRetorno.Text += "2 - " + fileee.Composers.ToList() + "\r\n";
            txtRetorno.Text += "3 - " + fileee.Artists.ToList() + "\r\n";
            txtRetorno.Text += "4 - " + fileee.Genres.ToList() + "\r\n";
            txtRetorno.Text += "5 - " + fileee.Year + "\r\n";
            txtRetorno.Text += "6 - " + fileee.BeatsPerMinute + "\r\n";
            txtRetorno.Text += "7 - " + fileee.Length + "\r\n";
            txtRetorno.Text += "8 - " + fileee.JoinedArtists + "\r\n";
            txtRetorno.Text += "9 - " + fileee.Track + "\r\n";
            txtRetorno.Text += "10 - " + fileee.TrackCount + "\r\n";
            //1 -
            //2 - System.String[]
            //3 - System.String[]
            //4 - System.String[]
            //5 - 2022
            //6 - 0
            //7 -
            //8 - Japãozin

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            BuscaDados();
        }
    }
}
