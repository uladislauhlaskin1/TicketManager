using System.ComponentModel.DataAnnotations;

namespace TicketManagerTask.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string NameRu { get; set; }
    }
}
