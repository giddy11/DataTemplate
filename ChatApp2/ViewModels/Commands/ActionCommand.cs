using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatApp2.ViewModels.Commands
{
    public class ActionCommand : ICommand
    {
        public ActionCommand()
        {

        }
        public ActionCommand(Action action, bool canRun)
        {
            Action = action;
            CanRun = canRun;
        }

        public Action Action { get; }
        public bool CanRun { get; }
        public Action<object?> AcionWithParam { get; }
        public Func<object, bool> CanExecuteFunc { get; }

        public event EventHandler? CanExecuteChanged;

        //public bool CanExecute(object? parameter)
        //{
        //    return CanExecuteFunc.Invoke(parameter);
        //    return true;
        //}

        public ActionCommand(Action<object?> acionWithParam, Func<object, bool> canExecuteFunc)
        {
            AcionWithParam = acionWithParam;
            CanExecuteFunc = canExecuteFunc;
        }
        public void Execute(object? parameter)
        {
            if (Action != null)
                Action.Invoke();

            if (AcionWithParam != null)
                AcionWithParam.Invoke(parameter);
        }

        internal void RaiseCanExecuteChanged()
        {
            if (Action is not null)
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
            return CanExecuteFunc.Invoke(parameter);
        }
    }
}
