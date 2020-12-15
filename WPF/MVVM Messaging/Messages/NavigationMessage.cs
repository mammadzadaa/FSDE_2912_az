using GalaSoft.MvvmLight;
using MVVM_Messaging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Messages
{
    class NavigationMessage : IMessage
    {
        public ViewModelBase ViewModel { get; set; }
    }
}
