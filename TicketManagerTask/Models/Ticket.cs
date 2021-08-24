using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        public bool IsReserved { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
