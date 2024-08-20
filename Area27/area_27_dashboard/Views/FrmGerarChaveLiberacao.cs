using area_27_dashboard.Models;
using area_27_dashboard.Uteis;

namespace area_27_dashboard.Views
{
    public partial class FrmGerarChaveLiberacao : Form
    {
        private bool isUpdating = false;
        private KeyGenerator _keyGenerator;
        private KeyDecoder _keyDecoder;
        private ChaveLiberacao _chaveLiberacao;

        public FrmGerarChaveLiberacao()
        {
            InitializeComponent();
            _keyGenerator = new KeyGenerator();
            _keyDecoder = new KeyDecoder();
            _chaveLiberacao = new ChaveLiberacao();
        }

        private void btnGerarChave_Click(object sender, EventArgs e)
        {
            var Liber = new Liberacao.LiberacaoKey();
            Liber.identifiquer = "djcristiano.sgp@hotmail.com";
            Liber.chave = _chaveLiberacao.GeraChave($"{(dtpDataValidade.Value - DateTime.Now).Days.ToString("0000")}{DateToTimestamp(dtpDataValidade.Value)}").Result;
            Liber.datavalidade = dtpDataValidade.Value.ToString("dd/MM/yyyy");
            Liber.dias = nmDias.Value.ToString();
            txtChave.Text = _keyGenerator.GenerateKey(Liber);
        }

        private async void btnChecarChave_Click(object sender, EventArgs e)
        {
            var retorno = await _keyDecoder.DecodeKey(txtChave.Text);            
            retorno.chave = await _chaveLiberacao.GetChave(retorno.chave);
            var res = TimestampToDate(long.Parse(retorno.chave.Substring(4)));
            txtDescricaoCliente.Text = retorno.identifiquer.ToString();
            dtpDataValidade.Value = res.Date;
        }

        public long DateToTimestamp(DateTime date)
        {
            return new DateTimeOffset(date).ToUnixTimeSeconds();
        }

        public DateTime TimestampToDate(long timestamp)
        {
            return DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
        }

        private void nmDias_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;

                var novadata = DateTime.Now.AddDays((double)nmDias.Value);
                if (dtpDataValidade.Value != novadata)
                    dtpDataValidade.Value = novadata;
            }
            finally
            {
                isUpdating = false;
            }
        }

        private void dtpDataValidade_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;

                var dias = (dtpDataValidade.Value - DateTime.Now).Days;
                if (nmDias.Value != dias)
                    nmDias.Value = dias;
            }
            finally
            {
                isUpdating = false;
            }
        }
    }
}
