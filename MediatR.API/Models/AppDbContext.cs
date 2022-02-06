using Microsoft.EntityFrameworkCore;

namespace MediatR.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

    }
}
