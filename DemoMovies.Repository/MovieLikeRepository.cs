using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DemoMovies.Repository
{
    public class MovieLikeRepository : IMovieLikeRepository
    {
        private DemoMoviesContext Context { get; set; }
        public MovieLikeRepository(DemoMoviesContext context)
        {
            Context = context;
        }

        public void Add(MovieLike movieLike)
        {
            Context.MovieLikes.Add(movieLike);
            Context.SaveChanges();
        }

        public List<MovieLike> GetAll()
        {
            return Context.MovieLikes.ToList();
        }

        public MovieLike GetByForeignKey(int movieId, int userId)
        {
            return Context.MovieLikes.FirstOrDefault(x => x.MovieId == movieId && x.UserId == userId);
        }

        public void Update(MovieLike movieLike)
        {
            Context.MovieLikes.Update(movieLike);
            Context.SaveChanges();
        }

        public void Remove(MovieLike movieLike)
        {
            Context.MovieLikes.Remove(movieLike);
            Context.SaveChanges();
        }
    }
}