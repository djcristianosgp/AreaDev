using area_api.Context;
using area_api.Models.Cadastros;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace area_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> GetCategorias()
        {
            var categoria = _context.Categorias.ToList();
            if (categoria is null)
                return NotFound("Categorias não encontradas!!");
            return categoria;
        }

        [HttpGet("{id:int}", Name = "ObterCategoriaCodigo")]
        public ActionResult<Categoria> GetCategoriaId(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(m => m.CategoriaId == id);
            if (categoria is null)
                return NotFound("Categoria não Encontrada!!");
            return categoria;
        }

        [HttpGet("{descricao}")]
        public ActionResult<Categoria> GetCategoriaDescricao(string descricao)
        {
            var categoria = _context.Categorias.FirstOrDefault(m => m.Descricao == descricao);
            if (categoria is null)
                return NotFound("Categoria não Encontrada!!");
            return categoria;
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriaProduto()
        {
            return _context.Categorias.Include(p => p.Produto).ToList();
        }


        [HttpPost]
        public ActionResult PostCategoria(Categoria categoria)
        {
            if (categoria is null)
                return BadRequest();
            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCategoriaCodigo",
                new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult PutCategoria(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
                return BadRequest("Codigo não confere!!!");

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteCategoria(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(m => m.CategoriaId == id);
            if (categoria is null)
                return NotFound("Categoria não encontrada!!!");

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return Ok(categoria);
        }
    }
}
