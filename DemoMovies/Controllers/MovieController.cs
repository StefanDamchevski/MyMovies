using DemoMovies.Data;
using DemoMovies.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoMovies.Controllers
{
    public class MovieController : Controller
    {
        public IMovieService MovieService { get; set;}
        public MovieController(IMovieService movieService)
        {
            MovieService = movieService;
        }
        public IActionResult Overview(string title)
        {
            var movies = MovieService.GetByTitle(title);
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            var currentMovie = MovieService.GetMovieDetails(id);
            return View(currentMovie);
        }
        public IActionResult Create()
        {
            var movie = new Movie();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieService.Add(movie);
                return RedirectToAction("Overview");
            }
            else
            {
                return View(movie);
            }
        }
    }
}