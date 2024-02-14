using Microsoft.AspNetCore.Mvc;
using Mission06_Carpenter.Models;
using System.Diagnostics;

namespace Mission06_Carpenter.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterAMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterAMovie(Movie response)
        {
            _context.Movies.Add(response); //add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

    }
}
