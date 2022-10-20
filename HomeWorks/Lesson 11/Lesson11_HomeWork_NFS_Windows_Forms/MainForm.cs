using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson11_HomeWork_NFS_Windows_Forms
{
	public partial class MainForm : Form
	{
		Graphics _graph;
		public MainForm()
		{
			InitializeComponent();
		}
		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			_graph = CreateGraphics();
			RaceDraw.graph = _graph;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			Cars[] carsArray = new Cars[6];
			carsArray[0] = new Cars(1);
			carsArray[1] = new Cars(2);
			carsArray[2] = new Cars("Bugatti", 12, 3);
			carsArray[3] = new Cars("Porsche", 13, 4);
			carsArray[4] = new Cars("BMW", 14, 5);
			carsArray[5] = new Cars("Tesla", 99, 6);

			Race.CarsArray = carsArray;
			Race.Distance = 800;
			Race.NewRace();
		}
		private void buttonStart_Click(object sender, EventArgs e)
		{
			Race.StartRace();
		}
	}
}
