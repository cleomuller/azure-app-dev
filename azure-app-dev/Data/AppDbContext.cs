using Microsoft.EntityFrameworkCore;

namespace azure_app_dev.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
