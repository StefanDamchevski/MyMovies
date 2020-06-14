using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Service.Interfaces
{
    public interface IMovieCommentService
    {
        void Add(string comment, int movieId, int userId);
        List<MovieComment> GetAll();
        void Approve(int id);
    }
}
