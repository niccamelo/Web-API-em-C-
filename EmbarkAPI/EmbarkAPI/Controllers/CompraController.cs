using EmbarkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmbarkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : Controller
    {
        private readonly EmbarkDBContext _context;

        public CompraController(EmbarkDBContext context)
        {
            _context = context;
        }

        // GET: api/Cursos - LISTA TODOS OS CURSOS
        [HttpGet]
        public IEnumerable<Compra> GetCompra()
        {
            return _context.Compra;
        }

        // GET: api/compra/id - LISTA Compra POR ID
        [HttpGet("{id}")]
        public IActionResult GetCompraPorId(int id)
        {
            Compra compra = _context.Compra.SingleOrDefault(modelo => modelo.id_compra == id);
            if (compra == null)
            {
                return NotFound();
            }
            return new ObjectResult(compra);
        }


        // CRIA UMa NOVa Compra
        [HttpPost]
        public IActionResult CriarCompra(Compra item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Compra.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // ATUALIZA UM Compra EXISTENTE
        [HttpPut("{id}")]
        public IActionResult AtualizaCompra(int id, Compra item)
        {
            if (id != item.id_compra)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        // APAGA UM Compra POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaCompra(int id)
        {
            var compra = _context.Compra.SingleOrDefault(m => m.id_compra == id);

            if (compra == null)
            {
                return BadRequest();
            }

            _context.Compra.Remove(compra);
            _context.SaveChanges();
            return Ok(compra);
        }
    }
}
