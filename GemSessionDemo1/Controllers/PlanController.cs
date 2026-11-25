using GymSessionDemo1.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSessionDemo1.Controllers
{
    public class PlanController : Controller
    {
        // this isn't correct solution 
        private GymDbContext dbcontext = new GymDbContext(); // resolved bu DI


        //search in database about all plans so this is heavy operation async so it will return task
        public async Task<IActionResult> Index()
        {
            var plans = await   dbcontext.Plans.ToListAsync();  // get all product from database and save it locally
            return View(plans); // stronglytyped data
        }
        public IActionResult IndexTest()
        {
            return View();
        }
    }
}
