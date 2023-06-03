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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Skill List";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Skill List";

            var values = skillManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Add Skill";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Add Skill";

            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = skillManager.TGetById(id);
            skillManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Edit Skill";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Edit Skill";

            var value = skillManager.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);

            return RedirectToAction("Index");
        }
    }
}
