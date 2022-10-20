using System;
using System.Dynamic;

namespace Lesson11_HomeWork_NeedForSpeed
{
	public class Cars : IComparable
	{
		private string _model = "Standard model";
		private int _speed = 15;
		private int _distance = 0;
		private int _time = 0;
		private bool _finishRace = false;

		public Cars()
		{
		}
		public int GetDistance()
		{
			return _distance;
		}
		public Cars(string model, int speed)
		{
			_model = model;
			_speed = speed;
		}
		public string GetInfo()
		{
			return $"{_model}, speed: {_speed} m/s, current distance: {_distance}, time for race: {_time}";
		}
		public bool Drive(int maxDistance)
		{
			if (!_finishRace)
			{
				_distance += _speed;
				_time += 1;
				if (_distance >= maxDistance)
				{
					_finishRace = true;
					_distance = maxDistance;
				}
			}
			return !_finishRace;
		}
		public void SetPenalty()
		{
			_distance += -5;
		}
		public void ShowPenalty()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Car {_model} hit an obstacle {_distance}");
			Console.ResetColor();
		}
		public int CompareTo(object obj)
		{
			if (obj is Cars car)
			{
				if (_distance.CompareTo(car._distance) == 0)
				{
					return _time.CompareTo(car._time);
				}
				else
				{
					return _distance.CompareTo(car._distance)*(-1);
				}
			}
			else throw new ArgumentException("Incorrect value");
		}
		public void ClearResults()
		{
			_time = 0;
			_distance = 0;
			_finishRace = false;
		}
	}
}