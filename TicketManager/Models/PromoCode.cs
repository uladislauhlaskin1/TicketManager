using System;
using System.ComponentModel.DataAnnotations;

namespace TicketManager.Models
{
    public class PromoCode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string Code { get; set; }
        [Required]
        [Range(0, 1)]
        public double Coefficient { get; set; }
        public double DiscountPercent => Math.Round((1 - Coefficient) * 100);
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
    }
}
