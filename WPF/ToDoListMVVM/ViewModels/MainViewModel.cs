using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using ToDoListMVVM.Models;

namespace ToDoListMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string taskName;
        private string taskDescription;
        private ObservableCollection<MyTask> myTasks;
        private bool taskIsDone;
        private DateTime taskDeadline = DateTime.Now;
        private CommandBase addTaskCommand;

        public string TaskName { get => taskName; set => OnChanged(out taskName, value); }
        public string TaskDescription { get => taskDescription; set => OnChanged(out taskDescription, value); }
        public bool TaskIsDone { get => taskIsDone; set => OnChanged(out taskIsDone, value); }
        public DateTime TaskDeadline { get => taskDeadline; set => OnChanged(out taskDeadline, value); }
        public ObservableCollection<MyTask> MyTasks { get => myTasks; set => OnChanged(out myTasks, value); }
        public MyTask SelectedItem { get; set; }

        public CommandBase AddTaskCommand => addTaskCommand ?? (addTaskCommand = new CommandBase(x => AddTask()));
       
        //{
        //    get
        //    {
        //        return addTaskCommand ?? (addTaskCommand = new CommandBase(x => AddTask()));

        //        //if (addTaskCommand == null)
        //        //{
        //        //    addTaskCommand = new CommandBase(x => AddTask());
        //        //}
        //        //return addTaskCommand;
        //    }
        //} 
        public CommandBase RemoveTaskCommand { get; set; }

        public MainViewModel()
        {
           
            RemoveTaskCommand = new CommandBase(x =>
            {
                RemoveTask();
            });
            myTasks = new ObservableCollection<MyTask>();
        }

        public void AddTask()
        {
            MyTasks.Add(new MyTask()
            {
                Name = TaskName,
                Description = TaskDescription,
                Deadline = TaskDeadline,
                IsDone = TaskIsDone
            });
            Clear();
        }

        public void RemoveTask()
        {
            if (SelectedItem != null)
                MyTasks.Remove(SelectedItem);
        }

        private void Clear()
        {
            TaskName = string.Empty;
            TaskDescription = string.Empty;
            TaskDeadline = DateTime.Now;
            TaskIsDone = false;
        }
    }


    public class CommandBase : ICommand
    {
        private Action<object> action;
        
        public CommandBase(Action<object> action)
        {
            this.action = action;
        }

        public void Execute(object parameter)
        {
            action?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
    }



    //public class AddTaskCommand : ICommand
    //{
    //    public MainViewModel ViewModel { get; set; }
    //    public AddTaskCommand(MainViewModel viewModel)
    //    {
    //        ViewModel = viewModel;
    //    }
    //    public void Execute(object parameter)
    //    {
    //        ViewModel.AddTask();
    //    }

    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter) => true;
    //}

    //public class RemoveTaskCommand : ICommand
    //{
    //    public MainViewModel ViewModel { get; set; }
    //    public RemoveTaskCommand(MainViewModel viewModel)
    //    {
    //        ViewModel = viewModel;
    //    }
    //    public void Execute(object parameter)
    //    {
    //        ViewModel.RemoveTask();
    //    }

    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter) => true;
    //}
}
