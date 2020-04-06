using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BillingManagement.UI.ViewModels.Commands
{
    public class NewCustomerCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;

        public NewCustomerCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
