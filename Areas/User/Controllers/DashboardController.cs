using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        Context c = new Context();

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.v = user.Name;
            ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == user.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = _userManager.Users.Count();
            ViewBag.v4 = c.Skills.Count();

            string api = "e783e8959b9be76053e0e71c81392b14";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=gemlik&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.v6 = document.Descendants("city").ElementAt(0).Attribute("name").Value;

            return View();
        }
    }
}
