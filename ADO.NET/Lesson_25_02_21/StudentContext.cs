using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25_02_21
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base(@"Data Source = localhost\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=Academy") { }
        public DbSet<Student> Students { get; set; }
    }
}
