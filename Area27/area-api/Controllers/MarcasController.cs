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
            var marcas = _context.Marcas.ToList();
            if (marcas is null)
                return NotFound("Marcas não encontradas!!");
            return marcas;
        }

        [HttpGet("{id:int}", Name = "ObterMarcaCodigo")]
        public ActionResult<Marca> GetMarcaId(int id)
        {
            var marca = _context.Marcas.FirstOrDefault(m => m.MarcaId == id);
            if (marca is null)
                return NotFound("Marca não Encontrada!!");
            return marca;
        }

        [HttpGet("{descricao}")]
        public ActionResult<Marca> GetMarcaDescricao(string descricao)
        {
            var marca = _context.Marcas.FirstOrDefault(m => m.Descricao == descricao.ToUpper());
            if (marca is null)
                return NotFound("Marca não Encontrada!!");
            return marca;
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Marca>> GetMarcaProduto()
        {
            return _context.Marcas.Include(p => p.Produto).ToList();
        }

        [HttpPost]
        public ActionResult PostMarca(Marca marca)
        {
            if (marca is null)
                return BadRequest();
            _context.Marcas.Add(marca);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterMarcaCodigo",
                new { id = marca.MarcaId }, marca);
        }

        [HttpPut("{id:int}")]
        public ActionResult PutMarca(int id, Marca marca)
        {
            if (id != marca.MarcaId)
                return BadRequest("Codigo não confere!!!");

            _context.Entry(marca).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(marca);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteMarca(int id)
        {
            var marca = _context.Marcas.FirstOrDefault(m => m.MarcaId == id);
            if (marca is null)
                return NotFound("Marca não encontrada!!!");

            _context.Marcas.Remove(marca);
            _context.SaveChanges();

            return Ok(marca);
        }
    }
}
