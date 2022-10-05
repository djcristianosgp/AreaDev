using MarkupConverter;

namespace converter_file.Telas
{
    public partial class FrmConverterText : Form
    {
        public FrmConverterText()
        {
            InitializeComponent();
        }
        private void FrmConverterText_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        public void Inicializa()
        {
            cbxConverterPara.SelectedIndex = 2;
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void btnCopyArquiOrigem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtArquivoOrigem.Text);
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            ofpFileOpen.Multiselect = false;
            //opArquivo.Title = "Selecione o Arquivo de conexão que deseja abrir!!";
            //ofpFileOpen.Filter = "Arquivos (*" + sExtensao + ")|*" + sExtensao;
            //ofpFileOpen.InitialDirectory = sPastaPadrao;
            if (ofpFileOpen.ShowDialog() == DialogResult.OK)
            {
                FileInfo fiInfo = new FileInfo(ofpFileOpen.FileName);
                txtArquivoSelecionado.Text = fiInfo.Name;
            }
            if (File.Exists(txtArquivoSelecionado.Text)) btnConverter.Enabled = true;
            else btnConverter.Enabled = false;

        }

        private void btnLerArquivoSelecionado_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            ConverterArquivo();

        }

        private void btnSalvarArquivo_Click(object sender, EventArgs e)
        {

        }

        private void txtArquivoSelecionado_TextChanged(object sender, EventArgs e)
        {
            //Valida();
        }
        private void txtArquivoSelecionado_Leave(object sender, EventArgs e)
        {
            Valida();
        }

        public void Valida()
        {
            if (File.Exists(txtArquivoSelecionado.Text)) btnConverter.Enabled = true;
            else btnConverter.Enabled = false;
        }

        private void LerArquivo()
        {
            try
            {
                StreamReader srArquivoSelecionado = new StreamReader(txtArquivoSelecionado.Text);
                txtArquivoOrigem.Text = srArquivoSelecionado.ReadToEnd();
                srArquivoSelecionado.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConverterArquivo()
        {
            IMarkupConverter markupConverter;
            markupConverter = new MarkupConverter.MarkupConverter();

            LerArquivo();
            var sArquivoLido = txtArquivoOrigem.Text;
            string sConverterDe = cbxConverterPara.SelectedItem.ToString().Split('>')[0].ToUpper();
            string sConverterPara = cbxConverterPara.SelectedItem.ToString().Split('>')[1].ToUpper();
            try
            {
                var vArquivo = txtArquivoOrigem.Text;
                if(sConverterDe == "HTML" && sConverterPara =="RTF")
                {
                    var rtfResult = markupConverter.ConvertHtmlToRtf(sArquivoLido);
                    txtResult.Text = rtfResult;
                }
                else if (sConverterDe == "HTML" && sConverterPara == "XMAL")
                {
                    var rtfResult = markupConverter.ConvertHtmlToXaml(sArquivoLido);
                    txtResult.Text = rtfResult;
                }
                else if (sConverterDe == "RTF" && sConverterPara == "HTML")
                {
                    var rtfResult = markupConverter.ConvertRtfToHtml(sArquivoLido);
                    txtResult.Text = rtfResult;
                }
                else if (sConverterDe == "XMAL" && sConverterPara == "HTML")
                {
                    var rtfResult = markupConverter.ConvertXamlToHtml(sArquivoLido);
                    txtResult.Text = rtfResult;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SalvarArquivo()
        {

        }

    }
}
