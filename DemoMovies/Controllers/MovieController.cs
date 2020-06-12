using DemoMovies.Helpers;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DemoMovies.Controllers
{
    [Authorize(Policy = "IsAdmin")]
    public class MovieController : Controller
    {
        public IMovieService MovieService { get; set;}
        public MovieController(IMovieService movieService)
        {
            MovieService = movieService;
        }
        [AllowAnonymous]
        public IActionResult Overview(string title)
        {
            var movieOverviewData = new MovieOverviewDataModel();

            var movies = MovieService.GetByTitle(title);
            var sideBarData = MovieService.GetSideBarData();

            var overViewModels = movies
                .Select(x => ModelConverter.OveviewModelConvert(x))
                .ToList();

            movieOverviewData.MovieOverview = overViewModels;
            movieOverviewData.SideBarData = sideBarData;

            return View(movieOverviewData);
        }
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var currentMovie = MovieService.GetMovieDetails(id);
            var sideBarData = MovieService.GetSideBarData();

            var model = ModelConverter.DetailsModelConvert(currentMovie);
            model.SideBarData = sideBarData;

            return View(model);
        }
        public IActionResult Create()
        {
            var movie = new MovieCreateModel();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Create(MovieCreateModel movieCreate)
        {
            if (ModelState.IsValid)
            {
                var movie = ModelConverter.CreateModelToMovieConvert(movieCreate);
                MovieService.Add(movie);
                return RedirectToAction("ModifyOverview");
            }
            else
            {
                return View(movieCreate);
            }
        }
        public IActionResult ModifyOverview()
        {
            var movies = MovieService.GetAll();

            var model = movies
                .Select(x => ModelConverter.ConvertToModifyOverviewModel(x))
                .ToList();

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            MovieService.Delete(id);
            return RedirectToAction("ModifyOverview");
        }

        public IActionResult Modify(int id)
        {
            var movie = MovieService.GetById(id);
            var model = ModelConverter.ConvertToMovieModifyModel(movie);
            return View(model);
        }
        [HttpPost]
        public IActionResult Modify(MovieModifyModel model)
        {
            if (ModelState.IsValid)
            {
                var movie = ModelConverter.ConvertFromMovieModifyModel(model);
                MovieService.UpdateMovie(movie);
                return RedirectToAction("ModifyOverview");
            }
            else
            {
                return View(model);
            }
        }
    }
}