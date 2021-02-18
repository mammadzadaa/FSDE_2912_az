using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Model
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Coins { get; set; }
        public string Login { get; set; }
        public string PassHash { get; set; }
        public string Salt { get; set; }
    }
}
