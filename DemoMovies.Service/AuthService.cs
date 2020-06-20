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
        private IUserRepository UserRepository { get; set; }
        private IUserService UserService { get; set; }

        public AuthService(IUserRepository userRepository, IUserService userService)
        {
            UserRepository = userRepository;
            UserService = userService;
        }
        public async Task<Response> SignInAsync(string username, string password, HttpContext httpContext)
        {
            User user = UserRepository.GetByUsername(username);
            Response response = new Response();
            if(user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserName),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim("IsAdmin", user.IsAdmin.ToString()),
                    new Claim("Id" , user.Id.ToString()),
                };

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

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

        public Response SignUp(string username, string password)
        {
            Response response = UserService.CreateNewUser(username, password);
            return response;
        }
    }
}