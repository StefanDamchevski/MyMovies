using DemoMovies.Repository;
using DemoMovies.Repository.Interfaces;
using DemoMovies.Service.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.Service
{
    public class UserService : IUserService
    {
        public IUserRepository UserRepository { get; }
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        public async Task<bool> SignInAsync(string username, string password, HttpContext httpContext)
        {
            var user = UserRepository.GetByUsername(username);
            if(user != null && user.Password == password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserName),
                    new Claim(ClaimTypes.Name, user.UserName)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await httpContext.SignInAsync(principal);

                return true;
            }
            return false;
        }
    }
}
