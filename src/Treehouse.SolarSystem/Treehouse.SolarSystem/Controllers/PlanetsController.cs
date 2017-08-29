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
        private bool _disposed = false;
        private Context _context = null;
        private Repository _repository = null;

        public PlanetsController()
        {
            _context = new Context();
            _repository = new Repository(_context);
        }

        public ActionResult Index()
        {
            var planets = _repository.GetPlanets();

            return View(planets);
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }
    }
}