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

namespace MVVM_Messaging.ViewModel
{
    class ForecastListVM : ViewModelBase
    {
        public IEnumerable<Forecast> ListOfForecast => storage.GetAllForecast();
        private RelayCommand addPage;
        private RelayCommand viewCommand;
        private RelayCommand elementDoubleClickCommand;
        private Forecast selectedForecast;

        public ForecastListVM(IStorageService storageService, Messenger messenger, IWeatherService weatherService)
        {
            storage = storageService;
            Messenger = messenger;
            storage.AddForecast(weatherService.GetWeatherByName("Baku"));
            storage.AddForecast(weatherService.GetWeatherByName("Ganja"));

        }

        public Forecast SelectedForecast 
        { 
            get => selectedForecast; 
            set
            {
                Set(ref selectedForecast, value);
                ViewCommand.RaiseCanExecuteChanged();
            }
        }

        public IStorageService storage { get; set; }
        public Messenger Messenger { get; set; }

        public RelayCommand ViewCommand => viewCommand ??= new RelayCommand(() =>
        {
            Messenger.Send(new NavigationMessage() { ViewModel = App.Container.GetInstance<InfoForecastVM>() });
            Messenger.Send(new ForecastMessage() { CurrentForecast = SelectedForecast });
        }, () => SelectedForecast != null);

        public RelayCommand AddPage => addPage ??= new RelayCommand(() =>
        {

            Messenger.Send(new NavigationMessage() { ViewModel = App.Container.GetInstance<AddForecastVM>() });
        });

        public RelayCommand ElementDoubleClickCommand => elementDoubleClickCommand ?? new RelayCommand(()=>
        {
            Messenger.Send(new NavigationMessage() { ViewModel = App.Container.GetInstance<InfoForecastVM>() });
            Messenger.Send(new ForecastMessage() { CurrentForecast = SelectedForecast });
        });
    }
}
