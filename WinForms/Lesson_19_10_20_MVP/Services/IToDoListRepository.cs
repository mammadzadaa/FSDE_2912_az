using Lesson_19_10_20_MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Services
{
    public interface IToDoListRepository
    {
        IEnumerable<ToDo> GetAllTasks();
        void AddTask(ToDo task);
        void RemoveTask(string id);
    }
}
