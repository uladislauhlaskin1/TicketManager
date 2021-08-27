using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TicketManager.Models
{
    public class TicketTypeViewModel
    {
        public List<Ticket> Tickets { get; set; }
        public SelectList Types { get; set; }
        public string Type { get; set; }
        public string Singer { get; set; }
    }
}
