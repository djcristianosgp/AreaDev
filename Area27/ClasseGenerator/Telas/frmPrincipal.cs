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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnGerador_Click(object sender, EventArgs e)
        {
            frmGenerator FormGerador = new frmGenerator();
            FormGerador.MdiParent = this;
            FormGerador.Show();
        }
    }
}
