using System.Data;

namespace Musicas.Telas
{
    public partial class FrmGerenciarMusicas : Form
    {
        public FrmGerenciarMusicas()
        {
            InitializeComponent();
        }
        string[] sLista = { "Artista", "Ano", "Genero" };

        private void FrmGerenciarMusicas_Load(object sender, EventArgs e)
        {

        }

        public void Inicializa()
        {
            GetOrganiza();
        }

        public void GetOrganiza()
        {
            cbxOrganizarPor.Items.Clear();
            cbxOrganizarPor.Items.Add(sLista);
            if (cbxOrganizarPor.Items.Count > 0)
                cbxOrganizarPor.SelectedIndex = 0;
        }

        public void GetListaMusicas(string sPastaOrigem)
        {
            try
            {
                string[] arquivos = Directory.GetFiles(sPastaOrigem, "*.mp3", SearchOption.AllDirectories);
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[8]{
                        new DataColumn("Titulo",typeof(string)),
                        new DataColumn("Artista",typeof(string)),
                        new DataColumn("Genero",typeof(string)),
                        new DataColumn("Track",typeof(string)),
                        new DataColumn("Ano",typeof(string)),
                        new DataColumn("Arquivo",typeof(string)),
                        new DataColumn("Nome",typeof(string)),
                        new DataColumn("Data Criação",typeof(DateTime)),
                    });
                foreach (var item in arquivos)
                {
                    FileInfo fileInfo = new FileInfo(item);
                    var filetag = TagLib.File.Create(item).Tag;
                    //EntMusicas eeMusica = new EntMusicas()
                    string title = string.IsNullOrEmpty(filetag.Title.ToString()) ? "Sem Titulo" : filetag.Title.ToString();
                    string artist = string.IsNullOrEmpty(filetag.Artists[0].ToString()) ? "Sem Artista" : filetag.Artists[0].ToString();
                    string genres = "";
                    try
                    {
                        genres = filetag.Genres[0].ToString();
                    }
                    catch (Exception)
                    {
                        genres = "Sem Genero";
                    }

                    string track = string.IsNullOrEmpty(filetag.Track.ToString()) ? "Sem Track" : filetag.Track.ToString();
                    string year = string.IsNullOrEmpty(filetag.Year.ToString()) ? "Sem Ano" : filetag.Year.ToString();
                    string fullname = fileInfo.FullName.ToString();
                    string name = fileInfo.Name.ToString();
                    DateTime datecreate = Convert.ToDateTime(fileInfo.CreationTime);
                    dt.Rows.Add(title, artist, genres, track, year, fullname, name, datecreate);
                }
                this.dtListaMusicas.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetMoveMusicas(string sPastaDestino, string sOrganiza)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            GetListaMusicas(txtPastaOrigem.Text);
        }
    }
}
