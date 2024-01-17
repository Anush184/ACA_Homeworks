using CustomCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionExample
{
    public class CustomCollectionOperations
    {
        public  void CustomCollection_ElementAdded(object? sender, ElementChangedEventArgs<int> e)
        {
            Console.WriteLine($"Event: Element Added - {e.Element}");
        }

        public  void CustomCollection_ElementRemoved(object? sender, ElementChangedEventArgs<int> e)
        {
            Console.WriteLine($"Event: Element Removed - {e.Element}");
        }
    }
}
