using System;

namespace Lesson6_HomeWork_Calculator
{
    public static class General
    {
        public static string[] ActionAndValues()
        {
            string[] answer = new string[3];
            Console.WriteLine("Choose action(+,-,*,/)");
            while (true)
            {
                string _Action = Console.ReadLine();
                if (_Action == "+" || _Action == "-" || _Action == "*" || _Action == "/")
                {
                    answer[0] = _Action;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect action! Try again");
                }
            }
            Console.WriteLine("Enter first number");
            answer[1] = Console.ReadLine();

            Console.WriteLine("Enter second number");
            answer[2] = Console.ReadLine();

            return answer;
        }
}
}
