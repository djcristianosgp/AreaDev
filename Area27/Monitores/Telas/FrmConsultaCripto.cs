using Monitores.Classes.Cripto;

namespace Monitores.Telas
{
    public partial class FrmConsultaCripto : Form
    {
        public FrmConsultaCripto()
        {
            InitializeComponent();
        }

        private void FrmConsultaCripto_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        public void Inicializa()
        {
            txtCriptoMoeda.AutoCompleteCustomSource.Clear();
            foreach (var item in Parametros.tipoCripto)
            {
                txtCriptoMoeda.AutoCompleteCustomSource.Add(item.Key + " : " + item.Value);
            }

            txtTipoConsulta.AutoCompleteCustomSource.Clear();
            txtTipoConsulta.PlaceholderText = "Parametros disponiveis (";

            foreach (var item in Parametros.parametroCripto)
            {
                txtTipoConsulta.PlaceholderText += item.Key + " ,";
                txtTipoConsulta.AutoCompleteCustomSource.Add(item.Key + " : " + item.Value);
            }
            txtTipoConsulta.PlaceholderText = txtTipoConsulta.PlaceholderText.Remove(txtTipoConsulta.PlaceholderText.Length - 1, 1);
            txtTipoConsulta.PlaceholderText += ").";
        }

        public bool Valida()
        {
            if (txtTipoConsulta.Text.Length > 0 && txtCriptoMoeda.Text.Length > 0)
                return true;
            else
                return false;
        }

        private void btnExecutarConsulta_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                var retorno = Parametros.Buscadados(txtCriptoMoeda.Text.ToLower(), txtTipoConsulta.Text.ToLower());
                txtResultado.Text = "";
                if (retorno.ticker != null)
                {
                    txtResultado.Text += "\r\nMaior preço unitário de negociação das últimas 24 horas: $" + Math.Round(Convert.ToDecimal(retorno.ticker.high.Replace(".", ",")), 4);
                    txtResultado.Text += "\r\nMenor preço unitário de negociação das últimas 24 horas: $" + Math.Round(Convert.ToDecimal(retorno.ticker.low.Replace(".", ",")), 4);
                    txtResultado.Text += "\r\nQuantidade negociada nas últimas 24 horas: " + Math.Round(Convert.ToDecimal(retorno.ticker.vol.Replace(".", ",")),4);
                    txtResultado.Text += "\r\nPreço unitário da última negociação: $" + Math.Round(Convert.ToDecimal(retorno.ticker.last.Replace(".", ",")),4);
                    txtResultado.Text += "\r\nMaior preço de oferta de compra das últimas 24 horas: $" + Math.Round(Convert.ToDecimal(retorno.ticker.buy.Replace(".", ",")),4);
                    txtResultado.Text += "\r\nMenor preço de oferta de venda das últimas 24 horas: $" + Math.Round(Convert.ToDecimal(retorno.ticker.sell.Replace(".", ",")),4);
                    txtResultado.Text += "\r\nData e hora da informação: " + Parametros.ConvertUnixDateTime(retorno.ticker.date);
                    txtResultado.Text += "\r\n";
                }
                if (retorno.orderbook != null)
                {
                    //txtResultado.Text += "\r\nLista de ofertas de compras, ordenadas do maior para o menor preço: $" + Math.Round(Convert.ToDecimal(retorno.orderbook[0].bids), 4);
                    //txtResultado.Text += "\r\nLista de ofertas de venda, ordenadas do menor para o maior preço: $" + Math.Round(Convert.ToDecimal(retorno.orderbook[0].asks), 4);
                    //txtResultado.Text += "\r\n";
                }
                if (retorno.trades != null)
                {
                    //txtResultado.Text += "\r\nData e hora da negociação: " + Parametros.ConvertUnixDateTime(retorno.trades.date);
                    //txtResultado.Text += "\r\nPreço unitário da negociação: $" + Math.Round(Convert.ToDecimal(retorno.trades.price.Replace(".", ",")), 4);
                    //txtResultado.Text += "\r\nQuantidade da negociação: " + Math.Round(Convert.ToDecimal(retorno.trades.amount.Replace(".", ",")), 4);
                    //txtResultado.Text += "\r\nIdentificador da negociação: " + retorno.trades.tid;
                    //txtResultado.Text += "\r\nIndica a ponta executora da negociação: " + retorno.trades.type;
                    //txtResultado.Text += "\r\n";
                }
            }
        }
    }
}
