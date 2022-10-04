using System;
using System.Text.RegularExpressions;

namespace Lesson7_HomeWork_Cars
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello! This is program for car accounting!");
			Console.WriteLine("How many cars?");

			int count = Convert.ToInt32(Console.ReadLine());
			string[,] cars = new string[count, 4];

			string owner, brand, number, year, pattern;
			bool incorrectvalue = true;
			for (int i = 0; i < count; i++)
			{
				incorrectvalue = true;
				Console.WriteLine("Enter owner([A-Z][a-z] [A-Z][a-z]):");
				do
				{
					pattern = @"^[A-Z][a-z]+\s[A-Z][a-z]+$";
					owner = Console.ReadLine();
					if (Regex.IsMatch(owner, pattern, RegexOptions.None))
					{
						incorrectvalue = false;
					}
					else
					{
						Console.WriteLine("Incorrect value! Try again");
					}

				} while (incorrectvalue);

				incorrectvalue = true;
				Console.WriteLine("Enter brand:");
				do
				{
					brand = Console.ReadLine();
					if (Regex.Replace(brand, " ", "") == "")
					{
						Console.WriteLine("Incorrect value! Try again");
					}
					else
					{
						incorrectvalue = false;
					}

				} while (incorrectvalue);

				incorrectvalue = true;
				Console.WriteLine("Enter number([A-Z][A-Z][0-9][0-9][0-9][0-9][A-Z][A-Z]):");
				do
				{
					pattern = @"^[A-Z][A-Z][0-9][0-9][0-9][0-9][A-Z][A-Z]$";
					number = Console.ReadLine();
					if (Regex.IsMatch(number, pattern, RegexOptions.None))
					{
						incorrectvalue = false;
					}
					else
					{
						Console.WriteLine("Incorrect value! Try again");
					}

				} while (incorrectvalue);
				
				incorrectvalue = true;
				Console.WriteLine("Enter year:");
				do
				{
					pattern = @"^[1-2][890][0-9][0-9]$";
					year = Console.ReadLine();
					if (Regex.IsMatch(year, pattern, RegexOptions.None))
					{
						if (Convert.ToInt32(year) < 1886 || Convert.ToInt32(year) > Convert.ToInt32(DateTime.Now.Year))
						{
							Console.WriteLine("Incorrect value! Try again");
						}
						else
						{
							incorrectvalue = false;
						}
					}
					else
					{
						Console.WriteLine("Incorrect value! Try again");
					}

				} while (incorrectvalue);

				cars[i, 0] = owner;
				cars[i, 1] = brand;
				cars[i, 2] = number;
				cars[i, 3] = year;
			}
			for (int i = 0; i < cars.GetLength(0); i++)
			{
				Console.WriteLine("{0} Car: , owner: {1}, brand: {2}, number {3}, year{4}", i+1, cars[i, 0], cars[i, 1], cars[i, 2], cars[i, 3]);

			}
		}
	}
}
