using System;
namespace Lesson6_HomeWork_Calculator
{
	public class Calculator
	{
		public static void Start()
		{
			do
			{
				Console.WriteLine("Choose Number System:");
				Console.WriteLine("1. Binary");
				Console.WriteLine("2. Decimal");
				Console.WriteLine("3. Hexadecimal");

				string chooseSystem = Console.ReadLine();
				switch (chooseSystem)
				{
					case "1":
						BinaryDecimalHexCalc.StartCalc(2);
						break;
					case "2":
						BinaryDecimalHexCalc.StartCalc(10);
						break;
					case "3":
						BinaryDecimalHexCalc.StartCalc(16);
						break;
					default:
						Console.WriteLine("Try again");
						break;
				}

				Console.WriteLine("Do you want to choose another numeric system? y/n");
				if (Console.ReadKey().KeyChar == 'y')
				{
					Console.WriteLine();
				}
				else
				{
					Console.WriteLine();
					return;
				}

			} while (true);
		}
	}
}