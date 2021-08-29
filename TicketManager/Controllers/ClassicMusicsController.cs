using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketManager.Data;
using TicketManager.Models.ConcertTypes;

namespace TicketManager.Controllers
{
    [Authorize]
    public class ClassicMusicsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassicMusicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClassicMusics
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClassicMusics.Include(c => c.Location).Include(c => c.Singer).Include(c => c.Tickets);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClassicMusics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classicMusic = await _context.ClassicMusics
                .Include(c => c.Location)
                .Include(c => c.Singer)
                .Include(c => c.Tickets)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classicMusic == null)
            {
                return NotFound();
            }

            return View(classicMusic);
        }

        // GET: ClassicMusics/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name");
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name");
            return View();
        }

        // POST: ClassicMusics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("VoiceType,ConcertName,Composer,Id,SingerId,LocationId,Date,Discriminator")] ClassicMusic classicMusic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classicMusic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", classicMusic.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", classicMusic.SingerId);
            return View(classicMusic);
        }

        // GET: ClassicMusics/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classicMusic = await _context.ClassicMusics.FindAsync(id);
            if (classicMusic == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", classicMusic.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", classicMusic.SingerId);
            return View(classicMusic);
        }

        // POST: ClassicMusics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("VoiceType,ConcertName,Composer,Id,SingerId,LocationId,Date,Discriminator")] ClassicMusic classicMusic)
        {
            if (id != classicMusic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classicMusic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassicMusicExists(classicMusic.Id))
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
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", classicMusic.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", classicMusic.SingerId);
            return View(classicMusic);
        }

        // GET: ClassicMusics/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classicMusic = await _context.ClassicMusics
                .Include(c => c.Location)
                .Include(c => c.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classicMusic == null)
            {
                return NotFound();
            }

            return View(classicMusic);
        }

        // POST: ClassicMusics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classicMusic = await _context.ClassicMusics.FindAsync(id);
            _context.ClassicMusics.Remove(classicMusic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassicMusicExists(int id)
        {
            return _context.ClassicMusics.Any(e => e.Id == id);
        }
    }
}
