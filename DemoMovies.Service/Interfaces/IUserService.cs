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
        Response UpdateUser(User user);
        void GiveAdminRole(int id);
        void RemoveAdminRole(int id);
        void ChangePassword(int id, string password);
        Response CreateNewUser(string username, string password);
    }
}
