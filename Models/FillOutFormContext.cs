using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class FillOutFormContext : DbContext
    {
        public FillOutFormContext(DbContextOptions<FillOutFormContext> options) : base(options)
        {

        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Movie> Movies { get; set; } // Add this DbSet<Movie> property
    }
}
