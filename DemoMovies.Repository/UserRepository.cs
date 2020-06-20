using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(User newUser)
        {
            Context.Users.Add(newUser);
            Context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return Context.Users.ToList();
        }

        public void Delete(int id)
        {
            User user = new User
            {
                Id = id,
            };
            Context.Users.Remove(user);
            Context.SaveChanges();
        }

        public User GetById(int id)
        {
            return Context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(User user)
        {
            Context.Users.Update(user);
            Context.SaveChanges();
        }
    }
}