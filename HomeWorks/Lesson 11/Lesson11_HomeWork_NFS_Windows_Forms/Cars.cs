using System;

namespace Lesson11_HomeWork_NFS_Windows_Forms
{
	public class Cars : IComparable
	{
		private string _model = "Standard model";
		private int _speed = 11;
		private int _distance = 0;
		private int _time = 0;
		private int _number;
		private bool _finishRace = false;
		public int GetDistance()
		{
			return _distance;
		}
		public int GetNumber()
		{
			return _number;
		}
		public Cars(int number)
		{
			_number = number;
		}
		public Cars(string model, int speed, int number)
		{
			_model = model;
			_speed = speed;
			_number = number;
		}
		public string GetInfo()
		{
			return $"{_model}, number: {_number}, speed: {_speed}m/s, distance: {_distance}, time for race: {_time}";
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
					return _distance.CompareTo(car._distance) * (-1);
				}
			}
			else throw new ArgumentException("Incorrect value");
		}
	}
}