using area_27_dashboard.Uteis;

namespace area_27_dashboard.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {

            }
        }

        private bool Valida()
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show($"Campo de email deve ser preenchido!!{Environment.NewLine}Corrija e tente novamente!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show($"Campo de senha deve ser preenchido!!{Environment.NewLine}Corrija e tente novamente!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!Validacoes.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show($"Não é um email válido!!{Environment.NewLine}Corrija e tente novamente!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

    }
}
