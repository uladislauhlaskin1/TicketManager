using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TicketManagerTask.Data;
using TicketManagerTask.Models;

namespace TicketManagerTask.Views.Concerts
{
    public class CreateModel : PageModel
    {
        private readonly TicketManagerTask.Data.ApplicationDbContext _context;

        public CreateModel(TicketManagerTask.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id");
        ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Concert Concert { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Concerts.Add(Concert);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
