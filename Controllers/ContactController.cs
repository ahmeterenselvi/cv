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
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Message List";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Message List";

            var values = messageManager.TGetList();

            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = messageManager.TGetById(id);
            messageManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ContactDetails(int id)
        {
            ViewBag.v1 = "Message Details";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Message Details";

            var value = messageManager.TGetById(id);

            return View(value);
        }
    }
}
