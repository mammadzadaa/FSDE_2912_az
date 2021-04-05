using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson_01_04_21
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static Mutex mutex;
        protected override void OnStartup(StartupEventArgs e)
        {
            if (Mutex.TryOpenExisting("SomeMutexName", out Mutex m))
            {
                MessageBox.Show("This app already open!");
                Environment.Exit(0);
            }
            mutex = new Mutex(true, "SomeMutexName");
            base.OnStartup(e);
        }
    }
}
