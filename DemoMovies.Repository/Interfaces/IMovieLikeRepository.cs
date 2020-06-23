using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Repository.Interfaces
{
    public interface IMovieLikeRepository
    {
        void Add(MovieLike movieLike);
        List<MovieLike> GetAll();
        MovieLike GetByForeignKey(int movieId, int userId);
        void Update(MovieLike movieLike);
        void Remove(MovieLike movieLike);
    }
}
