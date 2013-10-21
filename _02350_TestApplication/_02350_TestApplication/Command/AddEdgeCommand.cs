using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _02350_TestApplication.Command
{
    class AddEdgeCommand : ICommand
    {

        public void Execute(object parameter)
        { 
            
        }
            

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return false;
        }
    }
}
