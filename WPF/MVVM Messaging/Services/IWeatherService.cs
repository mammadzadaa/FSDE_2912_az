using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Services
{

    public interface IWeatherService
    {
        public Forecast GetWeatherByName(string countryName);
        public Forecast GetWeatherByLongLat(double longitude, double latitude);
    }


}
