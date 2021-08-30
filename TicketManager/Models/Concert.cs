using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TicketManager.Models
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
        public string Discriminator { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<PromoCode> PromoCodes { get; set; }

        [NotMapped]
        public int TicketAmount { get; set; }

        public string ConcertType()
        {
            if (string.IsNullOrEmpty(Discriminator))
                return "";
            string[] split = Regex.Split(Discriminator, @"(?<!^)(?=[A-Z])");
            StringBuilder s = new StringBuilder();
            foreach (string word in split)
            {
                s.Append($"{word} ");
            }
            return s.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ConcertType());
            sb.Append(" - ");
            if (Singer != null)
            {
                sb.Append(Singer.Name);
                sb.Append(" - ");
            }
            sb.Append(Date);
            if (Location != null)
            {
                sb.Append(" - ");
                sb.Append(Location.Name);
            }
            return sb.ToString();
        }

        public string Name => ToString();
        public string Type => ConcertType();

        public int AvailableTickets => Tickets == null ? 0 : Tickets.Where(t => !t.IsReserved).Count();
        public int ReservedTickets => Tickets == null ? 0 : Tickets.Where(t => t.IsReserved).Count();
    }
}
