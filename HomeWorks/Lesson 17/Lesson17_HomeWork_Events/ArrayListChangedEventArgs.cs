using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HomeWork_Events
{
    public class ArrayListChangedEventArgs
    {
        private object item;
        public object Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
