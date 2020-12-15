using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.ViewModel
{
    class ForecastListVM : ViewModelBase
    {
        private RelayCommand addPage;

        public RelayCommand AddPage => addPage ??= new RelayCommand(() => {

            var messenger = App.Container.GetInstance<Messenger>();
            messenger.Send(new NavigationMessage() { ViewModel = new AddForecastVM() });

        });

    }
}
