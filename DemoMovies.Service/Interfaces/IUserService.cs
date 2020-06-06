using DemoMovies.Data;
using DemoMovies.Service.Dto;
using System.Collections.Generic;

namespace DemoMovies.Service.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        void Delete(int id);
        User GetById(int id);
        void UpdateUser(User user);
    }
}
