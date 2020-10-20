using Lesson_19_10_20_MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Services
{
    public class ToDoListRepository : IToDoListRepository
    {
        private List<ToDo> listOfToDo;
        public ToDoListRepository()
        {
            listOfToDo = new List<ToDo>();
            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Wash Dishes",
                Description = "Wash it by using new dish washer"
            });

            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Do homework",
                Description = "DO the homework before bed time"
            });

            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Repair car tires",
                Description = "Repair them before going back to home"
            });
        }
        public void AddTask(ToDo task)
        {
            listOfToDo.Add(task);
        }

        public IEnumerable<ToDo> GetAllTasks()
        {
            return listOfToDo;
        }

        public void RemoveTask(string id)
        {
            listOfToDo.RemoveAll(x => x.Id == id);
        }
    }
}
