using System.ComponentModel.DataAnnotations;

namespace Dwello_App.Models
{
    public class Payments
    {
        [Required]
        [Key]
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }

        public ICollection<Bookings> Bookings { get; set; }
    }
}
