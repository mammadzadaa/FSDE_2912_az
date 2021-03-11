using Lesson_08_03_21.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_08_03_21.Models;
using System.Data.SqlClient;
using Dapper;

namespace Lesson_08_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var _conn_str = @"data source=localhost\SQLEXPRESS;initial catalog=University;integrated security=True;MultipleActiveResultSets=True";
            Console.ReadKey();
            using (var _conn = new SqlConnection(_conn_str))
            {
                _conn.Open();
                var newSql = @"SELECT * FROM Students JOIN Groups ON Group_Id = Students.Group_Id";
                var oldSql = @"SELECT * FROM Students";
                var gd = new Dictionary<int, Group>();
                var sd = new Dictionary<int, Student>();
                var st = _conn.Query<Student,Group,Student>(
                    newSql, (s,g) =>
                    {
                        Group gTemp;
                        if (!gd.ContainsKey(g.Id))
                        {
                            gTemp = g;
                            gd.Add(g.Id, g);
                        }
                        else
                        {
                            gTemp = gd[g.Id];
                        }
                            s.Group = gTemp;
                        if(!sd.ContainsKey(s.Id))
                        {
                            sd.Add(s.Id, s);                            
                            return s; 
                        }
                        else
                        {
                            return sd[s.Id];
                        }
                    }).Distinct().ToList();

                Console.WriteLine(st[0].Group.Name);
                st.ForEach(Console.WriteLine);
            }
            Console.ReadKey();


            using (UniversityDB db = new UniversityDB())
            {
                 db.Students.ToList().ForEach(Console.WriteLine);
                
                //var g = db.Groups.FirstOrDefault();
                ////var g = db.Groups.Include("Students").FirstOrDefault();
                ////db.Entry(g).Collection(x => x.Teachers).Load();

                ////Console.WriteLine(g.Name);
                //g.Students.ForEach(Console.WriteLine);
                //g.Teachers.ForEach(Console.WriteLine);
                //db.Entry(g).State = System.Data.Entity.EntityState.Modified;
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
