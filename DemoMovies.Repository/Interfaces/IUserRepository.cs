using DemoMovies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMovies.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
    }
}
