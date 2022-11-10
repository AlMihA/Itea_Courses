using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_HomeWork_CarCollection
{
    public class VehicleCollectionContravariant<T> : IAnyCollection_Contravariant<T>
    {
        T Item;

        public VehicleCollectionContravariant(T item)
        {
            Item = item;
        }
        public void Show()
        {
            Console.WriteLine(Item.ToString());
        }
    }
}
