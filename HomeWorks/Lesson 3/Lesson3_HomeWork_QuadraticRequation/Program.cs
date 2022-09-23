using System;

namespace Lesson3_HomeWork_QuadraticRequation
{
    internal class Program
    {
        static double Discriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        static void GetDecision(double a, double b, double c)
        {
            double D = Discriminant(a, b, c);

            if (D < 0)
            {
                Console.WriteLine("No decision.");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Decision: x1 = x2 = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Decision: x1 = {0}, x2 = {1}", x1, x2);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true) //зробив цикл, щоб постійно не запускати програму для перевірки. Вихід через закриття консолі або Ctrl^c.
            {
                double a;
                double b;
                double c;
                
                try
                {
                    Console.WriteLine("Input a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input c:");
                    c = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Incorrect value!");
                    continue;
                }

                GetDecision(a, b, c);
            }
        }
    }
}
