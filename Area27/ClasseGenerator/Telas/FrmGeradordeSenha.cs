namespace ClasseGenerator.Telas
{
    public partial class FrmGeradordeSenha : Form
    {
        public FrmGeradordeSenha()
        {
            InitializeComponent();
        }

        string snumeros = "0123456789";
        string sletras = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        string scaracteres = @"!@#$%¨&*()_+=-{[}]^~:;?/>.<,|\";
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
                Clipboard.SetText(txtResultado.Text);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                string sretorno = string.Empty;
                string slista = string.Empty;
                if (chkCaracteres.Checked)
                    slista += scaracteres;
                if (chkLetras.Checked)
                    slista += sletras;
                if (chkNumero.Checked)
                    slista += snumeros;

                Random rdd = new Random();

                for (int iContador = 0; iContador < nmQuantidade.Value; iContador++)
                {
                    int isenha =  rdd.Next(slista.Length+1);
                    sretorno += isenha < slista.Length ? slista.Substring(isenha, 1): slista.Substring(isenha-1, 1);
                }
                txtResultado.Text = sretorno;
            }
        }

        public bool Valida()
        {
            if (chkCaracteres.Checked || chkLetras.Checked || chkLetras.Checked)
                return true;
            else
                return false;
        }
    }
}
