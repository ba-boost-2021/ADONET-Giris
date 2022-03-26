using Microsoft.EntityFrameworkCore;
using Tratel.Entities.Auth;
using Tratel.Entities.Customer;
using Tratel.Entities.Main;

namespace Tratel.Data
{
    public class TratelDbContext : DbContext
    {
        public TratelDbContext()
        {

        }

        public TratelDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<LookUpType> LookUpTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
