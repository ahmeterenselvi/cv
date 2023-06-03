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
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());

        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            ViewBag.v1 = "Add Social Media";
            ViewBag.v2 = "Social Medias";
            ViewBag.v3 = "Add Social Media";

            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            ViewBag.v1 = "Add Social Media";
            ViewBag.v2 = "Social Medias";
            ViewBag.v3 = "Add Social Media";

            socialMediaManager.TAdd(socialMedia);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = socialMediaManager.TGetById(id);
            socialMediaManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSocialMedia()
        {
            ViewBag.v1 = "Edit Social Media";
            ViewBag.v2 = "Social Medias";
            ViewBag.v3 = "Edit Social Media";

            return View();
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            ViewBag.v1 = "Edit Social Media";
            ViewBag.v2 = "Social Medias";
            ViewBag.v3 = "Edit Social Media";

            socialMediaManager.TUpdate(socialMedia);

            return RedirectToAction("Index");
        }
    }
}
