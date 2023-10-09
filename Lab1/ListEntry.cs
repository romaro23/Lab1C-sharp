using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ListEntry
    {
        public string NameOfCollection { get; set; }
        public string Event { get; set; }
        public int NumberOfChangedElement {  get; set; }

        public ListEntry(string nameOfCollection, string @event, int changedElement)
        {
            NameOfCollection = nameOfCollection;
            Event = @event;
            NumberOfChangedElement = changedElement;
        }
        public override string ToString()
        {
            return $"NameOfCollection: {NameOfCollection}, Event: {Event}, NumberOfChangedElement: {NumberOfChangedElement} \n";
        }

    }
}
