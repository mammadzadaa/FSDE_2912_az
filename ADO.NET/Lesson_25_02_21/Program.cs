using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1 db = new Model1())
            {
                foreach (var c in db.Customers)
                {
                    Console.WriteLine(c.FirstName);
                    Console.WriteLine(c.CartNumber);
                    Console.WriteLine(c.Email);
                    Console.WriteLine();

                }

            }

            using (StudentContext db = new StudentContext())
            {

                //var st = new Student()
                //{
                //    FirstName = "Aftandil",
                //    LastName = "Isfendiyarov",
                //    Coins = 100,
                //    Login = "afti",
                //    PasswordHash = "djshakjdash",
                //    Salt = "salt"
                //};
                //db.Students.Add(st);

                //db.Students.Remove(db.Students.First());

                var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                arr.Where(x => x > 1).Where(x => x % 2 != 0);

                var s = db.Students.FirstOrDefault(x => x.FirstName == "Aftandil");
                //Reflection
                //Type t = typeof(Student);
                //var fs = t.GetProperties();


                //foreach (var f in fs)
                //{
                //    Console.WriteLine(f.Name);
                //    Console.WriteLine(f.PropertyType);
                //    Console.WriteLine(f.GetValue(s));
                //    Console.WriteLine();
                //}

                Expression<Predicate<int>> e = (x => x % 2 != 0);
                Console.WriteLine(e.Type);
                Console.WriteLine(e.NodeType);
                Console.WriteLine(e.Body.Type);
                Console.WriteLine(e.Body.NodeType);
                Console.WriteLine(e.Parameters[0].Name);
                Console.WriteLine(e.Reduce().NodeType);
                Console.WriteLine(e.Reduce().Type.FullName);

                db.Students.Where(x => x.FirstName.Contains('a'));

                db.Students.FirstOrDefault(x => x.FirstName == "Aftandil").Login = "afti12345";
                //Console.WriteLine(db.ChangeTracker.HasChanges());
                //db.SaveChanges();
                //var students = db.Students;
                //foreach (var s in students)
                //{
                //    Console.WriteLine($"{s.FirstName}  {s.LastName}");
                //}
            }



            //using (PhonebookContext db = new PhonebookContext())
            //{
            //    Console.WriteLine("My Contacts: ");
            //    var contacts = db.Phonebook;
            //    foreach (var contact in contacts)
            //    {
            //        Console.WriteLine($"{contact.Name} phone is {contact.Phone}");
            //    }
            //}
        }
    }
}
