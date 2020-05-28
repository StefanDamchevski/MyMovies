using Microsoft.EntityFrameworkCore;

namespace DemoMovies.Data
{
    public class DemoMoviesContext:DbContext
    {
        public DemoMoviesContext(DbContextOptions<DemoMoviesContext> options) : base(options)
        {
        }
        public virtual DbSet<Movie> Movies { get; set; }
    }
}