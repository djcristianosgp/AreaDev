using area_27_dashboard.DB;
using area_27_dashboard.Models;

namespace area_27_dashboard
{
    public partial class Form1 : Form
    {
        private BaseModelSupabase _Supabase;
        public Form1()
        {
            InitializeComponent();
            _Supabase = new BaseModelSupabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new UsuarioViewModel();
                model.usuarioid = 1;
                var teste = _Supabase.GetConectionSupabase();
                teste.InitializeAsync();
                //await teste.From<UsuarioViewModel>().Insert(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
