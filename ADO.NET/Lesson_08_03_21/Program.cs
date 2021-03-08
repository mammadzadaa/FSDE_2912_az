using Lesson_08_03_21.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_08_03_21.Models;

namespace Lesson_08_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UniversityDB db = new UniversityDB())
            {
                var g = db.Groups.FirstOrDefault();
                //var g = db.Groups.Include("Students").FirstOrDefault();
                //db.Entry(g).Collection(x => x.Teachers).Load();

                //Console.WriteLine(g.Name);
                g.Students.ForEach(Console.WriteLine);
                g.Teachers.ForEach(Console.WriteLine);
                db.Entry(g).State = System.Data.Entity.EntityState.Modified;
                //db.Database.ExecuteSqlCommand("");

                //foreach (var teacher in g.Teachers)
                //{
                //    Console.WriteLine(teacher.Groups.Count);
                //}

                //foreach (var student in g.Students)
                //{
                //    Console.WriteLine(student.Name);
                //    Console.WriteLine(student.Group.Name);
                //}
            }


        }
    }
}
