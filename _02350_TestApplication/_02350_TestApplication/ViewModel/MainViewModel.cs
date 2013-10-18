using _02350_TestApplication.Command;
using _02350_TestApplication.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _02350_TestApplication.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 

        public ObservableCollection<ClassBox> ClassBoxes { get; set; }
        public ObservableCollection<Edge> Edges { get; set; }
        public ObservableCollection<ClassBox> SelectedClassBox { get; set; }

        // start with undo/redo definitions
        private static RoutedUICommand applicationUndo;

        public static RoutedUICommand ApplicationUndo
        {
            get { return _02350_TestApplication.ViewModel.MainViewModel.applicationUndo; }
        }

        // maybe up for a change
        public void AddClassBoxCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New Command triggered with " + e.Source.ToString());
        }

        public void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New Command triggered with " + e.Source.ToString());
        }

        public MainViewModel()
        {
            //create bindings
            //binding = new CommandBinding(_02350_TestApplication.Command.AddClassBoxCommand);
            CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += NewCommand;
            //this.CommandBindings.Add(binding);

            //SelectedClassBox = new ObservableCollection<ClassBox>();

            ClassBoxes = new ObservableCollection<ClassBox>()
            {
                new ClassBox() { X=100, Y=100, Width=80, Height=80 }, // jeg fatter overhoved ikke det her med komma og semikolon til sidst??  @mathias
                new ClassBox() { X=140, Y=300, Width=80, Height=80}
            };



            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}