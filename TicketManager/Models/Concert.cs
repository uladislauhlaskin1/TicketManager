using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManager.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        public int BandId { get; set; }
        public Band Band { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public DateTime Date { get; set; }
        public int ConcertTypeId { get; set; }
        public ConcertType ConcertType { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public int TicketsCount => Tickets.Count;
        public ICollection<PromoCode> PromoCodes { get; set; }
    }
}
