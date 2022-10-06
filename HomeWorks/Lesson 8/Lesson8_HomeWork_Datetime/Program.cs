using System;

namespace Lesson8_HomeWork_Datetime
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				string d = "";
				Console.WriteLine("Do you want to set datetime y/n?");
				if (Console.ReadLine() == "y")
				{
					Console.WriteLine("Enter date:");
					bool incorrectvalue = true;
					do
					{
						try
						{
							d = Console.ReadLine();
							DateTime temp = DateTime.Parse(d);
							incorrectvalue = false;
						}
						catch
						{
							Console.WriteLine("Incorrect value! Try again");
						}

					} while (incorrectvalue);

				}

				DateTime_Tools dtools;
				if (d != "")
				{
					dtools = new DateTime_Tools(Convert.ToDateTime(d));
				}
				else
				{
					dtools = new DateTime_Tools();
				}

				Console.WriteLine("Date = " + dtools.ToString());
				Console.WriteLine("Previous Day = " + dtools.GetPreviousDate().ToString("d"));
				Console.WriteLine("Next Day = " + dtools.GetNextDate().ToString("d"));
				Console.WriteLine("Days to end of month = " + dtools.DaysToEndOfMonth());

				Console.WriteLine("Override ToString = " + dtools.ToString());
				Console.WriteLine("Overload ToString(Grinvich) = " + dtools.ToString(true));
				Console.WriteLine("Overload ToString(Not Grinvich) = " + dtools.ToString(false));

				Console.WriteLine("Leap year = " + dtools.LeapYear);

				Console.WriteLine("Index(5) = " + dtools[5].ToString("d"));
				Console.WriteLine("Index(-3) = " + dtools[-3].ToString("d"));

				dtools.Date = DateTime.Now;
				Console.WriteLine("Change date on today = " + dtools.Date.ToString("d"));

			} while (true);

		}
	}
}
