using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using MVVM_Messaging.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Messaging.ViewModel
{
    class AddForecastVM : ViewModelBase, IDataErrorInfo
    {
        public AddForecastVM(IWeatherService weatherService, IStorageService storageService, Messenger messenger)
        {
            WeatherService = weatherService;
            Storage = storageService;
            Messenger = messenger;

            ThisLocation = new Location();


                messenger.Register<LocationMessege>(this, m =>
                {
                    Longtitude = m.Longitute.ToString();
                    Latitude = m.Latitude.ToString();
                });
            
           
        }

        public IStorageService Storage { get; set; }
        public IWeatherService WeatherService { get; set; }
        public Messenger Messenger { get; set; }

        private RelayCommand addBtn;
        private RelayCommand cancelCommand;
        private string cityName;
        private string latitude;
        private string longtitude;
        private bool byNameOrCords = true;
        private Location location;

        public Location ThisLocation
        {
            get => location;
            set
            {
                Set(ref location, value);
                
                AddBtn.RaiseCanExecuteChanged();
            }
        }
        public bool ByNameOrCords
        {
            get => byNameOrCords;
            set
            {
                Set(ref byNameOrCords, value);
                AddBtn.RaiseCanExecuteChanged();

            }
        }

        [Required]
        public string CityName
        {
            get => cityName;
            set
            {
                Set(ref cityName, value);
                AddBtn.RaiseCanExecuteChanged();
            }
        }
        public string Latitude
        {
            get => latitude;
            set
            {
                Set(ref latitude, value);
                if (!string.IsNullOrWhiteSpace(Longtitude) && !string.IsNullOrWhiteSpace(Latitude))
                {

                    ThisLocation = new Location(double.Parse(Latitude), double.Parse(Longtitude));
                }
                AddBtn.RaiseCanExecuteChanged();
            }
        }
        public string Longtitude
        {
            get => longtitude;
            set
            {
                Set(ref longtitude, value);
                if (!string.IsNullOrWhiteSpace(Longtitude) && !string.IsNullOrWhiteSpace(Latitude))
                {
                    ThisLocation = new Location(double.Parse(Latitude), double.Parse(Longtitude));
                }
                AddBtn.RaiseCanExecuteChanged();
            }
        }


        public RelayCommand AddBtn => addBtn ??= new RelayCommand(() =>
           {
           Messenger.Send(new NavigationMessage() { ViewModel = App.Container.GetInstance<ForecastListVM>() });

           if (ByNameOrCords)
               Storage.AddForecast(WeatherService.GetWeatherByName(CityName));

           else
           {
               Storage.AddForecast(WeatherService.GetWeatherByLongLat(Double.Parse(Longtitude), Double.Parse(Latitude)));
              
               }
           }, () =>
            {
                return (ByNameOrCords && !string.IsNullOrWhiteSpace(CityName)) ||
                (!ByNameOrCords && !string.IsNullOrWhiteSpace(Latitude) && !string.IsNullOrWhiteSpace(Longtitude));
            });
        public RelayCommand CancelCommand => cancelCommand ??= new RelayCommand(() =>
        {
            Messenger.Send(new NavigationMessage() { ViewModel = App.Container.GetInstance<ForecastListVM>() });
        });

        public string Error { get; }

        public string this[string columnName]
        {
            get
            {
                var validationContext = new ValidationContext(this);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(this, validationContext, results, true);

                if (isValid)
                    return string.Empty;

                var result = results.FirstOrDefault(x => x.MemberNames.Contains(columnName));

                if (result is null)
                    return string.Empty;

                return result.ErrorMessage;
            }
        }
    }


}
