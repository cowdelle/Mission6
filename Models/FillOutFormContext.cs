using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class FillOutFormContext : DbContext
    {
        public FillOutFormContext(DbContextOptions<FillOutFormContext> options) : base (options)
        {

        }

        public DbSet<Application> Applications { get; set; }
    }
}
