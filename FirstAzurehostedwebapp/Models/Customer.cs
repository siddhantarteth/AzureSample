using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FirstAzureHostedWebApp.Models
{
    public class Customers
    {
        [Key]
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {

        }
    }
}
