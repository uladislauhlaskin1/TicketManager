using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tickets
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Tickets
        //        .Include(t => t.Concert)
        //        .Include(t => t.User)
        //        .Include(t => t.Concert.Location)
        //        .Include(t => t.Concert.Singer);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public async Task<IActionResult> Index(int? concertId, string singer)
        {
            IQueryable<Concert> concertsQuery = _context.Concerts.OrderBy(c => c.Discriminator).ThenBy(c => c.Singer.Name).ThenBy(c => c.Date).Distinct();

            var tickets = _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.User)
                .Include(t => t.Concert.Location)
                .Include(t => t.Concert.Singer)
                .Select(t => t);

            if (!String.IsNullOrEmpty(singer))
            {
                tickets = tickets.Where(t => t.Concert.Singer.Name.Contains(singer));
            }

            if (concertId != null)
            {
                tickets = tickets.Where(t => t.Concert.Id == concertId);
            }

            var ticketTypeVm = new TicketTypeViewModel
            {
                Concerts = new SelectList(await concertsQuery.ToListAsync(), "Id", "Name"),
                Tickets = await tickets.ToListAsync()
            };

            return View(ticketTypeVm);
        }

        public async Task<IActionResult> IndexFilter(int? concertId, string singer)
        {
            IQueryable<Concert> concertsQuery = _context.Concerts.OrderBy(c => c.Discriminator).ThenBy(c => c.Singer.Name).ThenBy(c => c.Date).Distinct();

            var tickets = _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.User)
                .Include(t => t.Concert.Location)
                .Include(t => t.Concert.Singer)
                .Select(t => t);

            if (!String.IsNullOrEmpty(singer))
            {
                tickets = tickets.Where(t => t.Concert.Singer.Name.Contains(singer));
            }

            if (concertId != null)
            {
                tickets = tickets.Where(t => t.Concert.Id == concertId);
            }

            var ticketTypeVm = new TicketTypeViewModel
            {
                Concerts = new SelectList(await concertsQuery.ToListAsync(), "Id", "Name"),
                Tickets = await tickets.ToListAsync()
            };

            return View(ticketTypeVm);
        }

        public async Task<IActionResult> UserTickets()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var applicationDbContext = _context.Tickets
               .Include(t => t.Concert)
               .Include(t => t.User)
               .Include(t => t.Concert.Location)
               .Include(t => t.Concert.Singer)
               .Where(t => t.UserId == userId);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tickets/ConcertTickets/5
        [Route("/{Controller}/AvailableConcertTickets/{id?}")]
        public async Task<IActionResult> AvailableConcertTickets(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concert = await _context.Concerts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concert == null)
            {
                return NotFound();
            }

            var applicationDbContext = _context.Tickets
               .Include(t => t.Concert)
               .Include(t => t.User)
               .Include(t => t.Concert.Location)
               .Include(t => t.Concert.Singer)
               .Where(t => t.ConcertId == id)
               .Where(t => !t.IsReserved);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Reserve(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            if (userId == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.User)
                .Include(t => t.Concert.Location)
                .Include(t => t.Concert.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (ticket == null)
            {
                return NotFound();
            }
            if (ticket.IsReserved)
            {
                return BadRequest();
            }

            ticket.IsReserved = true;
            ticket.UserId = userId;
            await _context.SaveChangesAsync();
            return View(ticket);
        }

        public async Task<IActionResult> CancelReservation(int? id) // I know it's a bad approach, just a temporary solution
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            if (userId == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.User)
                .Include(t => t.Concert.Location)
                .Include(t => t.Concert.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (ticket == null)
            {
                return NotFound();
            }
            if (!ticket.IsReserved)
            {
                return BadRequest();
            }

            ticket.IsReserved = false;
            ticket.UserId = null;
            await _context.SaveChangesAsync();
            return View(ticket);
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.User)
                .Include(t => t.Concert.Location)
                .Include(t => t.Concert.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            var concerts = _context.Concerts.Include(c => c.Location).Include(c => c.Singer)
                .Where(c => c.Date >= DateTime.Now).OrderBy(c => c.Discriminator).ThenBy(c => c.Singer.Name);
            ViewData["ConcertId"] = new SelectList(concerts, "Id", "Name");
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("Id,ConcertId,IsReserved,UserId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConcertId"] = new SelectList(_context.Concerts, "Id", "Name", ticket.ConcertId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "UserName", ticket.UserId);
            return View(ticket);

            //List<Ticket> toAdd = new();
            //if (ModelState.IsValid)
            //{
            //    toAdd.Add(ticket);
            //    toAdd.Add(ticket);
            //    toAdd.Add(ticket);
            //    toAdd.Add(ticket);
            //    toAdd.Add(ticket);

            //    await _context.AddRangeAsync(toAdd);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["ConcertId"] = new SelectList(_context.Concerts, "Id", "Name", ticket.ConcertId);
            //ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "UserName", ticket.UserId);
            //return View(toAdd);
        }

        [Authorize(Roles = "Administrator")]
        //[Route("/{Controller}/ConcertType/{type?}/Singer/{singer?}/")]
        public IActionResult CreateMany(int? amount)
        {
            var concerts = _context.Concerts.Include(c => c.Location).Include(c => c.Singer).Where(c => c.Date >= DateTime.Now).OrderBy(c => c.Date);
            ViewData["ConcertId"] = new SelectList(concerts, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateMany([Bind("Id,ConcertId,IsReserved,UserId")] Ticket ticket, int amount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConcertId"] = new SelectList(_context.Concerts, "Id", "Name", ticket.ConcertId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "UserName", ticket.UserId);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["ConcertId"] = new SelectList(_context.Concerts.Include(c => c.Singer).Include(c => c.Location), "Id", "Name", ticket.ConcertId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "UserName", ticket.UserId);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConcertId,IsReserved,UserId")] Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Id))
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
            ViewData["ConcertId"] = new SelectList(_context.Concerts, "Id", "Name", ticket.ConcertId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "UserName", ticket.UserId);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Concert)
                .Include(t => t.User)
                .Include(t => t.Concert.Location)
                .Include(t => t.Concert.Singer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
