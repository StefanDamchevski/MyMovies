using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoMovies.Controllers
{
    public class AuthController : Controller
    {
        public IUserService UserService { get; set; }
        public AuthController(IUserService userService)
        {
            UserService = userService;
        }
        public IActionResult SignIn()
        {
            var signIn = new SignInModel();
            return View(signIn);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signIn)
        {
            if (ModelState.IsValid)
            {
                var isSignedIn = await UserService.SignInAsync(signIn.UserName, signIn.Password, HttpContext);
                if (isSignedIn)
                {
                    return RedirectToAction("Overview", "Movie");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Username or password is incorrect");
                    return View(signIn);
                }
            }
            else
            {
                return View(signIn);
            }
        }
    }
}