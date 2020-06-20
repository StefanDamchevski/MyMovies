using DemoMovies.Data;
using DemoMovies.Helpers;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            List<User> users = UserService.GetAll();

            List<ModifyUsersModel> model = users
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
            User user = UserService.GetById(id);
            ModifyCurrentUserModel model = ModelConverter.ConvertToModifyCurrentUserModel(user);
            return View(model);
        }
        [HttpPost]
        public IActionResult Modify(ModifyCurrentUserModel currentUserModel)
        {
            if (ModelState.IsValid)
            {
                User updatedUser = ModelConverter.ConvertFromUserModifyCurrnetUserModel(currentUserModel);
                SignUpInResponse response = UserService.UpdateUser(updatedUser);
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
        public IActionResult GiveAdminRole(int id)
        {
            UserService.GiveAdminRole(id);
            return RedirectToAction("ModifyUsers");
        }
        public IActionResult RemoveAdminRole(int id)
        {
            UserService.RemoveAdminRole(id);
            return RedirectToAction("ModifyUsers");
        }
        public IActionResult ChangePassword(int id)
        {
            User user = UserService.GetById(id);
            ChangePassword model = ModelConverter.ConvertToChangePasswordModel(user);
            return View();
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                User user = ModelConverter.ConvertFromChangePasswordModel(model);
                UserService.ChangePassword(user);
                return RedirectToAction("ModifyUsers");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Details(int id)
        {
            User user = UserService.GetById(id);
            UserDetailsModel model = ModelConverter.ConvertToUserDetailsModel(user);
            return View(model);
        }
    }
}