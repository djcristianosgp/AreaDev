namespace area_27_dashboard.Models
{
    public class UsuarioViewModel
    {
        public int usuarioid { get; set; }
        public bool ativo { get; set; }
        public Dados dados { get; set; } = new Dados();
        public PermissoesViewModel permissoes { get; set; } = new PermissoesViewModel();

        public class Dados
        {
            public string nomecompleto { get; set; }
            public string email { get; set; }
            public string cpf { get; set; }
            public string telefone { get; set; }
            public string senha { get; set; }
        }

        public class PermissoesViewModel
        {
        public DashboardViewModel pdashboard {  get; set; } = new DashboardViewModel();
        public CadastrosViewModel pcadastrtos {  get; set; } = new CadastrosViewModel();
            public class DashboardViewModel
            {
                public bool editdashboard { get; set; } = false;
                public bool gestaodashboard { get; set; } = false;
                public bool viewdashboard { get; set; } = false;
            }

            public class CadastrosViewModel
            {
                public bool categorias { get; set; } = false;
                public bool dashboards { get; set; } = false;
                public bool sistema { get; set; } = false;
                public bool usuarios { get; set; } = false;
            }
        }
    }
}
