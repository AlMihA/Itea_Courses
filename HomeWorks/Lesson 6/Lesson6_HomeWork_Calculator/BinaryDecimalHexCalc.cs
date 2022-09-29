using System;

namespace Lesson6_HomeWork_Calculator
{
    internal class BinaryDecimalHexCalc
    {
        public static void StartCalc(int systemNumber)
        {
            while (true)
            {
                Console.WriteLine("\nThis is {0} Calculator. What are you want?", systemNumber == 2 ? "Binary" : systemNumber == 10 ? "Decimal" : "Hex");
                string[] actionAndNumbers = General.ActionAndValues(systemNumber);

                if (systemNumber == 10)
                {
                    double result = General.CalcValue(actionAndNumbers);
                    Console.WriteLine("{0} {1} {2} = {3}", actionAndNumbers[1], actionAndNumbers[0], actionAndNumbers[2], result);
                }
                else
                {
                    long[] result = General.CalcValue(actionAndNumbers, systemNumber);
                    Console.WriteLine("{0} {1} {2} = {3} {4}", actionAndNumbers[1], actionAndNumbers[0], actionAndNumbers[2], Convert.ToString(result[0], systemNumber), result[1] > 0 ? ("Remainder = " + Convert.ToString(result[1], systemNumber)) : "");
                }


                Console.WriteLine("Do you want to try again? y/n");

                if (Console.ReadKey().KeyChar == 'y')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    return;
                }
            }

        }
    }
}
