using MVVM.WPF.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.WPF.Commands
{
    public class CreateUserCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
