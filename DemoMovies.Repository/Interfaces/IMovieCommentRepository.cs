using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Repository.Interfaces
{
    public interface IMovieCommentRepository
    {
        void Add(MovieComment movieComment);
        List<MovieComment> GetAll();
        MovieComment GetById(int id);
        void Update(MovieComment comment);
        void Delete(int id);
    }
}
