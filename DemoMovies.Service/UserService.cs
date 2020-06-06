using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DemoMovies.Service
{
    public class UserService : IUserService
    {
        public IUserRepository UserRepository { get; set; }
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        public List<User> GetAll()
        {
            return UserRepository.GetAll();
        }

        public void Delete(int id)
        {
            UserRepository.Delete(id);
        }

        public User GetById(int id)
        {
            return UserRepository.GetById(id);
        }

        public void UpdateUser(User updatedUser)
        {
            UserRepository.Update(updatedUser);
        }
    }
}