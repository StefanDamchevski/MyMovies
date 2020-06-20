using System;
using System.Security.Claims;

namespace DemoMovies.Custom
{
    public class AuthorizeService
    {
        public static bool AuthorizeUser(ClaimsPrincipal user, int requestUserId)
        {
            return Convert.ToBoolean(user.FindFirst("IsAdmin").Value) || Convert.ToInt32(user.FindFirst("Id").Value) == requestUserId;
        }
    }
}
