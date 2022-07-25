using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmes.Telas
{
    public partial class FrmPrincipalFilmes : Form
    {
        public FrmPrincipalFilmes()
        {
            InitializeComponent();
        }

        private void miListarFilmes_Click(object sender, EventArgs e)
        {
            FrmListaFilmes frmListaFilmes = new FrmListaFilmes();
            frmListaFilmes.MdiParent=this;
            frmListaFilmes.Show();
        }
    }
}
