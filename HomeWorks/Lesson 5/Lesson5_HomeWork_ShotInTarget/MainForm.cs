using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson5_HomeWork_ShotInTarget
{
    public partial class MainForm : Form
    {
        //розмір поля зроюлено статичним, але можна обчислювати через висоту і ширину форми
        const int TARGET_WIDTH = 652;
        const int TARGET_HEIGHT = 452;

        Graphics graph;

        //початкова точка(центр)
        const int x0 = TARGET_WIDTH / 2;
        const int y0 = TARGET_HEIGHT / 2;

        bool initTarget = false;
        int sumPoints = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        
        //ініціалізація графіки ы малювання мішені, якщо не була раніше намальована
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            graph = CreateGraphics();
            if (!initTarget)
                DrawTarget();
        }

        //натиснення кнопки "Нова мішень"
        private void buttonClear_Click(object sender, EventArgs e)
        {
            DrawTarget();
        }

        //малювання мішені
        private bool DrawTarget()
        {
            int radius = 0;
            sumPoints = 0;
            labelSumPoints.Text = "";
            labelCurrentPoints.Text = "";
            labelCurrentShot.Text = "";
            try
            {
                radius = Convert.ToInt32(txtRadius.Text);
                if (radius < 0 || radius > 20)
                {
	                MessageBox.Show("Incorrect radius");
	                initTarget = false;
	                return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect radius");
                initTarget = false;
                return false;
            }
           
            graph.Clear(Color.White);

            //вісь Х і У
            graph.DrawLine(Pens.Black, x0 - 10 * radius - 30, y0, x0 + 10 * radius + 30, y0);
            graph.DrawLine(Pens.Black, x0, y0 - 10 * radius - 30, x0, y0 + 10 * radius + 30);

            //10 кругів з радіусом кожен раз більше на радіус
            for (int i = 1; i < 11; i++)
                graph.DrawEllipse(Pens.Black, x0 - radius * i, y0 - radius * i, radius * 2 * i, radius * 2 * i);
            initTarget = true;
            return true;

        }

        //кнопка "Піу" :)
        private void btnShot_Click(object sender, EventArgs e)
        {
            //якщо мішень не ініціалізована, то намалювати
            if (!initTarget)
                if (!DrawTarget())
                    return;

            //постріл
            Shot();
        }

        //підрахунок балів
        private int CalcPoints(int x, int y)
        {
	        int radius = Convert.ToInt32(txtRadius.Text);
            int a2 = (x - x0) * (x - x0);
            int b2 = (y - y0) * (y - y0);

            //якщо гіпотенуза прямокутного трикутника з кутами в центрі та координатами точки менше радіуса, то точка належить цьому колу
            double gipotenuza = Math.Sqrt(a2 + b2);

            //перевірка усіх 10ьох радіусів і повернення балів
            for (int i = 1; i < 11; i++)
            {
	            if (gipotenuza <= radius * i)
	            {
		            return (11 - i);
	            }

            }
	        return 0;
        }
        //постріл
        private void Shot()
        {
            //генерування точки пострілу
            Random rand = new Random();
            int x = rand.Next(TARGET_WIDTH);
            int y = rand.Next(TARGET_HEIGHT);

            //вивід точки з координатами на форму
            labelCurrentShot.Text = "(" + (x - x0).ToString() + "," + (y0-y).ToString() + ")";

            //малювання точки в вигляді кола з дуже маленьким радіусом
            Pen blackPen = new Pen(Color.Red, 3);
            graph.DrawEllipse(blackPen, x, y, 4, 4);

            //підрахунок балів і вивід на форму разом з сумою балів
            int currentPoint = CalcPoints(x, y);
            sumPoints += currentPoint;
            if (currentPoint == 0)
            {
	            labelCurrentPoints.Text = "Молоко :)";
            }
            else
            {
	            labelCurrentPoints.Text = currentPoint.ToString();
            }
            labelSumPoints.Text = sumPoints.ToString();
        }

	}
}
