using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManager.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        public double Price { get; set; }
        public bool IsReserved { get; set; }
        public string CustomerInfo { get; set; }
     }
}
