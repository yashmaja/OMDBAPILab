using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OMDB_API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OMDB_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDAL movieDAL = new MovieDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            MovieModel result = movieDAL.GetMovie(title);
            return View(result);
        }

        [HttpGet]
        public IActionResult MovieNight()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            MovieModel movie1 = movieDAL.GetMovie(title1);
            MovieModel movie2 = movieDAL.GetMovie(title2);
            MovieModel movie3 = movieDAL.GetMovie(title3);

            List<MovieModel> movies = new List<MovieModel>
            {
                movie1,
                movie2,
                movie3
            };

            return View(movies);
        }

        public IActionResult GenreSearch()
        {
            return View();
        }

        public IActionResult GenreSearch(string genre)
        {

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
