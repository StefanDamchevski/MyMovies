using DemoMovies.Data;
using DemoMovies.Helpers;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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
        public IActionResult ModifyComments()
        {
            var comments = MovieCommentService.GetAll();
            var model = comments
                .Select(x => ModelConverter.ConvertToModifyCommentsModel(x))
                .ToList();

            return View(model);
        }
        public IActionResult Approve(int id)
        {
            MovieCommentService.Approve(id);
            return RedirectToAction("ModifyComments");
        }
        public IActionResult Delete(int id)
        {
            MovieCommentService.Delete(id);
            return RedirectToAction("ModifyComments");
        }
        public IActionResult Modify(int id)
        {
            MovieComment movieComment = MovieCommentService.GetById(id);
            ModifyCommentModel model = ModelConverter.ConvertToModifyCommentsModel(movieComment);
            return View(model);
        }
        [HttpPost]
        public IActionResult Modify(ModifyCommentModel model)
        {
            if (ModelState.IsValid)
            {
                MovieCommentService.Update(model.Comment, model.Id);
                return RedirectToAction("ModifyComments");
            }
            else
            {
                return View(model);
            }
        }
    }
}