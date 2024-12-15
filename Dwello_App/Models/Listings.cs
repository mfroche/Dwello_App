using System.ComponentModel.DataAnnotations;

namespace Dwello_App.Models
{
    public class Listings
    {
        [Required]
        [Key]
        public int ListingId { get; set; }
        public int HostId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public ICollection<Host> Hosts { get; set; }
    }
}
