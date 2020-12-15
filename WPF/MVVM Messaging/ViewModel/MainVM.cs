using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    class MainVM : ViewModelBase
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }

        public MainVM()
        {
            CurrentViewModel = App.Container.GetInstance<ForecastListVM>();
            var messenger = App.Container.GetInstance<Messenger>();
            messenger.Register<NavigationMessage>(this, message =>
            {
                //var message = x as NavigationMessage;
                CurrentViewModel = message.ViewModel;
            });
        }
    }
}
