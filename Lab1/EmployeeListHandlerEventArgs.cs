using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class EmployeeListHandlerEventArgs: EventArgs
    {
        public string NameOfCollection { get; set; }
        public string Event { get; set; }
        public int NumberOfChangedElement { get; set; }
        public EmployeeListHandlerEventArgs(string nameOfCollection, string @event, int numberOfChangedElement)
        {
            NameOfCollection = nameOfCollection;
            Event = @event;
            NumberOfChangedElement = numberOfChangedElement;
        }
        public EmployeeListHandlerEventArgs()
        {
            NameOfCollection = "Employee";
            Event = "Added an item";
            NumberOfChangedElement = 0;
        }
        public override string ToString()
        {
            return $"NameOfCollection: {NameOfCollection}, Events: {Event}, NumberOfChangedElement:    {NumberOfChangedElement}";
        }
    }
}
