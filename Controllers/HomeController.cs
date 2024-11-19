using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Diagnostics;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcMovieContext _context;

        public HomeController(ILogger<HomeController> logger, MvcMovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // return list of new entertainment for the switcher feature
            if(_context.Movie == null)
            {
                return Problem("Database has zero movies.");
            }
            var movieQuery = from m in _context.Movie
                             orderby m.ReleaseDate descending                      
                             select m;

            var movies = await movieQuery.Include(m => m.Media).Take(30).ToListAsync();

            var homeVM = new HomeViewModel
            {
                NewMovies = movies.Take(5).ToList(),
                Movies = movies
            };

            return View(homeVM);
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
