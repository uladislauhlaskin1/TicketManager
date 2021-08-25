using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(-90, 90)]
        public double Latitude { get; set; }
        [Required]
        [Range(-180, 180)]
        public double Longitude { get; set; }
        [Display(Name = "Location Name")]
        [StringLength(60)]
        public string Name { get; set; }
        [StringLength(60)]
        public string NameRu { get; set; }
    }
}
