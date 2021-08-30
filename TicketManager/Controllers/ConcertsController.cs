using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketManager.Data;
using TicketManager.Models;

namespace TicketManager.Controllers
{
    [Authorize]
    public class ConcertsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConcertsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Concerts
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Concerts.Include(c => c.Location).Include(c => c.Tickets).Include(c => c.Singer);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public async Task<IActionResult> Index(string concertType, string singer, string sortOrder)
        {
            IQueryable<string> typesQuery = _context.Concerts.Select(c => c.Discriminator).OrderBy(c => c).Distinct();

            ViewData["DateSortParm"] = sortOrder == "Date" ? "Date_desc" : "Date";
            ViewData["SingerSortParm"] = sortOrder == "Singer" ? "Singer_desc" : "Singer";
            ViewData["LocationSortParm"] = sortOrder == "Location" ? "Location_desc" : "Location";
            ViewData["TypeSortParam"] = sortOrder == "Type" ? "Type_desc" : "Type";

            var data = _context.Concerts.Include(c => c.Location).Include(c => c.Tickets).Include(c => c.Singer).Select(d => d);

            switch (sortOrder)
            {
                case "Singer":
                    data = data.OrderBy(c => c.Singer.Name);
                    break;
                case "Singer_desc":
                    data = data.OrderByDescending(c => c.Singer.Name);
                    break;
                case "Date":
                    data = data.OrderBy(c => c.Date);
                    break;
                case "Date_desc":
                    data = data.OrderByDescending(s => s.Date);
                    break;
                case "Type":
                    data = data.OrderBy(c => c.Discriminator);
                    break;
                case "Type_desc":
                    data = data.OrderByDescending(c => c.Discriminator);
                    break;
                case "Location":
                    data = data.OrderBy(c => c.Location.Name);
                    break;
                case "Location_desc":
                    data = data.OrderByDescending(c => c.Location.Name);
                    break;
                default:
                    data = data.OrderBy(s => s.Singer.Name);
                    break;
            }

            //return View(await data.AsNoTracking().ToListAsync());
            if (!String.IsNullOrEmpty(singer))
            {
                data = data.Where(t => t.Singer.Name.Contains(singer));
            }

            if (!string.IsNullOrEmpty(concertType))
            {
                data = data.Where(t => t.Discriminator == concertType);
            }

            var concertTypeVm = new ConcertTypeViewModel
            {
                ConcertTypes = new SelectList(await typesQuery.ToListAsync()),
                Concerts = await data.ToListAsync()
            };

            return View(concertTypeVm);
        }

        // GET: Concerts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concert = await _context.Concerts
                .Include(c => c.Location)
                .Include(c => c.Singer)
                .Include(c => c.Tickets)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concert == null)
            {
                return NotFound();
            }

            return View(concert);
        }

        // GET: Concerts/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name");
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name");
            return View();
        }

        // POST: Concerts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("Id,SingerId,LocationId,Date,Discriminator,TicketAmount")] Concert concert)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concert);
                await _context.SaveChangesAsync();

                List<Ticket> tickets = new();
                for (int i = 0; i < concert.TicketAmount; i++)
                {
                    tickets.Add(new Ticket() { ConcertId = concert.Id });
                }
                concert.Tickets = tickets;
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", concert.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", concert.SingerId);
            return View(concert);
        }

        // GET: Concerts/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concert = await _context.Concerts.FindAsync(id);
            if (concert == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", concert.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", concert.SingerId);
            return View(concert);
        }

        // POST: Concerts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SingerId,LocationId,Date,Discriminator")] Concert concert)
        {
            if (id != concert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcertExists(concert.Id))
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
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Name", concert.LocationId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Name", concert.SingerId);
            return View(concert);
        }

        // GET: Concerts/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concert = await _context.Concerts
                .Include(c => c.Location)
                .Include(c => c.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concert == null)
            {
                return NotFound();
            }

            return View(concert);
        }

        // POST: Concerts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var concert = await _context.Concerts.FindAsync(id);
            _context.Concerts.Remove(concert);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcertExists(int id)
        {
            return _context.Concerts.Any(e => e.Id == id);
        }
    }
}
