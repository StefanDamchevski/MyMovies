using DemoMovies.Data;
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
            
            MovieComment movieComment = new MovieComment();
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
            MovieComment comment = MovieCommentRepository.GetById(id);
            comment.IsAproved = true;
            MovieCommentRepository.Update(comment);
        }

        public void Delete(int id)
        {
            MovieCommentRepository.Delete(id);
        }

        public MovieComment GetById(int id)
        {
            return MovieCommentRepository.GetById(id);
        }

        public void Update(string comment, int id)
        {
            MovieComment movieComment = MovieCommentRepository.GetById(id);
            movieComment.Comment = comment;
            MovieCommentRepository.Update(movieComment);
        }
    }
}
