using BilgeAdam.EF.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.EF.Common
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost, 12000;Database=Northwind;User Id=sa;Password=1q2w3e4R!");
        }
    }
}
