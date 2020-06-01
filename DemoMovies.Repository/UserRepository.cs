using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoMovies.Repository
{
    public class UserRepository:IUserRepository
    {
        private DemoMoviesContext Context { get; set; }
        public UserRepository(DemoMoviesContext context)
        {
            Context = context;
        }

        public User GetByUsername(string username)
        {
            return Context.Users.FirstOrDefault(x => x.UserName == username);
        }
    }
}
