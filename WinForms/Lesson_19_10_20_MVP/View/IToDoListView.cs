using Lesson_19_10_20_MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.View
{
    public interface IToDoListView
    {
        void UpdateList(IEnumerable<ToDo> list);
        event Action Add;
        event Action<string> Remove;
    }
}
