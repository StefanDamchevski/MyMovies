using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

        public SignUpInResponse UpdateUser(User updatedUser)
        {
            var users = UserRepository.GetAll()
                .Where(x => x.Id != updatedUser.Id && x.UserName == updatedUser.UserName)
                .ToList();

            var dbUser = UserRepository.GetById(updatedUser.Id);

            var response = new SignUpInResponse();

            if (!users.Any())
            {
                dbUser.UserName = updatedUser.UserName;
                dbUser.Password = BCrypt.Net.BCrypt.HashPassword(updatedUser.Password);

                UserRepository.Update(dbUser);
                response.IsSuccessful = true;
                return response;
            }
            else
            {
                response.IsSuccessful = false;
                response.Message = $"Username {updatedUser.UserName} already exists";
                return response;
            }
        }
    }
}