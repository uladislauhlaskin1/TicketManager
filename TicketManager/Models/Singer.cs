using System.ComponentModel.DataAnnotations;

namespace TicketManager.Models
{
    public class Singer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Singer")]
        public string Name { get; set; }
    }
}
