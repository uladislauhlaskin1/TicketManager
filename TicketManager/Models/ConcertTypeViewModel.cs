using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace TicketManager.Models
{
    public class ConcertTypeViewModel
    {
        public IList<Concert> Concerts { get; set; }
        public SelectList ConcertTypes { get; set; }
        public string ConcertType { get; set; }
        public string Singer { get; set; }
    }
}
