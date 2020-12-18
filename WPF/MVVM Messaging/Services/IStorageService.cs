using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Services
{
    interface IStorageService
    {
        public IEnumerable<Forecast> GetAllForecast();
        public void AddForecast(Forecast forecast);
    }
}
