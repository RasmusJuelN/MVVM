using MVVM.WPF.State.Navigators;
using MVVM.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.WPF.Commands
{
    internal class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.UserView:
                        _navigator.CurrentViewModel = new UserViewModel();
                        break;
                    case ViewType.CarView:
                        _navigator.CurrentViewModel = new CarViewModel();
                        break;
                    case ViewType.LogView:
                        _navigator.CurrentViewModel = new LogViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}