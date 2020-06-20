using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DemoMovies.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService AuthService { get; set; }
        public AuthController(IAuthService userService)
        {
            AuthService = userService;
        }
        public IActionResult SignIn()
        {
            SignInModel model = new SignInModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                Response response = await AuthService.SignInAsync(model.UserName, model.Password, HttpContext);
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
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
        public async Task<IActionResult> SignOut()
        {
            await AuthService.SignOutAsync(HttpContext);
            return RedirectToAction("Overview", "Movie");
        }
        public IActionResult SignUp()
        {
            SignUpModel model = new SignUpModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                Response response = AuthService.SignUp(model.Username, model.Password);
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
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}