using DemoMovies.Data;
using DemoMovies.Helpers;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DemoMovies.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private IMovieService MovieService { get; set;}
        private IMovieLikeService MovieLikeService { get; set; }

        public MovieController(IMovieService movieService, IMovieLikeService movieLikeService)
        {
            MovieService = movieService;
            MovieLikeService = movieLikeService;
        }
        [AllowAnonymous]
        public IActionResult Overview(string title)
        {
            MovieOverviewDataModel model = new MovieOverviewDataModel();

            model.MovieOverview = MovieService.GetByTitle(title)
                .Select(x => ModelConverter.OveviewModelConvert(x))
                .ToList();

            model.SideBarData = MovieService.GetSideBarData();

            return View(model);
        }
        [Authorize(Policy = "IsAdmin")]
        public IActionResult Approve(int id)
        {
            MovieService.Approve(id);
            return RedirectToAction("ModifyOverview");
        }
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            Movie movie = MovieService.GetMovieDetails(id);

            MovieDetailsModel model = ModelConverter.DetailsModelConvert(movie);
            model.SideBarData = MovieService.GetSideBarData();

            if (User.Identity.IsAuthenticated)
            {
                MovieLikeModel movieLike = model.MovieLikes.FirstOrDefault(x => x.UserId == Convert.ToInt32(User.FindFirst("Id").Value));
                if(movieLike != null)
                {
                    if (movieLike.Status)
                    {
                        model.MovieStatus = MovieLikeStatus.Liked;
                    }
                    else
                    {
                        model.MovieStatus = MovieLikeStatus.Disliked;
                    }
                }
            }
            return View(model);
        }
        public IActionResult Create()
        {
            MovieCreateModel model = new MovieCreateModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(MovieCreateModel model)
        {
            if (ModelState.IsValid)
            {
                Movie movie = ModelConverter.CreateModelToMovieConvert(model);
                MovieService.Add(movie);
                return RedirectToAction("Overview");
            }
            else
            {
                return View(model);
            }
        }
        [Authorize(Policy ="IsAdmin")]
        public IActionResult ModifyOverview()
        {
            List<ModifyOverviewModel> model = MovieService.GetAll()
                .Select(x => ModelConverter.ConvertToModifyOverviewModel(x))
                .ToList();

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            MovieService.Delete(id);
            return RedirectToAction("ModifyOverview");
        }
        [Authorize(Policy = "IsAdmin")]
        public IActionResult Modify(int id)
        {
            MovieModifyModel model = ModelConverter.ConvertToMovieModifyModel(MovieService.GetById(id));
            return View(model);
        }
        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        public IActionResult Modify(MovieModifyModel model)
        {
            if (ModelState.IsValid)
            {
                Movie movie = ModelConverter.ConvertFromMovieModifyModel(model);
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