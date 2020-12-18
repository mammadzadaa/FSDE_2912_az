using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Messages
{
    class LocationMessege : IMessage
    {
        public double Longitute { get; set; }
        public double Latitude { get; set; }
    }
}
