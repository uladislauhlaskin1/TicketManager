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
    public class ClassicMusicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassicMusicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ClassicMusics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassicMusic>>> GetClassicMusics()
        {
            return await _context.ClassicMusics.ToListAsync();
        }

        // GET: api/ClassicMusics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassicMusic>> GetClassicMusic(int id)
        {
            var classicMusic = await _context.ClassicMusics.FindAsync(id);

            if (classicMusic == null)
            {
                return NotFound();
            }

            return classicMusic;
        }

        // PUT: api/ClassicMusics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassicMusic(int id, ClassicMusic classicMusic)
        {
            if (id != classicMusic.Id)
            {
                return BadRequest();
            }

            _context.Entry(classicMusic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassicMusicExists(id))
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

        // POST: api/ClassicMusics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClassicMusic>> PostClassicMusic(ClassicMusic classicMusic)
        {
            _context.ClassicMusics.Add(classicMusic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassicMusic", new { id = classicMusic.Id }, classicMusic);
        }

        // DELETE: api/ClassicMusics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassicMusic(int id)
        {
            var classicMusic = await _context.ClassicMusics.FindAsync(id);
            if (classicMusic == null)
            {
                return NotFound();
            }

            _context.ClassicMusics.Remove(classicMusic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassicMusicExists(int id)
        {
            return _context.ClassicMusics.Any(e => e.Id == id);
        }
    }
}
