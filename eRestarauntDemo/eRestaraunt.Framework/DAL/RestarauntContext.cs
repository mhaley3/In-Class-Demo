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
        // The property name musst match the name of the database table
        public DbSet<Tables> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservations> Reservations { get; set; }

        // for customizing the model of out entities as we want them to match out database, we would put any details inside the following method
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservations>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");

                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
