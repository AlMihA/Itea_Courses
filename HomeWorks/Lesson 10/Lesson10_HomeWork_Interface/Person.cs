using System;

namespace Lesson10_HomeWork_Interface
{
	public class Person : IComparable
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
		public int CompareTo(object obj)
		{
			if (obj is Person personCompare)
			{
				if (personCompare.Name == Name && personCompare.Age == Age)
				{

					return 0;
				}
				else
				{
					if (Age < personCompare.Age)
						return -1;
					else 
						return 1;
				}
			}
			else
			{
				throw new ArgumentException(("obj is not Person class"));
			}
		}                           

		public string GetInfo()
		{
			return $"Person {Name}, Age: {Age}";
		}

		public static bool operator < (Person person1, Person person2)
		{       
			return person1.CompareTo(person2) < 0;
		}

		public static bool operator >(Person person1, Person person2)
		{
			return person1.CompareTo(person2) > 0;
		}

		public static bool operator ==(Person person1, Person person2)
		{
			return person1.CompareTo(person2) == 0;
		}

		public static bool operator !=(Person person1, Person person2)
		{
			return person1.CompareTo(person2) != 0;
		}
	}
}
