﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult Index()
        {
            var values = announcementManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var value = announcementManager.TGetById(id);

            return View(value);
        }
    }
}