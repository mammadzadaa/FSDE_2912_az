using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace MVVM_Messaging.Services
{
    public class WeatherService : IWeatherService
    { 
        public Forecast GetWeatherByLongLat(double longitude, double latitude)
        { 
            WebClient web = new WebClient();
            var apiKey = ConfigurationManager.AppSettings["WeatherApiKey"];
            var url = $@"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}";
            var str = web.DownloadString(url);
            var result = JsonSerializer.Deserialize<Forecast>(str);
            return result;
        }



        public Forecast GetWeatherByName(string countryName)
        {
            WebClient web = new WebClient();
            var apiKey = ConfigurationManager.AppSettings["WeatherApiKey"];
            var url = $@"https://api.openweathermap.org/data/2.5/weather?q={countryName}&appid={apiKey}";    
            var str = web.DownloadString(url);
            var result = JsonSerializer.Deserialize<Forecast>(str);
            return result;
        }
    }
}
