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
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Testimonial List";
            ViewBag.v2 = "Testimonials";
            ViewBag.v3 = "Testimonial List";

            var values = testimonialManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            ViewBag.v1 = "Add Testimonial";
            ViewBag.v2 = "Testimonials";
            ViewBag.v3 = "Add Testimonial";

            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            ViewBag.v1 = "Add Testimonial";
            ViewBag.v2 = "Testimonials";
            ViewBag.v3 = "Add Testimonial";

            testimonialManager.TAdd(testimonial);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = testimonialManager.TGetById(id);
            testimonialManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial()
        {
            ViewBag.v1 = "Edit Testimonial";
            ViewBag.v2 = "Testimonials";
            ViewBag.v3 = "Edit Testimonial";

            return View();
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            ViewBag.v1 = "Edit Testimonial";
            ViewBag.v2 = "Testimonials";
            ViewBag.v3 = "Edit Testimonial";

            testimonialManager.TUpdate(testimonial);

            return RedirectToAction("Index");
        }
    }
}
