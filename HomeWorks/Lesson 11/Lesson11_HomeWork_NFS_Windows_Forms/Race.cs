using System;
using System.Drawing;
namespace Lesson11_HomeWork_NFS_Windows_Forms
{
	public static class Race
	{
		public static int Distance = 0;
		public static Cars[] CarsArray;
		private static int[] _obstacleArray = new int[10];

		public static void NewRace()
		{
			RaceDraw.NumberOfCars = CarsArray.Length;
			GenerateObstacle();
			DrawNewMove();

			
		}

		public static void StartRace()
		{
			
			bool raceRunning = true;
			while (raceRunning)
			{
				bool showPos = false;
				raceRunning = false;
				foreach (Cars car in CarsArray)
				{
					if (car.Drive(Distance))
					{
						raceRunning = true;
						if (Array.IndexOf(_obstacleArray, car.GetDistance()) != -1)
						{
							int x = RaceDraw.RACE_WIDTH * (2 * car._number + 1) / ((CarsArray.Length + 1) * 2);
							RaceDraw.DrawCrash(x, 800 - car.GetDistance()+5, car._number);
							System.Threading.Thread.Sleep(1000);
							//car.ShowPenalty();
							car.SetPenalty();
							DrawNewMove();
							showPos = true;
						}
					}
				}
				if (showPos)
				{
					//SortPositions();
					//ShowPositions();
				}
				
				DrawNewMove();
				System.Threading.Thread.Sleep(10);

			}
			//FinishRace();
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
				//Console.WriteLine((i + 1) + ". " + CarsArray[i].GetInfo());
			}
		}
		private static void SortPositions()
		{
			Array.Sort(CarsArray);
		}

		public static void DrawNewMove()
		{
			RaceDraw.DrawRace();
			DrawObstacle();
			DrawCars();
		}

		private static void DrawObstacle()
		{
			for (int i = 0; i < _obstacleArray.Length; i++)
			{
				RaceDraw.DrawLine(new Pen(Color.Aqua, 1), 30, RaceDraw.START_Y - _obstacleArray[i], RaceDraw.RACE_WIDTH + 30, RaceDraw.START_Y - _obstacleArray[i]);
			}
		}

		private static void DrawCars()
		{
			for (int i = 0; i < CarsArray.Length; i++)
			{
				int x = RaceDraw.RACE_WIDTH * (2 * CarsArray[i]._number + 1) / ((CarsArray.Length + 1) * 2);
				RaceDraw.DrawCar(x - 10, RaceDraw.START_Y - CarsArray[i].GetDistance(), CarsArray[i]._number);
			}
		}
		private static void GenerateObstacle()
		{
			Random rnd = new();
			for (int i = 0; i < _obstacleArray.Length; i++)
			{
				_obstacleArray[i] = rnd.Next(1, Distance - 1);
			}

			Array.Sort(_obstacleArray);
		}
	}
}