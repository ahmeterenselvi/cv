using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Portfolio List";
            ViewBag.v2 = "Portfolios";
            ViewBag.v3 = "Portfolio List";

            var values = portfolioManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Add Portfolio";
            ViewBag.v2 = "Portfolios";
            ViewBag.v3 = "Add Portfolio";

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Add Portfolio";
            ViewBag.v2 = "Portfolios";
            ViewBag.v3 = "Add Portfolio";

            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult results = portfolioValidator.Validate(portfolio);

            if (!results.IsValid)
            {
                foreach (var result in results.Errors)
                {
                    ModelState.AddModelError(result.PropertyName, result.ErrorMessage);
                }
                return View();
            }
            
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Edit Portfolio";
            ViewBag.v2 = "Portfolios";
            ViewBag.v3 = "Edit Portfolio";

            var value = portfolioManager.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Edit Portfolio";
            ViewBag.v2 = "Portfolios";
            ViewBag.v3 = "Edit Portfolio";

            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult results = portfolioValidator.Validate(portfolio);

            if (!results.IsValid)
            {
                foreach (var result in results.Errors)
                {
                    ModelState.AddModelError(result.PropertyName, result.ErrorMessage);
                }
                return View();
            }

            portfolioManager.TUpdate(portfolio);

            return RedirectToAction("Index");
        }
    }
}
