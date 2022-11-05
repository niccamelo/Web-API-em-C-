using EmbarkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmbarkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {



        private readonly EmbarkDBContext _context;

        public ClienteController(EmbarkDBContext context)
        {
            _context = context;
        }

        // GET: api/Cursos - LISTA TODOS OS CURSOS
        [HttpGet]
        public IEnumerable<Cliente> GetCliente()
        {
            return _context.Cliente;
        }

        // GET: api/Cursos/id - LISTA CURSO POR ID
        [HttpGet("{id}")]
        public IActionResult GetClientePorId(int id)
        {
            Cliente cliente = _context.Cliente.SingleOrDefault(modelo => modelo.id_cliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return new ObjectResult(cliente);
        }


        // CRIA UM NOVO CURSO
        [HttpPost]
        public IActionResult CriarCliente(Cliente item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Cliente.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // ATUALIZA UM CURSO EXISTENTE
        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, Cliente item)
        {
            if (id != item.id_cliente)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        // APAGA UM CURSO POR ID
        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            var cliente = _context.Cliente.SingleOrDefault(m => m.id_cliente == id);

            if (cliente == null)
            {
                return BadRequest();
            }

            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}
