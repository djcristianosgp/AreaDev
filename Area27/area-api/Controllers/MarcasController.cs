using area_api.Context;
using area_api.Models.Cadastros;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace area_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MarcasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Marca>> GetMarcas()
        {
            try
            {
                var marcas = _context.Marcas.AsNoTracking().ToList();
                if (marcas is null)
                    return NotFound("Marcas não encontradas!!");
                return marcas;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("{id:int}", Name = "ObterMarcaCodigo")]
        public ActionResult<Marca> GetMarcaId(int id)
        {
            try
            {
                var marca = _context.Marcas.FirstOrDefault(m => m.MarcaId == id);
                if (marca is null)
                    return NotFound($"Marca com id={id} não Encontrada!!");
                return marca;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("{descricao}")]
        public ActionResult<Marca> GetMarcaDescricao(string descricao)
        {
            try
            {
                var marca = _context.Marcas.AsNoTracking().FirstOrDefault(m => m.Descricao == descricao.ToUpper());
                if (marca is null)
                    return NotFound($"Marca '{descricao}' não Encontrada!!");
                return marca;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Marca>> GetMarcaProduto()
        {
            try
            {
                return _context.Marcas.Include(p => p.Produto).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpGet("produtos/{descricao}")]
        public ActionResult<IEnumerable<Marca>> GetMarcaProdutoDescricao(string descricao)
        {
            try
            {
                return _context.Marcas.Include(p => p.Produto).Where(m => m.Descricao == descricao.ToUpper()).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpPost]
        public ActionResult PostMarca(Marca marca)
        {
            try
            {
                if (marca is null)
                    return BadRequest();
                _context.Marcas.Add(marca);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterMarcaCodigo",
                    new { id = marca.MarcaId }, marca);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult PutMarca(int id, Marca marca)
        {
            try
            {
                if (id != marca.MarcaId)
                    return BadRequest($"Codigo {id} não confere com {marca.MarcaId}!!!");

                _context.Entry(marca).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(marca);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteMarca(int id)
        {
            try
            {
                var marca = _context.Marcas.FirstOrDefault(m => m.MarcaId == id);
                if (marca is null)
                    return NotFound($"Marca com id={id} não encontrada!!!");

                _context.Marcas.Remove(marca);
                _context.SaveChanges();

                return Ok(marca);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao exeutar sua solicitação!!!");
            }
        }
    }
}
