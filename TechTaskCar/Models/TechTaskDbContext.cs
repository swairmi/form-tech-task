using Microsoft.EntityFrameworkCore;

namespace TechTaskCar.Models
{
    public class TechTaskDbContext : DbContext
    {
        public TechTaskDbContext(DbContextOptions<TechTaskDbContext> options)
            : base(options)
        {
        }

        // Define DbSets for your tables
        public DbSet<Submission> Submission { get; set; }

    }
}
