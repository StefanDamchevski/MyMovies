using DemoMovies.Data;
using System.Collections.Generic;

namespace DemoMovies.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
        void Add(User newUser);
        List<User> GetAll();
        void Delete(int id);
        User GetById(int id);
        void Update(User user);
    }
}
