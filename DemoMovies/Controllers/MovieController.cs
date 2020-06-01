using DemoMovies.Data;
using DemoMovies.Helpers;
using DemoMovies.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

            var overViewModels = movies
                .Select(x => OverviewModelConverter.OveviewModelConvert(x))
                .ToList();

            return View(overViewModels);
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
                return RedirectToAction("ModifyOverview");
            }
            else
            {
                return View(movie);
            }
        }
        public IActionResult ModifyOverview()
        {
            var movies = MovieService.GetAll();
            return View(movies);
        }
        public IActionResult Delete(int id)
        {
            MovieService.Delete(id);
            return RedirectToAction("ModifyOverview");
        }

        public IActionResult Modify(int id)
        {
            var movie = MovieService.GetById(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Modify(Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieService.UpdateMovie(movie);
                return RedirectToAction("ModifyOverview");
            }
            else
            {
                return View();
            }
        }
    }
}