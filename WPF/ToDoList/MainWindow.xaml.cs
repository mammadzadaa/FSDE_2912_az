using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string taskName;
        private string taskDescription;
        private ObservableCollection<MyTask> myTasks;
        private bool taskIsDone;
        private DateTime taskDeadline = DateTime.Now;

        public string TaskName { get => taskName; set => OnChanged(out taskName, value); }
        public string TaskDescription { get => taskDescription; set => OnChanged(out taskDescription, value); }
        public bool TaskIsDone { get => taskIsDone; set => OnChanged(out taskIsDone, value); }
        public DateTime TaskDeadline { get => taskDeadline;set => OnChanged(out taskDeadline, value); }
        public ObservableCollection<MyTask> MyTasks { get => myTasks; set => OnChanged(out myTasks, value); }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            myTasks = new ObservableCollection<MyTask>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnChanged<T>(out T prop, T val, [CallerMemberName] string propName = "")
        {
            prop = val;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            MyTasks.Add(new MyTask()
            {
                Name = TaskName,
                Description = TaskDescription,
                Deadline = TaskDeadline,
                IsDone = TaskIsDone
            });
            TaskName = string.Empty;
            TaskDescription = string.Empty;
            TaskDeadline = DateTime.Now;
            TaskIsDone = false;
        }
    }
}
