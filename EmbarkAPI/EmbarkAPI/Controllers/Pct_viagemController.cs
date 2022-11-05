using EmbarkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmbarkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pct_viagemController : Controller
    {
        private readonly EmbarkDBContext _context;

        public Pct_viagemController(EmbarkDBContext context)
        {
            _context = context;
        }

        // GET: api/Pct_viagem - LISTA TODOS OS CURSOS
        [HttpGet]
        public IEnumerable<Pct_viagem> GetPct_viagem()
        {
            return _context.Pct_viagem;
        }

        // GET: api/Pct_viagem/id - LISTA Pct_viagem POR ID
        [HttpGet("{id}")]
        public IActionResult GetPct_viagemPorId(int id)
        {
            Pct_viagem pct_viagem = _context.Pct_viagem.SingleOrDefault(modelo => modelo.Id_destino == id);
            if (pct_viagem == null)
            {
                return NotFound();
            }
            return new ObjectResult(pct_viagem);
        }


        // CRIA UM NOVO Pct_viagem
        [HttpPost]
        public IActionResult CriarPct_viagem(Pct_viagem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Pct_viagem.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // ATUALIZA UM Pct_viagem EXISTENTE
        [HttpPut("{id}")]
        public IActionResult AtualizaPct_viagem(int id, Pct_viagem item)
        {
            if (id != item.Id_destino)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        // APAGA UM Pct_viagem POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaPct_viagem(int id)
        {
            var pct_viagem = _context.Pct_viagem.SingleOrDefault(m => m.Id_destino == id);

            if (pct_viagem == null)
            {
                return BadRequest();
            }

            _context.Pct_viagem.Remove(pct_viagem);
            _context.SaveChanges();
            return Ok(pct_viagem);
        }
    }
}
