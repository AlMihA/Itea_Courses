using System.Drawing;

namespace Lesson11_HomeWork_NFS_Windows_Forms
{
	public static class RaceDraw
	{
		public static Graphics graph;
		public static int NumberOfCars;
		public const int RACE_WIDTH = 600;
		public const int RACE_HEIGHT = 830;
		public const int START_Y = RACE_HEIGHT + 30;
		public static void DrawRace()
		{
			graph.Clear(Color.White);

			DrawLine(Pens.Red, RACE_WIDTH / (NumberOfCars + 1), 60, RACE_WIDTH / (NumberOfCars + 1), START_Y);
			for (int i = 0; i < NumberOfCars; i++)
			{
				graph.DrawLine(Pens.Black, RACE_WIDTH * (i + 2) / (NumberOfCars + 1), 60, RACE_WIDTH * (i + 2) / (NumberOfCars + 1), START_Y);
			}
			DrawLine(Pens.Red, RACE_WIDTH, 60, RACE_WIDTH , START_Y);
			DrawLine(Pens.Blue, 30, START_Y, RACE_WIDTH + 30, START_Y);
			DrawLine(Pens.Blue, 30, 60, RACE_WIDTH + 30, 60);

			DrawString("Start", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.Red), new PointF(30, RACE_HEIGHT + 50));
			DrawString("Finish", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.Red), new PointF(25, 35));
		}

		public static void DrawString(string txt, Font font, SolidBrush solidBrush, PointF pointF)
        {
			graph.DrawString(txt, font, solidBrush, pointF);
		}
		public static void DrawLine(Pen pen,int x0, int y0, int x1, int y1)
		{
			graph.DrawLine(pen, x0, y0, x1, y1);
		}
		public static void DrawCar(int x, int y, int number)
		{
			int sideA = 20;
			int sideB = 30;
			Pen pen = new Pen(Color.Green, 1);
			graph.DrawRectangle(pen, x, y, sideA, sideB);
			graph.DrawString(number.ToString(), new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.DarkGreen), new PointF(x, y));
		}
		public static void DrawCrash(int x, int y)
		{
			Image newImage = Properties.Resources.Crash;
			graph.DrawImage(newImage, x, y);
		}
	}
}