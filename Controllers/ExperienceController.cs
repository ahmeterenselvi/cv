﻿using BusinessLayer.Concrete;
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
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Experience List";
            ViewBag.v2 = "Experiences";
            ViewBag.v3 = "Experience List";

            var values = experienceManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Add Experience";
            ViewBag.v2 = "Experiences";
            ViewBag.v3 = "Add Experience";

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.TGetById(id);
            experienceManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Edit Experience";
            ViewBag.v2 = "Experiences";
            ViewBag.v3 = "Edit Experience";

            var value = experienceManager.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);

            return RedirectToAction("Index");
        }
    }
}
