using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_27_dashboard.Views
{
    public partial class FrmDashboardView : Form
    {
        public string Dashboard {  get;  }
        public FrmDashboardView(string dashboard)
        {
            InitializeComponent();
            Dashboard = dashboard;
        }

        private void FrmDashboardView_Load(object sender, EventArgs e)
        {

        }
    }
}
