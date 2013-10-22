using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace _02350_TestApplication.Command
{
    class CommandHistoryItem
    {
        public string CommandName { get; set; }

        public UIElement ElementActedOn { get; set; }

        public string PropertyActedOn { get; set; }

        public object PreviousState { get; set; }

        public CommandHistoryItem(string commandName, UIElement elementActedOn, string propertyActedOn, object previousState)
        {
            CommandName = commandName;
            ElementActedOn = elementActedOn;
            PropertyActedOn = propertyActedOn;
            PreviousState = previousState;
        }

        public bool CanUndo
        {
            get { return (ElementActedOn != null && PropertyActedOn != ""); }
        }

        public void Undo()
        {
            Type elementType = ElementActedOn.GetType();
            PropertyInfo property = elementType.GetProperty(PropertyActedOn);
            property.SetValue(ElementActedOn, PreviousState, null);
        }
    }
}
