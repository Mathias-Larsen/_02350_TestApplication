﻿using _02350_TestApplication.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _02350_TestApplication.Command
{
    public class AddClassBoxCommand : ICommand
    {
        private ObservableCollection<ClassBox> classBoxes;
        private ClassBox classBox;

        public AddClassBoxCommand(ObservableCollection<ClassBox> _classBox) { classBoxes = _classBox; }

        public void Execute(object parameter)
        {
            classBoxes.Add(classBox = new ClassBox());
        }

        public void UnExecute()
        {
            classBoxes.Remove(classBox);
        }

        public bool CanExecute(object parameter)
        {
            return false;
        }

        public event EventHandler CanExecuteChanged;
    }
}
