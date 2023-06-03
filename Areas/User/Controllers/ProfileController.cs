using Core_Proje.Areas.User.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel model = new();
            model.Name = user.Name;
            model.SurName = user.SurName;
            model.Password = user.PasswordHash;
            model.ConfirmPassword = user.PasswordHash;
            model.ImageUrl = user.ImageUrl;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //IdentityResult sifre;

            user.Name = userEditViewModel.Name;
            user.SurName = userEditViewModel.SurName;
            user.ImageUrl = userEditViewModel.ImageUrl;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            //if (userEditViewModel.Password == userEditViewModel.ConfirmPassword)
            //    sifre = await _userManager.ChangePasswordAsync(user, user.PasswordHash,userEditViewModel.Password);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }

            return View();
        }


    }
}
