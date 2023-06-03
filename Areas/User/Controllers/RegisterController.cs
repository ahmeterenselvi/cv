using Core_Proje.Areas.User.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
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
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [Area("User")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [Area("User")]
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel registerInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(registerInfo);
            }

            var user = new WriterUser()
            {
                Name = registerInfo.Name,
                SurName = registerInfo.SurName,
                UserName = registerInfo.UserName,
                Email = registerInfo.Mail,
                ImageUrl = registerInfo.ImageUrl
            };

            var result = await _userManager.CreateAsync(user, registerInfo.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return RedirectToAction("Index", "Login");
        }

    }
}
