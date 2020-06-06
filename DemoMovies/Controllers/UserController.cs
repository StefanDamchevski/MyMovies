using DemoMovies.Data;
using DemoMovies.Helpers;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMovies.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IUserService UserService { get; set; }
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        public IActionResult ModifyUsers()
        {
            var users = UserService.GetAll();

            var model = users
                .Select(x => ModelConverter.ConvertToModifyUserModel(x))
                .ToList();

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            UserService.Delete(id);
            return RedirectToAction("ModifyUsers");
        }
        public IActionResult Modify(int id)
        {
            var user = UserService.GetById(id);
            var model = ModelConverter.ConvertToModifyCurrentUserModel(user);
            return View(model);
        }
        [HttpPost]
        public IActionResult Modify(ModifyCurrentUserModel currentUserModel)
        {
            if (ModelState.IsValid)
            {
                var updatedUser = ModelConverter.ConvertFromUserModifyCurrnetUserModel(currentUserModel);
                var response =  UserService.UpdateUser(updatedUser);
                if (response.IsSuccessful)
                {
                    return RedirectToAction("ModifyUsers");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, response.Message);
                    return View(currentUserModel);
                }
            }
            else
            {
                return View(currentUserModel);
            }
        }
    }
}