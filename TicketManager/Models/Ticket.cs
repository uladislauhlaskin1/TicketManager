using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketManager.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        [Display(Name = "Is Reserved")]
        public bool IsReserved { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [NotMapped]
        public int Amount { get; set; }
    }
}
