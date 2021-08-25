using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketManager.Data;
using TicketManager.Models.ConcertTypes;

namespace TicketManager.Controllers
{
    public class OpenAirsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OpenAirsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OpenAirs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OpenAirs.Include(o => o.Location).Include(o => o.Singer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OpenAirs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var openAir = await _context.OpenAirs
                .Include(o => o.Location)
                .Include(o => o.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (openAir == null)
            {
                return NotFound();
            }

            return View(openAir);
        }

        // GET: OpenAirs/Create
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id");
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name");
            return View();
        }

        // POST: OpenAirs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Headliner,LocationInstruction,Id,SingerId,LocationId,Date,Discriminator")] OpenAir openAir)
        {
            if (ModelState.IsValid)
            {
                _context.Add(openAir);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", openAir.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", openAir.SingerId);
            return View(openAir);
        }

        // GET: OpenAirs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var openAir = await _context.OpenAirs.FindAsync(id);
            if (openAir == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", openAir.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", openAir.SingerId);
            return View(openAir);
        }

        // POST: OpenAirs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Headliner,LocationInstruction,Id,SingerId,LocationId,Date,Discriminator")] OpenAir openAir)
        {
            if (id != openAir.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(openAir);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpenAirExists(openAir.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", openAir.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", openAir.SingerId);
            return View(openAir);
        }

        // GET: OpenAirs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var openAir = await _context.OpenAirs
                .Include(o => o.Location)
                .Include(o => o.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (openAir == null)
            {
                return NotFound();
            }

            return View(openAir);
        }

        // POST: OpenAirs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var openAir = await _context.OpenAirs.FindAsync(id);
            _context.OpenAirs.Remove(openAir);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpenAirExists(int id)
        {
            return _context.OpenAirs.Any(e => e.Id == id);
        }
    }
}
