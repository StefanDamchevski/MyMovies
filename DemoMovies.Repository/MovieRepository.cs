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
            return Context.Movies.FirstOrDefault(x => x.Id == id);   
        }
        public List<Movie> GetByTitle(string title)
        {
            var movies = Context.Movies.AsQueryable();
            if (!String.IsNullOrEmpty(title))
            {
                movies = movies.Where(x => x.Title.Contains(title));
            }
            return movies.ToList();
        }
        public void Update(Movie movie)
        {
            Context.Entry<Movie>(movie).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}