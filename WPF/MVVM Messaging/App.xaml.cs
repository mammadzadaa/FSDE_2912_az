using MVVM_Messaging.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Messaging
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        public static Container Container { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Container = new Container();
            Container.RegisterSingleton<MainWindow>();
            Container.RegisterSingleton<MainVM>();
            Container.RegisterSingleton<Messenger>();
            Container.Register<ForecastListVM>();
            Container.Register<AddForecastVM>();
            Container.Register<InfoForecastVM>();

            var main = Container.GetInstance<MainWindow>();
            main.Show();

            base.OnStartup(e);
        }
    }
}
