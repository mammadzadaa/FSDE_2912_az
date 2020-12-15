using MVVM_Messaging.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Messages
{
    public class ForecastMessage : IMessage
    {
        public Forecast CurrentForecast { get; set; }
    }
}
