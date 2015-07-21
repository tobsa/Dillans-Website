using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dillans.Models;
using Dillans.ViewModels;

namespace Dillans.Controllers
{
    public class HomeController : Controller
    {
        private readonly PizzaService service = new PizzaService();

        public ActionResult Index()
        {
            service.ResetSession();

            var model = new HomeViewModel()
            {
                PizzaGroups = service.GetPizzaGroups()
            };

            return View(model);
        }

        public ActionResult Filter()
        {
            service.ResetSession();

            var model = new FilterViewModel()
            {
                FreeIngredients = service.GetFreeIngredients(),
                UsedIngredients = service.GetUsedIngredients(),
                PizzaGroups = service.GetPizzaGroups()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Filter(string ingredient)
        {
            if (string.IsNullOrWhiteSpace(ingredient))
                return View("Error");

            service.AddUsedIngredient(ingredient);

            var model = new FilterViewModel()
            {
                FreeIngredients = service.GetFreeIngredients(),
                UsedIngredients = service.GetUsedIngredients(),
                PizzaGroups = service.GetFilteredPizzaGroups()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult ClearFilter()
        {
            service.ResetSession();

            var model = new FilterViewModel()
            {
                FreeIngredients = service.GetFreeIngredients(),
                UsedIngredients = service.GetUsedIngredients(),
                PizzaGroups = service.GetFilteredPizzaGroups()
            };

            return RedirectToAction("Filter", model);
        }
    }
}