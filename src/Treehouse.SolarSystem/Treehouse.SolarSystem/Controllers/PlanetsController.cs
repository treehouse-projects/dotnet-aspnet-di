using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treehouse.SolarSystem.Data;

namespace Treehouse.SolarSystem.Controllers
{
    public class PlanetsController : Controller
    {
        private Repository _repository = null;

        public PlanetsController()
        {
            var context = new Context();
            _repository = new Repository(context);
        }

        public ActionResult Index()
        {
            var planets = _repository.GetPlanets();

            return View(planets);
        }
    }
}