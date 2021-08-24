using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TicketManagerTask.Data;
using TicketManagerTask.Models;

namespace TicketManagerTask.Views.Concerts
{
    public class DetailsModel : PageModel
    {
        private readonly TicketManagerTask.Data.ApplicationDbContext _context;

        public DetailsModel(TicketManagerTask.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Concert Concert { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Concert = await _context.Concerts
                .Include(c => c.Location)
                .Include(c => c.Singer).FirstOrDefaultAsync(m => m.Id == id);

            if (Concert == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
