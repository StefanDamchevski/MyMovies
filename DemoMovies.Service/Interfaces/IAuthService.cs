using DemoMovies.Service.Dto;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DemoMovies.Service.Interfaces
{
    public interface IAuthService
    {
        Task<SignUpInResponse> SignInAsync(string username, string password,HttpContext httpContext);
        Task SignOutAsync(HttpContext httpContext);
        SignUpInResponse SignUp(string username, string password);
    }
}
