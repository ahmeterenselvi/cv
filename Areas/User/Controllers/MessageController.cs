using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace Core_Proje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class MessageController : Controller
    {
        WriterMessageManager manager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var values = manager.GetListbyReceiver(user.Email);

            return View(values);
        }

        [Area("User")]
        public async Task<IActionResult> SenderMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var values = manager.GetListbySender(user.Email);

            return View(values);
        }

        [Area("User")]
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [Area("User")]
        [HttpPost]
        public async Task<IActionResult> SendMessage(WriterMessage writerMessage)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            Context c = new Context();

            writerMessage.Sender = user.Email;
            writerMessage.SenderName = user.Name + " " + user.SurName;
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToString("dd,MM,yyyy"));
            if (writerMessage.Sender == "admin@gmail.com")
            {
                writerMessage.ReceiverName = "Admin";
            }
            else
            {
                writerMessage.ReceiverName = c.Users.Where(u => u.Email == writerMessage.Receiver).Select(x => x.Name + " " + x.SurName).FirstOrDefault();
            }

            manager.TAdd(writerMessage);

            return RedirectToAction("SenderMessage", "Message");
        }

        public IActionResult MessageDetails(int id)
        {
            var value = manager.TGetById(id);

            return View(value);
        }
    }
}
