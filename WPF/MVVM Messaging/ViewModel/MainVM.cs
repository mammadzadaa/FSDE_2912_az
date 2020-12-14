using MVVM_Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    class MainVM : BaseVM
    {
        private BaseVM currentViewModel;

        public BaseVM CurrentViewModel { get => currentViewModel; set => OnChanged(out currentViewModel, value); }

        public MainVM()
        {
            CurrentViewModel = App.Container.GetInstance<ForecastListVM>();
            var messenger = App.Container.GetInstance<Messenger>();
            messenger.Subscribe<NavigationMessage>(x =>
            {
                var message = x as NavigationMessage;
                CurrentViewModel = message.ViewModel;
            });
  
        }
    }
}
