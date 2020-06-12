using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Interfaces;
using System;

namespace DemoMovies.Service
{
    public class MovieCommentService : IMovieCommentService
    {
        private IMovieCommentRepository MovieCommentRepository { get; set; }
        public MovieCommentService(IMovieCommentRepository movieCommentRepository)
        {
            MovieCommentRepository = movieCommentRepository;
        }
        public void Add(string comment, int movieId, int userId)
        {
            var movieComment = new MovieComment();
            movieComment.Comment = comment;
            movieComment.DateCreated = DateTime.Now;
            movieComment.MovieId = movieId;
            movieComment.UserId = userId;

            MovieCommentRepository.Add(movieComment);
        }
    }
}
