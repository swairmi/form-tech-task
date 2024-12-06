//using the entity framework to aid with dynamic table creation
using Microsoft.EntityFrameworkCore;

//using the modals as name space to aid with cross file connectivity, scalebility and readablity =
namespace TechTaskCar.Models
{

    //creating a new modal inheriting from DbContext
    public class TechTaskDbContext : DbContext
    {
        public TechTaskDbContext(DbContextOptions<TechTaskDbContext> options) : base(options){

        }

        //creating a property which will house our forms properties
        public DbSet<Submission> Submission { get; set; }

    }
}
