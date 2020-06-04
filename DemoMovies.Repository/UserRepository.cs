using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
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
    }
}