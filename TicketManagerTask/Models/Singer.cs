using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models
{
    public class Singer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
