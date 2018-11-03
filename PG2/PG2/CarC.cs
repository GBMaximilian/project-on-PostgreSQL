using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PG2
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
        public CarContext() : base(nameOrConnectionString: "Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Person>()
            //    .HasMany(t => t.Cars)
            //    .WithMany(t => t.Persons)
            //    .Map(m =>
            //    {
            //        m.ToTable("PersonCar");
            //        m.MapLeftKey("PersonID");
            //        m.MapRightKey("LicenceNumber");
            //    });
        }

    }
}
