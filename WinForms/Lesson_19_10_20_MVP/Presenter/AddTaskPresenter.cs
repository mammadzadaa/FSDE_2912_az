using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.Services;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_10_20_MVP.Presenter
{
    public class AddTaskPresenter
    {
        private IAddForm view;
        private IToDoListRepository repository;

        public AddTaskPresenter(IAddForm view, IToDoListRepository repository)
        {
            this.view = view;
            this.repository = repository;
            view.Add += AddTask;
        }

        private void AddTask()
        {
            var task = new ToDo()
            {
                Id = Guid.NewGuid().ToString(),
                Title = view.Title,
                Description = view.Description
            };
            repository.AddTask(task);
        }
    }
}
