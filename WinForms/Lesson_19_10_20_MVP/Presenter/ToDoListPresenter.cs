using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.Services;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19_10_20_MVP.Presenter
{
    public class ToDoListPresenter
    {
        
        private IToDoListView view;
        private IToDoListRepository repository;
        public ToDoListPresenter(IToDoListView view, IToDoListRepository repository)
        {
            this.view = view;
            this.repository = repository;

            view.Add += AddItem;
            view.Remove += RemoveItem;
                      
            view.UpdateList(repository.GetAllTasks());
        }

        public void AddItem()
        {
            Program.AddTask();
        }

        public void RemoveItem(string id)
        {
            repository.RemoveTask(id);
            view.UpdateList(repository.GetAllTasks());
        }
    }
}
