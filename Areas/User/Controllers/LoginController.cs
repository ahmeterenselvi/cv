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
    [Area("user")]
    [Route("User/[controller]/[action]")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [Area("User")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Area("User")]
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLoginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.UserName, userLoginViewModel.Password, true, true);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }

            ModelState.AddModelError("", "Hatalı Giriş.");

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");
        }
    }
}
