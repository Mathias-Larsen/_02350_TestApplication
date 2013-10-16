using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350_TestApplication.Model
{
    public class ClassBox : NotifyBase
    {
        private static int counter = 0;
        public int Number { get; private set; } // skal bruges til at finde nummeret på en enkelt klasse
        private int x,y, height, width;
        public int X { get { return x; } set { x = value; NotifyPropertyChanged("X"); } } // der skal også være noget notify property changed
        public int Y { get { return y; } set { y = value; NotifyPropertyChanged("Y"); } }
        public int Width { get { return width; } set { width = value; NotifyPropertyChanged("Width"); } }
        public int Height { get { return height; } set { height = value; NotifyPropertyChanged("Height"); } }

        private string className;
        public string ClassName { get { return className; } set { className = value; NotifyPropertyChanged("ClassName"); } }

        private List<string> attNames, methodNames;
        public List<string> AttNames { get { return attNames; } set { attNames = value; NotifyPropertyChanged("AttNames"); } }
        public List<string> MethodNames { get { return methodNames; } set { methodNames = value; NotifyPropertyChanged("MethodNames"); } }

        public ClassBox()
        { 
            Number = ++counter;
            X = Y = 100; //hvor skal de dukke op?
            Width = Height = 100; //og hvor store skal de være?
            className = "Class name";
            attNames = new List<string>();
            methodNames = new List<string>();
            attNames.Add("test");
            attNames.Add("Test");
        }
    }
}
