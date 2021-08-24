using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        public int SingerId { get; set; }
        public Singer Singer { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public DateTime Date { get; set; }
        public string Discriminator { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public int TicketsCount => Tickets.Count;
        public ICollection<PromoCode> PromoCodes { get; set; }
    }
}
