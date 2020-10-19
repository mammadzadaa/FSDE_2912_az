using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Model
{
    public class ToDo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
