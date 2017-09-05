using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Treehouse.SolarSystem.Models;

namespace Treehouse.SolarSystem.Data
{
    public class Context : DbContext
    {
        public DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}