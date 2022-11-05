using EmbarkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmbarkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospedagemController : Controller
    {

        private readonly EmbarkDBContext _context;

        public HospedagemController(EmbarkDBContext context)
        {
            _context = context;
        }

        // GET: api/Hospedagem - LISTA TODOS OS CURSOS
        [HttpGet]
        public IEnumerable<Hospedagem> GetHospedagem()
        {
            return _context.Hospedagem;
        }

        // GET: api/Hospedagem/id - LISTA Hospedagem POR ID
        [HttpGet("{id}")]
        public IActionResult GetHospedagemPorId(int id)
        {
            Hospedagem hospedagem = _context.Hospedagem.SingleOrDefault(modelo => modelo.Id_hosp == id);
            if (hospedagem == null)
            {
                return NotFound();
            }
            return new ObjectResult(hospedagem);
        }


        // CRIA UMa nova Hospedagem
        [HttpPost]
        public IActionResult CriarHospedageme(Hospedagem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Hospedagem.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // ATUALIZA UMa Hospedagem EXISTENTE
        [HttpPut("{id}")]
        public IActionResult AtualizaHospedagem(int id, Hospedagem item)
        {
            if (id != item.Id_hosp)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        // APAGA UMA Hospedagem POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaHospedagem(int id)
        {
            var hospedagem = _context.Hospedagem.SingleOrDefault(m => m.Id_hosp == id);

            if (hospedagem == null)
            {
                return BadRequest();
            }

            _context.Hospedagem.Remove(hospedagem);
            _context.SaveChanges();
            return Ok(hospedagem);
        }
    }
}
