using System;

namespace Lesson11_HomeWork_NeedForSpeed
{
	class Program
	{
		static void Main(string[] args)
		{
			Cars[] carsArray = new Cars[5];
			carsArray[0] = new Cars();
			carsArray[1] = new Cars();
			carsArray[2] = new Cars("Bugatti", 18);
			carsArray[4] = new Cars("BMW", 16);
			carsArray[3] = new Cars("Porsche", 17);

			Console.WriteLine("---------------------- CARS ----------------------");
			foreach (Cars car in carsArray)
			{
				Console.WriteLine(car.GetInfo());
			}

			Race.CarsArray = carsArray;
			Race.Distance = 1000;

			while (true)
			{
				Race.StartRace();
				Console.WriteLine();
				Console.WriteLine("Do you want to start next race? y/n");
				if (Console.ReadLine() != "y")
				{
					break;
				}
				foreach (Cars car in carsArray)
					car.ClearResults();
			}
		}
	}
}
