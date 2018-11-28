using System;
using System.Windows.Input;

namespace MVVM.Helpers
{
    // handles the ICommand implementation and trigger a necessary Action
    // if the user interacts with the UI with command implemntation
    public class CommandHandler : ICommand
    {
        // triggers a callback
        private Action<object> _action;

        // determin if the action is executable
        private bool _canExecute;
        
        public CommandHandler(Action<object> action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
