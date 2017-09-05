using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Treehouse.SolarSystem.Models
{
    public class Planet
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public int Diameter { get; set; }
        public int Position { get; set; }
    }
}