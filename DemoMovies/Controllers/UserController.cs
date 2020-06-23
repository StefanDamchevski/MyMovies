using DemoMovies.Custom;
using DemoMovies.Data;
using DemoMovies.Helpers;
using DemoMovies.Service.Dto;
using DemoMovies.Service.Interfaces;
using DemoMovies.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMovies.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private IUserService UserService { get; set; }
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        [Authorize(Policy = "IsAdmin")]
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
            if (!AuthorizeService.AuthorizeUser(User,id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                UserService.Delete(id);
            }
            if (Convert.ToInt32(User.FindFirst("Id").Value) == id)
            {
                return RedirectToAction("SignOut", "Auth");
            }
            else
            {
                return RedirectToAction("Success");
            }
        }
        public IActionResult Modify(int id)
        {
            if (!AuthorizeService.AuthorizeUser(User, id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                ModifyCurrentUserModel model = ModelConverter.ConvertToModifyCurrentUserModel(UserService.GetById(id));
                return View(model);
            }
        }
        [HttpPost]
        public IActionResult Modify(ModifyCurrentUserModel model)
        {
            if(!AuthorizeService.AuthorizeUser(User, model.Id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    User user = ModelConverter.ConvertFromUserModifyCurrnetUserModel(model);
                    Response response = UserService.UpdateUser(user);
                    if (response.IsSuccessful)
                    {
                        return RedirectToAction("Success");
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
        public IActionResult GiveAdminRole(int id)
        {
            if (!AuthorizeService.AuthorizeUser(User, id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                UserService.GiveAdminRole(id);
                return RedirectToAction("ModifyUsers");
            }
        }
        public IActionResult RemoveAdminRole(int id)
        {
            if (!AuthorizeService.AuthorizeUser(User, id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                UserService.RemoveAdminRole(id);
            }
            if (Convert.ToInt32(User.FindFirst("Id").Value) == id)
            {
                return RedirectToAction("SignOut", "Auth");
            }
            else
            {
                return RedirectToAction("ModifyUsers");
            }
        }
        public IActionResult ChangePassword(int id)
        {
            if (!AuthorizeService.AuthorizeUser(User, id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                ChangePassword model = new ChangePassword();
                model.Id = id;
                return View(model);
            }
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePassword model)
        {
            if (!AuthorizeService.AuthorizeUser(User, model.Id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    UserService.ChangePassword(model.Id, model.Password);
                    return RedirectToAction("Success");
                }
                else
                {
                    return View(model);
                }
            }
        }

        public IActionResult Details(int id)
        {
            if (!AuthorizeService.AuthorizeUser(User, id))
            {
                return RedirectToAction("AccessDenied", "Auth");
            }
            else
            {
                User user = UserService.GetById(id);
                UserDetailsModel model = ModelConverter.ConvertToUserDetailsModel(user);
                return View(model);
            }
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}