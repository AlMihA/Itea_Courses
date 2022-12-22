using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.SqlClient;

namespace Lesson18_HomeWork
{
	static class University
	{
		public static void StartWork()
		{
			bool boolExit = false;
			do
			{
				Console.WriteLine();
				Console.WriteLine("Choose option:");
				Console.WriteLine("1. Work with Students");
				Console.WriteLine("2. Work with Books");
				Console.WriteLine("3. Work with Lessons");
				Console.WriteLine("4. Exit");

				string chooseOption = Console.ReadLine();

				switch (chooseOption)
				{
					case "1":
						StudentOption.StartWork();
						break;
					case "2":
						BookOption.StartWork();
						break;
					case "3":
						LessonOption.StartWork();
						break;
					case "4":
						boolExit = true;
						break;
				}

			} while (!boolExit);
		}
	}
}
