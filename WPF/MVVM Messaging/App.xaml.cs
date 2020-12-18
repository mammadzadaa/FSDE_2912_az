using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Services;
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
            Container.RegisterSingleton<ForecastListVM>();
            Container.Register<AddForecastVM>();
            Container.Register<InfoForecastVM>();

            Container.Register<ForecastMessage>();

            Container.RegisterSingleton<Messenger>();
            Container.RegisterSingleton<IStorageService, LocalStorage>();
            Container.RegisterSingleton<IWeatherService, WeatherService>();


            var main = Container.GetInstance<MainWindow>();
            main.Show();

            base.OnStartup(e);
        }
    }
}
