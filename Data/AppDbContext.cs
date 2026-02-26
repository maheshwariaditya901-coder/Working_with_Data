using Microsoft.EntityFrameworkCore;
using Working_with_Data.Models;
namespace Working_with_Data.Data
{
    public class AppDbContext : DbContext
    {
        // ctor and double tab to make contructor

        // we pass connection string and all info to AppDbcontext which we injected in program.cs file. 
        // options contains  Configuration required to connect to the database that comes from appdbcontext 
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
