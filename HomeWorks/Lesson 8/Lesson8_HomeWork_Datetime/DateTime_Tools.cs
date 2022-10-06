using System;
namespace Lesson8_HomeWork_Datetime
{
	public class DateTime_Tools
	{
		private DateTime date;
		private bool leapYear;

		public DateTime Date
		{
			get
			{
				return date;
			}
			set
			{
				date = value;
				leapYear = (date.Year % 4 == 0) ? true : false;
			}
		}

		public bool LeapYear
		{
			get
			{
				return leapYear;
			}
		}
		
		public DateTime_Tools()
		{
			this.Date = new DateTime(2000, 1, 1); ;
		}

		public DateTime_Tools(DateTime d)
		{
			this.Date = d;
		}
		
		public DateTime GetPreviousDate()
		{
			return Date - TimeSpan.FromDays(1);
		}

		public DateTime GetNextDate()
		{
			return Date + TimeSpan.FromDays(1);
		}

		public int DaysToEndOfMonth()
		{
			return System.DateTime.DaysInMonth(Date.Year, Date.Month) - Date.Day;
		}

		public override string ToString()
		{
			return Date.ToString("d");
		}

		public string ToString(bool grin)
		{
			if (grin)
				return Date.ToString("R");
			else
			{
				return Date.ToString();
			}
		}

		public DateTime this[int i]
		{

			get
			{
				return Date + TimeSpan.FromDays(i);
			}
		}



	}
}