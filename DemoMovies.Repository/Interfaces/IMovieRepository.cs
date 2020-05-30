using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Repository.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        List<Movie> GetByTitle(string title);
        void Update(Movie movie);
        void Delete(int id);
    }
}
