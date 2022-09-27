using Newtonsoft.Json.Linq;

namespace Teste_API.Telas
{
    public partial class frmAPI : Form
    {
        public frmAPI()
        {
            InitializeComponent();
        }
        Dictionary<string, string> ddHeaderRequest = new Dictionary<string, string>();
        Dictionary<string, string> ddQueryRequest = new Dictionary<string, string>();
        string sPastaPadrao = @"C:\Area27\TesteAPI\";
        string sExtensao = ".eta";

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void frmAPI_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(sPastaPadrao))
                Directory.CreateDirectory(sPastaPadrao);
        }

        public void PreparaTXTEndPointResult()
        {

            string sUriEndpointResult = "{0}?{1}", sUriEndpoint = "", sQueryParameters = "";
            //Pegar o EndPoint
            sUriEndpoint = txtEndpointUri.Text.Trim();
            //Percorrer a grid de Query parameters
            try
            {
                ddQueryRequest.Clear();
                for (int iCounter = 0; iCounter < dtQueryParameters.Rows.Count; iCounter++)
                {
                    if (!string.IsNullOrEmpty(dtQueryParameters.Rows[iCounter].Cells[0].Value.ToString().Trim()) &&
                        !string.IsNullOrEmpty(dtQueryParameters.Rows[iCounter].Cells[1].Value.ToString().Trim()))
                        ddQueryRequest.Add(dtQueryParameters.Rows[iCounter].Cells[0].Value.ToString().Trim(), dtQueryParameters.Rows[iCounter].Cells[1].Value.ToString().Trim());

                    if (sQueryParameters != "") sQueryParameters += "&";
                    if (!string.IsNullOrEmpty(dtQueryParameters.Rows[iCounter].Cells[0].Value.ToString().Trim()))
                        sQueryParameters += dtQueryParameters.Rows[iCounter].Cells[0].Value.ToString().Trim() + "=";
                    else
                        sQueryParameters += "" + "=";
                    if (!string.IsNullOrEmpty(dtQueryParameters.Rows[iCounter].Cells[1].Value.ToString().Trim()))
                        sQueryParameters += dtQueryParameters.Rows[iCounter].Cells[1].Value.ToString().Trim();
                    else
                        sQueryParameters += "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dtQueryParameters.Rows.Count > 0)
                txtEndpointUriResult.Text = String.Format(sUriEndpointResult, sUriEndpoint, sQueryParameters);
            else
                txtEndpointUriResult.Text = sUriEndpoint;

        }

        public void PreparaHeader()
        {
            ddHeaderRequest.Clear();
            //Percorrer a grid de Query parameters
            try
            {
                for (int iCounter = 0; iCounter < dtHeaderParameters.Rows.Count; iCounter++)
                {
                    if (!string.IsNullOrEmpty(dtHeaderParameters.Rows[iCounter].Cells[0].Value.ToString().Trim()) &&
                        !string.IsNullOrEmpty(dtHeaderParameters.Rows[iCounter].Cells[1].Value.ToString().Trim()))
                        ddHeaderRequest.Add(dtHeaderParameters.Rows[iCounter].Cells[0].Value.ToString().Trim(),
                            dtHeaderParameters.Rows[iCounter].Cells[1].Value.ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEndpointUri_TextChanged(object sender, EventArgs e)
        {
            PreparaTXTEndPointResult();
        }

        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            dtQueryParameters.Rows.Add("QueryName "+ dtQueryParameters.Rows.Count, "QueryValue");
            PreparaTXTEndPointResult();
        }

        private void btnRemoveQuery_Click(object sender, EventArgs e)
        {
            if (dtQueryParameters.SelectedRows.Count > 0 && dtQueryParameters.Rows.Count > 0)
            {
                dtQueryParameters.Rows.RemoveAt(dtQueryParameters.CurrentRow.Index);
            }
            PreparaTXTEndPointResult();
        }

        private void dtQueryParameters_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            PreparaTXTEndPointResult();
        }

        private void dtQueryParameters_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PreparaTXTEndPointResult();
        }

        private void dtQueryParameters_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            PreparaTXTEndPointResult();
        }

        private void dtQueryParameters_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            PreparaTXTEndPointResult();
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            dtHeaderParameters.Rows.Add("HeaderName "+ dtHeaderParameters.Rows.Count, "HeaderValue");
            PreparaHeader();
        }

        private void btnRemoveHeader_Click(object sender, EventArgs e)
        {
            if (dtHeaderParameters.SelectedRows.Count > 0 && dtHeaderParameters.Rows.Count > 0)
            {
                dtHeaderParameters.Rows.RemoveAt(dtHeaderParameters.CurrentRow.Index);
            }
            PreparaHeader();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Executa();
        }

        public void Executa()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtEndpointUriResult.Text))
                {
                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Clear();
                        foreach (var item in ddHeaderRequest)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                        txtResult.Text = "";
                        var vJson = client.GetStringAsync(txtEndpointUriResult.Text).Result;
                        JObject json = JObject.Parse(vJson);
                        foreach (var eResult in json)
                        {
                            txtResult.Text += eResult;
                        }
                        tbcPrincipal.SelectedTab =tbResultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtHeaderParameters_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            PreparaHeader();
        }

        private void dtHeaderParameters_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            PreparaHeader();
        }

        private void dtHeaderParameters_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PreparaHeader();
        }

        private void dtHeaderParameters_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            PreparaHeader();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        public void SalvarArquivo()
        {
            try
            {
                string sTextoArquivo = "";
                if (!string.IsNullOrEmpty(txtNameConexao.Text))
                {
                    sTextoArquivo += "URI|" + txtEndpointUri.Text + "\r\n";
                    if (ddQueryRequest.Count > 0)
                    {
                        foreach (var Item in ddQueryRequest)
                        {
                            sTextoArquivo += "Q|" + Item.Key + "=" + Item.Value + "\r\n";
                        }
                    }
                    if (ddHeaderRequest.Count > 0)
                    {
                        foreach (var Item in ddHeaderRequest)
                        {
                            sTextoArquivo += "H|" + Item.Key + "=" + Item.Value + "\r\n";
                        }
                    }
                    File.WriteAllText(sPastaPadrao + txtNameConexao.Text.Trim() + sExtensao, sTextoArquivo);
                }
                else
                {
                    MessageBox.Show("Informe o nome da conexao para continuar?");
                    txtNameConexao.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LerArquivo(string sArquivo)
        {
            StreamReader sTexto = new StreamReader(sArquivo);
            String linha;
            dtQueryParameters.Rows.Clear();
            dtHeaderParameters.Rows.Clear();
            // Lê linha por linha
            while ((linha = sTexto.ReadLine()) != null)
            {
                if (linha.Split('|')[0].ToString() == "URI") txtEndpointUri.Text = linha.Split('|')[1].ToString();
                if (linha.Split('|')[0].ToString() == "Q") dtQueryParameters.Rows.Add(linha.Split('|')[1].ToString().Split('=')[0], linha.Split('|')[1].ToString().Split('=')[1]);
                if (linha.Split('|')[0].ToString() == "H") dtHeaderParameters.Rows.Add(linha.Split('|')[1].ToString().Split('=')[0], linha.Split('|')[1].ToString().Split('=')[1]);
            }
            sTexto.Close();

        }

        private void BTNbUSCAaRQUIVO_Click(object sender, EventArgs e)
        {
            opArquivo.Multiselect = false;
            opArquivo.Title = "Selecione o Arquivo de conexão que deseja abrir!!";
            opArquivo.Filter = "Arquivos (*" + sExtensao + ")|*" + sExtensao;
            opArquivo.InitialDirectory = sPastaPadrao;
            if (opArquivo.ShowDialog() == DialogResult.OK)
            {
                FileInfo fiInfo = new FileInfo(opArquivo.FileName);
                txtNameConexao.Text = fiInfo.Name.Replace(fiInfo.Extension, "");
                LerArquivo(opArquivo.FileName);
            }
        }
    }
}
