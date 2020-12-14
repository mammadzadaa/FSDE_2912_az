using MVVM_Messaging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Messages
{
    class NavigationMessage : IMessage
    {
        public BaseVM ViewModel { get; set; }
    }
}
