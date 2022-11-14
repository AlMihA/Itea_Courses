using System;

namespace Lesson17_HomeWork_Events
{
	class Program
	{
		static void Main(string[] args)
		{
			CityWithEvents city1 = new();
			Police police = new(city1);
			FireService fireService = new(city1);
			Ambulance ambulance = new(city1);

			city1.CityName = "City";
			Random random = new();

			for (int i = 0; i < 10; i++)
			{
				int randomValue = random.Next(1, 100);
				city1.GenerateIncident(randomValue);
			}
			Console.ReadLine();
		}
    }
}
