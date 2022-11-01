using Uteis.Manipuladores;

namespace Manipuladores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            if(dtDataTeste.Value <= DateTime.Now)
            {
                txtRetorno.Text = "";
                txtRetorno.Text += "Retorno Ano Mes Dia | "+ManipulaIdade.GetIdadeAnoMesDia(dtDataTeste.Value)+"\r\n";
                txtRetorno.Text += "Retorno Ano Mes | "+ManipulaIdade.GetIdadeAnoMes(dtDataTeste.Value) + "\r\n";
                txtRetorno.Text += "Retorno Mes Dia | "+ManipulaIdade.GetIdadeMesDia(dtDataTeste.Value) + "\r\n";
                txtRetorno.Text += "Retorno Completo | "+ManipulaIdade.GetIdadeCompleta(dtDataTeste.Value) + "\r\n";
            }
        }
    }
}