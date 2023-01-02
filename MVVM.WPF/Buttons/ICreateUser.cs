using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.WPF.Buttons
{
    public interface ICreateUser
    {
        ICommand CreateUser { get; set; }
    }
}
