using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lesson_25_02_21
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Connection")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LogStatu> LogStatus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersLog> OrdersLogs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Reqem> Reqems { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogStatu>()
                .HasMany(e => e.OrdersLogs)
                .WithOptional(e => e.LogStatu)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalPriece)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Priece)
                .HasPrecision(19, 4);
        }
    }
}
