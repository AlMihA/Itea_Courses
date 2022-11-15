using System;
using System.Collections;

namespace Lesson17_HomeWork_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayCity = new ArrayList();
            CityWithEvents city1 = new();
            CityWithEvents city2 = new();

            arrayCity.Add(city1);
            arrayCity.Add(city2);

            Police police = new(arrayCity);
            FireService fireService = new(arrayCity);
            Ambulance ambulance = new(arrayCity);

            city1.CityName = "City1";
            city2.CityName = "City2";

            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Attempt - " + i);
                int randomValue = random.Next(1, 100);
                city1.GenerateIncident(randomValue);

                randomValue = random.Next(1, 100);
                city2.GenerateIncident(randomValue);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
