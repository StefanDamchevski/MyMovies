using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Service.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        List<Movie> GetByTitle(string title);
        Movie GetMovieDetails(int id);
        void Delete(int id);
        void UpdateMovie(Movie movie);
    }
}
