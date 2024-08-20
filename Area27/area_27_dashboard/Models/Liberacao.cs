namespace area_27_dashboard.Models
{
    public class Liberacao
    {
        public Liberacao()
        {
            new LiberacaoKey();
            new LiberacaoResult();
        }
        public class LiberacaoKey
        {
            public string identifiquer { get; set; }
            public string chave { get; set; }
            public string dias { get; set; }
            public string datavalidade { get; set; }
        }
        public class LiberacaoResult
        {
            public string identifiquer { get; set; }
            public string chave { get; set; }
            public string dias { get; set; }
            public string datavalidade { get; set; }
        }
    }
    
}
