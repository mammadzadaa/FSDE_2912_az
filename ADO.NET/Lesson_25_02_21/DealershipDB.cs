using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25_02_21
{
    public class DealershipDB : DbContext
    {
        public DealershipDB() : base("name=Connection") { }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasIndex(x => x.Id);
            modelBuilder.Entity<Car>().HasKey(x => x.Id);

            modelBuilder.Entity<Buyer>().HasIndex(x => x.Id);
            modelBuilder.Entity<Buyer>().HasKey(x => x.Id);

            modelBuilder.Entity<Sale>().HasIndex(x => x.Id);
            modelBuilder.Entity<Sale>().HasKey(x => x.Id);
        }
    }
}
