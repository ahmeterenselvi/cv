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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Service List";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Service List";

            var values = serviceManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddService(int id)
        {
            ViewBag.v1 = "Add Service";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Add Service";

            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.TGetById(id);
            serviceManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Edit Service";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Edit Service";

            var value = serviceManager.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);

            return RedirectToAction("Index");
        }
    }
}
