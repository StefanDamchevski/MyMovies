using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DemoMovies.Controllers
{
    public class AuthController : Controller
    {
        public IAuthService AuthService { get; set; }
        public AuthController(IAuthService userService)
        {
            AuthService = userService;
        }
        public IActionResult SignIn()
        {
            var signIn = new SignInModel();
            return View(signIn);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signIn, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var response = await AuthService.SignInAsync(signIn.UserName, signIn.Password, HttpContext);
                if (response.IsSuccessful)
                {
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Overview", "Movie");
                    }   
                }
                else
                {
                    ModelState.AddModelError(string.Empty, response.Message);
                    return View(signIn);
                }
            }
            else
            {
                return View(signIn);
            }
        }
        public async Task<IActionResult> SignOut()
        {
            await AuthService.SignOutAsync(HttpContext);
            return RedirectToAction("Overview", "Movie");
        }
        public IActionResult SignUp()
        {
            var model = new SignUpModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var response = AuthService.SignUp(model.Username, model.Password);
                if (response.IsSuccessful)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, response.Message);
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }
}