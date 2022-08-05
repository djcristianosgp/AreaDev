using area_api.Models.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace area_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "LIXEIRO","FURADEIRA","CADEIRA","MESA","FOGÃO","VASSOURA","CAMA","SOFÁ"
    };

        private readonly ILogger<ProdutosController> _logger;

        public ProdutosController(ILogger<ProdutosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Produtos")]
        public IEnumerable<Produto> Get()
        {
            var random = new Random();
            return Enumerable.Range(1, 8).Select(index => new Produto
            {
                ProdutoId = index,
                Descricao = Summaries[Random.Shared.Next(Summaries.Length)],
                CategoriaId = Random.Shared.Next(1, 7),
                //Preco = random.NextDouble(),//Random.Shared.NextDouble(0.0, 200.0) ,
                Datacadastro = DateTime.Now.AddDays(-Random.Shared.Next(0, 50)),
                Ativo = true
            })
            .ToArray();
        }
        [HttpGet("Produtos Ativos")]
        public IEnumerable<string> GetTesteHotReload()
        {
            return new string[] { "Hot Reload 2", "Visual Studio 2021", ".NET 5" };
        }

    }
}