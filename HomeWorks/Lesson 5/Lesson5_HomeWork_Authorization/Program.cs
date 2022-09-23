using System;

namespace Lesson5_HomeWork_Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello! Enter password:");
            } while (Console.ReadLine() != "administrator");

            Console.WriteLine("Autorization as Administrator is successful!");

        }
    }
}
