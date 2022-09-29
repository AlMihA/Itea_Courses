using System;
using System.Text.RegularExpressions;

namespace Lesson6_HomeWork_Calculator
{
	public static class General
	{
		public static string[] ActionAndValues(int numberSystem)
		{
			string[] answer = new string[3];

			do
			{
				Console.WriteLine("Enter first number");
				answer[1] = Console.ReadLine();
			} while (!CheckValue(answer[1], numberSystem,""));

			do
			{
				Console.WriteLine("Choose action(+,-,*,/)");
				answer[0] = Console.ReadLine();
			} while (!CheckValue(answer[0]));

			do
			{
				Console.WriteLine("Enter second number");
				answer[2] = Console.ReadLine();
			} while (!CheckValue(answer[2], numberSystem, answer[0]));

			return answer;
		}

		public static double CalcValue(string[] actionAndNumbers)
		{
			double result;
            double a = Convert.ToDouble(actionAndNumbers[1]);
			double b = Convert.ToDouble(actionAndNumbers[2]);
			if (actionAndNumbers[0] == "+")
			{
				result = a + b;
			}
			else if (actionAndNumbers[0] == "-")
			{
				result = a - b;
			}
			else if (actionAndNumbers[0] == "*")
			{
				result = a * b;
			}
			else
			{
				result = a / b;
			}

			return result;
		}

		public static long[] CalcValue(string[] actionAndNumbers, int systemNumber)
		{
			long[] result = new long[2];
			result[1] = 0;
			long a = Convert.ToInt32(actionAndNumbers[1], systemNumber);
			long b = Convert.ToInt32(actionAndNumbers[2], systemNumber);
			if (actionAndNumbers[0] == "+")
			{
				result[0] = a + b;
			}
			else if (actionAndNumbers[0] == "-")
			{
				result[0] = a - b;
			}
			else if (actionAndNumbers[0] == "*")
			{
				result[0] = a * b;
			}
			else
			{
				result[0] = a / b;
				result[1] = a % b;
			}

			return result;
		}

		private static bool CheckValue(string value)
		{
			if (value == "+" || value == "-" || value == "*" || value == "/")
			{
				return true;
			}
			else
			{
				Console.WriteLine("Incorrect action!");
				return false;
			}
		}

		private static bool CheckValue(string value, int numberSystem, string action)
		{
			if (Regex.Replace(value, "0", "") == "" && action == "/")
			{
				Console.WriteLine("Divide by zero!");
				return false;
			}

			switch (numberSystem)
			{
				case 10:
					if (!double.TryParse(value, out double a))
					{
						Console.WriteLine("Incorrect number");
						return false;
					}
					else
					{
						return true;
					}
				case 2:
				case 16:
					try
					{
						a = Convert.ToInt32(value, numberSystem);
						return true;
					}
					catch
					{
						Console.WriteLine("Incorrect number");
						return false;
					}
				default:
					Console.WriteLine("Incorrect number system");
					return false;
			}
		}
	}
}
