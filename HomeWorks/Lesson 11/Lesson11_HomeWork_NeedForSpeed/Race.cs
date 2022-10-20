using System;

namespace Lesson11_HomeWork_NeedForSpeed
{
	public static class Race
	{
		public static int Distance = 0;
		public static Cars[] CarsArray;
		private static int[] _obstacleArray = new int[15];
		public static void StartRace()
		{
			Console.WriteLine("--------------------- START ----------------------");
			GenerateObstacle();
			bool raceRunning = true;
			while (raceRunning)
			{
				raceRunning = false;
				bool showPos = false;
				foreach (Cars car in CarsArray)
				{
					if (car.Drive(Distance))
					{
						raceRunning = true;
						if (Array.IndexOf(_obstacleArray, car.GetDistance()) != -1)
						{
							car.ShowPenalty();
							car.SetPenalty();
							showPos = true;
						}
					}
				}
				if (showPos)
				{
					SortPositions();
					ShowPositions();
				}
			}
			Console.WriteLine();
			Console.WriteLine("----------------------FINISH RESULTS --------------");
			FinishRace();
		}
		public static void FinishRace()
		{
			SortPositions();
			ShowPositions();
		}
		private static void ShowPositions()
		{
			for (int i = 0; i < CarsArray.Length; i++)
			{
				Console.WriteLine((i+1) +". " + CarsArray[i].GetInfo());
			}
		}
		private static void SortPositions()
		{
			Array.Sort(CarsArray);
		}
		private static void GenerateObstacle()
		{
			Random rnd = new();
			for (int i = 0; i < _obstacleArray.Length; i++)
			{
				_obstacleArray[i] = rnd.Next(1,Distance - 1);
			}

			Array.Sort(_obstacleArray);
			Console.WriteLine("Obstacle points:");
			
			string str = string.Join(" ", _obstacleArray);
			Console.WriteLine(str);
		}
	}
}