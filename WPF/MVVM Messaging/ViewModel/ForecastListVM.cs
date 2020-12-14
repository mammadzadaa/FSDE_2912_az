using MVVM_Messaging.Commands;
using MVVM_Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.ViewModel
{
    class ForecastListVM : BaseVM
    {
        private CommandBase addPage;

        public CommandBase AddPage => addPage ??= new CommandBase(() => {

            var messenger = App.Container.GetInstance<Messenger>();
            messenger.Send(new NavigationMessage() { ViewModel = new AddForecastVM() });
        });

    }
}
