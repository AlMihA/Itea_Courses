using System;

namespace Lesson9_HomeWork_Software
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Software[] softwares = new Software[4];

            Free free = new Free("Notepad", "Microsoft");
            softwares[0] = free;

            Trial trial1 = new Trial("Office", "Microsoft", new DateTime(2022, 8, 1), 90);
            softwares[1] = trial1;

            Trial trial2 = new Trial("Visual Studio", "Microsoft", new DateTime(2022, 5, 1), 90);
            softwares[2] = trial2;

            Commercial commercial = new Commercial("Fifa 2023", "EA Sports", new DateTime(2022, 5, 1), 360, 27.68);
            softwares[3] = commercial;

            foreach (Software soft in softwares)
            {
                soft.ShowInformation();
            }
            Console.WriteLine();
            Console.WriteLine("Can use today:");
            foreach (Software soft in softwares)
            {
                if (soft.CanUseToday())
                {
                    Console.WriteLine(soft.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
