using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult ReceiverMessageList()
        {
            ViewBag.v1 = "Receiver Messages";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Receiver Messages";

            var values = writerMessageManager.GetListbyReceiver("admin@gmail.com");

            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            ViewBag.v1 = "Sender Messages";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Sender Messages";

            var values = writerMessageManager.GetListbySender("admin@gmail.com");

            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            ViewBag.v1 = "Message Details";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Message Details";

            var value = writerMessageManager.TGetById(id);
            return View(value);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var value = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(value);

            return RedirectToAction("ReceiverMessageList");
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            ViewBag.v1 = "Send a Message";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Send a Message";

            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage writerMessage)
        {
            ViewBag.v1 = "Send a Message";
            ViewBag.v2 = "Messages";
            ViewBag.v3 = "Send a Message";

            Context c = new();

            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToString("dd,MM,yyyy"));
            writerMessage.ReceiverName = c.Users.Where(u => u.Email == writerMessage.Receiver).Select(x => x.Name + " " + x.SurName).FirstOrDefault();

            writerMessageManager.TAdd(writerMessage);

            return RedirectToAction("SenderMessageList", "AdminMessage");
        }
    }
}
