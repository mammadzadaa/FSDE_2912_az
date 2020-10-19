using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Presenter
{
    public class ToDoListPresenter
    {
        private List<ToDo> listOfToDo;
        private IToDoListView view;
        public ToDoListPresenter(IToDoListView view)
        {
            this.view = view;
            listOfToDo = new List<ToDo>();

            view.Add += AddItem;
            view.Remove += RemoveItem;
                        
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
            view.UpdateList(listOfToDo);
        }

        public void AddItem()
        {
            listOfToDo.Add(new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Feed the cat",
                Description = "Feed him before 10 am"
            });
            view.UpdateList(listOfToDo);
        }

        public void RemoveItem(string id)
        {
            var index = listOfToDo.FindIndex(x => x.Id == id);
            listOfToDo.RemoveAt(index);
            view.UpdateList(listOfToDo);
        }
    }
}
