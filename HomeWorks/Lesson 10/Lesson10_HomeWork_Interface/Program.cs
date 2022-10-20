using System;

namespace Lesson10_HomeWork_Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] persons =
			{
				new Person("John", 37),
				new Person("John1", 37),
				new Person("John2", 37),
				new Person("Alex", 42),
			};

			foreach (Person person in persons)
			{
				Console.WriteLine(person.GetInfo());
			}

			Console.WriteLine();

			for (int i = 0; i< persons.Length; i++)
			{
				for (int j = 0; j < persons.Length; j++)
				{
					if (i == j)
						continue;

					if (persons[i] < persons[j])
						Console.WriteLine($"{persons[i].GetInfo()} is less than {persons[j].GetInfo()}");
					if (persons[i] > persons[j])
						Console.WriteLine($"{persons[i].GetInfo()} is greater than {persons[j].GetInfo()}");
					if (persons[i] == persons[j])
						Console.WriteLine($"{persons[i].GetInfo()} equals {persons[j].GetInfo()}");
					if (persons[i] != persons[j])
						Console.WriteLine($"{persons[i].GetInfo()} does not equals {persons[j].GetInfo()}");
				}
			}
			
			
		}
	}
}
