using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Tools.Commands
{
    public abstract class Command
    {
        protected Func<bool> canExecute;
        public Command(Func<bool> canExecute)
        {
            this.canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => canExecute?.Invoke() ?? true;

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
