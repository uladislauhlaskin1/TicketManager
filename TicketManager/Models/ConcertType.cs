using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManager.Models
{
    public class ConcertType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRu { get; set; }
    }
}
