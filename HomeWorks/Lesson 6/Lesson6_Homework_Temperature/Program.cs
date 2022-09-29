using System;

namespace Lesson6_Homework_Temperature
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				string temperatureMeasure;
				bool incorrectChoose = true;
				do
				{
					Console.WriteLine("Choose temperature measure:");
					Console.WriteLine("C. Celsius");
					Console.WriteLine("F. Fahrenheit");
					Console.WriteLine("K. Kelvin");

					temperatureMeasure = Console.ReadLine();


					switch (temperatureMeasure)
					{
						case "C":
						case "c":
						case "F":
						case "f":
						case "K":
						case "k":
							incorrectChoose = false;
							break;
						default:
							Console.WriteLine("Incorrect choose. Try again");
							break;
					}
				} while (incorrectChoose);

				Console.WriteLine("Enter degrees");

				double degrees;
				while (true)
				{
					if (double.TryParse(Console.ReadLine(), out degrees))
					{
						break;
					}
					else
					{
						Console.WriteLine("Incorrect value.Try again");
					}
				}

				Temperature temperature = new Temperature();
				temperature.Degrees = degrees;
				temperature.TemperatureMeasure = temperatureMeasure;
				temperature.ConvertToAnotherMeasure();

				Console.WriteLine("Do you want to try again? y/n");
				if (Console.ReadKey().KeyChar == 'y')
				{
					Console.WriteLine();
				}
				else
				{
					break;
				}
			}

		}
	}
}
