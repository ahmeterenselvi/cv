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
    public class SubContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Edit Contact";
            ViewBag.v2 = "Contact";
            ViewBag.v3 = "Edit Contact";

            var values = contactManager.TGetList().FirstOrDefault(); ;

            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ViewBag.v1 = "Edit Contact";
            ViewBag.v2 = "Contact";
            ViewBag.v3 = "Edit Contact";

            contactManager.TUpdate(contact);

            return RedirectToAction("Index");
        }
    }
}
