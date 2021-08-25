using System.ComponentModel.DataAnnotations;

namespace TicketManager.Models.ConcertTypes
{
    public class Party : Concert
    {
        [Display(Name = "Document Age Confirmation")]
        [StringLength(60)]
        public string DocumentAgeConfirmation { get; set; }
    }
}
