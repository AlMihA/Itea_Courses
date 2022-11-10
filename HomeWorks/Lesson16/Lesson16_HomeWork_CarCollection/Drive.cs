using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_HomeWork_CarCollection
{
    public class Drive<T> 
    {
        public T Transport;
        public string SoundDrive { get; set; }

        public void Driving()
        {
            Console.WriteLine(SoundDrive + " " + Transport.ToString());
        }
    }
}
