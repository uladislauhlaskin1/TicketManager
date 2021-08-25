using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models.ConcertTypes
{
    public class ClassicMusic : Concert
    {
        [Display(Name = "Voice Type")]
        [StringLength(60)]
        public string VoiceType { get; set; }
        [StringLength(60)]
        [Display(Name = "Concert Name")]
        public string ConcertName { get; set; }
        [StringLength(60)]
        public string Composer { get; set; }
    }
}
