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
            try
            {
                var categoria = _context.Categorias.AsNoTracking().ToList();
                if (categoria is null)
                    return NotFound("Categorias não encontradas!!");
                return categoria;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("{id:int}", Name = "ObterCategoriaCodigo")]
        public ActionResult<Categoria> GetCategoriaId(int id)
        {
            try
            {
                var categoria = _context.Categorias.FirstOrDefault(m => m.CategoriaId == id);
                if (categoria is null)
                    return NotFound($"Categoria com id={id} não Encontrada!!");
                return categoria;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("{descricao}")]
        public ActionResult<Categoria> GetCategoriaDescricao(string descricao)
        {
            try
            {
                var categoria = _context.Categorias.AsNoTracking().FirstOrDefault(m => m.Descricao == descricao);
                if (categoria is null)
                    return NotFound($"Categoria '{descricao}' não Encontrada!!");
                return categoria;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriaProduto()
        {
            try
            {
                return _context.Categorias.Include(p => p.Produto).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("produtos/{descricao}")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriaProdutoDescricao(string descricao)
        {
            try
            {
                return _context.Categorias.Include(p => p.Produto).Where(c => c.Descricao == descricao.ToUpper()).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpPost]
        public ActionResult PostCategoria(Categoria categoria)
        {
            try
            {
                if (categoria is null)
                    return BadRequest();
                _context.Categorias.Add(categoria);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterCategoriaCodigo",
                    new { id = categoria.CategoriaId }, categoria);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult PutCategoria(int id, Categoria categoria)
        {
            try
            {
                if (id != categoria.CategoriaId)
                    return BadRequest($"Codigo {id} não confere com {categoria.CategoriaId}!!!");

                _context.Entry(categoria).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(categoria);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteCategoria(int id)
        {
            try
            {
                var categoria = _context.Categorias.FirstOrDefault(m => m.CategoriaId == id);
                if (categoria is null)
                    return NotFound($"Categoria com id={id} não encontrada!!!");

                _context.Categorias.Remove(categoria);
                _context.SaveChanges();

                return Ok(categoria);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }
    }
}
