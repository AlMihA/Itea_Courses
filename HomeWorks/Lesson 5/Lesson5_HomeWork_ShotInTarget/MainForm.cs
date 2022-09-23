using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson5_HomeWork_ShotInTarget
{
    public partial class MainForm : Form
    {
        const int TARGET_WIDTH = 652;
        const int TARGET_HEIGHT = 452;

        Graphics graph;
        int x0 = TARGET_WIDTH / 2;
        int y0 = TARGET_HEIGHT / 2;

        bool initTarget = false;
        int sumPoints = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            graph = CreateGraphics();
            if (!initTarget)
                DrawTarget();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DrawTarget();
        }

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
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect radius");
                initTarget = false;
                return false;
            }
           
            graph.Clear(Color.White);
            
            for (int i = 1; i < 11; i++)
                graph.DrawEllipse(Pens.Black, x0 - radius * i, y0 - radius * i, radius * 2 * i, radius * 2 * i);
            initTarget = true;
            return true;

        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            if (!initTarget)
                if (!DrawTarget())
                    return;

            Shot();
        }

        private int CalcPoints(int x, int y)
        {
            int points = 0;
            int a2 = (x - x0) * (x - x0);
            int b2 = (y - y0) * (y - y0);
            double gipotenuza = Math.Sqrt(a2 + b2);
            return points;
        }
        private void Shot()
        {
            Random rand = new Random();
            int x = rand.Next(TARGET_WIDTH);
            int y = rand.Next(TARGET_HEIGHT);

            labelCurrentShot.Text = "(" + x + "," + y + ")";
            Pen blackPen = new Pen(Color.Red, 3);
            graph.DrawEllipse(blackPen, x, y, 4, 4);


            sumPoints += 5;
            labelCurrentPoints.Text = "5";
            labelSumPoints.Text = sumPoints.ToString();
        }

       
    }
}
