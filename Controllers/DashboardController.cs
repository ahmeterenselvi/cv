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
    public class DashboardController : Controller
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Dashboard Page";
            ViewBag.v3 = "Dashboard";

            return View();
        }
        [HttpPost]
        public IActionResult Index(ToDoList toDoList)
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Dashboard Page";
            ViewBag.v3 = "Dashboard";

            toDoList.Status = false;
            toDoListManager.TAdd(toDoList);

            return RedirectToAction("Index");
        }
    }
}
