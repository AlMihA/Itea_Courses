using System;

namespace Lesson6_HomeWork_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            Console.WriteLine("Choose Number System:");
            Console.WriteLine("1. Binary");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("3. Hexadecimal");

            while (true)
            {
                string chooseSystem = Console.ReadLine();
                switch (chooseSystem)
                {
                    case "1":
                        break;
                    case "2":
                        DecimalCalc.StartCalc();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }
            }
        }
    }
}
