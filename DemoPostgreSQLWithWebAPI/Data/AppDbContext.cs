using Microsoft.EntityFrameworkCore;

namespace DemoPostgreSQLWithWebAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
