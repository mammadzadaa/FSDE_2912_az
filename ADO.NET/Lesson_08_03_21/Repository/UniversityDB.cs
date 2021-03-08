using Lesson_08_03_21.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_03_21.Repository
{
    public class UniversityDB : DbContext
    {
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public UniversityDB() : base("Connection") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>().HasKey(x => x.Id);
            modelBuilder.Entity<Teacher>().HasIndex(x => x.Id);
            

            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().HasIndex(x => x.Id);

            modelBuilder.Entity<Group>().HasKey(x => x.Id);
            modelBuilder.Entity<Group>().HasIndex(x => x.Id);
        }

    }
}
