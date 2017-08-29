using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treehouse.SolarSystem.Models;

namespace Treehouse.SolarSystem.Data
{
    public class Repository
    {
        private Context _context = null;

        public Repository(Context context)
        {
            _context = context;
        }

        public List<Planet> GetPlanets()
        {
            return _context.Planets
                .OrderBy(p => p.Position)
                .ToList();
        }
    }
}