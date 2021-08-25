using System.ComponentModel.DataAnnotations;

namespace TicketManager.Models.ConcertTypes
{
    public class OpenAir : Concert
    {
        [StringLength(60)]
        public string Headliner { get; set; }
        [Display(Name = "Location Instruction")]
        [StringLength(100)]
        public string LocationInstruction { get; set; }
    }
}
