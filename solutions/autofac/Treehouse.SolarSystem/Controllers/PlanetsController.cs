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

        public PlanetsController(Repository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var planets = _repository.GetPlanets();

            return View(planets);
        }
    }
}