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
        private readonly PizzaService _service = new PizzaService();

        public ActionResult Index()
        {
            _service.ResetSession();

            var model = new HomeViewModel()
            {
                PizzaGroups = _service.GetPizzaGroups()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult IndexFilter()
        {
            var model = new HomeViewModel()
            {
                PizzaGroups = _service.GetFilteredPizzaGroups()
            };

            _service.ResetSession();

            return View("Index", model);
        }

        public ActionResult Filter()
        {
            _service.ResetSession();

            var model = new FilterViewModel()
            {
                FreeIngredients = _service.GetFreeIngredients(),
                UsedIngredients = _service.GetUsedIngredients()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Filter(string ingredient)
        {
            if (string.IsNullOrWhiteSpace(ingredient))
                return View("Error");

            _service.AddUsedIngredient(ingredient);

            var model = new FilterViewModel()
            {
                FreeIngredients = _service.GetFreeIngredients(),
                UsedIngredients = _service.GetUsedIngredients()
            };

            return View(model);
        }
    }
}