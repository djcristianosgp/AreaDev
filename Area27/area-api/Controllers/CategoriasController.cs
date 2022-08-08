using area_api.Models.Cadastros;
using Microsoft.AspNetCore.Mvc;

namespace area_api.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]
    public class CategoriasController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "LIMPEZA","FERRAMENTAS","ESCRITORIO","MOVEIS","COZINHA","QUARTO","SALA"
    };

        private readonly ILogger<CategoriasController> _logger;

        public CategoriasController(ILogger<CategoriasController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Categorias")]
        public IEnumerable<Categoria> Get()
        {
            var random = new Random();
            return Enumerable.Range(1, 8).Select(index => new Categoria
            {
                CategoriaId= index,
                Descricao = Summaries[Random.Shared.Next(Summaries.Length)],
                Datacadastro = DateTime.Now.AddDays(-Random.Shared.Next(0,20)),
                Ativo= true
            })
            .ToArray();
        }
        [HttpGet("Categorias Ativas")]
        public IEnumerable<string> GetTesteHotReload()
        {
            return new string[] { "Hot Reload 2", "Visual Studio 2021", ".NET 5"};
        }

    }
}