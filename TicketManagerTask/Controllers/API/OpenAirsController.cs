using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketManagerTask.Data;
using TicketManagerTask.Models.ConcertTypes;

namespace TicketManagerTask.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAirsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OpenAirsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/OpenAirs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpenAir>>> GetOpenAirs()
        {
            return await _context.OpenAirs.ToListAsync();
        }

        // GET: api/OpenAirs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OpenAir>> GetOpenAir(int id)
        {
            var openAir = await _context.OpenAirs.FindAsync(id);

            if (openAir == null)
            {
                return NotFound();
            }

            return openAir;
        }

        // PUT: api/OpenAirs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpenAir(int id, OpenAir openAir)
        {
            if (id != openAir.Id)
            {
                return BadRequest();
            }

            _context.Entry(openAir).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpenAirExists(id))
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

        // POST: api/OpenAirs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OpenAir>> PostOpenAir(OpenAir openAir)
        {
            _context.OpenAirs.Add(openAir);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpenAir", new { id = openAir.Id }, openAir);
        }

        // DELETE: api/OpenAirs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpenAir(int id)
        {
            var openAir = await _context.OpenAirs.FindAsync(id);
            if (openAir == null)
            {
                return NotFound();
            }

            _context.OpenAirs.Remove(openAir);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OpenAirExists(int id)
        {
            return _context.OpenAirs.Any(e => e.Id == id);
        }
    }
}
