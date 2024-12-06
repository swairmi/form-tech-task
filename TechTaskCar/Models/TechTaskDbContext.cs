//using the entity framework to aid with dynamic table creation
using Microsoft.EntityFrameworkCore;

//using the modals as name space to aid with cross file connectivity, scalebility and readablity =
namespace TechTaskCar.Models
{

    //creating a new modal inheriting from DbContext
    public class TechTaskDbContext : DbContext
    {

        //creating a constructor to configur the DbContext with options that are passed into it when the application is started
        public TechTaskDbContext(DbContextOptions<TechTaskDbContext> options) : base(options){

        }

        //creating a property which will house our forms properties
        public DbSet<Submission> Submission { get; set; }

    }
}
