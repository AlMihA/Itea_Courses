using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HomeWork_Events
{
    public delegate void ArrayListChangedEventHandler(object sender, ArrayListChangedEventArgs incidentEventArgs);
    public class ArrayListWithEvents:ArrayList
    {
        public event ArrayListChangedEventHandler ArrayChanged;
        
        private ArrayListChangedEventArgs eventArgs = new ArrayListChangedEventArgs();

        public virtual void ArrayListChanged(ArrayListChangedEventArgs args)
        {
            if (null != ArrayChanged)
            {
                ArrayChanged(this, args);
            }

        }
        public override int Add(object value)
        {
            eventArgs.Item = value;
            ArrayListChanged(eventArgs);
            return base.Add(value);
        }
    }
}
