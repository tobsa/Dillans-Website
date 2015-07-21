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
            var model = new HomeViewModel()
            {
                PizzaGroups = _service.GetPizzaGroups()
            };

            return View(model);
        }

        public ActionResult Filter()
        {
            throw new NotImplementedException();
        }
    }
}