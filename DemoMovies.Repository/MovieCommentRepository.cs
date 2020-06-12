using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemoMovies.Repository
{
    public class MovieCommentRepository : IMovieCommentRepository
    {
        public DemoMoviesContext Context { get; set; }
        public MovieCommentRepository(DemoMoviesContext context)
        {
            Context = context;
        }
        public void Add(MovieComment movieComment)
        {
            Context.MovieComments.Add(movieComment);
            Context.SaveChanges();
        }
    }
}