using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Edit About";
            ViewBag.v2 = "About";
            ViewBag.v3 = "Edit About";

            var value = aboutManager.TGetList().FirstOrDefault();

            return View(value);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            ViewBag.v1 = "Edit About";
            ViewBag.v2 = "About";
            ViewBag.v3 = "Edit About";

            aboutManager.TUpdate(about);

            return RedirectToAction("Index");
        }
    }
}
