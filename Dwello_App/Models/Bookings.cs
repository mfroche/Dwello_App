using System.ComponentModel.DataAnnotations;

namespace Dwello_App.Models
{
    public class Bookings
    {
        [Required]
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int ListingId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumOfDays { get; set; }
        public int Rate { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Listings> Listings { get; set; }
    }
}
