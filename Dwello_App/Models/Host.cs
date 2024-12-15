using System.ComponentModel.DataAnnotations;

namespace Dwello_App.Models
{
    public class Host
    {
        [Required]
        [Key]
        public int HostId { get; set; }
        public int UserId { get; set; }
        public int HostRating { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
