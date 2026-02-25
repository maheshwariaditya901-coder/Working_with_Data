using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using Working_with_Data.Data;

namespace Working_with_Data.Controllers
{
    
        public class GadgetController : Controller
    {


        // readonly → Value can only be assigned inside constructor.
        // AppDbContext → Your database class (inherits from DbContext)
        // dbContext → Variable name which store database connection object.


        // to access data and pass it to the view we need to make the instance of appdbContext

        private readonly AppDbContext dbContext;
        public GadgetController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
 
        public IActionResult Index()
        {
            var DATA = dbContext.Gadgets.ToList();
            return View(DATA);
        }
 

    }
}
