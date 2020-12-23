using Contact_App.Model;
using Contact_App.Services;
using Contact_App.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Contact_App
{

    public partial class App : Application
    {
        public static Container Container { get; set; }
        public App()
        {
            Container = new Container();
            Container.RegisterSingleton<MainVM>();
            Container.RegisterSingleton<AddCOntactsVM>();
            Container.RegisterSingleton<StatisticsVM>();
            Container.RegisterSingleton<ContactListVM>();
            Container.RegisterSingleton<Messenger>();

            Container.RegisterSingleton<IStorage<Contact>, JsonStorage>();
        }
    }
}
