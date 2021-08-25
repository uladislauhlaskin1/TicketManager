using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models.ConcertTypes
{
    public class Party : Concert
    {
        [Display(Name = "Document Age Confirmation")]
        [StringLength(60)]
        public string DocumentAgeConfirmation { get; set; }
    }
}
