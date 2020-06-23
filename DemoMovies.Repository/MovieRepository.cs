using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMovies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private DemoMoviesContext Context { get; set; }
        public MovieRepository(DemoMoviesContext context)
        {
            Context = context;
        }
        public void Add(Movie movie)
        {
            movie.DateCreated = DateTime.Now;
            Context.Movies.Add(movie);
            Context.SaveChanges();
        }
        public List<Movie> GetAll()
        {
            return Context.Movies.ToList();
        }
        public Movie GetById(int id)
        {
            return Context.Movies
                .Include(x => x.MovieComment)
                    .ThenInclude(x => x.User)
                .Include(x => x.MovieLikes)
                .FirstOrDefault(x => x.Id == id); 
        }
        public List<Movie> GetByTitle(string title)
        {
            IQueryable<Movie> movies = Context.Movies.AsQueryable();
            if (!String.IsNullOrEmpty(title))
            {
                movies = movies.Where(x => x.Title.Contains(title));
            }
            return movies.ToList();
        }
        public void Update(Movie movie)
        {
            Context.Movies.Update(movie);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie movie = new Movie
            {
                Id = id,
            };
            Context.Movies.Remove(movie);
            Context.SaveChanges();
        }
    }
}