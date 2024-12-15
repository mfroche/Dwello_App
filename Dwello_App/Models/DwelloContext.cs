using Microsoft.EntityFrameworkCore;

namespace Dwello_App.Models
{
    public class DwelloContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Listings> Listings { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Reviews> Reviews { get; set; }

        public DwelloContext(DbContextOptions<DwelloContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {
                    UserId = 1,
                    UserFirstName = "John",
                    UserLastName = "Doe",
                    UserEmail = "john.doe@example.com",
                    UserDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    UserAddress = "123 Main Street",
                    DateJoined = new DateTime(2023, 1, 15)
                },
                new User {
                    UserId = 2,
                    UserFirstName = "Jane",
                    UserLastName = "Smith",
                    UserEmail = "jane.smith@example.com",
                    UserDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    UserAddress = "456 Oak Avenue",
                    DateJoined = new DateTime(2023, 2, 20)
                }
            );
        }
    }
}
