using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManager.Models
{
    public class PromoCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public double Coefficient { get; set; }
        public double DiscountPercent => (1 - Coefficient) * 100;
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
    }
}
