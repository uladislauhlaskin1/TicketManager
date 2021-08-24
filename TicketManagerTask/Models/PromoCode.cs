using System;
using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models
{
    public class PromoCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public double Coefficient { get; set; }
        public double DiscountPercent => Math.Round((1 - Coefficient) * 100);
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
    }
}
