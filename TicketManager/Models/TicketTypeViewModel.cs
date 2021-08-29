using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TicketManager.Models
{
    public class TicketTypeViewModel
    {
        public IList<Ticket> Tickets { get; set; }
        public SelectList Concerts { get; set; }
        public string Singer { get; set; }
        public int? ConcertId { get; set; }
    }
}
