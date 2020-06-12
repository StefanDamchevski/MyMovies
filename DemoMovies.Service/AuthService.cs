using DemoMovies.Data;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoMovies.Service
{
    public class AuthService : IAuthService
    {
        public IUserRepository UserRepository { get; }
        public AuthService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        public async Task<SignUpInResponse> SignInAsync(string username, string password, HttpContext httpContext)
        {
            var user = UserRepository.GetByUsername(username);
            var response = new SignUpInResponse();
            if(user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserName),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim("IsAdmin", user.IsAdmin.ToString()),
                    new Claim("Id" , user.Id.ToString()),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await httpContext.SignInAsync(principal);

                response.IsSuccessful = true;
                return response;
            }
            response.IsSuccessful = false;
            response.Message = "Username or password is incorrect";
            return response;
        }
        public async Task SignOutAsync(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }

        public SignUpInResponse SignUp(string username, string password)
        {
            var user = UserRepository.GetByUsername(username);
            var response = new SignUpInResponse();

            if (user == null)
            {
                var newUser = new User();
                newUser.UserName = username;
                newUser.Password = BCrypt.Net.BCrypt.HashPassword(password);

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