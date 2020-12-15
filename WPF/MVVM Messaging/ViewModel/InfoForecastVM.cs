using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using MVVM_Messaging.Messages;
using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MVVM_Messaging.ViewModel
{
    class InfoForecastVM : ViewModelBase
    {
        private Forecast thisForecast;
        private string image;
        public Location ThisLocation { get; set; }
        public string Image { get => image; set { Set(ref image, value); } }
        public Forecast ThisForecast { get => thisForecast; set { Set(ref thisForecast, value); } }
        public InfoForecastVM()
        {


            var messenger = App.Container.GetInstance<Messenger>();
            messenger.Register<ForecastMessage>(this, message =>
            {
                ThisForecast = message.CurrentForecast;
                Image = $"http://openweathermap.org/img/wn/{ThisForecast.weather[0].icon}.png"  ;
                ThisLocation = new Location(ThisForecast.coord.lat, ThisForecast.coord.lon);
            });

        }
    }
}
