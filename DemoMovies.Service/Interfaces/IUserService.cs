using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.Service.Interfaces
{
    public interface IUserService
    {
        Task<bool> SignInAsync(string username, string password, Microsoft.AspNetCore.Http.HttpContext httpContext);
    }
}
