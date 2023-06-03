using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.User.ViewComponents.Navbar
{
    public class NavbarInfo:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public NavbarInfo(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.p = user.ImageUrl;

            return View();
        }
    }
}
