using Microsoft.AspNetCore.Mvc;
using CadastroEstudanteApi.Data;
using CadastroEstudanteApi.Models;

namespace CadastroEstudanteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudantesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstudantesController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 GET: api/estudantes
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Estudantes.ToList());
        }

        // 🔹 GET por ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var estudante = _context.Estudantes.Find(id);

            if (estudante == null)
                return NotFound();

            return Ok(estudante);
        }

        // 🔹 POST
        [HttpPost]
        public IActionResult Post(Estudante estudante)
        {
            _context.Estudantes.Add(estudante);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = estudante.Id }, estudante);
        }

        // 🔹 PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, Estudante estudante)
        {
            var existente = _context.Estudantes.Find(id);

            if (existente == null)
                return NotFound();

            existente.Nome = estudante.Nome;

            _context.SaveChanges();

            return NoContent();
        }

        // 🔹 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var estudante = _context.Estudantes.Find(id);

            if (estudante == null)
                return NotFound();

            _context.Estudantes.Remove(estudante);
            _context.SaveChanges();

            return NoContent();
        }
    }
}