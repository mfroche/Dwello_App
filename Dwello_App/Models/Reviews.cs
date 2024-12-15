using System.ComponentModel.DataAnnotations;

namespace Dwello_App.Models
{
    public class Reviews
    {
        [Required]
        [Key]
        public int ReviewId { get; set; }
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Feedback { get; set; }

        public ICollection<Bookings> Bookings { get; set; }
        public User User { get; set; }
    }
}
