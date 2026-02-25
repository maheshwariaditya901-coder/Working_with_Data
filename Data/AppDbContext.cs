using Microsoft.EntityFrameworkCore;
using Working_with_Data.Models;
namespace Working_with_Data.Data
{
    public class AppDbContext : DbContext
    {
        // ctor and double tab to make contructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {       
                
        }

        // we have to define the model name to the db.
        public DbSet<Gadget> Gadgets { get; set; }
    }


}

//DbContext do : 

//Manages database connection

//Maps Models to Tables

//Tracks changes

//Executes queries

//Saves data
