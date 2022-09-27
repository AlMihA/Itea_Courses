using System;

namespace Lesson5_HomeWork_Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
			const string pass = "123";
			do
			{
				Console.WriteLine("Hello! Enter password:");
				string answer = Console.ReadLine();
				if (answer == "administrator")
				{
					Console.WriteLine("Autorization as Administrator is successful!");
					break;
				}
				else if (answer == pass)
				{
					Console.WriteLine("Autorization as User is successful!");
					break;
				}
				else
				{
					Console.WriteLine("Password incorrect!");
				}

			} while (true);

		}
    }
}
