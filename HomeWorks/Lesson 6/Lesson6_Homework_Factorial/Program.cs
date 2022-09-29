using System;

namespace Lesson6_Homework_Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter value:");
				byte value;
				while (true)
				{
					if (byte.TryParse(Console.ReadLine(), out value))
					{
						break;
					}
					else
					{
						Console.WriteLine("Incorrect value.Try again");
					}
				}

				double result = Factorial(value);
				Console.WriteLine("{0}! = {1}", value, result);
			}
		}

		static double Factorial(int value)
		{
			if (value == 1 || value == 0)
				return value;
			return Factorial(value - 1) * value;
		}
	}
}
