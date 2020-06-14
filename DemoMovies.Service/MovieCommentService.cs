using DemoMovies.Data;
using DemoMovies.Repository;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Interfaces;
using System;
using System.Collections.Generic;

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
            movieComment.IsAproved = false;

            MovieCommentRepository.Add(movieComment);
        }

        public List<MovieComment> GetAll()
        {
            return MovieCommentRepository.GetAll();
        }

        public void Approve(int id)
        {
            var comment = MovieCommentRepository.GetById(id);
            comment.IsAproved = true;
            MovieCommentRepository.Update(comment);
        }
    }
}
