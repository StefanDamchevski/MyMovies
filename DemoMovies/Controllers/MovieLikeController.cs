using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoMovies.Controllers
{
    [Authorize]
    public class MovieLikeController : Controller
    {
        private IMovieLikeService MovieLikeService { get; set; }
        public MovieLikeController(IMovieLikeService movieLikeService)
        {
            MovieLikeService = movieLikeService;
        }
        [HttpPost]
        public IActionResult AddLike([FromBody] RequestLikeModel model)
        {
            int userId = Convert.ToInt32(User.FindFirst("Id").Value);
            MovieLikeService.AddLike(model.Id, userId);
            return Ok();
        }
        public IActionResult UnLike([FromBody] RequestLikeModel model)
        {
            int userId = Convert.ToInt32(User.FindFirst("Id").Value);
            MovieLikeService.UnLike(model.Id, userId);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddDislike([FromBody] RequestLikeModel model)
        {
            int userId = Convert.ToInt32(User.FindFirst("Id").Value);
            MovieLikeService.AddDislike(model.Id, userId);
            return Ok();
        }
        public IActionResult UnDislike([FromBody] RequestLikeModel model)
        {
            int userId = Convert.ToInt32(User.FindFirst("Id").Value);
            MovieLikeService.UnDislike(model.Id, userId);
            return Ok();
        }
    }
}