using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace DemoMovies.Service
{
    public class MovieLikeService : IMovieLikeService
    {
        private IMovieLikeRepository MovieLikeRepository { get; set; }
        public MovieLikeService(IMovieLikeRepository movieLikeRepository)
        {
            MovieLikeRepository = movieLikeRepository;
        }

        public void AddLike(int movieId, int userId)
        {
            MovieLike movieLike = MovieLikeRepository.GetByForeignKey(movieId, userId);
            if(movieLike == null)
            {
                MovieLike newMovieLike = CreateNewMovieLike(movieId, userId);
                MovieLikeRepository.Add(newMovieLike);
            }
            else
            {
                movieLike.Status = true;
                MovieLikeRepository.Update(movieLike);
            }
        }

        private static MovieLike CreateNewMovieLike(int movieId, int userId)
        {
            MovieLike movieLike = new MovieLike();
            movieLike.Status = true;
            movieLike.MovieId = movieId;
            movieLike.UserId = userId;
            movieLike.DateCreated = DateTime.Now;
            return movieLike;
        }

        public List<MovieLike> GetAll()
        {
            return MovieLikeRepository.GetAll();
        }

        public void UnLike(int movieId, int userId)
        {
            MovieLike movieLike = MovieLikeRepository.GetByForeignKey(movieId, userId);
            MovieLikeRepository.Remove(movieLike);
        }

        public void AddDislike(int movieId, int userId)
        {
            MovieLike movieDisLike = MovieLikeRepository.GetByForeignKey(movieId, userId);
            if (movieDisLike == null)
            {
                MovieLike newMovieDisLike = CreateNewMovieDisLike(movieId, userId);
                MovieLikeRepository.Add(newMovieDisLike);
            }
            else
            {
                movieDisLike.Status = false;
                MovieLikeRepository.Update(movieDisLike);
            }
        }

        private MovieLike CreateNewMovieDisLike(int movieId, int userId)
        {
            MovieLike movieDisLike = new MovieLike();
            movieDisLike.Status = false;
            movieDisLike.MovieId = movieId;
            movieDisLike.UserId = userId;
            movieDisLike.DateCreated = DateTime.Now;
            return movieDisLike;
        }

        public void UnDislike(int movieId, int userId)
        {
            MovieLike movieLike = MovieLikeRepository.GetByForeignKey(movieId, userId);
            MovieLikeRepository.Remove(movieLike);
        }
    }
}