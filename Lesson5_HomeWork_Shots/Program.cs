using System;

namespace Lesson5_HomeWork_Shots
{
	class Program
	{
		static int CalcPoints(int x, int y, int radius)
		{
			double gipotenuza = Math.Sqrt(x * x + y * y);
			for (int i = 1; i < 11; i++)
			{
				if (gipotenuza <= radius * i)
				{
					return (11 - i);
				}
			}
			return 0;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter radius");
			int radius = Convert.ToInt32(Console.ReadLine());

			while (true)
			{
				Random rand = new Random();
				int x = rand.Next(10 * radius) - rand.Next(10 * radius);
				int y = rand.Next(10 * radius) - rand.Next(10 * radius);

				int currentPoint = CalcPoints(x, y, radius);

				Console.WriteLine("Shot({0},{1}). Result:{2}", x, y, currentPoint.ToString());
				Console.WriteLine("Press for Fire!");
				Console.ReadKey();
			}

		}
	}
}
