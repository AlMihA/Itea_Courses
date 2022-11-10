using System;

namespace Lesson16_HomeWork_CarCollection
{
    public class VehicleCollectionCovariant<T> : IAnyCollection_Covariant<T>
    {
        T Item;
        public VehicleCollectionCovariant(T item) 
        {
            Item = item; 
        }
        public void Show()
        {
            Console.WriteLine(Item.ToString());
        }
    }
}
