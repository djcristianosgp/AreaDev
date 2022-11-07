using ClasseGenerator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseGenerator.Telas
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        private void frmGenerator_Load(object sender, EventArgs e)
        {

        }
        public void Inicializa()
        {
            cbxDriverBanco.SelectedIndex = 0;
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            if(ClsBancoFirebird.TestaConecao(txtHost.Text,txtDataBase.Text))
            {
                grFuncoes.Enabled = true;
                MessageBox.Show("Conexão validada com sucesso!!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                grFuncoes.Enabled = false;
                MessageBox.Show("Conexão inválida!\r\nConfira os dados e tente novamente","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
