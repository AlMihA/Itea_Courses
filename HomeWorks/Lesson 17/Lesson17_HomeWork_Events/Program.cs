using System;
using System.Collections;

namespace Lesson17_HomeWork_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            CityWithEvents city1 = new("City1");
            CityWithEvents city2 = new("City2");
            
            ArrayListWithEvents arrayCityWithEvents = new ArrayListWithEvents();

            arrayCityWithEvents.Add(city1);
            arrayCityWithEvents.Add(city2);

            Police police = new(arrayCityWithEvents);
            FireService fireService = new(arrayCityWithEvents);
            Ambulance ambulance = new(arrayCityWithEvents);

            CityWithEvents city3 = new("City3");
            police.listOfCity.Add(city3);

            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Attempt - " + i);
                int randomValue = random.Next(1, 100);
                city1.GenerateIncident(randomValue);

                randomValue = random.Next(1, 100);
                city2.GenerateIncident(randomValue);
                
                randomValue = random.Next(1, 100);
                city3.GenerateIncident(randomValue);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
