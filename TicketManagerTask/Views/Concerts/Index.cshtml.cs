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
    public class IndexModel : PageModel
    {
        private readonly TicketManagerTask.Data.ApplicationDbContext _context;

        public IndexModel(TicketManagerTask.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Concert> Concert { get;set; }

        public async Task OnGetAsync()
        {
            Concert = await _context.Concerts
                .Include(c => c.Location)
                .Include(c => c.Singer).ToListAsync();
        }
    }
}
