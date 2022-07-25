using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filmes.Classes;
using Filmes.Entidades;

namespace Filmes.Telas
{
    public partial class FrmListaFilmes : Form
    {
        public FrmListaFilmes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ClsListaFilmes.FU_ListaFilmes(txtPasta.Text);
            EntFilmes eFilmes = new EntFilmes();

        }
    }
}
