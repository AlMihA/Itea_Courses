using System;

namespace Lesson6_HomeWork_Calculator
{
    internal class BinaryCalc
    {
        public static void StartCalc()
        {
            while (true)
            {
                Console.WriteLine("This is Decimal Calculator. What are you want?");
                string[] ActionAndNumbers = General.ActionAndValues();

                int a, b;

                try
                {
                    a = Convert.ToInt32(ActionAndNumbers[1], 2);

                }
                if (!decimal.TryParse(ActionAndNumbers[1], out a))
                    Console.WriteLine("Incorrect first number");
                if (!decimal.TryParse(ActionAndNumbers[2], out b))
                    Console.WriteLine("Incorrect secong number");

                decimal result = 0;
                if (ActionAndNumbers[0] == "+")
                {
                    result = a + b;
                }
                else if (ActionAndNumbers[0] == "-")
                {
                    result = a - b;
                }
                else if (ActionAndNumbers[0] == "*")
                {
                    result = a * b;
                }
                else
                {
                    result = a / b;
                }
                Console.WriteLine("{0} {1} {2} = {3}", ActionAndNumbers[1], ActionAndNumbers[0], ActionAndNumbers[2], result);
            }

        }
    }
}
