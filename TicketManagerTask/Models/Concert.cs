using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketManagerTask.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SingerId { get; set; }
        public Singer Singer { get; set; }
        [Required]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Discriminator { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        //[NotMapped]
        //public int TicketsCount => Tickets.Count;
        public ICollection<PromoCode> PromoCodes { get; set; }

    }
}
