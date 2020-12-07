using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM_Tools.Commands
{
    public class CommandBase : Command, ICommand
    {
        private Action action;

        public CommandBase(Action action, Func<bool> canExecute = null) : base(canExecute)
        {
            this.action = action;

        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }
    }
}
