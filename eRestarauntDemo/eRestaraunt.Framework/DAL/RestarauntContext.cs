using eRestaraunt.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity; // needed fot the DbContext and other EF classes 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaraunt.Framework.DAL
{
    // By making our DAL class internal, that means that our outside projects cant directly 
    // access our data access layer ( they will have to go through our BLL to do stuff)
    internal class RestarauntContext : DbContext
    {
        public RestarauntContext()
            : base("DefaultConnection")
        { }

        // one property for each table/entry in the database
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
