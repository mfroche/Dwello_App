using System.ComponentModel.DataAnnotations;

namespace Dwello_App.Models
{
    public class User
    {
        [Required]
        [Key]
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserDescription { get; set; }
        public string UserAddress { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
