using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Interfaces;
using System.Collections.Generic;

namespace DemoMovies.Service
{
    public class MovieService:IMovieService
    {
        private IMovieRepository MovieRepository { get; set; }
        public MovieService(IMovieRepository movieRepo)
        {
            MovieRepository = movieRepo;
        }
        public List<Movie> GetAll()
        {
            return MovieRepository.GetAll();
        }
        public Movie GetById(int id)
        {
            return MovieRepository.GetById(id);
        }
        public void Add(Movie movie)
        {
            MovieRepository.Add(movie);
        }
        public List<Movie> GetByTitle(string title)
        {
            return MovieRepository.GetByTitle(title);
        }
        public Movie GetMovieDetails(int id)
        {
            var movie = MovieRepository.GetById(id);
            movie.Views += 1;
            MovieRepository.Update(movie);
            return movie;
        }

        public void Delete(int id)
        {
            MovieRepository.Delete(id);
        }

        public void UpdateMovie(Movie movie)
        {
            MovieRepository.Update(movie);
        }
    }
}