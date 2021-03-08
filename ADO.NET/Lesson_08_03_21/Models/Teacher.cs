using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_03_21.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual List<Group> Groups { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname + " muellim"; 
        }
    }
}
