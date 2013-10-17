using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350_TestApplication.Command
{
    public interface IUndoRedoCommand
    {
        void Execute();
        void UnExecute();
    }
}
