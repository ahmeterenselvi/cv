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
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal()); 

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Edit Feature";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Edit Feature";

            var value = featureManager.TGetList().FirstOrDefault();

            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            ViewBag.v1 = "Edit Feature";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Edit Feature";

            featureManager.TUpdate(feature);

            return View();
        }
    }
}
