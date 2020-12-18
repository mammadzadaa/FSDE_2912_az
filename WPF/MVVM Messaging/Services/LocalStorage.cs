using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Services
{
    class LocalStorage : IStorageService
    {
        public List<Forecast> Forecasts { get; set; } = new List<Forecast>();
        public void AddForecast(Forecast forecast)
        {
            Forecasts.Add(forecast);
        }

        public IEnumerable<Forecast> GetAllForecast()
        {
            return Forecasts;
        }
    }
}
