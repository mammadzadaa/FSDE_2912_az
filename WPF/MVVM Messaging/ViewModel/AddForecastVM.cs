using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Messaging.ViewModel
{
    class AddForecastVM : ViewModelBase
    {
        public WeatherService WeatherService { get; set; } = new WeatherService();
        private RelayCommand addBtn;
        private string cityName;

        //public int MyProperty { get; set; }

        public string CityName { get => cityName; set { Set(ref cityName,value); } }

        public RelayCommand AddBtn => addBtn ??= new RelayCommand(() =>
           {
               var messenger = App.Container.GetInstance<Messenger>();
                 messenger.Send(new NavigationMessage() { ViewModel = new InfoForecastVM() });
                 messenger.Send(new ForecastMessage() { CurrentForecast = WeatherService.GetWeatherByName(CityName) });
           });
    }
}
