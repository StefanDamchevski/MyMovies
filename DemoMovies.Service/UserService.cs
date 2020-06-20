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
        private IUserRepository UserRepository { get; set; }
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

        public Response UpdateUser(User updatedUser)
        {
            List<User> users = UserRepository.GetAll()
                .Where(x => x.Id != updatedUser.Id && x.UserName == updatedUser.UserName)
                .ToList();

            User dbUser = UserRepository.GetById(updatedUser.Id);

            Response response = new Response();

            if (!users.Any())
            {
                dbUser.UserName = updatedUser.UserName;
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

        public void GiveAdminRole(int id)
        {
            User user = UserRepository.GetById(id);
            user.IsAdmin = true;
            UserRepository.Update(user);
        }

        public void RemoveAdminRole(int id)
        {
            User user = UserRepository.GetById(id);
            user.IsAdmin = false;
            UserRepository.Update(user);
        }

        public void ChangePassword(int id, string password)
        {
            User dbUser = UserRepository.GetById(id);
            dbUser.Password = BCrypt.Net.BCrypt.HashPassword(password);
            UserRepository.Update(dbUser);
        }

        public Response CreateNewUser(string username, string password)
        {
            User user = UserRepository.GetByUsername(username);
            Response response = new Response();

            if (user == null)
            {
                User newUser = new User()
                {
                    UserName = username,
                    Password = BCrypt.Net.BCrypt.HashPassword(password),
                    IsAdmin = false,
                };

                UserRepository.Add(newUser);

                response.IsSuccessful = true;
                return response;
            }
            else
            {
                response.IsSuccessful = false;
                response.Message = $"Username {username} already exists";
                return response;
            }
        }
    }
}