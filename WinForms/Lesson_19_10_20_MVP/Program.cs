using Lesson_19_10_20_MVP.Presenter;
using Lesson_19_10_20_MVP.Services;
using Lesson_19_10_20_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19_10_20_MVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static IToDoListRepository repository;
        static ToDoListView view;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            repository = new ToDoListJsonRepository();
            view = new ToDoListView();
            //var view = new Test();

            var presenter = new ToDoListPresenter(view, repository);

            Application.Run(view);
        }
        public static void AddTask()
        {
            var dialog = new AddForm();
            var dialogPresenter = new AddTaskPresenter(dialog, repository);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                view.UpdateList(repository.GetAllTasks());
            }
        }
    }
}
