using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Listener
    {
        private List<ListEntry> listeners = new List<ListEntry>();
        public List<ListEntry> Listeners
        { get { return listeners; }
          set { listeners = value; }
        }

        public void HandleEmployee(object sender, EmployeeListHandlerEventArgs e)
        {
            ListEntry listener = new ListEntry(e.NameOfCollection, e.Event, e.NumberOfChangedElement);
            Listeners.Add(listener);
        }
        public override string ToString()
        {
            return $"{string.Join("; ", Listeners)}";
        }
    }
}
