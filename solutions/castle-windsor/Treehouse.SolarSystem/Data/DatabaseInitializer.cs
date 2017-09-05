using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Treehouse.SolarSystem.Models;

namespace Treehouse.SolarSystem.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var planetMercury = new Planet() { Name = "Mercury", Diameter = 4878, Position = 1 };
            var planetVenus = new Planet() { Name = "Venus", Diameter = 12104, Position = 2 };
            var planetEarth = new Planet() { Name = "Earth", Diameter = 12760, Position = 3 };
            var planetMars = new Planet() { Name = "Mars", Diameter = 6787, Position = 4 };
            var planetJupiter = new Planet() { Name = "Jupiter", Diameter = 139822, Position = 5 };
            var planetSaturn = new Planet() { Name = "Saturn", Diameter = 120500, Position = 6 };
            var planetUranus = new Planet() { Name = "Uranus", Diameter = 51120, Position = 7 };
            var planetNeptune = new Planet() { Name = "Neptune", Diameter = 49530, Position = 8 };

            context.Planets.Add(planetMercury);
            context.Planets.Add(planetVenus);
            context.Planets.Add(planetEarth);
            context.Planets.Add(planetMars);
            context.Planets.Add(planetJupiter);
            context.Planets.Add(planetSaturn);
            context.Planets.Add(planetUranus);
            context.Planets.Add(planetNeptune);

            context.SaveChanges();
        }
    }
}