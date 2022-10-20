using System;

namespace Lesson9_HomeWork_Software
{
    internal class Free : Software
    {
        public Free(string name, string manufacturer):base(name,manufacturer)
        {
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"Free - {Name}({Manufacturer})");
        }
        public override bool CanUseToday()
        {
            return true;
        }
    }
}
