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
                raceRunning = false;
                int[,] crashArray = new int[5, 3];
                Cars[] carsCrashArray = new Cars[5];
                int a = 0;
                foreach (Cars car in CarsArray)
                {
                    if (car.Drive(Distance))
                    {
                        raceRunning = true;
                        if (Array.IndexOf(_obstacleArray, car.GetDistance()) != -1)
                        {
                            int x = RaceDraw.RACE_WIDTH * (2 * car.GetNumber() + 1) / ((CarsArray.Length + 1) * 2);

                            crashArray[a, 0] = x;
                            crashArray[a, 1] = car.GetDistance();
                            crashArray[a, 2] = car.GetNumber();
                            carsCrashArray[a] = car;
                            a += 1;
                        }
                    }
                }
                DrawNewMove();
                if (a != 0)
                {
                    for (int i = 0; i < a; i++)
                    {
                        RaceDraw.DrawCrash(crashArray[i, 0], 800 - crashArray[i, 1]+20);
                    }
                    SortPositions();
                    ShowPositions();
                    System.Threading.Thread.Sleep(2000);

                    for (int i = 0; i < a; i++)
                    {
                        carsCrashArray[i].SetPenalty();
                    }
                    DrawNewMove();
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
            ResultOfRace();
        }
        public static void ResultOfRace()
        {
            SortPositions();
            ShowPositions();
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
                int x = RaceDraw.RACE_WIDTH * (2 * CarsArray[i].GetNumber() + 1) / ((CarsArray.Length + 1) * 2);
                RaceDraw.DrawCar(x - 10, RaceDraw.START_Y - CarsArray[i].GetDistance(), CarsArray[i].GetNumber());
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
        private static void ShowPositions()
        {
            Font font = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush solidBrush = new SolidBrush(Color.DarkGreen);
            string txt = "";
            for (int i = 0; i < CarsArray.Length; i++)
            {
                txt = (i + 1).ToString() + ". " + CarsArray[i].GetInfo();
                RaceDraw.DrawString(txt, font, solidBrush, new PointF(660, 60 + 15 * i));
            }
        }
        private static void SortPositions()
        {
            Array.Sort(CarsArray);
        }
    }
}