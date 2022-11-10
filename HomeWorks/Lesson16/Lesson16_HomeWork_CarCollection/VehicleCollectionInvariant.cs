using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_HomeWork_CarCollection
{
    public class VehicleCollectionInvariant<T> : IAnyCollection_Invariant<T>
    {
        T Item;

        public VehicleCollectionInvariant(T item)
        {
            Item = item;
        }
        public void Show()
        {
            Console.WriteLine(Item.ToString());
        }
    }
}
