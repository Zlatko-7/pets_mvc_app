using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetsApp.Data
{
    public class ApplicationDbContext : DbContext
    {       

        public ApplicationDbContext() : base("name=ApplicationDbContext")
        {
        }

        public System.Data.Entity.DbSet<PetsApp.Models.Owner> Owners { get; set; }
    }
}
