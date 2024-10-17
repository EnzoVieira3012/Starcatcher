using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Data;
using Starcatcher.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starcatcher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotasController : ControllerBase
    {
        private readonly StarcatcherContext _context;

        public CotasController(StarcatcherContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cota>>> GetCotas()
        {
            return await _context.Cotas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cota>> GetCota(int id)
        {
            var cota = await _context.Cotas.FindAsync(id);

            if (cota == null)
            {
                return NotFound();
            }

            return cota;
        }

        [HttpPost]
        public async Task<ActionResult<Cota>> PostCota(Cota cota)
        {
            _context.Cotas.Add(cota);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCota", new { id = cota.Id }, cota);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCota(int id, Cota cota)
        {
            if (id != cota.Id)
            {
                return BadRequest();
            }

            _context.Entry(cota).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CotaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCota(int id)
        {
            var cota = await _context.Cotas.FindAsync(id);
            if (cota == null)
            {
                return NotFound();
            }

            _context.Cotas.Remove(cota);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CotaExists(int id)
        {
            return _context.Cotas.Any(e => e.Id == id);
        }
    }
}