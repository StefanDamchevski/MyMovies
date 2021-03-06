﻿using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoMovies.Repository
{
    public class MovieCommentRepository : IMovieCommentRepository
    {
        private DemoMoviesContext Context { get; set; }
        public MovieCommentRepository(DemoMoviesContext context)
        {
            Context = context;
        }
        public void Add(MovieComment movieComment)
        {
            Context.MovieComments.Add(movieComment);
            Context.SaveChanges();
        }

        public List<MovieComment> GetAll()
        {
            return Context.MovieComments
                .Include(x => x.Movie)
                .Include(x => x.User)
                .ToList();
        }

        public MovieComment GetById(int id)
        {
            return Context.MovieComments
                .Include(x => x.User)
                .Include(x => x.Movie)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(MovieComment comment)
        {
            Context.MovieComments.Update(comment);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            MovieComment movieComment = new MovieComment
            {
                Id = id,
            };
            Context.MovieComments.Remove(movieComment);
            Context.SaveChanges();
        }
    }
}