using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ToDoListMVVM.Commands
{
    public class CommandBase : ICommand
    {
        private Action<object> action;
        private Func<bool> canExecute;

        public CommandBase(Action<object> action, Func<bool> canExecute = null)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public void Execute(object parameter)
        {
            action?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => canExecute?.Invoke() ?? true;

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this,EventArgs.Empty);
    }
}
