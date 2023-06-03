using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IViewComponentResult Invoke()
        {
            var values = writerMessageManager.GetListbyReceiver("admin@gmail.com").OrderByDescending(x=>x.Date).Take(3).ToList();
            ViewBag.MessageCount = values.Count();

            return View(values);
        }
    }
}
