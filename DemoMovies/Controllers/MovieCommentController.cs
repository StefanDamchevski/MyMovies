using DemoMovies.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoMovies.Controllers
{
    public class MovieCommentController : Controller
    {
        public IMovieCommentService MovieCommentService { get; set; }
        public MovieCommentController(IMovieCommentService movieCommentService)
        {
            MovieCommentService = movieCommentService;
        }
        [Authorize]
        public IActionResult Add(string comment, int movieId)
        {
            if (!String.IsNullOrEmpty(comment))
            {
                var userId = Convert.ToInt32(User.FindFirst("Id").Value);
                MovieCommentService.Add(comment, movieId, userId);
                return RedirectToAction("Details", "Movie", new { id = movieId });
            }
            else
            {
                return RedirectToAction("Details", "Movie", new { id = movieId });
            }
         
        }
    }
}