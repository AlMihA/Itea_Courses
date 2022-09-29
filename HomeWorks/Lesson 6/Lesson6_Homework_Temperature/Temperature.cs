using System;

namespace Lesson6_Homework_Temperature
{
	public class Temperature
	{
		public double Degrees;
		public string TemperatureMeasure;
		public void ConvertToAnotherMeasure()
		{
			switch (TemperatureMeasure)
			{
				case "C":
				case "c":
					Console.WriteLine("{0} C = {1}", Degrees, ConvertCelciusToKelvin(Degrees));
					Console.WriteLine("{0} C = {1}", Degrees, ConvertCelciusToFahrenheit(Degrees));
					break;
				case "F":
				case "f":
					Console.WriteLine("{0} F = {1}", Degrees, ConvertFahrenheitToCelcius(Degrees));
					Console.WriteLine("{0} F = {1}", Degrees, ConvertFahrenheitToKelvin(Degrees));
					break;
				case "K":
				case "k":
					Console.WriteLine("{0} K = {1}", Degrees, ConvertKelvinToCelcius(Degrees));
					Console.WriteLine("{0} K = {1}", Degrees, ConvertKelvinToFahrenheit(Degrees));
					break;
			}
		}

		private string ConvertCelciusToKelvin(double degrees)
		{
			return degrees + 273.15 + " K";
		}

		private string ConvertCelciusToFahrenheit(double degrees)
		{
			return degrees * 1.8 + 32 + " F";
		}

		private string ConvertFahrenheitToCelcius(double degrees)
		{
			return (degrees - 32) * 5 / 9 + " C";
		}

		private string ConvertFahrenheitToKelvin(double degrees)
		{
			return (degrees + 459.67) * 5 / 9 + " K";
		}

		private string ConvertKelvinToCelcius(double degrees)
		{
			return degrees - 273.15 + " C";
		}

		private string ConvertKelvinToFahrenheit(double degrees)
		{
			return degrees * 1.8 - 459.67 + " F";
		}
	}
}